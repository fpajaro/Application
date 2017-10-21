import { Injectable } from '@angular/core';
import { Event } from '../models/event';

@Injectable()
export class EventService{

    get():Promise<Event[]>{

        return Promise.resolve([
            {id: 1, start_date: "2017-10-16 00:00", end_date: "2017-10-16 13:00", text: "Event 1"},
            {id: 2, start_date: "2017-10-17 00:00", end_date: "2017-10-17 13:00", text: "Event 2"}
        ]);
    }

}
