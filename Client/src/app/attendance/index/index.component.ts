import { Component } from '@angular/core';
import { Subject } from 'rxjs';
import { IEmployeeAttendance } from 'src/app/shared/Models/IEmployeeAttendance';
import { AttendanceService } from '../attendance.service';

@Component({
  selector: 'app-index',
  templateUrl: './index.component.html',
  styleUrls: ['./index.component.scss']
})
export class IndexComponent {

  company: IEmployeeAttendance[]  = [] ;
  constructor(public companyService: AttendanceService) { }
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
    let month =new Date().getMonth() + 1
    let year = new Date().getFullYear();
    this.companyService.GetOneAttendanceForMonth(year, month).subscribe({
      next: res => {
      this.company = res.result;
      console.log(this.company);
      
      this.dtTrigger.next(null);
    },
  
    error: err => console.log(err)
  });
  }


  deleteCompany(id: number)
  {
    console.log(id);
    this.companyService.DeleteAttendance(id).subscribe({
      next: res => {
        console.log(res);
        window.location.reload();
      },
      error: err => console.log(err)
    });
  }
}
