import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AccessoryNextComponent } from './accessory-next.component';

describe('AccessoryNextComponent', () => {
  let component: AccessoryNextComponent;
  let fixture: ComponentFixture<AccessoryNextComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AccessoryNextComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AccessoryNextComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
