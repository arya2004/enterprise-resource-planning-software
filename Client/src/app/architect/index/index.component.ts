import { Component, OnInit } from '@angular/core';
import { Subject } from 'rxjs';
import { IArchitect } from 'src/app/shared/Models/Master/IArchitect';
import { ArchitectService } from '../architect.service';

@Component({
  selector: 'app-index',
  templateUrl: './index.component.html',
  styleUrls: ['./index.component.scss']
})
export class IndexComponent implements OnInit{

 
  company: IArchitect[]  = [] ;
  constructor(public companyService: ArchitectService) { }
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
    this.companyService.GetArchitect().subscribe({
      next: res => {
      this.company = res.result;
      this.dtTrigger.next(null);
    },
  
    error: err => console.log(err)
  });
  }


  deleteCompany(id: number)
  {
    console.log(id);
    this.companyService.DeleteArchitect(id).subscribe({
      next: res => {
        console.log(res);
        window.location.reload();
      },
      error: err => console.log(err)
    });
  }
}
