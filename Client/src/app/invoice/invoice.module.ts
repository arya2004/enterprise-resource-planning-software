import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { GstIndexComponent } from './gst-index/gst-index.component';
import { GstNewComponent } from './gst-new/gst-new.component';
import { GstEditComponent } from './gst-edit/gst-edit.component';
import { ProformaIndexComponent } from './proforma-index/proforma-index.component';
import { ProformaNewComponent } from './proforma-new/proforma-new.component';
import { ProformaEditComponent } from './proforma-edit/proforma-edit.component';
import { RouterModule } from '@angular/router';
import { InvoiceRoutingModule } from './invoice-routing.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DataTablesModule } from 'angular-datatables';



@NgModule({
  declarations: [
    GstIndexComponent,
    GstNewComponent,
    GstEditComponent,
    ProformaIndexComponent,
    ProformaNewComponent,
    ProformaEditComponent
  ],
  imports: [
    CommonModule,
    RouterModule,
    InvoiceRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    DataTablesModule
  ]
})
export class InvoiceModule { }
