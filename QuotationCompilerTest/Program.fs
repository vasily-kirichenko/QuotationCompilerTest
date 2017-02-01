open QuotationCompiler

[<EntryPoint>]
let main _ = 
    let plus = QuotationCompiler.Eval <@ 1 + 1 @>
    

    0