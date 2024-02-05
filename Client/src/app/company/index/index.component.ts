import { Component, OnInit } from '@angular/core';
import { CompanyService } from '../company.service';
import { ICompany } from 'src/app/shared/Models/Master/ICompany';

@Component({
  selector: 'app-index',
  templateUrl: './index.component.html',
  styleUrls: ['./index.component.scss']
})
export class IndexComponent implements OnInit {

  company: ICompany[]  = [] ;
  constructor(public companyService: CompanyService) { }

  ngOnInit(): void {
    this.getAllCompany();
  }

  getAllCompany()
  {
    this.companyService.GetCompany().subscribe({
      next: res => {
      this.company = res.result;
    },
  
    error: err => console.log(err)
  });
  }
}
