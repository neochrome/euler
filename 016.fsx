// 2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
// What is the sum of the digits of the number 2^1000?
open System

2I**1000
|> Seq.unfold (fun n -> if n > 0I then Some(n % 10I, n / 10I) else None)
|> Seq.reduce (+) 
|> Console.WriteLine
