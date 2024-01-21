import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { IndexComponent } from './index/index.component';
import { NewComponent } from './new/new.component';
import { EditComponent } from './edit/edit.component';
import { RouterModule } from '@angular/router';
import { TravelRoutingModule } from './travel-routing.module';



@NgModule({
  declarations: [
    IndexComponent,
    NewComponent,
    EditComponent
  ],
  imports: [
    CommonModule,
    RouterModule,
    TravelRoutingModule
  ]
})
export class TravelModule { }
