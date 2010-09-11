// n! means n * (n - 1) * ... * 3 * 2 * 1
// Find the sum of the digits in the number 100!
open System

[1I..100I]
|> Seq.reduce (*)
|> Seq.unfold (fun n -> if n > 0I then Some(n % 10I, n / 10I) else None)
|> Seq.reduce (+)
|> Console.WriteLine

// correct answer: 648