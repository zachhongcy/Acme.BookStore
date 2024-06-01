import { AuthService } from '@abp/ng.core';
import { Component } from '@angular/core';
import { BookService } from '@proxy';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
})
export class HomeComponent {
  get hasLoggedIn(): boolean {
    return this.authService.isAuthenticated;
  }

  constructor(
    private authService: AuthService,
    private bookService: BookService) {}

  login() {
    this.authService.navigateToLogin();
  }

  getBook() {
    this.bookService.get().subscribe();
  }
}
