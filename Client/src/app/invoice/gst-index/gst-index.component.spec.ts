import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GstIndexComponent } from './gst-index.component';

describe('GstIndexComponent', () => {
  let component: GstIndexComponent;
  let fixture: ComponentFixture<GstIndexComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GstIndexComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(GstIndexComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
