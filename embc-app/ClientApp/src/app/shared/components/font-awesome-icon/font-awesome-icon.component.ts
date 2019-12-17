import { Component, Input } from '@angular/core';

export type IconSizes = 'lg'
  | 'xs'
  | 'sm'
  | '1x'
  | '2x'
  | '3x'
  | '4x'
  | '5x'
  | '6x'
  | '7x'
  | '8x'
  | '9x'
  | '10x';


  // Font Awesome is changing 'data-title' to 'title'.....
@Component({
  selector: 'app-font-awesome-icon',
  template: `
    <i *ngIf="icon" [style.color]="color" [ngClass]="classes">
      <span class="toolTipText" *ngIf="toolTip">{{this.toolTip}}</span>
    </i>
  `,
  styleUrls: ['./font-awesome-icon.component.scss']
})
export class FontAwesomeIconComponent {

  // Required
  @Input() icon: string;

  // (Optional)
  @Input() border          = false;
  @Input() className       = '';         // CSS classes listed in the string (space delimited) are added.
  @Input() color           = 'inherit';
  @Input() fixedWidth      = false;
  @Input() inverse         = false;
  @Input() size: IconSizes = null;
  @Input() toolTip: string = null;

  get classes() {
    const cssClasses = {
      'fa-border': this.border,
      'fa-fw': this.fixedWidth,
      'fa-inverse': this.inverse,
      [`fas fa-${this.icon}`]: this.icon !== null,
      [`fa-${this.size}`]: this.size !== null,
      'toolTipAnchor': true,
      [this.className]: this.className !== null,  // extra classes (if provided)
    };
    return cssClasses;
  }


}
