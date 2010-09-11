// You are given the following information, but you may prefer to do some research for yourself.
//
// 1 Jan 1900 was a Monday.
// Thirty days has September,
// April, June and November.
// All the rest have thirty-one,
// Saving February alone,
// Which has twenty-eight, rain or shine.
// And on leap years, twenty-nine.
// A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.
// How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?

let leap year = 
    if year % 400 = 0 then 1
    elif year % 100 = 0 then 0
    elif year % 4 = 0 then 1
    else 0

let days_per_months year = [31;28 + leap year;31;30;31;30;31;31;30;31;30;31]

(1900, [0])
|> Seq.unfold (fun (year, offsets) -> 
    let new_offsets = List.scanBack(fun acc x -> acc + x) (days_per_months year) offsets.Head 
    Some((year, new_offsets), (year + 1, new_offsets))
    )
|> Seq.skip 1
|> Seq.takeWhile(fun (year,_) -> year <= 2000)
|> Seq.map(fun (year, offsets) -> (year, offsets.Tail |> List.filter(fun x -> x % 7 = 6)))
|> Seq.fold(fun acc (_,offsets) -> acc + offsets.Length) 0
|> printfn "%A"
