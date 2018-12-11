module Problem2

open System.IO

let Solve = 
    let numberParser (line : string) = line |> int

    let repeatingNumberFinderFactory() = 
        let mutable numbersSoFar = Map.empty
        let mutable accumulator = 0

        let repeatingNumberFinder n =
            accumulator <- accumulator + n
            if numbersSoFar.ContainsKey accumulator
                then Some accumulator 
                else
                    numbersSoFar <- numbersSoFar.Add (accumulator, true)
                    None

        repeatingNumberFinder

    // repeat infinitely
    let repeat items = 
        seq { while true do yield! items }

    let getInput = fun () -> File.ReadAllLines("Day1\\problem1.data")

    let repeatingNumbers = repeatingNumberFinderFactory()

    getInput()
        |> Seq.map numberParser
        |> repeat
        |> Seq.pick repeatingNumbers