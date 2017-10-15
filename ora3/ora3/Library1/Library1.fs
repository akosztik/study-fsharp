namespace Library1

type Class() =
    member this.A = ""


module private First =
    
    let x = 5

module Second =
    
    let a = First.x + 5

    let internal itern () = 6

    let private priv () = 7

    let t = priv () + 5
