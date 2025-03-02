import { htmlSafe } from '@ember/template';
import Component from '@glimmer/component';
import { task } from 'ember-concurrency';

// todo: Refactor this component!
export default class MyProfileComponent extends Component {
  get colorStyle() {
    return htmlSafe(`color:#${this.args.account.color};`);
  }

  inputHandler = task(async () => {
    this.args.account.save();
  });
}
