import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44308/',
  redirectUri: baseUrl,
  clientId: 'Loyalty_App',
  responseType: 'code',
  scope: 'offline_access Loyalty',
  requireHttps: true,
};

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'Loyalty',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44308',
      rootNamespace: 'Loyalty',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
  remoteEnv: {
    url: '/getEnvConfig',
    mergeStrategy: 'deepmerge'
  }
} as Environment;
