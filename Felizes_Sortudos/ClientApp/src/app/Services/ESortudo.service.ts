import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import { map } from 'rxjs/operators';
import { IFelizesSortudos } from '../Models/felizesSortudos.interface';
@Injectable()

export class ESortudoService {
  constructor(private http: Http) { }

  PostSortudos(felizesSortudos: IFelizesSortudos) {
    return this.http.post("api/ESortudo", felizesSortudos)
      .pipe(map(res => res));
  }
}
