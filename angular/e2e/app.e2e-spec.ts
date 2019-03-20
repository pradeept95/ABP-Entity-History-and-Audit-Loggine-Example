import { AuditDemoTemplatePage } from './app.po';

describe('AuditDemo App', function() {
  let page: AuditDemoTemplatePage;

  beforeEach(() => {
    page = new AuditDemoTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
