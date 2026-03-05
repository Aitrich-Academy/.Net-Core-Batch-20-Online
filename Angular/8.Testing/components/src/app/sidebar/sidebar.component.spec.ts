import { ComponentFixture, TestBed } from '@angular/core/testing';
import { SidebarComponent } from './sidebar.component';
import { NO_ERRORS_SCHEMA } from '@angular/core';

describe('SidebarComponent', () => {
  let component: SidebarComponent;
  let fixture: ComponentFixture<SidebarComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      schemas:[NO_ERRORS_SCHEMA],
      declarations: [ SidebarComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SidebarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
  it(`should have as title 'platform-admin'`, () => {
    const fixture = TestBed.createComponent(SidebarComponent);
    const app = fixture.componentInstance;
    expect(app.title).toEqual('sidebar');
  });

  it('should initialize properties correctly', () => {
    // Arrange (setup initial conditions)
    // component.someData = 'Test Data';
  
    // Act (trigger component lifecycle hooks)
    fixture.detectChanges();
  
    // Assert (check the expected results)
    expect(component.someData).toEqual('Test Data');
  });

  it('should render template elements', () => {
    // Act (trigger component lifecycle hooks)
    fixture.detectChanges();

    // Assert (check elements in the rendered template)
    const compiled = fixture.nativeElement;
    expect(compiled.querySelector('h1')).toBeTruthy(); // Check if an h1 element exists
    expect(compiled.querySelector('.content')).toBeTruthy(); // Check if an element with class 'content' exists
  });

 
});
