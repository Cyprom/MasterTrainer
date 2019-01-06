import { Component, OnInit } from '@angular/core';

@Component({
    selector: 'app-dashboard',
    templateUrl: './dashboard.component.html',
    styles: [':host { width: 100%; }']
})
export class DashboardComponent implements OnInit {

    constructor() { }

    public ngOnInit = () => { }
}