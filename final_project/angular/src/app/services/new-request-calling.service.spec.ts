import { TestBed } from '@angular/core/testing';

import { NewRequestCallingService } from './new-request-calling.service';

describe('NewRequestCallingService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: NewRequestCallingService = TestBed.get(NewRequestCallingService);
    expect(service).toBeTruthy();
  });
});
