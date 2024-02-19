import { TestBed } from '@angular/core/testing';

import { ProjectFeesService } from './project-fees.service';

describe('ProjectFeesService', () => {
  let service: ProjectFeesService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ProjectFeesService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
