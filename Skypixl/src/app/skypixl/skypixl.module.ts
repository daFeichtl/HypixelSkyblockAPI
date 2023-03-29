import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AccessoryNextComponent } from './accessory-next/accessory-next.component';
import {RouterModule, Routes} from "@angular/router";


const routes: Routes = [
  {path: "", redirectTo: "/next-accessories", pathMatch: "prefix"},
  {path: "/next-accessories", component: AccessoryNextComponent}
]
@NgModule({
  declarations: [
    AccessoryNextComponent,
  ],
  imports: [
    CommonModule,
    RouterModule.forRoot(routes)
  ],
  exports:[
    RouterModule
  ]
})
export class SkypixlModule { }
