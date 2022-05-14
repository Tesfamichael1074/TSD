import { Component, OnInit } from '@angular/core';
import { NotesComponentComponent } from '../notes-component/notes-component.component'
import { Note } from './../../models/Note'

@Component({
  selector: 'app-add-note-component',
  templateUrl: './add-note-component.component.html',
  styleUrls: ['./add-note-component.component.css']
})
export class AddNoteComponentComponent implements OnInit {

  constructor() { }

  inputNote: string = "";

  ngOnInit(): void {
  }

  addNote() {
    
  }

}
