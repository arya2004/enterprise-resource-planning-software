import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { IndexComponent } from './index/index.component';
import { NewComponent } from './new/new.component';
import { EditComponent } from './edit/edit.component';
import { CompanyRoutingModule } from './company-routing.module';
import { RouterModule } from '@angular/router';



@NgModule({
  declarations: [
    IndexComponent,
    NewComponent,
    EditComponent
  ],
  imports: [
    CommonModule,
    CompanyRoutingModule,
    RouterModule
  ]
})
export class CompanyModule { }
