import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EditComponent } from './edit/edit.component';
import { NewComponent } from './new/new.component';
import { IndexComponent } from './index/index.component';
import { ProjectsRoutingModule } from './projects-routing.module';
import { RouterModule } from '@angular/router';



@NgModule({
  declarations: [
    EditComponent,
    NewComponent,
    IndexComponent
  ],
  imports: [
    CommonModule,
    ProjectsRoutingModule,
    RouterModule
  ]
})
export class ProjectsModule { }
