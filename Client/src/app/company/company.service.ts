import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment.development';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
@Injectable({
  providedIn: 'root'
})
export class CompanyService {

  constructor(private http: HttpClient, private router: Router) { }

  ApiUri  = environment.apiUrl + "Company/";
  ApiUriUpdate  = environment.apiUrl + "Company";
 
  postCompany(company: any)
  {
    return this.http.post<any>(this.ApiUri , company);
  }

  GetCompany()
  {
    console.log(this.ApiUri);
    
    
    return this.http.get<any>(this.ApiUri + "GetAll");
   
  }
  
  GetOneCompany(id: number)
  {
    return this.http.get<any>(this.ApiUri + "GetOne" + `?id=${id}`);
  }

  UpdateCompany(company: any)
  {
    return this.http.put<any>(this.ApiUriUpdate, company);
  }

  DeleteCompany(name: number)
  {
    return this.http.delete<any>(this.ApiUri + `?id=${name}`);
  }


 


}
