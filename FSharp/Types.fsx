// Record types


type Customer = { Name: string; Age: int }
let customer = { Name = "John"; Age = 42 }


// Tuples

let myTuple = (1, "value")
let v1, v2 = myTuple

let success, value = System.Int32.TryParse("42")


// Option types

let getCustomerById (id: int) : Customer option =
    if id = 0 then None 
    else Some { Name = "John"; Age = 42 }

let customerOption = getCustomerById 0
let age = customerOption.Value.Age


// Discriminated unions

type DivisionResult =
| Sucess of quotient: int * remainder: int
| Error of string


// Units of measure

[<Measure>] type m
[<Measure>] type km
[<Measure>] type h

let meters = 1200<m>
let kilometers = 15<km>
//let total = meters + kilometers  // Error

let meters' = 1500<m>
let total = meters + meters'

let space = meters * meters

let hours = 3<h>
let speed = kilometers / hours

let convertToMeters (kms: int<km>) = kms / 1<km> * 1000<m>
convertToMeters 15<km>


// Object expressions

let myDisposable = { new System.IDisposable with 
                        member this.Dispose () = printfn "Dispose executed" }

myDisposable.Dispose()


// Inline functions

let inline add a b = a + b

add 1.0 2.0
add 1 2

type Product = { Name: string; Stock: int }
let product = { Name = "Toyota"; Stock = 12 }

let inline displayName (obj: 'a) =
    let name = (^a: (member get_Name: unit -> string) obj)
    printfn "Name: %s" name

displayName product
displayName customer