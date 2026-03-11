import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MainCount1Component } from './main-count1.component';
import { Card1Component } from '../card1/card1.component';
import { Card2Component } from '../card2/card2.component';
import { Card3Component } from '../card3/card3.component';

describe('MainCount1Component', () => {
  let component: MainCount1Component;
  let fixture: ComponentFixture<MainCount1Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MainCount1Component,
      Card1Component,
    Card2Component,
  Card3Component ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MainCount1Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
