# study-fsharp
fsharp speci course at ELTE IK

https://www.youtube.com/watch?v=c7eNDJN758U

https://www.youtube.com/watch?v=2XQ5agOzSBo
https://www.youtube.com/watch?v=2t9hscg-HCo


course, nem az idei: http://people.inf.elte.hu/gaiuaai/fsharp-2015-2016-2/

a helyes itt található: http://people.inf.elte.hu/jooseppi/fsharp/

beadandó 1.:   
Írjunk egy olyan függvényt, ami a Collatz szekvenciát számolja ki végtelenségig. A függvény paramétere legyen a kezdő szám. Outputja pedig legyen a számból kiinduló szekvencia. Ha elértük az 1-et, akkor termináljon a szekvencia. Például 5-re az alábbit állítsa elő: [5, 16, 8, 4, 2, 1]. Hint : Órai fibonacci példa  
https://en.wikipedia.org/wiki/Collatz_conjecture  






1.-2.gyak jegyzetek:  
-----------------------
MS build, fsharp, dot net -- ms code  
visual: ionide fsharp  

immutabilitas  

list arr seq  

val cubic : seq<int>    
/típus olyan seq amiben intek vannak, generikus param:seq<'T>)  
val cubicCalc : int ->int  
val seq.intInfinitite: (int-> T')-> seq<'T>  

fsharp script  
ALT+ENT interactive  

option<T>  
None és some ág különböző értékekkel térhet vissza.  
patternmatch  

mutable( ne használjunk)  

|>    
add4 5=> (add 4)5 =add 4 5  
partiális függvény alkalmazás:  
((4param a)b)c)d  
ua mint: (4paramab)cd   

let sum=  
  6  
  |>add 5  
  |>add 4  

let sum= add4(add 5 6)  
let list=["ALMA";"PEARS"]  

-forward pipeolás:  

list.map: ('T->'U)->'T list ->'U list  

let result=  
  List.map(fun (str:string) -> str.length) list  
let maprestult=  
  list  
  |>List.map(fun str->str.length)          -> azért mert egyébként nem tudná hogy string csak a list-ből tudja.  
let mapresshort=  
  List.map String.length list  
//List.map (fun str->String.length str) list  

ajánlott:  
project euler  
hackerrank  

[F#] taggel e-mailben a beadandók.  

List.iter  

List.fold()  
let aalist=[1;2;3;4]  
let aaasum= List.sum aalist  
let aasum'=  
  aalist  
  |>List.fold( fun s t -> s+t)  
  
       list     s               i  
 [1;2;3;4]      0                  -1  
 
  [ 2;3;4]     0+1                  0  
  
  [3;4]        (0+1)+2              1  
  4           ((0+1)+2 )+3          2  
  []          ( ((0+1)+2 )+3)+4     3  
    
                  10  
                    
  seq.unfold  -> ahogy a fib fv.  
    
  head , tail fv listákon  
  tryhead -> optionnal tér vissza  
  
 
  

