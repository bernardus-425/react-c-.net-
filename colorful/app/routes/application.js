import Route from '@ember/routing/route';
import { inject as service } from '@ember/service';

export default class ApplicationRoute extends Route {
  @service store;

  model() {
    // Retrieve the user's account on route load
    return this.store.findRecord('account', 1);
  }
}
