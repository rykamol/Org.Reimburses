import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ClaimCourseFormComponent } from './claim-course-form.component';

describe('ClaimCourseFormComponent', () => {
  let component: ClaimCourseFormComponent;
  let fixture: ComponentFixture<ClaimCourseFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ClaimCourseFormComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ClaimCourseFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
