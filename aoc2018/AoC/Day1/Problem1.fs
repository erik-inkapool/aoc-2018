module Problem1

open System.IO

let Solve = 
    let numberParser (line : string) =
        let toNegative = fun n -> n * -1

        match line with
            | number when number.StartsWith("-") -> number.Substring(1) |> int |> toNegative |> Some
            | number when number.StartsWith("+") -> number |> int |> Some
            | _ -> None

    let getInput = fun () -> File.ReadAllLines("Day1\\problem1.data")

    let stuff = getInput() |> Seq.choose numberParser
    
    stuff |> Seq.sum