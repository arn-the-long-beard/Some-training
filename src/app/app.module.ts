import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppService } from './app.service';
import { HttpModule } from '@angular/http';
import { AppComponent } from './app.component';
import {EmployeeService} from './employees/employee.service'
import {EmployeeListComponent} from './employees/employee-list.component'

@NgModule({
  declarations: [
    AppComponent,EmployeeListComponent  
  ],
  imports: [
    BrowserModule,
    HttpModule
  ],

  providers: [AppService,EmployeeService],
  bootstrap: [AppComponent]
})
export class AppModule { }
