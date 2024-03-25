import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ProjectsService } from '../projects.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-new',
  templateUrl: './new.component.html',
  styleUrls: ['./new.component.scss']
})
export class NewComponent implements OnInit {
  constructor(private fb:FormBuilder, private projectService: ProjectsService, private router: Router) {
    console.log(this.selectedValue)
  }

  selectedValue: string = "D46456";
  companies = [
    { companyId: 'A34345', companyCode: 'Project One', name: 'Project One'},
    { companyId: 'A34345', companyCode: 'Project One', name: 'Project One'},
    { companyId: 'A34345', companyCode: 'Project One', name: 'Project One'},
    { companyId: 'A34345', companyCode: 'Project One', name: 'Project One'},

  ];


  ngOnInit(): void {

    this.projectService.GetCompanyForDropdown().subscribe({
      next: (data) => {
        this.companies = data.result;
      },
      error: (err) => console.error(err)
    })

    this.form.get('projectCode')?.patchValue(this.selectedValue); 
  }

  range = new FormGroup({
    start: new FormControl<Date | null>(null),
    end: new FormControl<Date | null>(null),
  });


  description = "";



  above = this. fb.group({
    title: ['']
  })
  form = this.fb.group({

    
    client: [null],
    projectCode: [this.selectedValue],
    name: [null],
    clientWoNumber: [null],
    start: [null],
    end: [null],
    services: [null],
    projectLocation: [null],
    totalFees: [null],
    feesReceived: [null],
    feesBalance: [null],
    expenses: [null],
    profitAmount: [null],
    isCompleted: [null],




  });


 

  onSubmit()
  { 
    // const coding: IAssignment = new Assignment();
    // coding.title = this.above.value.title
    // coding.description = this.description
    // coding.startDate = this.range.value.start
    // coding.endDate = this.range.value.end
    // coding.evaluationemployees = this.employees.value
 
    console.log(JSON.stringify(this.form.value));
    
      // this.teacherService.postAssignment(coding).subscribe({
      //   next: () => this.router.navigateByUrl('/teacher')
      // })
  }
  


}
