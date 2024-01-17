import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NavBarComponent } from './nav-bar/nav-bar.component';
import { FooterComponent } from './footer/footer.component';
import { SideBarComponent } from './side-bar/side-bar.component';



@NgModule({
  declarations: [
    NavBarComponent,
    FooterComponent,
    SideBarComponent
  ],
  imports: [
    CommonModule
  ],
  exports:[
    NavBarComponent,
    FooterComponent,
    SideBarComponent
  ]
})
export class CoreModule { }
