import { Component, OnInit } from '@angular/core';
import { Subject } from 'rxjs';

@Component({
  selector: 'app-index',
  templateUrl: './index.component.html',
  styleUrls: ['./index.component.scss']
})
export class IndexComponent implements OnInit{

  constructor() { }
  dtOptions: DataTables.Settings = {};
  dtTrigger: Subject<any> = new Subject<any>();
  ngOnInit(): void {
    this.dtOptions = {
      pagingType: 'full_numbers'
    };
    this.getAllCompany();
   
  }

  getAllCompany()
  {
   // this.companyService.GetCompany().subscribe({
    //  next: res => {
    //  this.company = res.result;
      this.dtTrigger.next(null);
    //},
  
    //error: err => console.log(err)
  //}
  //);
  }

}
