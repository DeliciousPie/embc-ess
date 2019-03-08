import { Component, OnInit } from '@angular/core';
import { Evacuee } from '../core/models';
import { EvacueeService } from '../core/services/evacuee.service';
@Component({
  selector: 'app-volunteer-dashboard',
  templateUrl: './volunteer-dashboard.component.html',
  styleUrls: ['./volunteer-dashboard.component.scss']
})
export class VolunteerDashboardComponent implements OnInit {

  evacuees: Evacuee[];
  constructor(
    private evacueeService: EvacueeService
  ) { }

  ngOnInit() {
    this.evacueeService.getAllEvacuees().subscribe(evacuees=>this.evacuees=evacuees)
  }

}
