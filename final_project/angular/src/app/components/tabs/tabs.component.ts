import { Component, OnInit } from '@angular/core';
import { MatTabChangeEvent } from '@angular/material';
import { Router} from '@angular/router';

@Component({
  selector: 'app-tabs',
  templateUrl: './tabs.component.html',
  styleUrls: ['./tabs.component.css']
})
export class TabsComponent implements OnInit {

  constructor(private router: Router) { }

 

  onLinkClick=(event: MatTabChangeEvent)=>{
    // console.log('event => ', event);
    // console.log('index => ', event.index);
    // console.log('tab => ', event.tab);
  switch ( event.index) {
    case 0:
       this.router.navigate(['searchRequest']); 
      break;
      case 1:
        this.router.navigate(['newRequest']); 
       break;
       case 2:
        this.router.navigate(['chavrutaList']); 
       break;
       case 3:
        this.router.navigate(['schedule']); 
       break;
       case 4:
        this.router.navigate(['updateDetails']); 
       break;
       case 5:
        this.router.navigate(['about']); 
       break;
    default:
      break;
  } 
  }
  ngOnInit() {
  }

}
