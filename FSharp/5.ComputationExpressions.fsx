#r @"..\packages\FSharpx.Async.1.12.0\lib\net40\FSharpx.Async.dll"

open System.IO
open FSharpx.Control


let readAsync (file: string) = async {
    use reader = new StreamReader(file)
    let! content = reader.AsyncReadToEnd ()
    content |> printfn "Content: %s" }

let readAsync' (file: string) = async {
    let! content = async { use reader = new StreamReader(file) 
                           return! reader.AsyncReadToEnd () }
    content |> printfn "Content: %s" }

readAsync "C:\Users\Jorge\SkyDrive\Presentations\FiveReasons\FSharp\Data.csv"
|> Async.RunSynchronously


let sequence = seq { 
    yield 1
    yield 2
    yield 3 }

sequence
|> Seq.iter (fun i -> i |> printfn "%i")

let list = [1;2]
let sequence' = seq { 
    yield 1
    yield! list }

type LogBuilder() =
    member this.Bind (value, continuation) =
        printfn "Value: %b" value
        continuation value
    member this.Return value = 
        printfn "Result: %b" value
        value

let log = LogBuilder()

let isEven number = number % 2 = 0

log { let! x = isEven 1
      let! y = isEven 2
      return x && y }
