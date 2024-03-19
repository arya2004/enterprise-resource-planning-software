import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NewComponent } from './new/new.component';
import { IndexComponent } from './index/index.component';
import { EditComponent } from './edit/edit.component';
import { ProjectFeesRoutingModule } from './project-fees-routing.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { DataTablesModule } from 'angular-datatables';



@NgModule({
  declarations: [
    NewComponent,
    IndexComponent,
    EditComponent
  ],
  imports: [
    CommonModule,
    ProjectFeesRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule,
    DataTablesModule
  ]
})
export class ProjectFeesModule { }
