// declares function cardFace, with a parameter of type int called card, and it returns a string
let cardFace (card:int) :string = 
   let no = card % 13
   if no = 1 then "Ace"
   elif no = 0 then "King"
   elif no = 12 then "Queen"
   elif no = 11 then "Jack"
   else string no

printfn "%s" (cardFace 11)