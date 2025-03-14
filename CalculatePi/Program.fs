open System
open System.Diagnostics

let nilakantha n =
    n * (n+1.0m) * (n+2.0m)

// O(n), linear
let calcPi (steps:decimal) =
    let timer = new Stopwatch()
    timer.Start()
    let mutable pi = 3.0m
    // iterate between + and -
    let mutable sign = 1m

    // start at 2 increment by 2 until desired steps
    for n in 2.0m .. 2.0m .. steps do
        pi <- pi + ( sign * 4.0m/(nilakantha n) ) 
        sign <- sign * -1m

    printfn "Finished PI calc in %A. Steps %A"
        timer.Elapsed steps
    timer.Stop()
    pi

let machin = 4.0 * (4.0 * Math.Atan(1.0/5.0) - Math.Atan(1.0/239.0))

[<EntryPoint>]
let main argv =
    let pi5    = calcPi 5000m
    let pi10   = calcPi 10000m
    let pi100  = calcPi 100000m
    let pi1M   = calcPi 1000000m
    let pi100M = calcPi 100000000m
    let pi200M = calcPi 200000000m
    //let pi300M = calcPi 300000000m
    let pi500M = calcPi 500000000m
    let pi1B  = calcPi 1000000000m
    printfn "      π -> 3.1415926535897932384626433832795"
    printfn "--------------------------------------------"
    printfn "     5K -> %.020f" pi5
    printfn "    10K -> %.020f" pi10
    printfn "   100K -> %.020f" pi100
    printfn "     1M -> %.020f" pi1M
    printfn "   100M -> %1.31f" pi100M
    printfn "   200M -> %1.31f" pi200M
    //printfn "   300M -> %1.31f" pi300M
    printfn "   500M -> %1.31f" pi500M
    printfn "     1B -> %1.31f" pi1B
    printfn "Math.PI -> %1.31f" Math.PI
    printfn " Machin  -> %.45f" machin
    Console.ReadKey() |> ignore
    0 // exit code
