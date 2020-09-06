let calculateProduct = require("../linting.js");
var expect = require("chai").expect;
describe("Calculate Product function", function () {
  context("with arguments", function () {
    it("should return product of arguments", function () {
      expect(calculateProduct(1, 2, 3)).to.equal(6);
    });
  });
});
