import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'Book',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44329/',
    redirectUri: baseUrl,
    clientId: 'Book_App',
    responseType: 'code',
    scope: 'offline_access Book',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44329',
      rootNamespace: 'Acme.Book',
    },
  },
} as Environment;
