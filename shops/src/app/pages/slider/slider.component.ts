
import { Component } from '@angular/core';
import { Observable } from 'rxjs';
import { SliderService } from 'src/app/services/slider.service';

@Component({
  selector: 'app-index-slider',
  templateUrl: './slider.component.html',
  styleUrls: ['./slider.component.css']
})
export class SliderComponent {
  constructor(private sliderService: SliderService) {

  }
  ngOnInit(): void {
    this.sliderService.getCurrentSliders().subscribe(sliders => {
      console.log(sliders)
      if (sliders.length === 0) {
        this.sliderService.GetSliders().subscribe(res => {
          console.log(res.status)
          if (res.status === 'Success') {
            this.sliderService.setCurrentSliders(res.data);
          }
        });
      }
    });
  }
}
