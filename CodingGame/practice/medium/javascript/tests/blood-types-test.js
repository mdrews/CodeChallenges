// test cases for blood-types
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

describe('Parents blood types', () => {
  test('it should return defined output given the input', () => {
    const input = `
      31
      ? O- B-
      A+ ? O-
      A- ? B+
      O+ ? A+
      A+ ? O+
      AB+ ? B+
      ? A+ A-
      AB+ ? B-
      ? AB+ AB-
      ? AB+ AB+
      O+ ? AB+
      AB- ? B+
      ? AB+ B-
      AB- ? A-
      ? O+ O-
      ? AB+ B+
      ? A+ B+
      ? O- A+
      B- ? AB+
      ? O- A-
      O+ ? A-
      B- ? AB-
      A- ? A-
      ? O- AB+
      ? B+ O+
      AB+ ? A-
      ? A+ B-
      ? B+ O-
      AB- ? B-
      B- ? O-
      ? AB+ A-`;
const output = `
      AB+ AB- B+ B-
      A+ A- B+ B- O+ O-
      AB+ B+
      A+ A- AB+ AB-
      A+ A- B+ B- O+ O-
      A+ A- AB+ AB- B+ B- O+ O-
      A+ A- AB+ AB- B+ B- O+ O-
      A+ A- AB+ AB- B+ B- O+ O-
      A+ A- AB+ AB- B+ B-
      A+ A- AB+ AB- B+ B-
      impossible
      A+ AB+ B+ O+
      A+ A- AB+ AB- B+ B- O+ O-
      A+ A- AB+ AB- B+ B- O+ O-
      A+ A- B+ B- O+ O-
      A+ A- AB+ AB- B+ B- O+ O-
      AB+ AB- B+ B-
      A+ AB+
      A+ AB+
      A+ A- AB+ AB-
      A+ A- AB+ AB-
      A+ A- AB+ AB-
      A+ A- AB+ AB- B+ B- O+ O-
      impossible
      A+ A- B+ B- O+ O-
      A+ A- AB+ AB- B+ B- O+ O-
      AB+ AB- B+ B-
      A+ A- B+ B- O+ O-
      A+ A- AB+ AB- B+ B- O+ O-
      A+ A- B+ B- O+ O-
      A+ A- AB+ AB- B+ B- O+ O-`;
      expect(bloodTypes(input).toEqual(output));
  });
});

describe('All combins', () => {
  test('it should return defined output given the input', () => {
    const input = `50
      ? AB- B-
      AB- O+ ?
      O- ? B-
      B- A+ ?
      B- ? B+
      O- ? B+
      O- A+ ?
      ? O+ A-
      AB- ? O+
      B- ? B-
      ? B+ AB-
      ? B+ AB+
      ? O- O+
      A+ O+ ?
      ? O- O-
      O+ AB- ?
      ? A- A+
      ? A- A-
      B+ AB- ?
      A+ AB- ?
      ? A+ O-
      ? B+ B-
      ? A+ O+
      ? A+ AB+
      O- B+ ?
      ? A+ AB-
      A- A- ?
      ? AB+ O+
      O+ B+ ?
      ? O+ AB-
      O- AB+ ?
      ? B+ B+
      ? AB+ O-
      AB+ A- ?
      ? O+ AB+
      ? AB- A+
      AB- A- ?
      ? A- AB+
      AB+ AB- ?
      A+ ? B+
      A+ ? B-
      B+ ? A+
      ? B+ A+
      AB+ ? O+
      ? B+ A-
      A- B+ ?
      B- O+ ?
      B+ B- ?
      AB+ ? O-
      B+ ? A-`;
const output = `A+ A- AB+ AB- B+ B- O+ O-
    A+ A- B+ B-
    AB+ AB- B+ B-
    A+ A- AB+ AB- B+ B- O+ O-
    A+ AB+ B+ O+
    AB+ B+
    A+ A- O+ O-
    A+ A- AB+ AB-
    impossible
    A+ A- AB+ AB- B+ B- O+ O-
    A+ A- AB+ AB-
    A+ A- AB+ AB-
    A+ B+ O+
    A+ A- O+ O-
    A+ A- B+ B- O+ O-
    A+ A- B+ B-
    A+ AB+ B+ O+
    A+ A- AB+ AB- B+ B- O+ O-
    A+ A- AB+ AB- B+ B-
    A+ A- AB+ AB- B+ B-
    A+ A- B+ B- O+ O-
    A+ A- AB+ AB- B+ B- O+ O-
    A+ A- B+ B- O+ O-
    AB+ AB- B+ B-
    B+ B- O+ O-
    AB+ AB- B+ B-
    A- O-
    impossible
    B+ B- O+ O-
    impossible
    A+ A- B+ B-
    A+ A- AB+ AB- B+ B- O+ O-
    impossible
    A+ A- AB+ AB- B+ B-
    impossible
    A+ AB+ B+ O+
    A- AB- B-
    AB+ B+
    A+ A- AB+ AB- B+ B-
    AB+ AB- B+ B-
    AB+ AB- B+ B-
    A+ A- AB+ AB-
    A+ A- AB+ AB-
    impossible
    A+ A- AB+ AB-
    A+ A- AB+ AB- B+ B- O+ O-
    B+ B- O+ O-
    B+ B- O+ O-
    impossible
    A+ A- AB+ AB-`;
      expect(bloodTypes(input).toEqual(output));
  });
});