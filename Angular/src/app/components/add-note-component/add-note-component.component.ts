import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NoteService } from '../../service/note.service'
@Component({
  selector: 'app-add-note-component',
  templateUrl: './add-note-component.component.html',
  styleUrls: ['./add-note-component.component.css']
})
export class AddNoteComponentComponent implements OnInit {

  constructor(private router: Router) { }

  inputNote: string = "";
  date: string = "";

  ngOnInit(): void {
  }

  addNote() {
    NoteService.addNote({text: this.inputNote, date: this.date})
    this.router.navigate(['/list']);
    alert('Note added successfully')
  }

}
