import { TestBed } from '@angular/core/testing';

import { AssociateFeeService } from './associate-fee.service';

describe('AssociateFeeService', () => {
  let service: AssociateFeeService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AssociateFeeService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
