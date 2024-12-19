import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'formatoTelefono',
  standalone: true
})
export class FormatoTelefonoPipe implements PipeTransform {

  transform(value: string): string {
    if (!value) return value;
    return value.replace(/^(\+?\d{3})(\d+)/, function(match, p1, p2) {
      let formatted = p2.replace(/(\d{4})(?=\d)/g, '$1 ');
      return p1 + ' ' + formatted;
    });
  }

}
