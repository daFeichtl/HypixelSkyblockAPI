import { Component } from '@angular/core';
import {ActivatedRoute, Router} from "@angular/router";
import {HypixelService} from "../backend";
import {isEmpty} from "rxjs";

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent {


  constructor(private router: Router,
              private hypixelService: HypixelService) {

  }

  apiKey = "";

  onLogin() {
    if (this.keyIsValid())
    this.router.navigateByUrl(`/skypixl/${this.apiKey}`)
  }
  keyIsValid(): boolean{
    if (isEmpty())
      this.hypixelService.hypixelApiKeyCheckGet(this.apiKey).subscribe((x: boolean) => {
        return x;
      })
    return false;
  }
}
