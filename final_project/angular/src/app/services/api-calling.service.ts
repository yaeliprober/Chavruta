

import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs/internal/Observable';
import { resource } from 'selenium-webdriver/http';
import { registerNgModuleType } from '@angular/core/src/linker/ng_module_factory_loader';
import { User } from '../Models/User';
//import { RequestResult} from '../services/api-calling.service.spec';

export class RequestResult {
  public Status: boolean;
  public Data: object;
  public Message: string;
 
  constructor(Status: boolean, Data: object, Message: string) {
    this.Data = Data;
    this.Message = Message;
    this.Status = Status;
  }
}
@Injectable({
  providedIn: 'root'
})
export class ApiCallingService {

  constructor(private http: HttpClient) {
  }
  public isLogedIn:boolean=false;//ask

  Login(mail: string, pass: string): Observable<RequestResult> {
    debugger;
    let params = new HttpParams().set("mail", mail).set("pass", pass);
    let t= new User();
    t.userMail=mail;
    t.userPassword=pass;
    return this.http.post<RequestResult>("http://localhost:64428/api/UsersManagement/CheckPass",t);
  }
  ForgotPass(mail: string): Observable<RequestResult> {    
    return this.http.get<RequestResult>("http://localhost:64428/api/UsersManagement/ForgotPass/"+mail);
  }
  
  // reg(): Observable<RequestResult> {
  //   debugger;
  //   //let params = new HttpParams().set("mail", mail).set("pass", pass);
  //   return this.http.get<RequestResult>("http://localhost:64428/api/UsersManagement/GetAllUsers");
  // }
}



























