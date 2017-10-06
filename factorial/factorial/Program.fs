// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

[<EntryPoint>]
let main argv = 
    printfn "%A" argv

    let fact n =
        [1..n]
        |>Seq.fold(fun i t -> i*t) 1
            

    let factSeq= fact 3
    printfn "%A" factSeq
    0 // return an integer exit code
