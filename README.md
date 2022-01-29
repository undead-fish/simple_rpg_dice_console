# simple_rpg_dice_console
the name says everything functionwise I guess.

For u "JUST GIMME THAT"-guys: The ZIP file is what u're looking for ^^


written in C# on .Net 5.0
Console only application

As I'm completely new to all this coding stuff, this little app was made with the intention of being implemented in a little text based rpg for learning purposes.
Everyone is welcome to use the code. Please feel free to text me, if u have an idea for optimisation, or if I did something wrong concerning open source manners.

(The programm virtualy lets you put dice of diverse kinds into a cup and roll them finaly.) 

MANUAL:

- Pick a dice by typing "x.Dy"
(x = amount)
(y = dice size/kind/sort thingywhatever)
(D is interchangable with W as in german dice means Würfel.)
(Example: 3D6 = program rolls three 6 sided dice. D20 = program rolls one 20 sided dice)

- Program lets u add more dice of different kinds step by step if u like to do so.
- Limit of dice per kind is 10 for each roll.
- Letters can be written capitalized and uncapitalized.

VERSION UPDATE 1.1 Notes:

Added:
- language of interaction menu: English (both versions inside zip file.)
- exe icons

VERSION 1.0 Notes:

- Language of interaction menu: German 

- For now it is not possible to add more dice by simply repeating a command. 
  The program will allways stick to the highest amount added of one sort of dice.
- For now It's not possible to remove dice from the cup in other way than simply finishing the roll and do it again.
  (As my coding skills will hopefully rise, I may add these features)

FOR DEVS:
- Both program.cs files are inactive, as their namespaces are commented out completely for not conflicting each other. 
  Uncomment one of them to activate.
- The dice are actually instances of a related class. The block of if states is incredibly big, because it handles every single dice. 
  Therefor the limit of 10 dice per sort. If anyone has an Idea how it's possible to simplify this and/or let the user manage the maximum amount, 
  feel free to contact me. I would be happy to learn. 
- The dice are collected in two structures. The first one is a HashSet<Action> for preventing duplicates going to the "cup". 
  Second one is a simple List<int> for calculating the sum of dice values.
- LINQ is used for calculation

copyright: undead-fish at something-with-tech-stuff.net (mail: uf@something-with-tech-stuff.net)
