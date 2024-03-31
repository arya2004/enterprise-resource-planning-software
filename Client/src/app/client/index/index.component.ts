import { Component } from '@angular/core';
import { Subject } from 'rxjs';
import { IClient } from 'src/app/shared/Models/Master/IClient';
import { ClientService } from '../client.service';

@Component({
  selector: 'app-index',
  templateUrl: './index.component.html',
  styleUrls: ['./index.component.scss']
})
export class IndexComponent {
  company: IClient[]  = [] ;
  constructor(public companyService: ClientService) { }
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
    this.companyService.GetClient().subscribe({
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
    this.companyService.DeleteClient(id).subscribe({
      next: res => {
        console.log(res);
        window.location.reload();
      },
      error: err => console.log(err)
    });
  }
}
