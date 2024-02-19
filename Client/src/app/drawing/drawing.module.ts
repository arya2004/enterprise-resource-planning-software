import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { IndexComponent } from './index/index.component';
import { NewComponent } from './new/new.component';
import { EditComponent } from './edit/edit.component';
import { RouterLink, RouterModule } from '@angular/router';
import { DrawingRoutingModule } from './drawing-routing.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    IndexComponent,
    NewComponent,
    EditComponent
  ],
  imports: [
    CommonModule,
    RouterModule,
    DrawingRoutingModule,
    FormsModule,
    ReactiveFormsModule
  ]
})
export class DrawingModule { }
