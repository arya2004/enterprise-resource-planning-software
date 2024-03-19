import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { IndexComponent } from './index/index.component';
import { NewComponent } from './new/new.component';
import { EditComponent } from './edit/edit.component';
import { RouterModule } from '@angular/router';
import { TimesheetRoutingModule } from './timesheet-routing.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DataTablesModule } from 'angular-datatables';



@NgModule({
  declarations: [
    IndexComponent,
    NewComponent,
    EditComponent
  ],
  imports: [
    CommonModule,
    RouterModule,
    TimesheetRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    DataTablesModule

  ]
})
export class TimesheetModule { }
