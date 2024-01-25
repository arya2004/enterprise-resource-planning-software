import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProformaNewComponent } from './proforma-new.component';

describe('ProformaNewComponent', () => {
  let component: ProformaNewComponent;
  let fixture: ComponentFixture<ProformaNewComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProformaNewComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ProformaNewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
