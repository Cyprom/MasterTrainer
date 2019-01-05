import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from "@angular/router";

@Component({
    selector: 'app-navigation',
    templateUrl: './navigation.component.html'
})
export class NavigationComponent implements OnInit {

    constructor(
        private activatedRoute: ActivatedRoute,
    ) {
        this.activatedRoute.params.subscribe(() => { });
    }

    public ngOnInit = () => { }
}