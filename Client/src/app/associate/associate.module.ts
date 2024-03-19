import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NewComponent } from './new/new.component';
import { IndexComponent } from './index/index.component';
import { EditComponent } from './edit/edit.component';
import { AssociateRoutingModule } from './associate-routing.module';
import { RouterModule } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DataTablesModule } from 'angular-datatables';



@NgModule({
  declarations: [
    NewComponent,
    IndexComponent,
    EditComponent
  ],
  imports: [
    CommonModule,
    AssociateRoutingModule,
    RouterModule,
    FormsModule,
    ReactiveFormsModule,
    DataTablesModule
  ]
})
export class AssociateModule { }
