import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { IndexComponent } from './index/index.component';
import { EditComponent } from './edit/edit.component';
import { NewComponent } from './new/new.component';



@NgModule({
  declarations: [
    IndexComponent,
    EditComponent,
    NewComponent
  ],
  imports: [
    CommonModule
  ]
})
export class AssociateFeeModule { }
