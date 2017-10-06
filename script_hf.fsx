let collatz n =
  Seq.unfold (fun i -> 
    if i % 2 = 0 then Some(i, i / 2) else Some(i, 3 * i + 1)) n
  |> Seq.takeWhile (fun n -> n <> 1) 