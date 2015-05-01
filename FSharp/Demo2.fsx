let ``add two numbers`` a b = a + b

let (><<*>) = ``add two numbers``

3 ><<*> 3


type Customer = { Name: string; Age: int }
type Product = { Name: string; Stock: int }
let customer = { Name = "John"; Age = 42 }
let product = { Name = "Car"; Stock = 3 }

let myTuple = (1, "message")
let number, message = myTuple

let success, number2 = System.Int32.TryParse "42"

let inline printName (namedObject: 'a) =
    let name = (^a: (member get_Name: unit -> string) namedObject)
    printfn "%s" name

printName customer
printName product

let myDisposable = { new System.IDisposable with
                        member this.Dispose () = printfn "Disposed" }

myDisposable.Dispose ()
