import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { IndexComponent } from './index/index.component';
import { NewComponent } from './new/new.component';
import { EditComponent } from './edit/edit.component';
import { RouterModule } from '@angular/router';
import { CompanyRoutingModule } from '../company/company-routing.module';
import { ClientRoutingModule } from './client-routing.module';



@NgModule({
  declarations: [
    IndexComponent,
    NewComponent,
    EditComponent
  ],
  imports: [
    CommonModule,
   ClientRoutingModule
  ]
})
export class ClientModule { }
