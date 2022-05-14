import { Component, OnInit } from '@angular/core';
import { Note } from './../../models/Note'
import { NoteService } from '../../service/note.service'


@Component({
  selector: 'app-notes-component',
  templateUrl: './notes-component.component.html',
  styleUrls: ['./notes-component.component.css']
})

export class NotesComponentComponent implements OnInit {

  notes: Note[] = [];

  constructor() { }

  ngOnInit(): void {
    this.notes = NoteService.getNotes()
  }

  deleteNote (id: number) {
    NoteService.deleteNote(id)
  }

}
