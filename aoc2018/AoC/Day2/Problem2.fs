module Day2.Problem2
    open System
    open System.IO

    let Solve = 
        let getInput = fun () -> File.ReadAllLines("Day2\\data")

        let isMatch line otherLine = 
            line 
            |> Seq.zip otherLine
            |> Seq.filter (fun (a, b) -> a <> b)
            |> Seq.length
            |> (=) 1

        let findMatch lines line =
            let toTuple matchingLine = (line, matchingLine)
            lines 
            |> Seq.tryFind (isMatch line) 
            |> Option.map toTuple

        let input = getInput()

        input 
        |> Seq.pick (findMatch input) 
        |> (fun (a, b) -> Seq.zip a b) 
        |> Seq.filter (fun (a, b) -> a = b)
        |> Seq.map fst
        |> String.Concat