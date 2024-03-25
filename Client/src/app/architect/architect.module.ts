import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { IndexComponent } from './index/index.component';
import { NewComponent } from './new/new.component';
import { EditComponent } from './edit/edit.component';
import { ArchitectRoutingModule } from './architect-routing.module';
import { RouterModule } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DataTablesModule } from 'angular-datatables';
import { ArchitectDashboardComponent } from './dashboard/dashboard.component';



@NgModule({
  declarations: [
    IndexComponent,
    NewComponent,
    EditComponent,
    ArchitectDashboardComponent
  ],
  imports: [
    CommonModule,
    ArchitectRoutingModule,
    RouterModule,
    FormsModule,
    ReactiveFormsModule,
    DataTablesModule
  ]
})
export class ArchitectModule { }
