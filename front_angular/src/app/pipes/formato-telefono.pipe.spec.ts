import { FormatoTelefonoPipe } from './formato-telefono.pipe';

describe('FormatoTelefonoPipe', () => {
  let pipe: FormatoTelefonoPipe;

  beforeEach(() => {
    pipe = new FormatoTelefonoPipe();
  });
  it('crear una instancia', () => {
    const pipe = new FormatoTelefonoPipe();
    expect(pipe).toBeTruthy();
  });

  it('debería formatear los números de teléfono correctamente', () => {
    const numeroOriginal = '+596123412345678';
    const numeroFormateado = pipe.transform(numeroOriginal);
    expect(numeroFormateado).toBe('+596 1234 1234 5678');
  });

  it('debería devolver el mismo valor para cadenas vacías', () => {
    const numeroOriginal = '';
    const numeroFormateado = pipe.transform(numeroOriginal);
    expect(numeroFormateado).toBe('');
  });

  it('debería devolver el mismo valor si la entrada no es un número de teléfono válido', () => {
    const numeroOriginal = 'abcd1234';
    const numeroFormateado = pipe.transform(numeroOriginal);
    expect(numeroFormateado).toBe('abcd1234'); // no hay números para formatear
  });

});
