module Day1.Problem2
    open System.IO

    let Solve = 
        let repeatingNumberFinderFactory() = 
            let mutable numbersSoFar = Set.empty
            let mutable accumulator = 0

            let repeatingNumberFinder n =
                accumulator <- accumulator + n
                if numbersSoFar.Contains accumulator
                    then Some accumulator 
                    else
                        numbersSoFar <- numbersSoFar.Add accumulator
                        None

            repeatingNumberFinder

        // repeat infinitely
        let repeat items = 
            seq { while true do yield! items }

        let getInput = fun () -> File.ReadAllLines("Day1\\data")

        let repeatingNumber = repeatingNumberFinderFactory()

        getInput()
            |> Seq.map int
            |> repeat
            |> Seq.pick repeatingNumber