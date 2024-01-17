import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ArchitectComponent } from './master/architect/architect.component';

const routes: Routes = [
  {path: '', component:ArchitectComponent},
  {path: 'company', loadChildren: () => import('./company/company.module').then(m => m.CompanyModule)},
  {path: 'client', loadChildren: () => import('./client/client.module').then(m => m.ClientModule)},
  {path: 'employee', loadChildren: () => import('./employee/employee.module').then(m => m.EmployeeModule)},
  {path: 'architect', loadChildren: () => import('./architect/architect.module').then(m => m.ArchitectModule)},
  {path: 'associate', loadChildren: () => import('./associate/associate.module').then(m => m.AssociateModule)},
  {path: 'project', loadChildren: () => import('./projects/projects.module').then(m => m.ProjectsModule)},
  {path: 'account', loadChildren: () => import('./master/master.module').then(m => m.MasterModule)},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
