import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { IndexComponent } from './index/index.component';
import { AttendanceRoutingModule } from './attendance-routing.module';
import { RouterModule } from '@angular/router';



@NgModule({
  declarations: [
    IndexComponent
  ],
  imports: [
    CommonModule,
    AttendanceRoutingModule,
    RouterModule
  ]
})
export class AttendanceModule { }
