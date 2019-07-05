import { BrowserModule } from '@angular/platform-browser';
import { NgModule,TemplateRef } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {MatButtonModule, MatCheckboxModule, MatInputModule,MatFormFieldModule} from '@angular/material';
import {MatTabsModule} from '@angular/material/tabs';
import {HttpClientModule} from '@angular/common/http';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { TooltipModule } from 'ngx-bootstrap/tooltip';
import { ModalModule,BsModalService } from 'ngx-bootstrap/modal';

import { FormsModule } from '@angular/forms';
import { SearchRequestComponent } from './components/search-request/search-request.component';
import { LoginComponent } from './components/login/login.component';
import { TabsComponent } from './components/tabs/tabs.component';
import { ChavrutaListComponent } from './components/chavruta-list/chavruta-list.component';
import { ScheduleComponent } from './components/schedule/schedule.component';
import { UpdateDetailsComponent } from './components/update-details/update-details.component';
import { AboutComponent } from './components/about/about.component';
import { NewRequestComponent } from './components/new-request/new-request.component';


@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    SearchRequestComponent,
    TabsComponent,
    ChavrutaListComponent,
    ScheduleComponent,
    UpdateDetailsComponent,
    AboutComponent,
    NewRequestComponent    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,FormsModule,
    MatButtonModule,
    MatInputModule,
    MatFormFieldModule,
    //  MatCheckboxModule,
     MatTabsModule,
     HttpClientModule,
     BsDropdownModule.forRoot(),
     TooltipModule.forRoot(),
     ModalModule.forRoot(),
  ],
  providers: [HttpClientModule,BsModalService],
  bootstrap: [AppComponent]
})
export class AppModule { }
