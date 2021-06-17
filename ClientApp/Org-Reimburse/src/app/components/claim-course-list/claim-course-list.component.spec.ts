import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ClaimCourseListComponent } from './claim-course-list.component';

describe('ClaimCourseListComponent', () => {
  let component: ClaimCourseListComponent;
  let fixture: ComponentFixture<ClaimCourseListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ClaimCourseListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ClaimCourseListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
