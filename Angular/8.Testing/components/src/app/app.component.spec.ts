import { TestBed } from '@angular/core/testing';
import { RouterTestingModule } from '@angular/router/testing';
import { AppComponent } from './app.component';
import { NO_ERRORS_SCHEMA } from '@angular/compiler';
import { SidebarComponent } from './sidebar/sidebar.component';
import { NavbarComponent } from './navbar/navbar.component';
import { Card1Component } from './card1/card1.component';
import { Card2Component } from './card2/card2.component';
import { Card3Component } from './card3/card3.component';
import { MainCount1Component } from './main-count1/main-count1.component';

describe('AppComponent', () => {
  //Arrange
  beforeEach(async () => {
    await TestBed.configureTestingModule({
      schemas:[NO_ERRORS_SCHEMA],
      imports: [
        RouterTestingModule
      ],
      declarations: [
        AppComponent,
       SidebarComponent,
       NavbarComponent,
       Card1Component,
       Card2Component,
       Card3Component,       
       MainCount1Component
      ],
    }).compileComponents();
  });

  it('should create the app', () => {

    //Act
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.componentInstance;
    //Assert
    expect(app).toBeTruthy();
  });

  it(`should have as title 'platform-admin'`, () => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.componentInstance;
    expect(app.title).toEqual('platform-admin');
  });

  it('should render title', () => {
    const fixture = TestBed.createComponent(AppComponent);
    fixture.detectChanges();
    const compiled = fixture.nativeElement as HTMLElement;
    expect(compiled.querySelector('.content span')?.textContent).toContain('platform-admin app is running!');
  });
});
