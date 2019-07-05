import { Component, OnInit } from '@angular/core';
import { from } from 'rxjs';
import { User } from 'src/app/Models/User';
import { Router} from '@angular/router';
import { RequestResult, ApiCallingService } from 'src/app/services/api-calling.service';

export class TabGroupBasicExample {}
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  mail: string;
  pass: string;
  hideForm:boolean=false;
  u: User = new User();
  constructor(private api: ApiCallingService,private router: Router) { }

  Login() {   
    this.api.Login(this.mail, this.pass).subscribe((success) => {
      let t: RequestResult = success;
      if(success)
      {      
        if((t.Data).toString()=="true")
          {
            this.hideForm=true;
            this.api.isLogedIn=true;
          }
        else
        alert(t.Message);//popup in case that the status is true
      }
     else
     alert(t.Message);
    }, (error) => {
      alert(error);
    });
  }
  ForgotPass() { 
    this.api.ForgotPass(this.mail).subscribe((success) => {
      let t: RequestResult = success;
     alert(t.Message);
    }, (error) => {
      alert(error);
    });
  }
  ngOnInit() {
  }
}
