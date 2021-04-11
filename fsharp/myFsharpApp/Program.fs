// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

// Define a function to construct a message to print
let from whom =
    sprintf "from %s" whom

let printGreeting name = 
    printfn "Hello %s from F#!" name

[<EntryPoint>]
let main argv =
    // let message = from "F#" // Call the function
    // printfn "Hello world %s" message
    printGreeting "Ana"
    0 // return an integer exit code
