import { createServer } from 'miragejs';
import { discoverEmberDataModels } from 'ember-cli-mirage';

export default function makeServer(config) {
  return createServer({
    ...config,
    models: { ...discoverEmberDataModels(), ...config.models },
    routes,
  });
}

function routes() {
  this.get('/accounts/1', () => ({
    account: {
      id: 1,
      color: 'BADA55',
    },
  }));

  this.patch(
    '/accounts/1',
    (schema, request) => {
      let requestBody = JSON.parse(request.requestBody);
      console.log(
        `${new Date().toISOString()} Server received request to update account's color to: ${
          requestBody.account.color
        }. Processing for two seconds...`
      );
      return {
        account: {
          id: 1,
          color: requestBody.account.color,
        },
      };
    },
    { timing: 2000 }
  );
}
