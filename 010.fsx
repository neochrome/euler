// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
// Find the sum of all the primes below two million.
open System

let isPrime n = match n with
                 | 0L -> false
                 | 1L -> false
                 | 2L -> true
                 | n -> seq{for d=3L to int64(round(sqrt(double(n)))) do yield d}
                        |> Seq.forall(fun d -> n % d = 0L = false) 

isPrime 10L
|> Console.WriteLine

