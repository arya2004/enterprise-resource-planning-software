import { Component, OnInit } from '@angular/core';
import { Subject } from 'rxjs';
import { AssociateService } from '../associate.service';
import { IAssociateIndex } from 'src/app/shared/Models/Master/IAssociateIndex';

@Component({
  selector: 'app-index',
  templateUrl: './index.component.html',
  styleUrls: ['./index.component.scss']
})
export class IndexComponent implements OnInit{

  
  company: IAssociateIndex[]  = [] ;
  constructor(public companyService: AssociateService) { }
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
    this.companyService.GetAssociate().subscribe({
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
    this.companyService.DeleteAssociate(id).subscribe({
      next: res => {
        console.log(res);
        window.location.reload();
      },
      error: err => console.log(err)
    });
  }

}
