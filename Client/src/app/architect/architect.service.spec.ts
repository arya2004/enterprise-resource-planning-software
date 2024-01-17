import { TestBed } from '@angular/core/testing';

import { ArchitectService } from './architect.service';

describe('ArchitectService', () => {
  let service: ArchitectService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ArchitectService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
