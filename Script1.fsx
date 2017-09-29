let x = 5

x = 6

let y = 5.

y = (float x)

// primitive types
let str = "asd"
let b = false
/// This is a character
let c = 'a'

(*
    
*)
// Collection types
// not lazy
let list = ["str"]
let arr = [|"str"|]
// lazy
let seq = Seq.singleton "seq"

let cubicCalc (a: int) = a * a * a
    
let cubic = Seq.initInfinite cubicCalc

let v125 = Seq.item 5 cubic

let cubic2 = Seq.initInfinite (fun (a: int) -> a * a * a)

// option

//type Option<'T> =
//    | None
//    | Some of 'T

let none = None
let somestr = Some "Hello World"

let printOption (input: string option) =
    match input with
    | None ->
        printfn "The value is none"
    | Some str ->
        //System.Console.WriteLine(str)
        // %s - print as string
        // %d - print as int
        printfn "%s" str

let tup = (0, 1)

let first = fst tup
let second = snd tup

let fib : seq<int> =
    Seq.unfold (fun (a, b) ->
        Some (a+b, (b, a+b))
    ) (0, 1)

let fib5th = Seq.item 4 fib

type Fruit =
    | Apple of int
    | Orange of string
    | Peach of bool

let printFruit : Fruit -> unit = function
//    fun f ->
//        match f with
      | Apple seeds -> printfn "This apple has %d seeds" seeds
      | Orange place -> printfn "This orange is from %s" place
      | Peach tasty -> printfn "Ths peach is %s" (if tasty then "true" else "false")

type WPerson =
    {
        FirstName: string
        LastName: string
        Age: int
    }

type Person =
    {
        FirstName: string
        LastName: string
        Age: int
    }

    member this.Print() =
        printfn "%s %s is %d years old" this.FirstName this.LastName this.Age
    
    static member Print(person: Person) =
        printfn "%s %s is %d years old" person.FirstName person.LastName person.Age

let p1 =
    {
        FirstName = "John"
        LastName = "Doe"
        Age = 42
    }

p1.Print()
Person.Print p1

type Person'(fname: string, lname: string, age: int, ?androidUser: bool) =
    member this.FirstName = fname
    member this.Phone = 
        match androidUser with
        | None -> "Not given"
        | Some false -> "Not android"
        | Some true -> "Android"
    static member Default() =
        Person'("Default", "Default", 0, true)

let p1' = Person'("Jane", "Doe", 42)

let defp = Person'.Default()
defp.FirstName

let mutable mut = 0
mut <- 1

let add a b = a + b

add 4 5

let sum =
    6
    |> add 5
    |> add 4

let sum' =
    add 5 6
    |> add 4

let sum'' =
    add 4 (add 5 6)
let add4 = add 4

let mul''''' a b c d e = a * b * c * d * e
let mul5'''' = mul''''' 5
let mul4''' = mul5'''' 4