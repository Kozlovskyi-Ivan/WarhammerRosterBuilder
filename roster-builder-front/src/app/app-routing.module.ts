import { DatasheetComponent } from './mainboard/datasheet/datasheet.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';


const routes: Routes = [
  {path: '',redirectTo: '/', pathMatch: 'full'},
  {path: 'datasheet/:name', component: DatasheetComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
