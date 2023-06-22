open System.Threading
open System

let mutable monologue = string("So you need help?")
let mutable count = 0


for i in monologue do
    stdout.Write(monologue[count])
    count <- count + 1
    Thread.Sleep(25) //Async.Sleep(25) |> Async.RunSynchronously

Console.ReadKey() |> ignore
Console.Clear()

monologue <- "Fine, I'll help"
count <- 0

for i in monologue do
    stdout.Write(monologue[count])
    count <- count + 1
    Thread.Sleep(25) //Async.Sleep(25) |> Async.RunSynchronously


Console.Clear()

monologue <- "Or maybe not... Like why should I?"
count <- 0

for i in monologue do
    stdout.Write(monologue[count])
    count <- count + 1
    Thread.Sleep(25) //Async.Sleep(25) |> Async.RunSynchronously

Console.ReadKey() |> ignore
