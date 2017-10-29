import { Injectable } from '@angular/core';
import { Event } from '../models/event';

import { Http } from '@angular/http';
import { ExtractData, HandleError } from './service-helper';
import 'rxjs/add/operator/toPromise';
import { Headers, RequestOptions } from '@angular/http';

@Injectable()
export class EventService{

    private eventUrl = 'api/events';

    constructor(private http: Http){}

    get(): Promise<Event[]>{

        return this.http.get(this.eventUrl)
        .toPromise()
        .then(ExtractData)
        .catch(HandleError);
    }

    insert(event: Event): Promise<Event>{
        let headers = new Headers({'Content-Type': 'application/json'});
        let options = new RequestOptions({headers: headers});
        return this.http.post(this.eventUrl, JSON.stringify(event), options)
        .toPromise()
        .then(ExtractData)
        .catch(HandleError);
    }

    update(event: Event): Promise<void>{
        return this.http.put('${this.eventUrl}/${event.id}', JSON.stringify(event))
        .toPromise()
        .then(ExtractData)
        .catch(HandleError);
    }

    remove(id: number): Promise<void>{
        return this.http.delete('${this.eventUrl}/${id}')
        .toPromise()
        .then(ExtractData)
        .catch(HandleError);
    }
}
