#r @"..\packages\FSharp.Compiler.Service\lib\net45\FSharp.Compiler.Service.dll"
#r @"..\packages\QuotationCompiler\lib\net45\QuotationCompiler.dll"

open QuotationCompiler

QuotationCompiler.Eval <@ 1 + 1 @>

let a = QuotationCompiler.ToDynamicAssembly <@ fun x -> x + 1 @>

a.c