import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { IArchitect } from 'src/app/shared/Models/Master/IArchitect';

@Component({
  selector: 'app-new',
  templateUrl: './new.component.html',
  styleUrls: ['./new.component.scss']
})
export class NewComponent {
  constructor(private fb: FormBuilder) {}

  architectForm: FormGroup = this.fb.group({
    architectCode: [null],
    companyName: [null],
    addressLine1: [null],
    addressLine2: [null],
    addressLine3: [null],
    city: [null],
    state: [null],
    country: [null],
    postalCode: [null],
    contactPerson1: [null],
    designation1: [null],
    mobileNumber1: [null, [Validators.required]],
    email1: [null, Validators.email],
    contactPerson2: [null],
    designation2: [null],
    mobileNumber2: [null, [Validators.required]],
    email2: [null, Validators.email],
    panNumber: [null],
    gstNumber: [null]
  });


onSubmit() {
  if (this.architectForm.valid) {
    const formData: IArchitect = this.architectForm.value;
    console.log(formData); // You can do whatever you want with the form data, e.g., send it to a server
  } else {
    // Form is invalid, handle validation errors or show appropriate messages
  }
}
}
