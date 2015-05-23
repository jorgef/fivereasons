// Pattern Matching

type Result =
    | Success
    | Error

let show result =
    match result with
    | Success -> printfn ":)"
    | Error -> printfn ":("

show Success // :)
show Error   // :(


type DivisionResult' =
    | Success of int
    | Error of string

let show' result =
    match result with
    | Success r -> printfn ":) %i" r
    | Error m -> printfn ":( %s" m 

show' (Success 2)             // :) 2
show' (Error "Error message") // :( Error message


type DivisionResult'' =
    | Success of quotient: int * remainder: int
    | Error of System.Exception

let show'' result =
    match result with
    | Success (q,r) -> printfn "%i %i" q r
    | Error m -> printfn "Error: %s" m.Message

show'' (Success (quotient=2, remainder=0)) // 2 0
show'' (Error (System.Exception("Error"))) // Error


let show''' result =
    match result with
    | Success (q,0) when q > 1 -> printfn "%i pieces" q
    | Success (q,r) -> printfn "%i %i" q r
    | Error m -> printfn "Error: %s" m.Message

show''' (Success (quotient=2, remainder=0)) // 2 pieces
show''' (Success (quotient=2, remainder=1)) // 2 1
show''' (Error (System.Exception("Error"))) // Error


let (|Pieces|_|) result = 
    match result with
    | Success (q,0) when q > 1 -> Some q
    | _ -> None

let show'''' result =
    match result with
    | Pieces q -> printfn "%i pieces" q
    | Success (q,r) -> printfn "%i %i" q r
    | Error m -> printfn "Error: %s" m.Message

show'''' (Success (quotient=2, remainder=0)) // 2 pieces
show'''' (Success (quotient=2, remainder=1)) // 2 1
show'''' (Error (System.Exception("Error")))  // Error