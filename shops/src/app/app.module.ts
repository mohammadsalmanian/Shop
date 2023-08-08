import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SiteHeaderComponent } from './SharedComponent/site-header/site-header.component';
import { SiteFooterComponent } from './SharedComponent/site-footer/site-footer.component';
import { IndexComponent } from './pages/index/index.component';
import { SliderComponent } from './pages/slider/slider.component';

@NgModule({
  declarations: [
    AppComponent,
    SiteHeaderComponent,
    SiteFooterComponent,
    IndexComponent,
    SliderComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
