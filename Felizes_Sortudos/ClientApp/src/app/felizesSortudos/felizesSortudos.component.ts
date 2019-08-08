import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { IFelizesSortudos } from '../Models/felizesSortudos.interface';
import { EFelizService } from '../Services/EFeliz.service';
import { ESortudoService } from '../Services/ESortudo.service';

@Component({
  selector: 'app-felizesSortudos',
  templateUrl: './felizesSortudos.component.html',
})
export class felizesSortudosComponent implements OnInit {
  form: FormGroup;
  felizesSortudos: IFelizesSortudos = <IFelizesSortudos>{};
  retornoEFeliz: string;
  retornoESortudo: string;

  constructor(private EFelizService: EFelizService, private ESortudoService: ESortudoService,  private fb: FormBuilder) {
    this.form = fb.group({
      "Numero": ["", Validators.required]
    });
  };


  onSubmit() {
    this.felizesSortudos.Numero = this.form.controls["Numero"].value;   

    this.EFelizService.VerificarEFeliz(this.felizesSortudos)
      .subscribe(data => this.retornoEFeliz = data.text(),
        error => console.log(error),
        () => console.log(this.retornoEFeliz));    

    this.ESortudoService.PostSortudos(this.felizesSortudos)
      .subscribe(data => this.retornoESortudo = data.text(),
        error => console.log(error),
        () => console.log(this.retornoESortudo));

  };

  ngOnInit() {
  }

  numberOnly(event): boolean {
    const charCode = (event.which) ? event.which : event.keyCode;
    if (charCode > 31 && (charCode < 48 || charCode > 57)) {
      return false;
    }
    return true;

  }
}

