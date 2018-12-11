module Problem1

open System.IO

let Solve = 
    let numberParser (line : string) = line |> int

    let getInput = fun () -> File.ReadAllLines("Day1\\problem1.data")

    getInput() |> Seq.sumBy numberParser