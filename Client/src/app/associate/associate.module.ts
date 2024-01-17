import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NewComponent } from './new/new.component';
import { IndexComponent } from './index/index.component';
import { EditComponent } from './edit/edit.component';
import { AssociateRoutingModule } from './associate-routing.module';
import { RouterModule } from '@angular/router';



@NgModule({
  declarations: [
    NewComponent,
    IndexComponent,
    EditComponent
  ],
  imports: [
    CommonModule,
    AssociateRoutingModule,
    RouterModule
  ]
})
export class AssociateModule { }
