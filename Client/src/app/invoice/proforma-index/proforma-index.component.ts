import { Component, OnInit } from '@angular/core';
import { Subject } from 'rxjs';

@Component({
  selector: 'app-proforma-index',
  templateUrl: './proforma-index.component.html',
  styleUrls: ['./proforma-index.component.scss']
})
export class ProformaIndexComponent implements OnInit {

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
