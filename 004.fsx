// A palindromic number reads the same both ways. The largest palindrome made from
// the product of two 2-digit numbers is 9009 = 91 * 99.
// Find the largest palindrome made from the product of two 3-digit numbers.
open System

let (<=>) a b = seq{for x in a do for y in b do yield x * y}

let reverse (x:int) = 
    let rec loop x acc = 
        let next = acc * 10 + x % 10
        if x = 0 then
            acc
        else loop (x / 10) next
    loop x 0
let isPalindromic x = x = reverse x

[1..999] <=> [1..999]
|> Seq.filter isPalindromic        
|> Seq.max
|> Console.WriteLine