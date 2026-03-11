import { Component } from '@angular/core';

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.css']
})
export class SidebarComponent {
  title= 'sidebar';
  someData:string ='Test Data';

  someEventOrAction() {
    throw new Error('Method not implemented.');
  }
 
  hoverIn(item:any) {
    item.classList.add('hovered');
  }
  
 hoverOut(item:any) {
    item.classList.remove('hovered');
  }
 
}
