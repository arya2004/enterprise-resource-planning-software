import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { IndexComponent } from './index/index.component';
import { NewComponent } from './new/new.component';
import { EditComponent } from './edit/edit.component';
import { RouterModule, Routes } from '@angular/router';
import { DashboardComponent } from './dashboard/dashboard.component';



const routes: Routes = [

  {path: '', component: IndexComponent},
  
  {path: 'new', component: NewComponent},
  {path: ':id', component: EditComponent},
  {path: ':id/dashboard', component: DashboardComponent},



]
@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forChild(routes)
  ]
})
export class ProjectsRoutingModule { }
