import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { environment } from 'src/environments/environment.development';

@Injectable({
  providedIn: 'root'
})
export class ArchitectService {

  constructor(private http: HttpClient, private router: Router) { }

  ApiUri  = environment.apiUrl + "Architect/";
  ApiUriUpdate  = environment.apiUrl + "Architect";
 
  postArchitect(company: any)
  {
    return this.http.post<any>(this.ApiUri , company);
  }

  GetArchitect()
  {
    console.log(this.ApiUri);
    
    
    return this.http.get<any>(this.ApiUri + "GetAll");
   
  }
  
  GetOneArchitect(id: number)
  {
    return this.http.get<any>(this.ApiUri + "GetOne" + `?id=${id}`);
  }

  UpdateArchitect(company: any)
  {
    return this.http.put<any>(this.ApiUriUpdate, company);
  }

  DeleteArchitect(name: number)
  {
    return this.http.delete<any>(this.ApiUri + `?id=${name}`);
  }

}
