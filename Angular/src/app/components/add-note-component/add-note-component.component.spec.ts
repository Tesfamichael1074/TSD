import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddNoteComponentComponent } from './add-note-component.component';

describe('AddNoteComponentComponent', () => {
  let component: AddNoteComponentComponent;
  let fixture: ComponentFixture<AddNoteComponentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddNoteComponentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AddNoteComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
