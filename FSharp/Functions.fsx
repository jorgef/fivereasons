// Functions

let add a b = a + b

let result = add 1 2


// Partial Application

let addOne = add 1
let addTwo = add 2 


// Pipelining

addOne 3
3 |> addOne

3
|> addOne
|> addTwo


// Composition

let addThree = addOne >> addTwo

4 |> addThree


// Function names with spaces and nested functions

let ``execute provided operation`` a b op =
    let printMsg a b = 
        printfn "args: %i %i" a b 
    printMsg a b
    op a b


// Operators as functions

``execute provided operation`` 1 2 add 
``execute provided operation`` 1 2 (*) 


// Operator overloading

let (!+) = addOne

!+ 3

let (><<*>) = add

3 ><<*> 3