import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { environment } from 'src/environments/environment.development';

@Injectable({
  providedIn: 'root'
})
export class ProjectsService {

  constructor(private http: HttpClient, private router: Router) { }

  ApiUri  = environment.apiUrl + "Project/";
  CompanyApiUri  = environment.apiUrl + "Company/";
 
  postProject(company: any)
  {
    return this.http.post<any>(this.ApiUri , company);
  }

  GetProject()
  {
    console.log(this.ApiUri);
    
    
    return this.http.get<any>(this.ApiUri + "GetAll");
   
  }

  GetCompanyForDropdown()
  {
    
    
    return this.http.get<any>(this.CompanyApiUri + "GetAllForDropdown");
   
  }
  
  GetOneProject(name: string)
  {
    return this.http.get<any>(this.ApiUri + "GetOne" + `?name=${name}`);
  }

  UpdateProject(company: any)
  {
    return this.http.put<any>(this.ApiUri, company);
  }

  DeleteProject(name: string)
  {
    return this.http.delete<any>(this.ApiUri + `?name=${name}`);
  }

}
