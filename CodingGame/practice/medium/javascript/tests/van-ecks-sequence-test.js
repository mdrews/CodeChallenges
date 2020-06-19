const jest = require('jest');

describe('Not Seen', () => {
  it('should return output given input', () => {
    input = `
    0
    2`;
    output = `0`;
    expect(vanEcks(input).toEqual(output));
  });
});

describe('Seen Before', () => {
  it('should return output given input', () => {
    input = `
    0
    3`;
    output = `1`;
    expect(vanEcks(input).toEqual(output));
  });
});