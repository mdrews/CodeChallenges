const jest = require('jest');

describe('Not Seen', () => {
  it('should return output given input', () => {
    let A1 = `0`;
    let N = `2`;
    output = `0`;
    expect(vanEcks(A1, N).toEqual(output));
  });
});

describe('Seen Before', () => {
  it('should return output given input', () => {
    let A1 = `0`;
    let N = `3`;
    output = `1`;
    expect(vanEcks(A1, N).toEqual(output));
  });
});
