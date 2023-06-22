open System.Threading
open System

let mutable monologue = string("So you need help?")
let mutable count = 0


for i in monologue do
    stdout.Write(monologue[count])
    count <- count + 1
    Thread.Sleep(50) //Async.Sleep(50) |> Async.RunSynchronously
Console.ReadKey() |> ignore
Console.Clear()
monologue <- "Fine, I'll help"
count <- 0
for i in monologue do
    stdout.Write(monologue[count])
    count <- count + 1
    Thread.Sleep(50) //Async.Sleep(50) |> Async.RunSynchronously
Console.Clear()
monologue <- "Or maybe not... Like why should I?"
count <- 0
for i in monologue do
    stdout.Write(monologue[count])
    count <- count + 1
    Thread.Sleep(50) //Async.Sleep(50) |> Async.RunSynchronously
Console.Clear()
monologue <- "Why would I give you something without asking for anything in return?"
count <- 0
for i in monologue do
    stdout.Write(monologue[count])
    count <- count + 1
    Thread.Sleep(50) //Async.Sleep(50) |> Async.RunSynchronously
Console.Clear()
monologue <- "Fine..."
count <- 0
for i in monologue do
    stdout.Write(monologue[count])
    count <- count + 1
    Thread.Sleep(50) //Async.Sleep(50) |> Async.RunSynchronously
Console.Clear()
monologue <- "Okay... I'll do it..."
count <- 0
for i in monologue do
    stdout.Write(monologue[count])
    count <- count + 1
    Thread.Sleep(50) //Async.Sleep(50) |> Async.RunSynchronously
Console.Clear()
monologue <- "just wait for a second..."
count <- 0
for i in monologue do
    stdout.Write(monologue[count])
    count <- count + 1
    Thread.Sleep(50) //Async.Sleep(50) |> Async.RunSynchronously
Console.Clear()
monologue <- "..."
count <- 0
for i in monologue do
    stdout.Write(monologue[count])
    count <- count + 1
    Thread.Sleep(50) //Async.Sleep(50) |> Async.RunSynchronously
Console.Clear()
monologue <- "Welcome to System Manager... or whatever this is..."
count <- 0
for i in monologue do
    stdout.Write(monologue[count])
    count <- count + 1
    Thread.Sleep(50) //Async.Sleep(50) |> Async.RunSynchronously
Console.Clear()
monologue <- "This program is designed for the sole purpose of managing the system that it was designed along with blah blah blah"
count <- 0
for i in monologue do
    stdout.Write(monologue[count])
    count <- count + 1
    Thread.Sleep(50) //Async.Sleep(50) |> Async.RunSynchronously
Console.Clear()
monologue <- "Moving on..."
count <- 0
for i in monologue do
    stdout.Write(monologue[count])
    count <- count + 1
    Thread.Sleep(50) //Async.Sleep(50) |> Async.RunSynchronously
Console.ReadKey() |> ignore
