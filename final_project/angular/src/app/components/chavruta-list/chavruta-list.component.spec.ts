import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ChavrutaListComponent } from './chavruta-list.component';

describe('ChavrutaListComponent', () => {
  let component: ChavrutaListComponent;
  let fixture: ComponentFixture<ChavrutaListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ChavrutaListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ChavrutaListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
