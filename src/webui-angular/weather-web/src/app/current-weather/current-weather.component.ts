import { Component, OnInit } from '@angular/core';


interface CurrentWeather {
  Timestamp: string;
  Summary: string;
  Location: string;
  Temperature: number;
  Humidity: number;
  Visibility: number;
  UVIndex: number;
}

const initial : CurrentWeather = {
  Timestamp: "07:30 am Saturday, 12 Sep '20",
  Summary: "Sunny",
  Location: "Brisbane",
  Temperature: 28,
  Humidity: 68,
  Visibility: 4,
  UVIndex: 0
};


@Component({
  selector: 'app-current-weather',
  templateUrl: './current-weather.component.html',
  styleUrls: ['./current-weather.component.css']
})
export class CurrentWeatherComponent implements OnInit {

  currentWeather = {
    ...initial,
    UVIndexRating: "Low"
  };

  constructor() { }

  ngOnInit(): void {
  }

}
