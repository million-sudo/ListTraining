let list1 = [ 1;2;3;4;5;6;7;8 ]
let list2 = 1::2::3::4::5::6::7::8::[];;
let list3 = List.init 5 (fun index -> (index+1,index+2,index+3,index,index))
let list4 = [1..10]
let list5 = ['a'..'z']
let list6 = [for a in 1..10 do yield (a * 2)]
let list7 = [for a in 1..100 do if a%3 = 0 then yield a]
let list8 = [for a in 1..3 do yield! [a..a + 4] ]

printfn "1: %A" list1
printfn "2: %A" list2
printfn "3: %A" list3
printfn "4: %A" list4
printfn "5: %A" list5
printfn "6: %A" list6
printfn "7: %A" list7
printfn "8: %A" list8

//first element of list
printfn "first element of list\n"

printfn "%A" <| list1.Head
printfn "%A" <| list2.Head
printfn "%A" <| list3.Head
printfn "%A" <| list4.Head
printfn "%A" <| list5.Head

//filter
printfn "Filtering for list\n"

printfn "1: Before: %A" list1
let list1_ = list1 |> List.filter(fun x -> x % 2 = 0)
printfn "_: After: %A" list1_

printfn "2: Before: %A" list2
let list2_ = list2 |> List.filter(fun x -> x <= 5)
printfn "2: After: %A" list2_
//map
printfn "map\n"

printfn "1: Before: %A" list1
let list1__ = list1 |> List.map(fun x -> x*x)
printfn "_: After: %A" list1__

printfn "2: Before: %A" list2
let list2__ = List.map(fun x -> x + 2)
printfn "_: After: %A" list2__

//append
printfn "append\n"

let doublelist = List.append list1 list2

printfn "%A" list1
printfn "%A" list2
printfn "%A" doublelist

let doublelist_ = list1 @ list2

printfn "\n2:\n"

printfn "%A" list1
printfn "%A" list2
printfn "%A" doublelist_

//sort
printfn "sort\n"

let sortlist1 = List.sort list1
let sortlist2 = List.sort list2
let sortlist3 = List.sort list3

printfn "1: %A" sortlist1
printfn "2: %A" sortlist2
printfn "3: %A" sortlist3

//average
printfn "average\n"

let list0 = [for x in (0.0)..(10.0) do yield x]

let averagelist1 = List.average list0

printfn "1: %A" averagelist1

//sum
printfn "sum\n"

let sumlist = List.sum list0

printfn "%A" sumlist

//List.fold
printfn "fold\n"

let twotwolist list = List.fold(fun a e -> e+2) 0 list

printfn "%A" (twotwolist [0..5])









