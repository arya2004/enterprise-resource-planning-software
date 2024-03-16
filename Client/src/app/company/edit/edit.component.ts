import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { CompanyService } from '../company.service';
import { ActivatedRoute, Router } from '@angular/router';
import { ICompany } from 'src/app/shared/Models/Master/ICompany';

@Component({
  selector: 'app-edit',
  templateUrl: './edit.component.html',
  styleUrls: ['./edit.component.scss']
})
export class EditComponent implements OnInit{
  
  kek : string = "werwegf"
  company !: any;
  companyId !: number;

  ngOnInit() {

    this.companyId = this.activatedRoute.snapshot.params['id'];
    console.log(this.companyId);
    this.companyService.GetOneCompany(this.companyId).subscribe({
      next: (res: any) => {
        this.company = res.result;
        console.log(this.company);
        this.companyForm.patchValue(this.company);
      },
      error: (err) => console.error(err)
    
    })

  }

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

  constructor(private fb: FormBuilder, private companyService: CompanyService, private router: Router, private activatedRoute: ActivatedRoute) {}


  onSubmit() {
    

      console.log(this.company);
      this.companyService.UpdateCompany(this.company).subscribe({
        next: (msg: any) => {
          console.log(msg);
          
          this.router.navigateByUrl('/company')
      },
        error: (err) => console.error(err)
      }
      );
     
 
  }
}
