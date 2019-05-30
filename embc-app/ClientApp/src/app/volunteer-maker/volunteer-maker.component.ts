import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { FormBuilder, Validators, FormGroup } from '@angular/forms';
import { combineLatest, Observable, of } from 'rxjs';
import { switchMap } from 'rxjs/operators';
import { AuthService } from '../core/services/auth.service';
import { VolunteerService } from '../core/services/volunteer.service';
import { OrganizationService } from '../core/services/organization.service';
import { Volunteer, Organization, ListResult } from '../core/models';
import { NotificationQueueService } from '../core/services/notification-queue.service';
import { UniqueKeyService } from '../core/services/unique-key.service';
import { invalidField } from 'src/app/shared/utils';

@Component({
  selector: 'app-volunteer-maker',
  templateUrl: './volunteer-maker.component.html',
  styleUrls: ['./volunteer-maker.component.scss']
})
export class VolunteerMakerComponent implements OnInit {

  editing = true; // whether we are adding/editing or reviewing
  submitting = false; // whether we are submitting data to BE
  doSelectOrg = false; // whether we can select org

  iAmLocalAuthority: boolean = null;
  iAmProvincialAdmin: boolean = null;
  mode: ('ADD' | 'EDIT') = null;
  path: string = null; // path for routing current user

  volunteer: Volunteer = null;

  metaOrganizations: ListResult<Organization> = { data: null, metadata: null };

  // the model for the form data collected
  form: FormGroup = null;

  // convenience getter for easy access to form fields
  get f(): any { return this.form.controls; }

  get currentOrganization(): Organization {
    return this.f.organization.value;
  }

  // to run validation after user clicks the Submit button
  shouldValidateForm = false;

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private volunteerService: VolunteerService,
    private organizationService: OrganizationService,
    private authService: AuthService,
    private notificationQueueService: NotificationQueueService,
    private uniqueKeyService: UniqueKeyService,
    public fb: FormBuilder
  ) { }

  ngOnInit() {
    this.form = this.fb.group({
      organization: ['', Validators.required],
      lastName: ['', Validators.required],
      firstName: ['', Validators.required],
      bceidAccountNumber: ['', Validators.required],
      isAdministrator: ['', Validators.required],
      isPrimaryContact: ['']
    });

    // validate isPrimaryContact only if isAdministrator is true
    this.form.controls.isAdministrator.valueChanges.subscribe(value => {
      if (value) {
        this.f.isPrimaryContact.setValidators([Validators.required]);
      } else {
        this.f.isPrimaryContact.clearValidators();
      }
      this.f.isPrimaryContact.updateValueAndValidity({ emitEvent: false });
    });

    // get a bunch of variables we need
    combineLatest(
      this.authService.getCurrentUser(),
      this.authService.isLocalAuthority$,
      this.authService.isProvincialAdmin$,
      this.authService.path
    ).subscribe(([currentUser, isLocalAuthority, isProvincialAdmin, path]) => {
      this.iAmLocalAuthority = isLocalAuthority;
      this.iAmProvincialAdmin = isProvincialAdmin;
      this.path = path;

      // if local authority then get their organization
      if (this.iAmLocalAuthority) {
        const volunteerId = currentUser.contactid;
        this.getVolunteerOrganization(volunteerId)
          .subscribe((organization: Organization) => {
            // set form value
            this.f.organization.setValue(organization);

            // continue
            this.ngOnInit2();
          }, err => {
            console.log('error getting organization =', err);
            this.notificationQueueService.addNotification('Failed to get organizations', 'danger');
            // navigate back to the volunteers list
            this.cancel();
          });
        return; // done for local authority
      }

      // if provincial admin then check for orgId query param
      if (this.iAmProvincialAdmin) {
        const orgId = this.route.snapshot.params.orgId; // may be null
        if (orgId) {
          this.organizationService.getOrganizationById(orgId)
            .subscribe((organization: Organization) => {
              // set form value
              this.f.organization.setValue(organization);

              // continue
              this.ngOnInit2();
            }, err => {
              console.log('error getting organization =', err);
              this.notificationQueueService.addNotification('Failed to get organizations', 'danger');
              // navigate back to the volunteers list
              this.cancel();
            });
        } else {
          // no id -- configure UI to select organization
          this.changeOrganization();

          // continue
          this.ngOnInit2();
        }
        return; // done for provincial admin
      }

      // should never get here
      console.log('error - current user was not Local Authority or Provincial Admin');
      // navigate back to home
      this.router.navigate([`/${this.path}`]);
    }, err => {
      console.log('error getting data =', err);
      this.notificationQueueService.addNotification('Failed to get data', 'danger');
      // navigate back to the volunteers list
      this.cancel();
    });
  }

  // async continuation of above
  private ngOnInit2() {
    const volunteerId = this.uniqueKeyService.getKey(); // may be null
    if (volunteerId) {
      // get volunteer to edit
      this.volunteerService.getVolunteerById(volunteerId)
        .subscribe((volunteer: Volunteer) => {
          this.mode = 'EDIT';

          this.volunteer = volunteer;

          // set form fields
          this.form.patchValue({
            organization: volunteer.organization, // NB - should have been set when
            lastName: volunteer.lastName,
            firstName: volunteer.firstName,
            bceidAccountNumber: volunteer.bceidAccountNumber,
            isAdministrator: volunteer.isAdministrator,
            isPrimaryContact: volunteer.isPrimaryContact
          });
        }, err => {
          console.log('error getting volunteer =', err);
          this.notificationQueueService.addNotification('Failed to get volunteer', 'danger');
          // navigate back to the volunteers list
          this.cancel();
        });
    } else {
      // no volunteerId -> add user
      this.mode = 'ADD';

      // this is a fresh form and will be a simple add organization
      this.volunteer = {
        id: '',
        firstName: '',
        initials: '',
        lastName: '',
        nickname: '',
        gender: '',
        dob: null,
        bceidAccountNumber: '',
        personType: 'VOLN',
        canAccessRestrictedFiles: null,
        organization: null,
        isAdministrator: null,
        isPrimaryContact: null
      };

      // no form fields to set
    }
  }

  private getVolunteerOrganization(volunteerId: string): Observable<Organization> {
    if (!volunteerId) {
      return of(null as Organization);
    }

    return this.volunteerService
      .getVolunteerById(volunteerId)
      .pipe(
        switchMap(volunteer => this.organizationService.getOrganizationById(volunteer.organization.id))
      );
  }

  invalid(field: string, parent: FormGroup = this.form): boolean {
    return invalidField(field, parent, this.shouldValidateForm);
  }

  changeOrganization() {
    // get all organizations (sorted by name)
    this.organizationService.getOrganizations(null, null, null, '+name')
      .subscribe((listResult: ListResult<Organization>) => {
        this.metaOrganizations = listResult;
        this.doSelectOrg = true;
      }, err => {
        console.log('error getting organizations =', err);
        this.notificationQueueService.addNotification('Failed to get organizations', 'danger');
        // navigate back to the volunteers list
        this.cancel();
      });
  }

  next() {
    this.shouldValidateForm = true;

    if (this.form.valid) {
      // update volunteer object
      this.volunteer = { ...this.volunteer, ...this.form.value };

      this.editing = false;
      window.scrollTo(0, 0); // scroll to top
    }
  }

  back() {
    // show the editing parts of the form
    this.editing = true;
    window.scrollTo(0, 0); // scroll to top
  }

  submit(addAnother?: boolean) {
    this.submitting = true;
    // check if this is an update
    if (this.volunteer.id) {
      // if the volunteer has an ID we need to update
      this.volunteerService.updateVolunteer(this.volunteer)
        .subscribe(() => {
          this.submitting = false;
          // add a notification about the update
          this.notificationQueueService.addNotification('User updated successfully', 'success');
          // if addAnother route then reset this form
          // else route back to the volunteers list
          if (addAnother) {
            this.resetForm();
          } else {
            // navigate back to the volunteers list
            this.cancel();
          }
        }, err => {
          this.submitting = false;
          console.log('error updating volunteer =', err);
          this.notificationQueueService.addNotification('Failed to update user', 'danger');
        });
    } else {
      // if the volunteer has no id we need to create a new one
      this.volunteerService.createVolunteer(this.volunteer)
        .subscribe(() => {
          this.submitting = false;
          // add a notification about the creation
          this.notificationQueueService.addNotification('User added successfully', 'success');
          // if addAnother route then reset this form
          // else route back to the volunteers list
          if (addAnother) {
            this.resetForm();
          } else {
            // navigate back to the volunteers list
            this.cancel();
          }
        }, err => {
          this.submitting = false;
          console.log('error creating volunteer =', err);
          this.notificationQueueService.addNotification('Failed to add user', 'danger');
        });
    }
  }

  // FUTURE: why not just reload this page?
  private resetForm() {
    // reset form fields (except organization)
    this.form.patchValue({
      lastName: '',
      firstName: '',
      bceidAccountNumber: '',
      isAdministrator: null,
      isPrimaryContact: null
    });

    this.shouldValidateForm = false;

    // go back to the first page
    this.back();
  }

  cancel() {
    // navigate back to the volunteers list
    // TODO: preserveQueryParams is deprecated, use queryParamsHandling instead
    // TODO: need to add orgId URL param?
    this.router.navigate([`/${this.path}/volunteers`], { preserveQueryParams: true });
  }

}
