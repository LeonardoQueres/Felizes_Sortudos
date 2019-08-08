import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import { map } from 'rxjs/operators';
import { IFelizesSortudos } from '../Models/felizesSortudos.interface';
@Injectable()

export class EFelizService {
  constructor(private http: Http) { }

  VerificarEFeliz(felizesSortudos: IFelizesSortudos) {
    return this.http.post("api/EFeliz", felizesSortudos )
      .pipe(map(res => res));
  }
}
