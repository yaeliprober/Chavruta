import { Component, OnInit } from '@angular/core';
import { RequestResult, NewRequestCallingService } from 'src/app/services/new-request-calling.service';
// import { RequestParameter } from 'src/app/Models/RequestParameter';
import{ RequestParameter } from 'src/app/Models/RequestParameter';

@Component({
  selector: 'app-new-request',
  templateUrl: './new-request.component.html',
  styleUrls: ['./new-request.component.css']
})

export class NewRequestComponent implements OnInit {
  ngOnInit() {
  } 
  constructor(private api: NewRequestCallingService) { }
  mail: string;
  n: RequestParameter = new RequestParameter();
  Submit(){
    this.api.GetId(this.mail).subscribe((success) =>{
      let t: RequestResult = success;
      if((t.Data).toString()=="true")
          {
            alert(t.Message);
            this.n.userId=parseInt((t.Data).toString(),10);
          }
          else 
          alert(t.Message);
    }, (error) => {
      alert(error);
    });

    this.api.AddRequest(this.n).subscribe((success) =>{
      let t: RequestResult = success;
      alert(t.Message);
    }, (error) => {
      alert(error);
    });
    }

  }

  
  
