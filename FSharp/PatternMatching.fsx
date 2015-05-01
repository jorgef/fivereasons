// Pattern Matching

let processResult result =
    match result with
    | "Success" -> printfn "Success"
    | "Error" -> printfn "Error"
    | r -> printfn "Invalid: %s" r

type DivisionResult' =
    | Success
    | Error

let processResult' result =
    match result with
    | Success -> printfn "Success"
    | Error -> printfn "Error"

type DivisionResult'' =
    | Success of quotient: int * remainder: int
    | Error of string

let processResult'' result =
    match result with
    | Success (2, 0) -> printfn "Success - Exact half"
    | Success (q, 0) -> printfn "Success - No remainder: %i" q
    | Success (q, r) -> printfn "Success: %i %i" q r
    | Error m -> printfn "Error: %s" m 

let evalOption result =
    match result with
    | Some(i) -> printfn "%i" i
    | None -> printfn "No results"

let processResult''' result =
    match result with
    | (2, 0) -> printfn "Exact half"
    | (q, 0) -> printfn "No remainder: %i" q
    | (q, r) -> printfn "%i %i" q r

processResult''' (3, 2)


// Active Patterns

let (|ExactHalf|_|) (q, r) = if q = 2 && r = 0 then Some q else None

let processResult'''' result =
    match result with
    | ExactHalf q -> printfn "Exact half"
    | (q, 0) -> printfn "No remainder: %i" q
    | (q, r) -> printfn "%i %i" q r

let r = processResult'''' (2, 0)