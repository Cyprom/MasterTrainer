import { Component, OnInit } from '@angular/core';

@Component({
    selector: 'app-home',
    templateUrl: './home.component.html',
    styles: [':host { width: 100%; }']
})
export class HomeComponent implements OnInit {

    constructor() { }

    public ngOnInit = () => { }
}