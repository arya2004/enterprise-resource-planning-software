import { Component } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Drawing } from 'src/app/shared/Models/IDrawing';

@Component({
  selector: 'app-new',
  templateUrl: './new.component.html',
  styleUrls: ['./new.component.scss']
})
export class NewComponent {
  

  constructor(private fb: FormBuilder) {}


  
    drawingForm: FormGroup= this.fb.group({
      drawingId: [null],
      project:  [null],
      company:  [null],
      employee:  [null],
      client: [null],
      architect: [null],
      drawingNumber: [null],
     
    });
  

  onSubmit() {
    if (this.drawingForm.valid) {
      const formData: Drawing = this.drawingForm.value;
      console.log(formData); // You can do whatever you want with the form data, e.g., send it to a server
    } else {
      console.log("INVALID FORM");
      console.log( this.drawingForm.value);
      // Form is invalid, handle validation errors or show appropriate messages
    }
  }
}
