import { HttpClient } from '@angular/common/http';

import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'client';
  users: any;
  constructor(private http: HttpClient) {}
  ngOnInit(): void {
    this.http.get('http://localhost:5000/api/user').subscribe({
      next: (response: any) => this.users = response,
      error: (error: any) => console.error('There was an error!', error),
      complete: () => console.log('Completed!')
    });
  
  }
}
