import { Note } from '../models/Note'

export class NoteService {

    private static notes: Note[] = [
        {
            text: 'first',
            date: this.getDate()
         },
         {
            text: 'second',
            date: this.getDate()
          },
          {
            text: 'third',
            date: this.getDate()
          }
    ];

    constructor() {
    }

    static getNotes(): Note[] {
        return this.notes;
      }
    static addNote(note: Note){
        this.notes.push(note)
    }

    static getDate() {
        var today = new Date();
        var date = today.getFullYear()+'-'+(today.getMonth()+1)+'-'+today.getDate();
        var time = today.getHours() + ":" + today.getMinutes() + ":" + today.getSeconds();
        var dateTime = date + ' ' + time;
    
        return dateTime
      }
    static deleteNote (id: number) {
        this.notes = this.notes.filter((v, i) => i !== id);
      }
}