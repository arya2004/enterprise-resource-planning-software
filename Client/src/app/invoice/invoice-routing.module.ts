import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { GstIndexComponent } from './gst-index/gst-index.component';
import { GstNewComponent } from './gst-new/gst-new.component';
import { GstEditComponent } from './gst-edit/gst-edit.component';
import { ProformaIndexComponent } from './proforma-index/proforma-index.component';
import { ProformaNewComponent } from './proforma-new/proforma-new.component';
import { ProformaEditComponent } from './proforma-edit/proforma-edit.component';

const routes: Routes = [

  {path: 'gst', component: GstIndexComponent},
  {path: 'gst/new', component: GstNewComponent},
  {path: 'gst/:id', component: GstEditComponent},
  
  {path: 'proforma', component: ProformaIndexComponent},
  {path: 'proforma/new', component: ProformaNewComponent},
  {path: 'proforma/:id', component: ProformaEditComponent},


]

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forChild(routes)
  ]
})
export class InvoiceRoutingModule { }
