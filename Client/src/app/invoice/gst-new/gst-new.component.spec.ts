import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GstNewComponent } from './gst-new.component';

describe('GstNewComponent', () => {
  let component: GstNewComponent;
  let fixture: ComponentFixture<GstNewComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GstNewComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(GstNewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
