let photos = [1..10]
let add2 x = x + 2
List.map add2 photos

let inputSequence = 
      ["a"; "b"; "c";
       "a"; "b"; "c"; "d";
       "a"; "b"; 
       "a"; "d"; "f";
       "a"; "x"; "y"; "z"]


let aIdx = 
    inputSequence 
        |> List.mapi (fun i x -> i, x)
        |> List.filter (fun x -> snd x = "a")
        |> List.map fst

[List.length inputSequence] 
    |> List.append aIdx 
    |> List.pairwise
    |> List.map (fun (x,y) -> inputSequence.[x .. (y - 1)])
 
aIdx |> List.append [16] 
[List.length inputSequence] |> List.append aIdx
inputSequence.[9..12]

aIdx |> List.map (fun x -> (List.splitAt x inputSequence))