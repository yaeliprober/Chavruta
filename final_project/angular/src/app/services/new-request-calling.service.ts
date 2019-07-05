import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs/internal/Observable';
import { RequestParameter } from '../Models/RequestParameter';

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
export class NewRequestCallingService {

  constructor(private http: HttpClient) { }
  GetId(mail: string): Observable<RequestResult> {
    return this.http.get<RequestResult>("http://localhost:64428/api/UsersManagement/GetId/"+mail);   
  }

  AddRequest(n:RequestParameter){   
    return this.http.post<RequestResult>("http://localhost:64428/api/UsersManagement/AddRequest",n);
  }
}
