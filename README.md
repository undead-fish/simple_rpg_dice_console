# simple_rpg_dices_console
the name says everything functionwise I guess ^^

written in C# on .Net 5.0
Console only application

As I'm completely new to all this coding stuff, this little app was made with the intention to be implemented in a little text based rpg for learning purposes.
Everyone is welcome to use the code. Please feel free to text me, if u have an idea for optimisation, or if I did something wrong concerning open source manners.

(The programm virtualy lets you put dices of diverse kinds into a cup and roll them finaly.) 

MANUAL:

- Pick a dice by typping "x.Dy"
(x = amount)
(y = dice size/kind/sort thingywhatever)
(Example: 3D6 = program rolls three 6 sided dices. D20 = program rolls one 20 sided dice)

- Program lets u add more dices of different kinds step by step if u like to do so.
- Limit of dices per kind of dice is 10 for each roll.


VERSION 1.0 Notes:

- Language of interaction menu: German 

- For now it is not possible to add more dices by simply repeating a command. 
  The program will allways stick to the highest amount added of one sort of dices.
- For now It's not possible to remove dices from the cup in other way than simply finishing the roll and do it again.
  (As my coding skills will hopefully rise, I may add these features)

FOR DEVS:
- The dices are actually instances of a related class. The block of if states is incredibly big, because it handles every single dice. 
  Therefor the limit of 10 dices per sort. If anyone has an Idea how it's possible to simplify this and/or let the user manage the maximum amount, 
  feel free to contact me. I would be happy to learn. 
- The dices are collected in two structures. The first one is a HashSet<Action> for preventing duplicates going to the "cup". 
  Second one is a simple List<int> for calculating the sum of dices values.
- LINQ is used for calculation

copyright: undead-fish at something-with-tech-stuff.net (mail: uf@something-with-tech-stuff.net)
