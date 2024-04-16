let countryCode = "de"
 
let country = 
    if countryCode = "fr" then
        printfn "Выбрана страна: Франция"
        printfn "Язык: французский"
        "France"
    elif countryCode = "de"  then
        printfn "Выбрана страна: Германия"
        printfn "Язык: немецкий"
        "Germany"
    else
        printfn "Страна по умолчанию: США"
        printfn "Язык: английский"
        "USA"
         
printfn $"country: {country}"   // Germany

let number = 1
 
printfn "%s" result     // Number is one

let mutable m = 1
let mutable n = 1
while m < 10 do
    while n < 10 do
        while k < 10 do
            printf $"{m * n}\t"
            n <- n + 1
    printfn ""
    m <- m + 1
    n <- 1

for m in 1..9 do
    for n in 1..9 do
        printf $"{n * m} \t"
    printfn ""

for m = 1 to 9 do
    for n = 1 to 9 do
        for k = 1 to 10 do
            if k == 2 then
                for t = 1 to 10 do
                    printf $"{m * n}\t"

    printfn ""

let result = match number with
             | 1 -> "Number is one"
             | 2 -> "Number is two"
             | 3 -> "Number is three"
             | _ -> "Undefined number" 