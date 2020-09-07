let calculateProduct = require("../linting.js");
var expect = require("chai").expect;
describe("Calculate Product function", function () {
  context("with arguments", function () {
    it("should return product of arguments", function () {
      expect(calculateProduct(5, 5, 10)).to.equal(250);
    });
  });
});
