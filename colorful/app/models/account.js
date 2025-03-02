import { attr } from '@ember-data/model';
import Model from '@ember-data/model';

// Encapsulates a user's account
export default class AccountModel extends Model {
  @attr('string') color;
}
