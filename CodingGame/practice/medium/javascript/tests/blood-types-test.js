const bloodTypes = require('../blood-types');

describe('Example', () => {
  test("it should return output given input", () => {
    const input = `
      4
      A- O+ ?
      A- ? A+
      ? O+ A+
      AB- ? O-`;
    const output = `
      A+ A- O+ O-
      A+ AB+ B+ O+
      A+ A- AB+ AB-
      impossible`;
    expect(bloodTypes(input)).toEqual(output);
  });
});
