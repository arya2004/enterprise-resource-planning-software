import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { environment } from 'src/environments/environment.development';

@Injectable({
  providedIn: 'root'
})
export class AssociateService {

  constructor(private http: HttpClient, private router: Router) { }

  ApiUri  = environment.apiUrl + "AuthAPI/";
 
 
  postAssociate(company: any)
  {
    return this.http.post<any>(this.ApiUri , company);
  }

  GetAssociate()
  {
    console.log(this.ApiUri);
    
    
    return this.http.get<any>(this.ApiUri + "GetAllAssociate");
   
  }
  
  GetOneAssociate(id: number)
  {
    return this.http.get<any>(this.ApiUri + "GetOne" + `?id=${id}`);
  }
      
 

  DeleteAssociate(name: number)
  {
    return this.http.delete<any>(this.ApiUri + `?id=${name}`);
  }

}
