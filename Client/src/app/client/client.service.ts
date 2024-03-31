import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { environment } from 'src/environments/environment.development';

@Injectable({
  providedIn: 'root'
})
export class ClientService {

  constructor(private http: HttpClient, private router: Router) { }

  ApiUri  = environment.apiUrl + "Client/";
  ApiUriUpdate  = environment.apiUrl + "Client";
 
  postClient(company: any)
  {
    return this.http.post<any>(this.ApiUri , company);
  }

  GetClient()
  {
    console.log(this.ApiUri);
    
    
    return this.http.get<any>(this.ApiUri + "GetAll");
   
  }
  
  GetOneClient(id: number)
  {
    return this.http.get<any>(this.ApiUri + "GetOne" + `?id=${id}`);
  }

  UpdateClient(company: any)
  {
    return this.http.put<any>(this.ApiUriUpdate, company);
  }

  DeleteClient(name: number)
  {
    return this.http.delete<any>(this.ApiUri + `?id=${name}`);
  }


}
