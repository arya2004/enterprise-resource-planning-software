import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProformaEditComponent } from './proforma-edit.component';

describe('ProformaEditComponent', () => {
  let component: ProformaEditComponent;
  let fixture: ComponentFixture<ProformaEditComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProformaEditComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ProformaEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
