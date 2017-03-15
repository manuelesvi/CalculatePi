open System
open System.Diagnostics

let nilakantha n =
    n * (n+1.0m) * (n+2.0m)

let calcPi (steps:decimal) =
    let timer = new Stopwatch()
    timer.Start()
    let mutable pi = 3.0m
    // use it to iterate between + and -
    let mutable sign = 1m

    // start at 2 increment by 2 until desired steps
    for n in 2.0m .. 2.0m .. steps do
        pi <- pi + ( sign * 4.0m/(nilakantha n) ) 
        sign <- sign * -1m

    printfn "Finished PI calc in %A. Steps %A" 
        timer.Elapsed steps
    timer.Stop()
    pi

let machin = 4.0 * ((4.0 * Math.Atan(1.0/5.0)) - Math.Atan(1.0/239.0))

[<EntryPoint>]
let main argv =
    let pi5    = calcPi 5000m
    let pi10   = calcPi 10000m
    let pi100  = calcPi 100000m
    let pi1M   = calcPi 1000000m
    let pi10M  = calcPi 10000000m
    let pi20M  = calcPi 20000000m
    //let pi50M  = calcPi 50000000m
    //let pi100M = calcPi 100000000m
    //let pi200M = calcPi 200000000m
    //let pi1B  = calcPi 1000000000m

    printfn "    5K -> %.020f" pi5
    printfn "   10K -> %.020f" pi10
    printfn "  100K -> %.020f" pi100
    printfn "    1M -> %.020f" pi1M
    printfn "   10M -> %.031f" pi10M
    printfn "   20M -> %.031f" pi20M
    //printfn " 50M -> %.031f" pi50M
    //printfn "100M -> %.031f" pi100M
    //printfn "200M -> %.031f" pi200M
    //printfn "  1B -> %.031f" pi1B
    
    printfn "Machin -> %.031f" machin
    //printfn "Max(int32) -> %.020f" piMax
    Console.ReadKey() |> ignore
    0 // return an integer exit code
