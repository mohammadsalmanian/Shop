
import { Component } from '@angular/core';
import { Observable } from 'rxjs';
import { SliderService } from 'src/app/services/slider.service';
import { Slider } from 'src/app/DTOs/Sliders/Slider';
//declare $ : any;
declare function homeslider():any;
@Component({
  selector: 'app-index-slider',
  templateUrl: './slider.component.html',
  styleUrls: ['./slider.component.css']
})
export class SliderComponent {
  constructor(private sliderService: SliderService) {

  }  
public slider : Slider[] = [];

  ngOnInit():void{
    this.sliderService.getCurrentSliders().subscribe(SliderResault => {
      if(SliderResault.length === 0){
        this.sliderService.GetSliders().subscribe(res=>{
          if(res.status === 'Success'){
            this.sliderService.setCurrentSliders(res.data);
          }
        });
      }else
      {
        this.slider = SliderResault;
        setInterval(()=>{ homeslider();
        },1000);       
      }
      console.log(SliderResault);
    //  $(document).ready(()=>{
    //   console.log("jquery in Ts");
    //  });
    });
  }
}
