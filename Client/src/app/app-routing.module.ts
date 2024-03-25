import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ArchitectComponent } from './master/architect/architect.component';
import { NotFoundComponent } from './core/not-found/not-found.component';
import { AuthGuard } from './core/guards/auth.guard';
import { HasRoleGuard } from './core/guards/has-role.guard';
import { IndexComponent } from './projects/index/index.component';

const routes: Routes = [
  {path: '', title:'Apte', component:IndexComponent},
  {path: 'account', loadChildren: () => import('./account/account.module').then(m => m.AccountModule)},
  {path: 'company', loadChildren: () => import('./company/company.module').then(m => m.CompanyModule)},
  {path: 'client', loadChildren: () => import('./client/client.module').then(m => m.ClientModule)},
  {path: 'employee', loadChildren: () => import('./employee/employee.module').then(m => m.EmployeeModule)},
  {path: 'architect', loadChildren: () => import('./architect/architect.module').then(m => m.ArchitectModule)},
  {path: 'associate', loadChildren: () => import('./associate/associate.module').then(m => m.AssociateModule)},
  {path: 'project', loadChildren: () => import('./projects/projects.module').then(m => m.ProjectsModule)},
  {path: 'attendance', loadChildren: () => import('./attendance/attendance.module').then(m => m.AttendanceModule)},
  {path: 'drawing', loadChildren: () => import('./drawing/drawing.module').then(m => m.DrawingModule)},
  {path: 'travel', loadChildren: () => import('./travel/travel.module').then(m => m.TravelModule)},
  {path: 'timesheet', loadChildren: () => import('./timesheet/timesheet.module').then(m => m.TimesheetModule)},
  {path: 'invoice', loadChildren: () => import('./invoice/invoice.module').then(m => m.InvoiceModule)},
  {path: 'project-fees', loadChildren: () => import('./project-fees/project-fees.module').then(m => m.ProjectFeesModule)},
  {path: 'associate-fees', loadChildren: () => import('./associate-fee/associate-fee.module').then(m => m.AssociateFeeModule)},
  {path: 'work-order', loadChildren: () => import('./work-order/work-order.module').then(m => m.WorkOrderModule)},
  //for a project
  {path: 'client', loadChildren: () => import('./client/client.module').then(m => m.ClientModule)},
  {path: 'project/:projectId/employee', loadChildren: () => import('./employee/employee.module').then(m => m.EmployeeModule)},
  {path: 'project/:projectId/architect', loadChildren: () => import('./architect/architect.module').then(m => m.ArchitectModule)},
  {path: 'project/:projectId/associate', loadChildren: () => import('./associate/associate.module').then(m => m.AssociateModule)},
  {path: 'project/:projectId/drawing', loadChildren: () => import('./drawing/drawing.module').then(m => m.DrawingModule)},
  {path: 'project/:projectId/travel', loadChildren: () => import('./travel/travel.module').then(m => m.TravelModule)},
  {path: 'project/:projectId/timesheet', loadChildren: () => import('./timesheet/timesheet.module').then(m => m.TimesheetModule)},
  {path: 'project/:projectId/invoice', loadChildren: () => import('./invoice/invoice.module').then(m => m.InvoiceModule)},
  {path: 'project/:projectId/project-fees', loadChildren: () => import('./project-fees/project-fees.module').then(m => m.ProjectFeesModule)},
  {path: 'project/:projectId/associate-fees', loadChildren: () => import('./associate-fee/associate-fee.module').then(m => m.AssociateFeeModule)},
  {path: 'project/:projectId/work-order', loadChildren: () => import('./work-order/work-order.module').then(m => m.WorkOrderModule)},
  
  {path: 'prot',canActivate:[AuthGuard], loadChildren: () => import('./master/master.module').then(m => m.MasterModule)},
  {path: 'cat',canActivate:[ HasRoleGuard], data: {role: 'CAT'}, loadChildren: () => import('./master/master.module').then(m => m.MasterModule)},
  { path: '**', component: NotFoundComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
