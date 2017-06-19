import { LootListManagerPage } from './app.po';

describe('loot-list-manager App', () => {
  let page: LootListManagerPage;

  beforeEach(() => {
    page = new LootListManagerPage();
  });

  it('should display welcome message', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('Welcome to app!!');
  });
});
