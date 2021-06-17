import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PaySalaryFormComponent } from './pay-salary-form.component';

describe('PaySalaryFormComponent', () => {
  let component: PaySalaryFormComponent;
  let fixture: ComponentFixture<PaySalaryFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PaySalaryFormComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PaySalaryFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
