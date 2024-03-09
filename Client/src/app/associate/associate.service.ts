import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { environment } from 'src/environments/environment.development';

@Injectable({
  providedIn: 'root'
})
export class AssociateService {

  constructor(private http: HttpClient, private router: Router) { }

  ApiUri  = environment.apiUrl + "Company/";
 
  postCompany(company: any)
  {
    return this.http.post<any>(this.ApiUri , company);
  }

  GetCompany()
  {
    console.log(this.ApiUri);
    
    
    return this.http.get<any>(this.ApiUri + "GetAll");
   
  }
  
  GetOneCompany(name: string)
  {
    return this.http.get<any>(this.ApiUri + "GetOne" + `?name=${name}`);
  }

  UpdateCompany(company: any)
  {
    return this.http.put<any>(this.ApiUri, company);
  }

  DeleteCompany(name: string)
  {
    return this.http.delete<any>(this.ApiUri + `?name=${name}`);
  }

}
