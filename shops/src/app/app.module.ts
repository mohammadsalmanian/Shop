import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SiteHeaderComponent } from './SharedComponent/site-header/site-header.component';
import { SiteFooterComponent } from './SharedComponent/site-footer/site-footer.component';
import { IndexComponent } from './pages/index/index.component';
import { SliderComponent } from './pages/slider/slider.component';
import { SpecialProductsComponent } from './pages/special-products/special-products.component';
import { NewProductsComponent } from './pages/new-products/new-products.component';
import { SliderService } from './services/slider.service';
import {HttpClientModule} from '@angular/common/http';
@NgModule({
  declarations: [
    AppComponent,
    SiteHeaderComponent,
    SiteFooterComponent,
    IndexComponent,
    SliderComponent,
    SpecialProductsComponent,
    NewProductsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [SliderService],
  bootstrap: [AppComponent]
}) 
export class AppModule { }
