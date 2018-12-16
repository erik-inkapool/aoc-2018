module Day2.Problem1
    open System.IO
    
    let Solve = 
        let getInput = fun () -> File.ReadAllLines("Day2\\data")
        
        let uniqueCounts line =
            line 
            |> Seq.toList 
            |> List.countBy id 
            |> List.map snd

        let linesWithExactlyNUniqueCounts counts n = 
            counts 
            |> Seq.map (List.contains n) 
            |> Seq.filter id 
            |> Seq.length


        let counts = getInput() |> Seq.map uniqueCounts

        linesWithExactlyNUniqueCounts counts 2 * linesWithExactlyNUniqueCounts counts 3