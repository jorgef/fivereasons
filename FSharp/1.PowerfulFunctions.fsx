// Functions

let add x y = x + y
let result = add 1 2 // result = 3


// Partial Application

let addOne = add 1
let result' = addOne 2 // result' = 3


// Pipelining

let result'' = 2 |> addOne  // result'' = 3


// Composition

let addTwo = add 2
let addThree = addOne >> addTwo
let result''' = addThree 1 // result''' = 4


// Unit tests: check out file 1a.Tests.fs