import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { environment } from 'src/environments/environment.development';

@Injectable({
  providedIn: 'root'
})
export class AttendanceService {

  constructor(private http: HttpClient, private router: Router) { }

  ApiUri  = environment.apiUrl + "Attendance/";
  ApiUriUpdate  = environment.apiUrl + "Attendance";
 
  postAttendance(company: any)
  {
    return this.http.post<any>(this.ApiUri + "Create" , company);
  }

  GetAttendance()
  {
    console.log(this.ApiUri);
    
    
    return this.http.get<any>(this.ApiUri + "GetAll");
   
  }
  
  GetOneAttendance(id: number)
  {
    return this.http.get<any>(this.ApiUri + "GetOne" + `?id=${id}`);
    //https://localhost:7130/api/Attendance/GetAttendanceForMonth?year=2024&month=3
  }

  GetOneAttendanceForMonth(year: number, month: number)
  {
    return this.http.get<any>(this.ApiUri + "GetAttendanceForMonth?" + `year=${year}`+ `&month=${month}`);
    //https://localhost:7130/api/Attendance/GetAttendanceForMonth?year=2024&month=3
  }


  UpdateAttendance(company: any)
  {
    return this.http.put<any>(this.ApiUriUpdate, company);
  }

  DeleteAttendance(name: number)
  {
    return this.http.delete<any>(this.ApiUri + `?id=${name}`);
  }
}
