open System
open System.Diagnostics

let nilakantha n =
    n * (n+1.0) * (n+2.0)

let calcPi (steps:float) =
    let timer = new Stopwatch()
    timer.Start()
    let mutable pi = 3.0
    // use it to iterate between + and -
    let mutable sign = 1.0

    // start at 2 increment by 2 until desired steps
    for n in 2.0 .. 2.0 .. steps do
        if n = 100000.0 then
            Debugger.Break()
        pi <- pi + ( sign * 4.0/(nilakantha n) ) 
        sign <- sign * -1.0

    printfn "Finished PI calc in %A. Steps %A" 
        timer.Elapsed steps
    timer.Stop()
    pi

let machin = 4.0 * ((4.0 * Math.Atan(1.0/5.0)) - Math.Atan(1.0/239.0))

[<EntryPoint>]
let main argv =     

    let pi5    = calcPi 5000.0
    let pi10   = calcPi 10000.0
    let pi100  = calcPi 100000.0
    //let piMax = calcPi System.Double.MaxValue-2.0

    printfn "  5K -> %.020f" pi5
    printfn " 10K -> %.020f" pi10
    printfn "100K -> %.020f" pi100
    
    printfn "Machin -> %f" machin
    //printfn "Max(int32) -> %.020f" piMax
    Console.ReadKey() |> ignore
    0 // return an integer exit code
