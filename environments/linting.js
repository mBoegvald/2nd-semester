// module.exports = function calculateProduct(a, b, c) {
//   return a * b * c;
// };
module.exports = function (a, b, c) {
  // convert arguments object to an array
  let args = Array.prototype.slice.call(arguments);
  console.log(args.length);

  //   if (args.length !== 3) {
  //     throw new TypeError("Needs 3 arguments");
  //   }

  //   //   error if non-finite numbers

  //   if (!args.every(Number.isFinite)) {
  //     throw new TypeError("function only takes numbers");
  //   }

  return args.reduce(function (a, b) {
    return a * b;
  });
};
