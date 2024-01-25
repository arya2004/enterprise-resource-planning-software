import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProformaIndexComponent } from './proforma-index.component';

describe('ProformaIndexComponent', () => {
  let component: ProformaIndexComponent;
  let fixture: ComponentFixture<ProformaIndexComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProformaIndexComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ProformaIndexComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
