import { Component } from '@angular/core';
import { ClientService } from '../client.service';
import { FormBuilder, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-edit',
  templateUrl: './edit.component.html',
  styleUrls: ['./edit.component.scss']
})
export class EditComponent {

  companyId !: number;

  ngOnInit() {

    this.companyId = this.activatedRoute.snapshot.params['id'];
    console.log(this.companyId);
    this.companyService.GetOneClient(this.companyId).subscribe({
      next: (res: any) => {

        this.companyForm.patchValue(res.result);
        console.log(res.result);
        
      },
      error: (err) => console.error(err)
    
    })

  }

  companyForm = this.fb.group({
    clientId: [this.companyId],
    clientCode: [null],
    clientName: [null],
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
    mobileNumber2: [null],
    email2: [null, Validators.email],
    panNumber: [null],
    gstNumber: [null]
  });


  constructor(private fb: FormBuilder, private companyService: ClientService, private router: Router, private activatedRoute: ActivatedRoute) {}


  onSubmit() {
    if (this.companyForm.valid) {

      console.log(this. companyForm.value);
      this.companyService.UpdateClient(this.companyForm.value).subscribe({
        next: (msg: any) => {
          console.log(msg);
          
          this.router.navigateByUrl('/client')
      },
        error: (err) => console.error(err)
      }
      );
     
 // You can do whatever you want with the form data, e.g., send it to a server
    } else {
      console.log(this. companyForm.value);
      // Form is invalid, handle validation errors or show appropriate messages
      this.companyService.UpdateClient(this.companyForm.value).subscribe({
        next: (msg: any) => {
          console.log(msg);
          
          this.router.navigateByUrl('/client')
      },
        error: (err) => console.error(err)
      }
      );
    }
  }
}
