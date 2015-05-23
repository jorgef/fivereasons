// Classes

type Customer' (name: string) =
    member this.Name = name
let customer' = Customer'("John")


// Records

type Customer = { Name: string }
let customer = { Name = "John" }


// Tuples

let getNameAndAge id = ("John", 42)

let name, age = getNameAndAge 3
let success, value = System.Int32.TryParse "42"


// Options

let getCustomerAgeById (id: int) : int =
    if id < 0 then 0 
    else 42

let getCustomerAgeById' (id: int) : int option =
    if id < 0 then None 
    else Some 42

let getCustomerById (id: int) : Customer =
    if id < 0 then { Name = "Unknown" } // No possible to return null or None
    else { Name = "John" }

let getCustomerById' (id: int) : Customer option =
    if id < 0 then None 
    else Some { Name = "John" }


// Units of measure

[<Measure>] type m
[<Measure>] type km

let meters = 200<m>
let kilometers = 30<km>
//let total = meters + kilometers  // Error


// Object expressions

type IProduct = 
    abstract member Name: string
    abstract member Show: unit -> unit

let myProduct = { new IProduct with 
                  member this.Name = "Product1"
                  member this.Show () = printfn "%s" this.Name }

myProduct.Name
myProduct.Show ()