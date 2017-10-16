
// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

[<EntryPoint>]
let main argv = 
    printfn "%A" argv

    let rec collatz = function
        | 1 -> [1]
        | 0 -> [0]
        | n when n%2=0 -> n::collatz (n/2) 
        | n when n%2=1 -> n::collatz (3*n+1) 

    let collatzS = collatz 6
         
    printfn "%A" (Seq.toList collatzS)
   

    0 // return an integer exit code