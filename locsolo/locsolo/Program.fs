open System

let locsol() =
    printfn"Kata kannája 2.5 liter 50 tövetlocsol meg vele. 1 tőre 1.5 liter vizet önt."
    let toszam =50.0
    let kannatérfogat= 2.5
    let toszomja= 1.5
    let fordulat =(int)((toszam*toszomja)/kannatérfogat)
    printfn " %i -szor megy a kútra." fordulat

locsol()
Console.ReadKey() |> ignore
