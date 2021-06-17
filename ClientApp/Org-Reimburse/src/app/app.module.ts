import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ClaimCourseFormComponent } from './components/claim-course-form/claim-course-form.component';
import { ClaimCourseListComponent } from './components/claim-course-list/claim-course-list.component';
import { PaySalaryFormComponent } from './components/pay-salary-form/pay-salary-form.component';

@NgModule({
  declarations: [
    AppComponent,
    ClaimCourseFormComponent,
    ClaimCourseListComponent,
    PaySalaryFormComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
