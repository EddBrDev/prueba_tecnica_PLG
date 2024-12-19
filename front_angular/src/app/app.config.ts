import { ApplicationConfig } from '@angular/core';
import { provideRouter } from '@angular/router';
import { HttpClientModule, provideHttpClient } from '@angular/common/http';
import { FormatoTelefonoPipe } from './pipes/formato-telefono.pipe';

import { routes } from './app.routes';

export const appConfig: ApplicationConfig = {
  providers: [provideRouter(routes),
    HttpClientModule,
    FormatoTelefonoPipe,
    provideHttpClient()
  ],
};
