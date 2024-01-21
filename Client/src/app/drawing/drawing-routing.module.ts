import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EditComponent } from './edit/edit.component';
import { NewComponent } from './new/new.component';
import { IndexComponent } from './index/index.component';
import { Router, RouterModule, Routes } from '@angular/router';

const routes: Routes = [

  {path: '', component: IndexComponent},
  {path: 'new', component: NewComponent},
  {path: ':id', component: EditComponent},


]


@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forChild(routes)
  ]
})
export class DrawingRoutingModule { }
