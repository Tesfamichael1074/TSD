import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NotesComponentComponent } from './components/notes-component/notes-component.component';
import { MainMenuComponentComponent } from './components/main-menu-component/main-menu-component.component';
import { AddNoteComponentComponent } from './components/add-note-component/add-note-component.component';
import { RoutingModelRoutingModule } from './routing-model/routing-model-routing.module'
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    NotesComponentComponent,
    MainMenuComponentComponent,
    AddNoteComponentComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    RoutingModelRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
