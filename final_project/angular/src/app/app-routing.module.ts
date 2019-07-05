import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { SearchRequestComponent } from './components/search-request/search-request.component';
import { TabsComponent } from './components/tabs/tabs.component';
import { LoginComponent } from './components/login/login.component';
import { AboutComponent } from './components/about/about.component';
import { ChavrutaListComponent } from './components/chavruta-list/chavruta-list.component';
import { NewRequestComponent } from './components/new-request/new-request.component';
import { ScheduleComponent } from './components/schedule/schedule.component';
import { UpdateDetailsComponent } from './components/update-details/update-details.component';

const routes: Routes = [
{ path: '', component:LoginComponent }, 
{ path: 'searchRequest', component: SearchRequestComponent },
{ path: 'tabs', component: TabsComponent },
{ path: 'about', component: AboutComponent },
{ path: 'chavrutaList', component: ChavrutaListComponent },
{ path: 'login', component: LoginComponent },
{ path: 'newRequest', component: NewRequestComponent },
{ path: 'schedule', component: ScheduleComponent },
{ path: 'updateDetails', component: UpdateDetailsComponent },
 ];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
