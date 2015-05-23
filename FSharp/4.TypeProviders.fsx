#r @"..\packages\FSharp.Data.2.2.0\lib\net40\FSharp.Data.dll"

type Customer = FSharp.Data.CsvProvider<"Data.csv">
let customers = Customer.Load "Data.csv"

customers.Rows
|> Seq.map (fun c -> c.Name)
|> Seq.toList