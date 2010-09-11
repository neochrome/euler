// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
// What is the smallest number that is evenly divisible by all of the numbers from 1 to 20?
let primes20 = [2L;3L;5L;7L;11L;13L;17L;19L]
let primes n = primes20 |> Seq.takeWhile(fun x -> x <= n) |> Seq.reduce(*)
let mdiv n x = n % x = 0L 
let div n x = [1L..n] |> List.forall(fun y -> x % y = 0L) 

let search n =
    let sw = System.Diagnostics.Stopwatch.StartNew()
    let ps = primes n
    Seq.unfold(fun x -> Some(x, x + 2L )) 2L
    |> Seq.find(fun x -> x * ps |> div n)
    |> fun x -> x * ps
    |> fun x -> printfn "%d: %b" x (div n x)
    printfn "%A" sw.Elapsed

search 10L
search 20L
