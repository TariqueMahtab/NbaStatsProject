import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router'; //  Add this
import { AppRoutingModule } from './app-routing.module'; //  Add this

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { AboutComponent } from './about/about.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    AboutComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,  //  Add this
    RouterModule       //  Add this
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
