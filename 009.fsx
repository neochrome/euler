// A Pythagorean triplet is a set of three natural numbers, a  b  c, for which,
// a^2 + b^2 = c^2
// For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.
//
// There exists exactly one Pythagorean triplet for which a + b + c = 1000.
// Find the product abc.

let py (a,b,c) = a*a + b*b = c*c

(3,4,5)
|> Seq.unfold(fun (a,b,c) -> Some((a,b,c), (a*2,b*2,c*2)))
|> Seq.find(fun (a,b,c) -> py (a,b,c) && a + b + c = 1000)
|> printfn "%A"