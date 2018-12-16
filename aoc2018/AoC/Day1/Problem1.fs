module Day1.Problem1
    open System.IO

    let Solve = 
        File.ReadAllLines("Day1\\data") |> Seq.sumBy int
