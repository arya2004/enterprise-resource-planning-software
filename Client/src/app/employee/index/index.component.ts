import { Component, OnInit } from '@angular/core';
import { Subject } from 'rxjs';
import { EmployeeService } from '../employee.service';
import { IEmployeeUser } from 'src/app/shared/Models/Master/IEmployeeUser';
import { IEmployeeIndex } from 'src/app/shared/Models/Master/IEmployeeIndex';

@Component({
  selector: 'app-index',
  templateUrl: './index.component.html',
  styleUrls: ['./index.component.scss']
})
export class IndexComponent implements OnInit{

  company: IEmployeeIndex[]  = [] ;
  constructor(public companyService: EmployeeService) { }
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
    this.companyService.GetEmployee().subscribe({
      next: res => {
      this.company = res.result;
      this.dtTrigger.next(null);
      console.log(this.company);
      
    },
  
    error: err => console.log(err)
  });
  }


  deleteCompany(id: number)
  {
    console.log(id);
    this.companyService.DeleteEmployee(id).subscribe({
      next: res => {
        console.log(res);
        window.location.reload();
      },
      error: err => console.log(err)
    });
  }
}
