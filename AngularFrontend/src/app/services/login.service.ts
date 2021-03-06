import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class LoginService {
  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
    })
  }
  
  baseUrl:string = "https://localhost:44306/api/login";
  constructor(private _http : HttpClient) { }
  loginUser(data){
    return this._http.post<Number>(this.baseUrl,data,this.httpOptions);
  }
  isLoggedIn(){
    if(sessionStorage.getItem('userData')){
      return true;
    }
    return false;
  }
  Logout()
  {
    if(sessionStorage.getItem('userData'))
    {
      sessionStorage.removeItem('userData');
    }
  }
}
