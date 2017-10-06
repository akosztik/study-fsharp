// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

[<EntryPoint>]
let main argv = 
    printfn "%A" argv

    let collatz n =
        Seq.unfold (fun i -> 
        if i % 2 = 0 then Some(i, i / 2) else Some(i, 3 * i + 1)) n
        

    let aCollatzSeq = collatz 6 |> Seq.takeWhile (fun n -> n <> 1) 
    printfn "%A" (Seq.toList aCollatzSeq)
   

    0 // return an integer exit code