import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { Subject } from 'rxjs';
import { ProjectsService } from 'src/app/projects/projects.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class EmployeeDashboardComponent implements OnInit{

  constructor(private projectService :ProjectsService, private fb: FormBuilder) { }
  dtOptions: DataTables.Settings = {};
  dtTrigger: Subject<any> = new Subject<any>();
  ngOnInit(): void {
    this.dtOptions = {
      pagingType: 'full_numbers'
    };
    this.getAllCompany();

    this.projectService.GetCompanyForDropdown().subscribe({
      next: (data) => {
        this.companies = data.result;
      },
      error: (err) => console.error(err)
    })

    this.form.get('projectCode')?.patchValue(this.selectedValue); 
   
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

  selectedValue: string = "D46456";
  companies = [
    { companyId: 'A34345', companyCode: 'Project One', name: 'Project One'},
    { companyId: 'A34345', companyCode: 'Project One', name: 'Project One'},
    { companyId: 'A34345', companyCode: 'Project One', name: 'Project One'},
    { companyId: 'A34345', companyCode: 'Project One', name: 'Project One'},

  ];


  form = this.fb.group({

    
    
    projectCode: [this.selectedValue],
  



  });
}
