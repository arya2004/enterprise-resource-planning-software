import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { IEmployeeUser } from 'src/app/shared/Models/Master/IEmployeeUser';

@Component({
  selector: 'app-new',
  templateUrl: './new.component.html',
  styleUrls: ['./new.component.scss']
})
export class NewComponent {
  constructor(private fb: FormBuilder) {}

  employeeUserForm: FormGroup = this.fb.group({
  
    email: [null, Validators.email],
    password: [null, Validators.required],
    employeeCode: [null],
    employeeName: [null],
    addressLine1: [null],
    addressLine2: [null],
    addressLine3: [null],
    city: [null],
    state: [null],
    country: [null],
    postalCode: [null],
    contactPerson1: [null],
    relation1: [null],
    mobileNumber1: [null],
    contactPerson2: [null],
    relation2: [null],
    mobileNumber2: [null],
    educationalQualification1: [null],
    educationalQualification2: [null],
    educationalQualification3: [null],
    expBeforeJoiningY: [null],
    expBeforeJoiningM: [null],
    pan: [null],
    uid: [null],
    birthDate: [null],
    anniversary: [null],
    bankName: [null],
    branchName: [null],
    branchAddress: [null],
    accountNumber: [null],
    isfCode: [null],
    accountType: [null],
    monthlySalary: [null]
  });


  onSubmit() {
    if (this.employeeUserForm.valid) {
      const formData: IEmployeeUser = this.employeeUserForm.value;
      console.log(formData); // You can do whatever you want with the form data, e.g., send it to a server
    } else {
      // Form is invalid, handle validation errors or show appropriate messages
    }
  }
  
}
