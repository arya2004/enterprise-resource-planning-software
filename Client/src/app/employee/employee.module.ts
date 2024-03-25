import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NewComponent } from './new/new.component';
import { IndexComponent } from './index/index.component';
import { EditComponent } from './edit/edit.component';
import { EmployeeRoutingModule } from './employee-routing.module';
import { RouterModule } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DataTablesModule } from 'angular-datatables';
import { EmployeeDashboardComponent } from './dashboard/dashboard.component';



@NgModule({
  declarations: [
    NewComponent,
    IndexComponent,
    EditComponent,
    EmployeeDashboardComponent
  ],
  imports: [
    CommonModule,
    EmployeeRoutingModule,
    RouterModule,
    ReactiveFormsModule,
    FormsModule,
    DataTablesModule
  ]
})
export class EmployeeModule { }
