import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ArchitectComponent } from './master/architect/architect.component';

const routes: Routes = [
  {path: '', component:ArchitectComponent},
  {path: 'account', loadChildren: () => import('./master/master.module').then(m => m.MasterModule)},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
