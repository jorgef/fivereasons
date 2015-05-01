let ``add two numbers`` a b = a + b

let (><<*>) = ``add two numbers``

2 ><<*> 3

let myTuple = (23, "aaa")

let number, message = myTuple

let success, integer = System.Int32.TryParse "42"

type Product = { Name: string; Stock: int }
type Customer = { Name: string; Age: int }

let customer = { Name= "John"; Age = 2 }
let product = { Name= "Car"; Stock = 2 }

let inline printName (obj: 'a) =
    let name = (^a: (member get_Name: unit -> string) obj)
    printfn "%s" name

printName product


let myDisposable = { new System.IDisposable with 
                        member this.Dispose () = printfn "Dispose called" }

myDisposable.Dispose()


let myDisposable2 = { new System.IDisposable with
                        member this.Dispose () = printfn "Disposed" }

myDisposable2.Dispose ()



type Result =
    | Success of quotient: int * remainder : int
    | Error of System.Exception

let (|NoRemainder|_|) = function 
    | Success(q, 0) -> Some q
    | _ -> None

let displayResult result =
    match result with
    | NoRemainder q -> printfn "%i" q
    | Success (q, r) -> printfn "%i %i" q r
    | Error e -> printfn "%s" e.Message

displayResult (Success(2, 0))


#r @"..\packages\FSharp.Data.2.2.0\lib\net40\FSharp.Data.dll"

open FSharp.Data

type Account = JsonProvider<"Data.json">
let accounts = Account.Load "Data.json"

accounts 
|> Seq.iter (fun a -> printfn "%s" a.Customer.FirstName)