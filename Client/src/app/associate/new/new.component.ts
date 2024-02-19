import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { IAssociateUser } from 'src/app/shared/Models/Master/IAssociateUser';

@Component({
  selector: 'app-new',
  templateUrl: './new.component.html',
  styleUrls: ['./new.component.scss']
})
export class NewComponent {
  ;

  constructor(private fb: FormBuilder) {}



 
  associateUserForm: FormGroup = this.fb.group({
    associateCode: [null],
      email: [null, Validators.email],
      password: [null],
      companyName: [null],
      addressLine1: [null],
      addressLine2: [null],
      addressLine3: [null],
      city: [null],
      state: [null],
      country: [null],
      postalCode: [null, Validators.pattern(/^-?\d+\.?\d*$/)],
      contactPerson1: [null],
      designation1: [null],
      mobileNumber1: [null, [Validators.required, Validators.pattern(/^-?\d+\.?\d*$/)]],
      email1: [null, Validators.email],
      contactPerson2: [null],
      designation2: [null],
      mobileNumber2: [null, Validators.pattern(/^-?\d+\.?\d*$/)],
      email2: [null, Validators.email],
      panNumber: [null],
      gstNumber: [null],
      bank: [null],
      branchName: [null],
      branchAddress: [null],
      accountNumber: [null],
      isfCode: [null],
      accountType: [null],
      isFreeLancer: [null]
    });
  

  onSubmit() {
    if (this.associateUserForm.valid) {
      const formData: IAssociateUser = this.associateUserForm.value;
      console.log(formData); // You can do whatever you want with the form data, e.g., send it to a server
    } else {
      console.log("INVALID FORM");
      console.log(this.associateUserForm.value);
      // Form is invalid, handle validation errors or show appropriate messages
    }
  }
}
