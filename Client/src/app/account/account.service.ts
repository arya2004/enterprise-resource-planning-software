import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ReplaySubject, map, of } from 'rxjs';
import { environment } from 'src/environments/environment.development';
import { User } from '../shared/Models/IUser';
import { Router } from '@angular/router';
import { IToken } from '../shared/Models/IToken';

@Injectable({
  providedIn: 'root'
})
export class AccountService {

  baseUrl = environment.apiUrl + "AuthAPI/";
  private currentUserSource = new ReplaySubject<User | null>(1);
  currentUser$ = this.currentUserSource.asObservable();
  Token!: IToken;

  constructor(private http: HttpClient, private router: Router) { 
    const t = localStorage.getItem('token');
    if (t) {
      this. Token = this.getUser(localStorage.getItem('token')!);
    }
   
  }

  loadCurrentUser(token: string | null) {
    if (token == null) {
      this.currentUserSource.next(null);
      return of(null);
    }

    let headers = new HttpHeaders();
    headers = headers.set('Authorization', `Bearer ${token}`);

    return this.http.get<User>(this.baseUrl + "GetCurrentUser", {headers}).pipe(
      map(user => {
        if (user) {
          localStorage.setItem('token', user.token);
          this.currentUserSource.next(user);
          return user;
        } else {
          return null;
        }
      })
    )
  }

  login(values: any) {
    return this.http.post<User>(this.baseUrl + 'login', values).pipe(
      map(user => {
        localStorage.setItem('token', user.token);
        this.currentUserSource.next(user);
        this.Token = this.getUser(user.token);
        //return user ; if wanna get back user
      })
    )
  }

  register(values: any) {
    return this.http.post<User>(this.baseUrl + 'register', values).pipe(
      map(user => {
        localStorage.setItem('token', user.token);
        this.currentUserSource.next(user);
      })
    )
  }

  logout() {
    localStorage.removeItem('token');
    this.currentUserSource.next(null);
    this.router.navigateByUrl('/');
  }

  checkEmailExists(email: string) {
    return this.http.get<boolean>(this.baseUrl + 'emailExists?email=' + email);
  }

  private getUser(token: string) : IToken{
    return JSON.parse(atob(token.split('.')[1])) as IToken;
  }
}

