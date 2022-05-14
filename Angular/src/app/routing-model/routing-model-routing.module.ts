import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NotesComponentComponent } from './../components/notes-component/notes-component.component';
import { AddNoteComponentComponent } from './../components/add-note-component/add-note-component.component';
import { MainMenuComponentComponent } from './../components/main-menu-component/main-menu-component.component';

const routes: Routes = [
  { path: 'menu', component:MainMenuComponentComponent },
  { path: 'add', component:AddNoteComponentComponent },
  { path: 'list', component:NotesComponentComponent },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class RoutingModelRoutingModule { }
