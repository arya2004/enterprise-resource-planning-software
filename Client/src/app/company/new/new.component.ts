import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ICompany } from 'src/app/shared/Models/Master/ICompany';
import { CompanyService } from '../company.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-new',
  templateUrl: './new.component.html',
  styleUrls: ['./new.component.scss']
})
export class NewComponent {


  kek : string = "werwegf"

  companyForm=  this.fb.group({
    companyCode: [null],
    name: ['', Validators.required],
    directorName: [null],
    directorEmployeeCode: [null, Validators.required],
    directorMobile: [null, [Validators.required]],
    landLine: [null, Validators.required],
    directorEmail: [null, Validators.email],
    addressLine1: [null],
    addressLine2: [null],
    addressLine3: [null],
    city: [null],
    state: [null],
    country: [null],
    postalCode: [null, Validators.required],
    panNumber: [null],
    gstNumber: [null]
  });

  constructor(private fb: FormBuilder, private companyService: CompanyService, private router: Router) {}


  onSubmit() {
    if (this.companyForm.valid) {

      console.log(this. companyForm.value);
      this.companyService.postCompany(this.companyForm.value).subscribe({
        next: (msg: any) => {
          console.log(msg);
          
          this.router.navigateByUrl('/company')
      },
        error: (err) => console.error(err)
      }
      );
     
 // You can do whatever you want with the form data, e.g., send it to a server
    } else {
      console.log(this. companyForm.value);
      // Form is invalid, handle validation errors or show appropriate messages
    }
  }

}
