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

describe('Child Blood Types', () => {
  test('it should return output given input', () => {
    const input = `
      12
      AB+ B- ?
      A+ O- ?
      O+ AB+ ?
      A- A+ ?
      O+ B- ?
      O- AB- ?
      AB- A+ ?
      AB+ AB+ ?
      A+ A- ?
      A- B- ?
      B- O- ?
      O- O+ ?`;
    const output = `
      A+ A- AB+ AB- B+ B-
      A+ A- O+ O-
      A+ A- B+ B-
      A+ A- O+ O-
      B+ B- O+ O-
      A- B-
      A+ A- AB+ AB- B+ B-
      A+ A- AB+ AB- B+ B-
      A+ A- O+ O-
      A- AB- B- O-
      B- O-
      O+ O-`;
      expect(bloodTypes(input)).toEqual(output);
  });
});