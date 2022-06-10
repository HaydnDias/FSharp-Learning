// create a list of int's, 0 .. 5 is a range operator that creates a list of numbers from 0 to 5
let cards = [ 0 .. 5 ]

let hand = []


(* Simple example, commented out
// Head gets the first item in a list, Tail returns all but the first.
// So this function prints the first item in the list and then returns the remaining items without the first one.
// This basically simulates removing a card from the deck
let drawCard (list:int list) = 
    printfn "%i" list.Head
    list.Tail


// this should print out 0 and 1, and set result to a list of 2,3,4,5
let result = cards |> drawCard |> drawCard
*)


// Declares a function that takes a tuple of (int list, int list)
// fst accesses the first tuple value, similar to doing tuple.Item1 in C#
// 2nd accesses the second tuple value, similar to doing tuple.Item2 in C#
// This function basically takes a deck and the current hand (draw)
// it prints out the first card, which it gets by accessing the first value in deck using .Head
// it then sets hand equal to the drawn hand with the first card appended
// It then returns a tuple of the remaining cards in deck, and the new hand
let drawCard (tuple: int list * int list) = 
    let deck = fst tuple
    let draw = snd tuple
    let firstCard = deck.Head
    printfn "%i" firstCard

    let hand = 
        draw
        |> List.append [firstCard]

    (deck.Tail, hand)
    
// this passes a tuple of (cards, hand) which is a (int list, int list) into drawCard, this returns an (int list, int list)
// which gets passed into drawCard again, which then deconstructs the tuple (int list, int list) result into d and h respectively.
let d, h = (cards, hand) |> drawCard |> drawCard

// prints out the list's using the %A string formatter, which is used for "Formatted using structured plain text formatting with the default layout settings"
// https://docs.microsoft.com/en-us/dotnet/fsharp/language-reference/plaintext-formatting#format-specifiers-for-printf
printfn "Deck: %A Hand: %A" d h