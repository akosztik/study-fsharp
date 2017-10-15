namespace Library1

module Result =
    
    let res = Signature.stringLength

    type C() =
        let x (t: int) = t * 2
        member private this.Rep = "qwe"
        member this.Example = "asd"


    let cval = C()

    type Counter() =
        let mutable count = 0
        let inc () =
            count <- count + 1
        let reset () =
            count <- 0

        member this.Get() = count
        member this.Increment() = inc ()
        member this.Reset() = reset ()

    let TestCounter () =
        let error () = printfn "Error in counter"
        let c = Counter()
        if c.Get() = 0 then
            c.Increment()
            if c.Get() = 1 then
                [1..5] |> List.iter (fun _ -> c.Increment())
                if c.Get() = 6 then
                    printfn "OK"
                else
                    error ()
            else
                error ()
        else
            error ()
        
    let TestCounterPar () =
        let error () = printfn "Error in counter"
        let c = Counter()
        if c.Get() = 0 then
            c.Increment()
            if c.Get() = 1 then
                [|1..1000|] |> Array.Parallel.iter (fun _ -> c.Increment())
                if c.Get() = 1001 then
                    printfn "OK"
                else
                    error ()
            else
                error ()
        else
            error ()

    let fact (n: int) =
        [2..n] |> List.fold (fun s t -> s * t) 1

    let rec factrec (n: int) =
        if n > 1 then
            n * factrec (n-1)
        else
            1

    let opt = Some 5

    let optn = None

    let OptConverter (o: int option) = // Option<int> == int option
        let value =
            //match o with
            //| None -> 0
            //| Some o -> o
            //defaultArg o 0
            o
            |> Option.defaultValue 0
        value