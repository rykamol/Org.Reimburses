import { PaySalaryFormComponent } from './components/pay-salary-form/pay-salary-form.component';
import { ClaimCourseFormComponent } from './components/claim-course-form/claim-course-form.component';
import { ClaimCourseListComponent } from './components/claim-course-list/claim-course-list.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {path:"",component:ClaimCourseListComponent},
  {path:"new-claim-course",component:ClaimCourseFormComponent},
  {path:"pay-salary",component:PaySalaryFormComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
