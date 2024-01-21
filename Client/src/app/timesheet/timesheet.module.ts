import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { IndexComponent } from './index/index.component';
import { NewComponent } from './new/new.component';
import { EditComponent } from './edit/edit.component';



@NgModule({
  declarations: [
    IndexComponent,
    NewComponent,
    EditComponent
  ],
  imports: [
    CommonModule
  ]
})
export class TimesheetModule { }
