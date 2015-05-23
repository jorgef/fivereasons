let isEven number = number % 2 = 0

let x = isEven 1
let y = isEven 2
x && y

type LogBuilder() =
    member this.Bind (value, continuation) =
        printfn "Value: %b" value
        continuation value
    member this.Return value = 
        printfn "Result: %b" value
        value

let log = LogBuilder()

log { let! x = isEven 1
      let! y = isEven 2
      return x && y }


open System.IO

let read (file: string) = 
    use reader = new StreamReader(file)
    let content = reader.ReadToEnd ()
    content |> printfn "Content: %s"

#r @"..\packages\FSharpx.Async.1.12.0\lib\net40\FSharpx.Async.dll"

open FSharpx.Control

let readAsync (file: string) = async {
    use reader = new StreamReader(file)
    let! content = reader.AsyncReadToEnd ()
    content |> printfn "Content: %s" }
