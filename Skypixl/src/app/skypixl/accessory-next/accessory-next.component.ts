import {Component, OnInit} from '@angular/core';
import {ActivatedRoute} from "@angular/router";

@Component({
  selector: 'app-accessory-next',
  templateUrl: './accessory-next.component.html',
  styleUrls: ['./accessory-next.component.scss']
})
export class AccessoryNextComponent implements OnInit{

  private apiKey: string = "";
  constructor(private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.activatedRoute.paramMap.subscribe(x => {
      if (x.has("apiKey"))
        this.apiKey = x.get("apiKey")!
    })

  }
}
