// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
// What is the 10001st prime number?

let isPrime n = 
    match n with
    | 0L -> false | 1L -> false | 2L -> true
    | n -> seq{for d=3L to int64(round(sqrt(double(n)))) do yield d}
        |> Seq.forall(fun d -> n % d <> 0L) 

let rec nextPrime (n: int64) = 
    if n = 2L then 3L 
    else
        let p = n + 2L
        if isPrime p then p
        else nextPrime p

let primes = 2L |> Seq.unfold(fun n -> Some(n, nextPrime n))

primes
|> Seq.skip 10000
|> Seq.take 1
|> Seq.iter (fun x -> x |> printfn "%A")