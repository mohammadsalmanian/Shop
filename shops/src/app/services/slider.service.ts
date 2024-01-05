import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, BehaviorSubject } from 'rxjs';
import { HomeSliderResponse } from '../DTOs/Sliders/HomeSliderResponse';
import { Slider } from '../DTOs/Sliders/Slider';
import { __values } from 'tslib';

@Injectable({
  providedIn: 'root'
})
export class SliderService {

  private homeSliders: BehaviorSubject<Slider[]> = new BehaviorSubject<Slider[]>([]);

  constructor(private http: HttpClient) { }

  //BehaviorSubject نوعی از Observable
  // public GetSlider():Observable<{status:string , data : Object}>{
  //   return this.http.get<{status:string , data : Object}>("https://localhost:44381/Slider/GetActiveSlider");
  //  }


  public GetSliders(): Observable<HomeSliderResponse> {
    return this.http.get<HomeSliderResponse>('https://localhost:44381/Slider/GetActiveSlider');
  }

  public getCurrentSliders(): Observable<Slider[]> {
    return this.homeSliders;
  }
  
  public setCurrentSliders(Slider: Slider[]) {
    this.homeSliders.next(Slider);
  }

}
