import { Component,OnInit,TemplateRef } from '@angular/core';
import {Observable} from "rxjs";
import {HttpClient} from "@angular/common/http";
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { ApiCallingService } from './services/api-calling.service';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
 
  title = 'angular';
res:Observable<string>;
  
  getData(){

  }
  public modalRef: BsModalRef; // {1}
  constructor(private http:HttpClient,private modalService: BsModalService,private api:ApiCallingService) {
  }
  ngOnInit() {
    
    debugger;
        // this.http
        // .get<string>("http://localhost:64857/values/GetData").toPromise()
        // .then(
        //   res => { // Success
        //     console.log(res);
        //   }
        // );
       
        
}

public openModal(template: TemplateRef<any>) {
  this.modalRef = this.modalService.show(template); // {3}
}
}
