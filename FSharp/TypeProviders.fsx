#r @"..\packages\FSharp.Data.2.2.0\lib\net40\FSharp.Data.dll"

type Account = FSharp.Data.JsonProvider<"Sample.json">
let results = Account.Load @"Data.json"

results 
|> Seq.map (fun r -> r.Customer.FirstName)
|> Seq.toList


type Customer = FSharp.Data.CsvProvider<"Data.csv">
let customers = Customer.Load "Data.csv"

customers.Rows
|> Seq.map (fun c -> c.Name)
|> Seq.toList



// http://blogs.msdn.com/b/dsyme/archive/2013/01/30/twelve-type-providers-in-pictures.aspx
