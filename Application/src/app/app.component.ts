import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

    values: string[] = [];

    constructor(private http:Http){}

    ngOnInit(){
        this.http.get('/api/values').subscribe(values => {
            this.values = values.json() as string[];
        })
    }
}
