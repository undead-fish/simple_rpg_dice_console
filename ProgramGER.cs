using System;
using System.Collections.Generic;
using System.Linq;

/*
namespace simple_rpg_dice_console
{
    #region dice classes
    public class Dice   // Main dice class
    {
        public Random rnd = new Random();     // initiating random seed for all instances
        private string Name;

        public Dice(string Name)   // Constructor
        {
            this.Name = Name;
        }
        public void setName(string Name)     // setMethod
        {
            this.Name = Name;
        }
        public string getName()     // getMethod
        {
            return this.Name;
        }
        public virtual void Show()   // printMethod in preparation for correct name print,
        {                            // in console for each object instance
            Console.Write("{" + this.Name);
        }

    }

    internal class D4 : Dice
    {
        private int D4Value;

        public D4(string Name, int D4Value)    // Constructor
            : base(Name)
        {
            this.D4Value = D4Value;
        }
        public void Roll()   // setMethod
        {
            this.D4Value = rnd.Next(1, 5);
        }
        public int getValue()   // getMethod
        {
            return this.D4Value;
        }
        public override void Show()    // printMethod in combination with 
        {
            base.Show();
            Console.Write(" zeigt: " + this.D4Value + "} ");
        }
    }

    internal class D6 : Dice
    {
        private int D6Value;

        public D6(string Name, int D6Value)    // Constructor
            : base(Name)
        {
            this.D6Value = D6Value;
        }
        public void Roll()   // setMethod
        {
            this.D6Value = rnd.Next(1, 7);
        }
        public int getValue()   // getMethod (..you get the point I guess)
        {
            return this.D6Value;
        }
        public override void Show()
        {
            base.Show();
            Console.Write(" zeigt: " + this.D6Value + "} ");
        }
    }

    internal class D8 : Dice
    {
        private int D8Value;

        public D8(string Name, int D8Value)    // Constructor
            : base(Name)
        {
            this.D8Value = D8Value;
        }
        public void Roll()   // setMethod
        {
            this.D8Value = rnd.Next(1, 9);
        }
        public int getValue()   // getMethod (..you get the point I guess)
        {
            return this.D8Value;
        }
        public override void Show()
        {
            base.Show();
            Console.Write(" zeigt: " + this.D8Value + "} ");
        }
    }

    internal class D10 : Dice
    {
        private int D10Value;

        public D10(string Name, int D10Value)
            : base(Name)
        {
            this.D10Value = D10Value;
        }
        public void Roll()
        {
            this.D10Value = rnd.Next(1, 11);
        }
        public int getValue()
        {
            return this.D10Value;
        }
        public override void Show()
        {
            base.Show();
            Console.Write(" zeigt: " + this.D10Value + "} ");
        }
    }

    internal class D12 : Dice
    {
        private int D12Value;

        public D12(string Name, int D12Value)
            : base(Name)
        {
            this.D12Value = D12Value;
        }
        public void Roll()
        {
            this.D12Value = rnd.Next(1, 13);
        }
        public int getValue()
        {
            return this.D12Value;
        }
        public override void Show()
        {
            base.Show();
            Console.Write(" zeigt: " + this.D12Value + "} ");
        }
    }

    internal class D20 : Dice
    {
        private int D20Value;

        public D20(string Name, int D20Value)
            : base(Name)
        {
            this.D20Value = D20Value;
        }
        public void Roll()
        {
            this.D20Value = rnd.Next(1, 21);
        }
        public int getValue()
        {
            return this.D20Value;
        }
        public override void Show()
        {
            base.Show();
            Console.Write(" zeigt: " + this.D20Value + "} ");
        }
    }

    internal class D100 : Dice
    {
        private int D100Value;

        public D100(string Name, int D100Value)
            : base(Name)
        {
            this.D100Value = D100Value;
        }
        public void Roll()
        {
            this.D100Value = rnd.Next(1, 101);
        }
        public int getValue()
        {
            return this.D100Value;
        }
        public override void Show()
        {
            base.Show();
            Console.Write(" zeigt: " + this.D100Value + "} ");
        }
    }
    #endregion

    internal class ProgramGER
    {
        static void Main(string[] args)
        {
            #region Main game and object -initialization

            #region console window resize
            try
            {
                Console.SetWindowSize(Math.Min(156, Console.LargestWindowWidth), Math.Min(35, Console.LargestWindowHeight));
            }
            catch
            {
                Console.WriteLine("Unable to rezise console window. Please feel free to rezise on your own for better readability und such.");
            }
            #endregion

            #region Dice Ini

            D4 D4 = new D4("W4 Nr.1", 18139);      // Initializing the single dice for usage.
            D4 D4_2 = new D4("W4 Nr.2", 39841);    // The intitial set value is just a random number from
            D4 D4_3 = new D4("W4 Nr.3", 57624);    // my mind to set the seeds starting points apart from each other,
            D4 D4_4 = new D4("W4 Nr.4", 38436);    // to get the thing even more fake randomized if possible.
            D4 D4_5 = new D4("W4 Nr.5", 40166);    // (Don't know if that is really working, or just crap in my mind :) 
            D4 D4_6 = new D4("W4 Nr.6", 77482);    // Please feel welcome to contact me, if you know the answer.
            D4 D4_7 = new D4("W4 Nr.7", 66462);    // I'm allways happy to learn! (mail: uf@something-with-thech-stuff.net))
            D4 D4_8 = new D4("W4 Nr.8", 92492);    // Anyway, don't worry. The value will snap back to
            D4 D4_9 = new D4("W4 Nr.9", 11713);    // the correct range of each dice.
            D4 D4_10 = new D4("W4 Nr.10", 62018);

            D6 D6 = new D6("W6 Nr.1", 46173);
            D6 D6_2 = new D6("W6 Nr.2", 23954);
            D6 D6_3 = new D6("W6 Nr.3", 67108);
            D6 D6_4 = new D6("W6 Nr.4", 83146);
            D6 D6_5 = new D6("W6 Nr.5", 59653);
            D6 D6_6 = new D6("W6 Nr.6", 27842);
            D6 D6_7 = new D6("W6 Nr.7", 16193);
            D6 D6_8 = new D6("W6 Nr.8", 99007);
            D6 D6_9 = new D6("W6 Nr.9", 35085);
            D6 D6_10 = new D6("W6 Nr.10", 73954);

            D8 D8 = new D8("W8 Nr.1", 89432);
            D8 D8_2 = new D8("W8 Nr.2", 13843);
            D8 D8_3 = new D8("W8 Nr.3", 44324);
            D8 D8_4 = new D8("W8 Nr.4", 91465);
            D8 D8_5 = new D8("W8 Nr.5", 22763);
            D8 D8_6 = new D8("W8 Nr.6", 19681);
            D8 D8_7 = new D8("W8 Nr.7", 34113);
            D8 D8_8 = new D8("W8 Nr.8", 64419);
            D8 D8_9 = new D8("W8 Nr.9", 29428);
            D8 D8_10 = new D8("W8 Nr.10", 94143);

            D10 D10 = new D10("W10 Nr.1", 76144);
            D10 D10_2 = new D10("W10 Nr.2", 46652);
            D10 D10_3 = new D10("W10 Nr.3", 97143);
            D10 D10_4 = new D10("W10 Nr.4", 12664);
            D10 D10_5 = new D10("W10 Nr.5", 56792);
            D10 D10_6 = new D10("W10 Nr.6", 32346);
            D10 D10_7 = new D10("W10 Nr.7", 99469);
            D10 D10_8 = new D10("W10 Nr.8", 51901);
            D10 D10_9 = new D10("W10 Nr.9", 87351);
            D10 D10_10 = new D10("W10 Nr.10", 14654);

            D12 D12 = new D12("W12 Nr.1", 29436);
            D12 D12_2 = new D12("W12 Nr.2", 75981);
            D12 D12_3 = new D12("W12 Nr.3", 12084);
            D12 D12_4 = new D12("W12 Nr.4", 79132);
            D12 D12_5 = new D12("W12 Nr.5", 56463);
            D12 D12_6 = new D12("W12 Nr.6", 65136);
            D12 D12_7 = new D12("W12 Nr.7", 21168);
            D12 D12_8 = new D12("W12 Nr.8", 38004);
            D12 D12_9 = new D12("W12 Nr.9", 96576);
            D12 D12_10 = new D12("W12 Nr.10", 45086);

            D20 D20 = new D20("W20 Nr.1", 91354);
            D20 D20_2 = new D20("W20 Nr.2", 26318);
            D20 D20_3 = new D20("W20 Nr.3", 77162);
            D20 D20_4 = new D20("W20 Nr.4", 17660);
            D20 D20_5 = new D20("W20 Nr.5", 35746);
            D20 D20_6 = new D20("W20 Nr.6", 89654);
            D20 D20_7 = new D20("W20 Nr.7", 12416);
            D20 D20_8 = new D20("W20 Nr.8", 83009);
            D20 D20_9 = new D20("W20 Nr.9", 30168);
            D20 D20_10 = new D20("W20 Nr.10", 55765);

            D100 D100 = new D100("W100 Nr.1", 111136);
            D100 D100_2 = new D100("W100 Nr.2", 325001);
            D100 D100_3 = new D100("W100 Nr.3", 652162);
            D100 D100_4 = new D100("W100 Nr.4", 109148);
            D100 D100_5 = new D100("W100 Nr.5", 564468);
            D100 D100_6 = new D100("W100 Nr.6", 237460);
            D100 D100_7 = new D100("W100 Nr.7", 980913);
            D100 D100_8 = new D100("W100 Nr.8", 704135);
            D100 D100_9 = new D100("W100 Nr.9", 95346);
            D100 D100_10 = new D100("W100 Nr.10", 412980);


            void RollAllDice()
            {
                D4.Roll();
                D4_2.Roll();
                D4_3.Roll();
                D4_4.Roll();
                D4_5.Roll();
                D4_6.Roll();
                D4_7.Roll();
                D4_8.Roll();
                D4_9.Roll();
                D4_10.Roll();

                D6.Roll();
                D6_2.Roll();
                D6_3.Roll();
                D6_4.Roll();
                D6_5.Roll();
                D6_6.Roll();
                D6_7.Roll();
                D6_8.Roll();
                D6_9.Roll();
                D6_10.Roll();

                D8.Roll();
                D8_2.Roll();
                D8_3.Roll();
                D8_4.Roll();
                D8_5.Roll();
                D8_6.Roll();
                D8_7.Roll();
                D8_8.Roll();
                D8_9.Roll();
                D8_10.Roll();

                D10.Roll();
                D10_2.Roll();
                D10_3.Roll();
                D10_4.Roll();
                D10_5.Roll();
                D10_6.Roll();
                D10_7.Roll();
                D10_8.Roll();
                D10_9.Roll();
                D10_10.Roll();

                D12.Roll();
                D12_2.Roll();
                D12_3.Roll();
                D12_4.Roll();
                D12_5.Roll();
                D12_6.Roll();
                D12_7.Roll();
                D12_8.Roll();
                D12_9.Roll();
                D12_10.Roll();

                D20.Roll();
                D20_2.Roll();
                D20_3.Roll();
                D20_4.Roll();
                D20_5.Roll();
                D20_6.Roll();
                D20_7.Roll();
                D20_8.Roll();
                D20_9.Roll();
                D20_10.Roll();

                D100.Roll();
                D100_2.Roll();
                D100_3.Roll();
                D100_4.Roll();
                D100_5.Roll();
                D100_6.Roll();
                D100_7.Roll();
                D100_8.Roll();
                D100_9.Roll();
                D100_10.Roll();
            }

            void ShowAllDice()
            {
                D4.Show();
                D4_2.Show();
                D4_3.Show();
                D4_4.Show();
                D4_5.Show();
                D4_6.Show();
                D4_7.Show();
                D4_8.Show();
                D4_9.Show();
                D4_10.Show();
                Console.WriteLine();
                D6.Show();
                D6_2.Show();
                D6_3.Show();
                D6_4.Show();
                D6_5.Show();
                D6_6.Show();
                D6_7.Show();
                D6_8.Show();
                D6_9.Show();
                D6_10.Show();
                Console.WriteLine();
                D8.Show();
                D8_2.Show();
                D8_3.Show();
                D8_4.Show();
                D8_5.Show();
                D8_6.Show();
                D8_7.Show();
                D8_8.Show();
                D8_9.Show();
                D8_10.Show();
                Console.WriteLine();
                D10.Show();
                D10_2.Show();
                D10_3.Show();
                D10_4.Show();
                D10_5.Show();
                D10_6.Show();
                D10_7.Show();
                D10_8.Show();
                D10_9.Show();
                D10_10.Show();
                Console.WriteLine();
                D12.Show();
                D12_2.Show();
                D12_3.Show();
                D12_4.Show();
                D12_5.Show();
                D12_6.Show();
                D12_7.Show();
                D12_8.Show();
                D12_9.Show();
                D12_10.Show();
                Console.WriteLine();
                D20.Show();
                D20_2.Show();
                D20_3.Show();
                D20_4.Show();
                D20_5.Show();
                D20_6.Show();
                D20_7.Show();
                D20_8.Show();
                D20_9.Show();
                D20_10.Show();
                Console.WriteLine();
                D100.Show();
                D100_2.Show();
                D100_3.Show();
                D100_4.Show();
                D100_5.Show();
                D100_6.Show();
                D100_7.Show();
                D100_8.Show();
                D100_9.Show();
                D100_10.Show();
            } //Shows all dice for testing purposes if needed

            RollAllDice(); // first initial roll of all dice (otherwise all would show 1 at this point)



            #endregion

            #region InGame callMethods

            // Method to quickly roll and show all dice for testing purposes
            void callAllDice()
            {
                bool GoOn = true;
                while (GoOn)
                {
                    Console.WriteLine();
                    Console.Write("Alle Würfel werfen?");
                    var inputchar = Console.ReadLine();

                    if (inputchar == "j" | inputchar == "ja" | inputchar == "J" | inputchar == "Ja" | inputchar == "y" | inputchar == "Y" | inputchar == "yes" | inputchar == "Yes")
                    {
                        RollAllDice();
                        ShowAllDice();
                        Console.WriteLine();
                    }
                    else
                    {
                        GoOn = false;
                    }

                }
            }

            // Main game method
            void callFreeDiceRoll()
            {
                bool start = true;
                while (start)
                {
                    HashSet<Action> PlayersDice = new HashSet<Action>();    // Datastructure for showing played dice
                    List<int> PlayersDiceValues = new List<int>();      // Datastructure for accumulating the results of played dice
                    bool GoOn = true;
                    bool GoOn1 = true;

                    while (GoOn)
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("         {{{{{  Ok, Würfeln wir!  }}}}}");
                        Console.WriteLine();
                        Console.WriteLine("     Mit welchen Würfeln möchtest du spielen?            (Sag zB.: 'W4', '3W12', oder '2W20',.. usw. um die Würfel in den Würfelbecher zu legen.");
                        Console.WriteLine("                                                         (Du kannst insgesamt 10 Würfel je Sorte auf einmal spielen.");
                        Console.WriteLine("                                                         (Bitte nenne nur eine Würfelart zurzeit und diese nur einmal pro Durchgang.");
                        Console.WriteLine("                                                         (Wenn du einen Würfel ohne Vorzähler angibst(zB.: 'W6'), wird ein Würfel angenommen.");
                        Console.WriteLine("                                                         (Siehe README.txt für mehr Info.");
                        Console.Write("     ");

                        while (GoOn1)
                        {
                            string inputDice = Console.ReadLine();

                            #region if states - Player chooses dice
                            #region D4 If States

                            if (inputDice == "W4" ^ inputDice == "1W4" ^ inputDice == "w4" ^ inputDice == "1w4" ^ inputDice == "D4" ^ inputDice == "1D4" ^ inputDice == "d4" ^ inputDice == "1d4")
                            {
                                bool isD4Showin = PlayersDice.Contains(D4.Show);
                                if (!isD4Showin)
                                {
                                    D4.Roll();
                                    PlayersDice.Add(D4.Show);
                                    PlayersDiceValues.Add(D4.getValue());
                                }
                            }
                            else if (inputDice == "2W4" ^ inputDice == "2w4" ^ inputDice == "2D4" ^ inputDice == "2d4")
                            {
                                bool isD4Showin = PlayersDice.Contains(D4.Show);
                                bool isD4_2Showin = PlayersDice.Contains(D4_2.Show);
                                if (!isD4Showin)
                                {
                                    D4.Roll();
                                    PlayersDice.Add(D4.Show);
                                    PlayersDiceValues.Add(D4.getValue());
                                }
                                if (!isD4_2Showin)
                                {
                                    D4_2.Roll();
                                    PlayersDice.Add(D4_2.Show);
                                    PlayersDiceValues.Add(D4_2.getValue());
                                }
                            }
                            else if (inputDice == "3W4" ^ inputDice == "3w4" ^ inputDice == "3D4" ^ inputDice == "3d4")
                            {
                                bool isD4Showin = PlayersDice.Contains(D4.Show);
                                bool isD4_2Showin = PlayersDice.Contains(D4_2.Show);
                                bool isD4_3Showin = PlayersDice.Contains(D4_3.Show);
                                if (!isD4Showin)
                                {
                                    D4.Roll();
                                    PlayersDice.Add(D4.Show);
                                    PlayersDiceValues.Add(D4.getValue());
                                }
                                if (!isD4_2Showin)
                                {
                                    D4_2.Roll();
                                    PlayersDice.Add(D4_2.Show);
                                    PlayersDiceValues.Add(D4_2.getValue());
                                }
                                if (!isD4_3Showin)
                                {
                                    D4_3.Roll();
                                    PlayersDice.Add(D4_3.Show);
                                    PlayersDiceValues.Add(D4_3.getValue());
                                }
                            }
                            else if (inputDice == "4W4" ^ inputDice == "4w4" ^ inputDice == "4D4" ^ inputDice == "4d4")
                            {
                                bool isD4Showin = PlayersDice.Contains(D4.Show);
                                bool isD4_2Showin = PlayersDice.Contains(D4_2.Show);
                                bool isD4_3Showin = PlayersDice.Contains(D4_3.Show);
                                bool isD4_4Showin = PlayersDice.Contains(D4_4.Show);
                                if (!isD4Showin)
                                {
                                    D4.Roll();
                                    PlayersDice.Add(D4.Show);
                                    PlayersDiceValues.Add(D4.getValue());
                                }
                                if (!isD4_2Showin)
                                {
                                    D4_2.Roll();
                                    PlayersDice.Add(D4_2.Show);
                                    PlayersDiceValues.Add(D4_2.getValue());
                                }
                                if (!isD4_3Showin)
                                {
                                    D4_3.Roll();
                                    PlayersDice.Add(D4_3.Show);
                                    PlayersDiceValues.Add(D4_3.getValue());
                                }
                                if (!isD4_4Showin)
                                {
                                    D4_4.Roll();
                                    PlayersDice.Add(D4_4.Show);
                                    PlayersDiceValues.Add(D4_4.getValue());
                                }
                            }
                            else if (inputDice == "5W4" ^ inputDice == "5w4" ^ inputDice == "5D4" ^ inputDice == "5d4")
                            {
                                bool isD4Showin = PlayersDice.Contains(D4.Show);
                                bool isD4_2Showin = PlayersDice.Contains(D4_2.Show);
                                bool isD4_3Showin = PlayersDice.Contains(D4_3.Show);
                                bool isD4_4Showin = PlayersDice.Contains(D4_4.Show);
                                bool isD4_5Showin = PlayersDice.Contains(D4_5.Show);
                                if (!isD4Showin)
                                {
                                    D4.Roll();
                                    PlayersDice.Add(D4.Show);
                                    PlayersDiceValues.Add(D4.getValue());
                                }
                                if (!isD4_2Showin)
                                {
                                    D4_2.Roll();
                                    PlayersDice.Add(D4_2.Show);
                                    PlayersDiceValues.Add(D4_2.getValue());
                                }
                                if (!isD4_3Showin)
                                {
                                    D4_3.Roll();
                                    PlayersDice.Add(D4_3.Show);
                                    PlayersDiceValues.Add(D4_3.getValue());
                                }
                                if (!isD4_4Showin)
                                {
                                    D4_4.Roll();
                                    PlayersDice.Add(D4_4.Show);
                                    PlayersDiceValues.Add(D4_4.getValue());
                                }
                                if (!isD4_5Showin)
                                {
                                    D4_5.Roll();
                                    PlayersDice.Add(D4_5.Show);
                                    PlayersDiceValues.Add(D4_5.getValue());
                                }
                            }
                            else if (inputDice == "6W4" ^ inputDice == "6w4" ^ inputDice == "6D4" ^ inputDice == "6d4")
                            {
                                bool isD4Showin = PlayersDice.Contains(D4.Show);
                                bool isD4_2Showin = PlayersDice.Contains(D4_2.Show);
                                bool isD4_3Showin = PlayersDice.Contains(D4_3.Show);
                                bool isD4_4Showin = PlayersDice.Contains(D4_4.Show);
                                bool isD4_5Showin = PlayersDice.Contains(D4_5.Show);
                                bool isD4_6Showin = PlayersDice.Contains(D4_6.Show);
                                if (!isD4Showin)
                                {
                                    D4.Roll();
                                    PlayersDice.Add(D4.Show);
                                    PlayersDiceValues.Add(D4.getValue());
                                }
                                if (!isD4_2Showin)
                                {
                                    D4_2.Roll();
                                    PlayersDice.Add(D4_2.Show);
                                    PlayersDiceValues.Add(D4_2.getValue());
                                }
                                if (!isD4_3Showin)
                                {
                                    D4_3.Roll();
                                    PlayersDice.Add(D4_3.Show);
                                    PlayersDiceValues.Add(D4_3.getValue());
                                }
                                if (!isD4_4Showin)
                                {
                                    D4_4.Roll();
                                    PlayersDice.Add(D4_4.Show);
                                    PlayersDiceValues.Add(D4_4.getValue());
                                }
                                if (!isD4_5Showin)
                                {
                                    D4_5.Roll();
                                    PlayersDice.Add(D4_5.Show);
                                    PlayersDiceValues.Add(D4_5.getValue());
                                }
                                if (!isD4_6Showin)
                                {
                                    D4_6.Roll();
                                    PlayersDice.Add(D4_6.Show);
                                    PlayersDiceValues.Add(D4_6.getValue());
                                }
                            }
                            else if (inputDice == "7W4" ^ inputDice == "7w4" ^ inputDice == "7D4" ^ inputDice == "7d4")
                            {
                                bool isD4Showin = PlayersDice.Contains(D4.Show);
                                bool isD4_2Showin = PlayersDice.Contains(D4_2.Show);
                                bool isD4_3Showin = PlayersDice.Contains(D4_3.Show);
                                bool isD4_4Showin = PlayersDice.Contains(D4_4.Show);
                                bool isD4_5Showin = PlayersDice.Contains(D4_5.Show);
                                bool isD4_6Showin = PlayersDice.Contains(D4_6.Show);
                                bool isD4_7Showin = PlayersDice.Contains(D4_7.Show);
                                if (!isD4Showin)
                                {
                                    D4.Roll();
                                    PlayersDice.Add(D4.Show);
                                    PlayersDiceValues.Add(D4.getValue());
                                }
                                if (!isD4_2Showin)
                                {
                                    D4_2.Roll();
                                    PlayersDice.Add(D4_2.Show);
                                    PlayersDiceValues.Add(D4_2.getValue());
                                }
                                if (!isD4_3Showin)
                                {
                                    D4_3.Roll();
                                    PlayersDice.Add(D4_3.Show);
                                    PlayersDiceValues.Add(D4_3.getValue());
                                }
                                if (!isD4_4Showin)
                                {
                                    D4_4.Roll();
                                    PlayersDice.Add(D4_4.Show);
                                    PlayersDiceValues.Add(D4_4.getValue());
                                }
                                if (!isD4_5Showin)
                                {
                                    D4_5.Roll();
                                    PlayersDice.Add(D4_5.Show);
                                    PlayersDiceValues.Add(D4_5.getValue());
                                }
                                if (!isD4_6Showin)
                                {
                                    D4_6.Roll();
                                    PlayersDice.Add(D4_6.Show);
                                    PlayersDiceValues.Add(D4_6.getValue());
                                }
                                if (!isD4_7Showin)
                                {
                                    D4_7.Roll();
                                    PlayersDice.Add(D4_7.Show);
                                    PlayersDiceValues.Add(D4_7.getValue());
                                }
                            }
                            else if (inputDice == "8W4" ^ inputDice == "8w4" ^ inputDice == "8D4" ^ inputDice == "8d4")
                            {
                                bool isD4Showin = PlayersDice.Contains(D4.Show);
                                bool isD4_2Showin = PlayersDice.Contains(D4_2.Show);
                                bool isD4_3Showin = PlayersDice.Contains(D4_3.Show);
                                bool isD4_4Showin = PlayersDice.Contains(D4_4.Show);
                                bool isD4_5Showin = PlayersDice.Contains(D4_5.Show);
                                bool isD4_6Showin = PlayersDice.Contains(D4_6.Show);
                                bool isD4_7Showin = PlayersDice.Contains(D4_7.Show);
                                bool isD4_8Showin = PlayersDice.Contains(D4_8.Show);
                                if (!isD4Showin)
                                {
                                    D4.Roll();
                                    PlayersDice.Add(D4.Show);
                                    PlayersDiceValues.Add(D4.getValue());
                                }
                                if (!isD4_2Showin)
                                {
                                    D4_2.Roll();
                                    PlayersDice.Add(D4_2.Show);
                                    PlayersDiceValues.Add(D4_2.getValue());
                                }
                                if (!isD4_3Showin)
                                {
                                    D4_3.Roll();
                                    PlayersDice.Add(D4_3.Show);
                                    PlayersDiceValues.Add(D4_3.getValue());
                                }
                                if (!isD4_4Showin)
                                {
                                    D4_4.Roll();
                                    PlayersDice.Add(D4_4.Show);
                                    PlayersDiceValues.Add(D4_4.getValue());
                                }
                                if (!isD4_5Showin)
                                {
                                    D4_5.Roll();
                                    PlayersDice.Add(D4_5.Show);
                                    PlayersDiceValues.Add(D4_5.getValue());
                                }
                                if (!isD4_6Showin)
                                {
                                    D4_6.Roll();
                                    PlayersDice.Add(D4_6.Show);
                                    PlayersDiceValues.Add(D4_6.getValue());
                                }
                                if (!isD4_7Showin)
                                {
                                    D4_7.Roll();
                                    PlayersDice.Add(D4_7.Show);
                                    PlayersDiceValues.Add(D4_7.getValue());
                                }
                                if (!isD4_8Showin)
                                {
                                    D4_8.Roll();
                                    PlayersDice.Add(D4_8.Show);
                                    PlayersDiceValues.Add(D4_8.getValue());
                                }
                            }
                            else if (inputDice == "9W4" ^ inputDice == "9w4" ^ inputDice == "9D4" ^ inputDice == "9d4")
                            {
                                bool isD4Showin = PlayersDice.Contains(D4.Show);
                                bool isD4_2Showin = PlayersDice.Contains(D4_2.Show);
                                bool isD4_3Showin = PlayersDice.Contains(D4_3.Show);
                                bool isD4_4Showin = PlayersDice.Contains(D4_4.Show);
                                bool isD4_5Showin = PlayersDice.Contains(D4_5.Show);
                                bool isD4_6Showin = PlayersDice.Contains(D4_6.Show);
                                bool isD4_7Showin = PlayersDice.Contains(D4_7.Show);
                                bool isD4_8Showin = PlayersDice.Contains(D4_8.Show);
                                bool isD4_9Showin = PlayersDice.Contains(D4_9.Show);
                                if (!isD4Showin)
                                {
                                    D4.Roll();
                                    PlayersDice.Add(D4.Show);
                                    PlayersDiceValues.Add(D4.getValue());
                                }
                                if (!isD4_2Showin)
                                {
                                    D4_2.Roll();
                                    PlayersDice.Add(D4_2.Show);
                                    PlayersDiceValues.Add(D4_2.getValue());
                                }
                                if (!isD4_3Showin)
                                {
                                    D4_3.Roll();
                                    PlayersDice.Add(D4_3.Show);
                                    PlayersDiceValues.Add(D4_3.getValue());
                                }
                                if (!isD4_4Showin)
                                {
                                    D4_4.Roll();
                                    PlayersDice.Add(D4_4.Show);
                                    PlayersDiceValues.Add(D4_4.getValue());
                                }
                                if (!isD4_5Showin)
                                {
                                    D4_5.Roll();
                                    PlayersDice.Add(D4_5.Show);
                                    PlayersDiceValues.Add(D4_5.getValue());
                                }
                                if (!isD4_6Showin)
                                {
                                    D4_6.Roll();
                                    PlayersDice.Add(D4_6.Show);
                                    PlayersDiceValues.Add(D4_6.getValue());
                                }
                                if (!isD4_7Showin)
                                {
                                    D4_7.Roll();
                                    PlayersDice.Add(D4_7.Show);
                                    PlayersDiceValues.Add(D4_7.getValue());
                                }
                                if (!isD4_8Showin)
                                {
                                    D4_8.Roll();
                                    PlayersDice.Add(D4_8.Show);
                                    PlayersDiceValues.Add(D4_8.getValue());
                                }
                                if (!isD4_9Showin)
                                {
                                    D4_9.Roll();
                                    PlayersDice.Add(D4_9.Show);
                                    PlayersDiceValues.Add(D4_9.getValue());
                                }
                            }
                            else if (inputDice == "10W4" ^ inputDice == "10w4" ^ inputDice == "10D4" ^ inputDice == "10d4")
                            {
                                bool isD4Showin = PlayersDice.Contains(D4.Show);
                                bool isD4_2Showin = PlayersDice.Contains(D4_2.Show);
                                bool isD4_3Showin = PlayersDice.Contains(D4_3.Show);
                                bool isD4_4Showin = PlayersDice.Contains(D4_4.Show);
                                bool isD4_5Showin = PlayersDice.Contains(D4_5.Show);
                                bool isD4_6Showin = PlayersDice.Contains(D4_6.Show);
                                bool isD4_7Showin = PlayersDice.Contains(D4_7.Show);
                                bool isD4_8Showin = PlayersDice.Contains(D4_8.Show);
                                bool isD4_9Showin = PlayersDice.Contains(D4_9.Show);
                                bool isD4_10Showin = PlayersDice.Contains(D4_10.Show);
                                if (!isD4Showin)
                                {
                                    D4.Roll();
                                    PlayersDice.Add(D4.Show);
                                    PlayersDiceValues.Add(D4.getValue());
                                }
                                if (!isD4_2Showin)
                                {
                                    D4_2.Roll();
                                    PlayersDice.Add(D4_2.Show);
                                    PlayersDiceValues.Add(D4_2.getValue());
                                }
                                if (!isD4_3Showin)
                                {
                                    D4_3.Roll();
                                    PlayersDice.Add(D4_3.Show);
                                    PlayersDiceValues.Add(D4_3.getValue());
                                }
                                if (!isD4_4Showin)
                                {
                                    D4_4.Roll();
                                    PlayersDice.Add(D4_4.Show);
                                    PlayersDiceValues.Add(D4_4.getValue());
                                }
                                if (!isD4_5Showin)
                                {
                                    D4_5.Roll();
                                    PlayersDice.Add(D4_5.Show);
                                    PlayersDiceValues.Add(D4_5.getValue());
                                }
                                if (!isD4_6Showin)
                                {
                                    D4_6.Roll();
                                    PlayersDice.Add(D4_6.Show);
                                    PlayersDiceValues.Add(D4_6.getValue());
                                }
                                if (!isD4_7Showin)
                                {
                                    D4_7.Roll();
                                    PlayersDice.Add(D4_7.Show);
                                    PlayersDiceValues.Add(D4_7.getValue());
                                }
                                if (!isD4_8Showin)
                                {
                                    D4_8.Roll();
                                    PlayersDice.Add(D4_8.Show);
                                    PlayersDiceValues.Add(D4_8.getValue());
                                }
                                if (!isD4_9Showin)
                                {
                                    D4_9.Roll();
                                    PlayersDice.Add(D4_9.Show);
                                    PlayersDiceValues.Add(D4_9.getValue());
                                }
                                if (!isD4_10Showin)
                                {
                                    D4_10.Roll();
                                    PlayersDice.Add(D4_10.Show);
                                    PlayersDiceValues.Add(D4_10.getValue());
                                }
                            }

                            #endregion
                            #region D6 If States
                            else if (inputDice == "W6" ^ inputDice == "1W6" ^ inputDice == "w6" ^ inputDice == "1w6" ^ inputDice == "D6" ^ inputDice == "1D6" ^ inputDice == "d6" ^ inputDice == "1d6")
                            {
                                bool isD6Showin = PlayersDice.Contains(D6.Show);
                                if (!isD6Showin)
                                {
                                    D6.Roll();
                                    PlayersDice.Add(D6.Show);
                                    PlayersDiceValues.Add(D6.getValue());
                                }
                            }
                            else if (inputDice == "2W6" ^ inputDice == "2w6" ^ inputDice == "2D6" ^ inputDice == "2d6")
                            {
                                bool isD6Showin = PlayersDice.Contains(D6.Show);
                                bool isD6_2Showin = PlayersDice.Contains(D6_2.Show);
                                if (!isD6Showin)
                                {
                                    D6.Roll();
                                    PlayersDice.Add(D6.Show);
                                    PlayersDiceValues.Add(D6.getValue());
                                }
                                if (!isD6_2Showin)
                                {
                                    D6_2.Roll();
                                    PlayersDice.Add(D6_2.Show);
                                    PlayersDiceValues.Add(D6_2.getValue());
                                }
                            }
                            else if (inputDice == "3W6" ^ inputDice == "3w6" ^ inputDice == "3D6" ^ inputDice == "3d6")
                            {
                                bool isD6Showin = PlayersDice.Contains(D6.Show);
                                bool isD6_2Showin = PlayersDice.Contains(D6_2.Show);
                                bool isD6_3Showin = PlayersDice.Contains(D6_3.Show);
                                if (!isD6Showin)
                                {
                                    D6.Roll();
                                    PlayersDice.Add(D6.Show);
                                    PlayersDiceValues.Add(D6.getValue());
                                }
                                if (!isD6_2Showin)
                                {
                                    D6_2.Roll();
                                    PlayersDice.Add(D6_2.Show);
                                    PlayersDiceValues.Add(D6_2.getValue());
                                }
                                if (!isD6_3Showin)
                                {
                                    D6_3.Roll();
                                    PlayersDice.Add(D6_3.Show);
                                    PlayersDiceValues.Add(D6_3.getValue());
                                }
                            }
                            else if (inputDice == "4W6" ^ inputDice == "4w6" ^ inputDice == "4D6" ^ inputDice == "4d6")
                            {
                                bool isD6Showin = PlayersDice.Contains(D6.Show);
                                bool isD6_2Showin = PlayersDice.Contains(D6_2.Show);
                                bool isD6_3Showin = PlayersDice.Contains(D6_3.Show);
                                bool isD6_4Showin = PlayersDice.Contains(D6_4.Show);
                                if (!isD6Showin)
                                {
                                    D6.Roll();
                                    PlayersDice.Add(D6.Show);
                                    PlayersDiceValues.Add(D6.getValue());
                                }
                                if (!isD6_2Showin)
                                {
                                    D6_2.Roll();
                                    PlayersDice.Add(D6_2.Show);
                                    PlayersDiceValues.Add(D6_2.getValue());
                                }
                                if (!isD6_3Showin)
                                {
                                    D6_3.Roll();
                                    PlayersDice.Add(D6_3.Show);
                                    PlayersDiceValues.Add(D6_3.getValue());
                                }
                                if (!isD6_4Showin)
                                {
                                    D6_4.Roll();
                                    PlayersDice.Add(D6_4.Show);
                                    PlayersDiceValues.Add(D6_4.getValue());
                                }
                            }
                            else if (inputDice == "5W6" ^ inputDice == "5w6" ^ inputDice == "5D6" ^ inputDice == "5d6")
                            {
                                bool isD6Showin = PlayersDice.Contains(D6.Show);
                                bool isD6_2Showin = PlayersDice.Contains(D6_2.Show);
                                bool isD6_3Showin = PlayersDice.Contains(D6_3.Show);
                                bool isD6_4Showin = PlayersDice.Contains(D6_4.Show);
                                bool isD6_5Showin = PlayersDice.Contains(D6_5.Show);
                                if (!isD6Showin)
                                {
                                    D6.Roll();
                                    PlayersDice.Add(D6.Show);
                                    PlayersDiceValues.Add(D6.getValue());
                                }
                                if (!isD6_2Showin)
                                {
                                    D6_2.Roll();
                                    PlayersDice.Add(D6_2.Show);
                                    PlayersDiceValues.Add(D6_2.getValue());
                                }
                                if (!isD6_3Showin)
                                {
                                    D6_3.Roll();
                                    PlayersDice.Add(D6_3.Show);
                                    PlayersDiceValues.Add(D6_3.getValue());
                                }
                                if (!isD6_4Showin)
                                {
                                    D6_4.Roll();
                                    PlayersDice.Add(D6_4.Show);
                                    PlayersDiceValues.Add(D6_4.getValue());
                                }
                                if (!isD6_5Showin)
                                {
                                    D6_5.Roll();
                                    PlayersDice.Add(D6_5.Show);
                                    PlayersDiceValues.Add(D6_5.getValue());
                                }
                            }
                            else if (inputDice == "6W6" ^ inputDice == "6w6" ^ inputDice == "6D6" ^ inputDice == "6d6")
                            {
                                bool isD6Showin = PlayersDice.Contains(D6.Show);
                                bool isD6_2Showin = PlayersDice.Contains(D6_2.Show);
                                bool isD6_3Showin = PlayersDice.Contains(D6_3.Show);
                                bool isD6_4Showin = PlayersDice.Contains(D6_4.Show);
                                bool isD6_5Showin = PlayersDice.Contains(D6_5.Show);
                                bool isD6_6Showin = PlayersDice.Contains(D6_6.Show);
                                if (!isD6Showin)
                                {
                                    D6.Roll();
                                    PlayersDice.Add(D6.Show);
                                    PlayersDiceValues.Add(D6.getValue());
                                }
                                if (!isD6_2Showin)
                                {
                                    D6_2.Roll();
                                    PlayersDice.Add(D6_2.Show);
                                    PlayersDiceValues.Add(D6_2.getValue());
                                }
                                if (!isD6_3Showin)
                                {
                                    D6_3.Roll();
                                    PlayersDice.Add(D6_3.Show);
                                    PlayersDiceValues.Add(D6_3.getValue());
                                }
                                if (!isD6_4Showin)
                                {
                                    D6_4.Roll();
                                    PlayersDice.Add(D6_4.Show);
                                    PlayersDiceValues.Add(D6_4.getValue());
                                }
                                if (!isD6_5Showin)
                                {
                                    D6_5.Roll();
                                    PlayersDice.Add(D6_5.Show);
                                    PlayersDiceValues.Add(D6_5.getValue());
                                }
                                if (!isD6_6Showin)
                                {
                                    D6_6.Roll();
                                    PlayersDice.Add(D6_6.Show);
                                    PlayersDiceValues.Add(D6_6.getValue());
                                }
                            }
                            else if (inputDice == "7W6" ^ inputDice == "7w6" ^ inputDice == "7D6" ^ inputDice == "7d6")
                            {
                                bool isD6Showin = PlayersDice.Contains(D6.Show);
                                bool isD6_2Showin = PlayersDice.Contains(D6_2.Show);
                                bool isD6_3Showin = PlayersDice.Contains(D6_3.Show);
                                bool isD6_4Showin = PlayersDice.Contains(D6_4.Show);
                                bool isD6_5Showin = PlayersDice.Contains(D6_5.Show);
                                bool isD6_6Showin = PlayersDice.Contains(D6_6.Show);
                                bool isD6_7Showin = PlayersDice.Contains(D6_7.Show);
                                if (!isD6Showin)
                                {
                                    D6.Roll();
                                    PlayersDice.Add(D6.Show);
                                    PlayersDiceValues.Add(D6.getValue());
                                }
                                if (!isD6_2Showin)
                                {
                                    D6_2.Roll();
                                    PlayersDice.Add(D6_2.Show);
                                    PlayersDiceValues.Add(D6_2.getValue());
                                }
                                if (!isD6_3Showin)
                                {
                                    D6_3.Roll();
                                    PlayersDice.Add(D6_3.Show);
                                    PlayersDiceValues.Add(D6_3.getValue());
                                }
                                if (!isD6_4Showin)
                                {
                                    D6_4.Roll();
                                    PlayersDice.Add(D6_4.Show);
                                    PlayersDiceValues.Add(D6_4.getValue());
                                }
                                if (!isD6_5Showin)
                                {
                                    D6_5.Roll();
                                    PlayersDice.Add(D6_5.Show);
                                    PlayersDiceValues.Add(D6_5.getValue());
                                }
                                if (!isD6_6Showin)
                                {
                                    D6_6.Roll();
                                    PlayersDice.Add(D6_6.Show);
                                    PlayersDiceValues.Add(D6_6.getValue());
                                }
                                if (!isD6_7Showin)
                                {
                                    D6_7.Roll();
                                    PlayersDice.Add(D6_7.Show);
                                    PlayersDiceValues.Add(D6_7.getValue());
                                }
                            }
                            else if (inputDice == "8W6" ^ inputDice == "8w6" ^ inputDice == "8D6" ^ inputDice == "8d6")
                            {
                                bool isD6Showin = PlayersDice.Contains(D6.Show);
                                bool isD6_2Showin = PlayersDice.Contains(D6_2.Show);
                                bool isD6_3Showin = PlayersDice.Contains(D6_3.Show);
                                bool isD6_4Showin = PlayersDice.Contains(D6_4.Show);
                                bool isD6_5Showin = PlayersDice.Contains(D6_5.Show);
                                bool isD6_6Showin = PlayersDice.Contains(D6_6.Show);
                                bool isD6_7Showin = PlayersDice.Contains(D6_7.Show);
                                bool isD6_8Showin = PlayersDice.Contains(D6_8.Show);
                                if (!isD6Showin)
                                {
                                    D6.Roll();
                                    PlayersDice.Add(D6.Show);
                                    PlayersDiceValues.Add(D6.getValue());
                                }
                                if (!isD6_2Showin)
                                {
                                    D6_2.Roll();
                                    PlayersDice.Add(D6_2.Show);
                                    PlayersDiceValues.Add(D6_2.getValue());
                                }
                                if (!isD6_3Showin)
                                {
                                    D6_3.Roll();
                                    PlayersDice.Add(D6_3.Show);
                                    PlayersDiceValues.Add(D6_3.getValue());
                                }
                                if (!isD6_4Showin)
                                {
                                    D6_4.Roll();
                                    PlayersDice.Add(D6_4.Show);
                                    PlayersDiceValues.Add(D6_4.getValue());
                                }
                                if (!isD6_5Showin)
                                {
                                    D6_5.Roll();
                                    PlayersDice.Add(D6_5.Show);
                                    PlayersDiceValues.Add(D6_5.getValue());
                                }
                                if (!isD6_6Showin)
                                {
                                    D6_6.Roll();
                                    PlayersDice.Add(D6_6.Show);
                                    PlayersDiceValues.Add(D6_6.getValue());
                                }
                                if (!isD6_7Showin)
                                {
                                    D6_7.Roll();
                                    PlayersDice.Add(D6_7.Show);
                                    PlayersDiceValues.Add(D6_7.getValue());
                                }
                                if (!isD6_8Showin)
                                {
                                    D6_8.Roll();
                                    PlayersDice.Add(D6_8.Show);
                                    PlayersDiceValues.Add(D6_8.getValue());
                                }
                            }
                            else if (inputDice == "9W6" ^ inputDice == "9w6" ^ inputDice == "9D6" ^ inputDice == "9d6")
                            {
                                bool isD6Showin = PlayersDice.Contains(D6.Show);
                                bool isD6_2Showin = PlayersDice.Contains(D6_2.Show);
                                bool isD6_3Showin = PlayersDice.Contains(D6_3.Show);
                                bool isD6_4Showin = PlayersDice.Contains(D6_4.Show);
                                bool isD6_5Showin = PlayersDice.Contains(D6_5.Show);
                                bool isD6_6Showin = PlayersDice.Contains(D6_6.Show);
                                bool isD6_7Showin = PlayersDice.Contains(D6_7.Show);
                                bool isD6_8Showin = PlayersDice.Contains(D6_8.Show);
                                bool isD6_9Showin = PlayersDice.Contains(D6_9.Show);
                                if (!isD6Showin)
                                {
                                    D6.Roll();
                                    PlayersDice.Add(D6.Show);
                                    PlayersDiceValues.Add(D6.getValue());
                                }
                                if (!isD6_2Showin)
                                {
                                    D6_2.Roll();
                                    PlayersDice.Add(D6_2.Show);
                                    PlayersDiceValues.Add(D6_2.getValue());
                                }
                                if (!isD6_3Showin)
                                {
                                    D6_3.Roll();
                                    PlayersDice.Add(D6_3.Show);
                                    PlayersDiceValues.Add(D6_3.getValue());
                                }
                                if (!isD6_4Showin)
                                {
                                    D6_4.Roll();
                                    PlayersDice.Add(D6_4.Show);
                                    PlayersDiceValues.Add(D6_4.getValue());
                                }
                                if (!isD6_5Showin)
                                {
                                    D6_5.Roll();
                                    PlayersDice.Add(D6_5.Show);
                                    PlayersDiceValues.Add(D6_5.getValue());
                                }
                                if (!isD6_6Showin)
                                {
                                    D6_6.Roll();
                                    PlayersDice.Add(D6_6.Show);
                                    PlayersDiceValues.Add(D6_6.getValue());
                                }
                                if (!isD6_7Showin)
                                {
                                    D6_7.Roll();
                                    PlayersDice.Add(D6_7.Show);
                                    PlayersDiceValues.Add(D6_7.getValue());
                                }
                                if (!isD6_8Showin)
                                {
                                    D6_8.Roll();
                                    PlayersDice.Add(D6_8.Show);
                                    PlayersDiceValues.Add(D6_8.getValue());
                                }
                                if (!isD6_9Showin)
                                {
                                    D6_9.Roll();
                                    PlayersDice.Add(D6_9.Show);
                                    PlayersDiceValues.Add(D6_9.getValue());
                                }
                            }
                            else if (inputDice == "10W6" ^ inputDice == "10w6" ^ inputDice == "10D6" ^ inputDice == "10d6")
                            {
                                bool isD6Showin = PlayersDice.Contains(D6.Show);
                                bool isD6_2Showin = PlayersDice.Contains(D6_2.Show);
                                bool isD6_3Showin = PlayersDice.Contains(D6_3.Show);
                                bool isD6_4Showin = PlayersDice.Contains(D6_4.Show);
                                bool isD6_5Showin = PlayersDice.Contains(D6_5.Show);
                                bool isD6_6Showin = PlayersDice.Contains(D6_6.Show);
                                bool isD6_7Showin = PlayersDice.Contains(D6_7.Show);
                                bool isD6_8Showin = PlayersDice.Contains(D6_8.Show);
                                bool isD6_9Showin = PlayersDice.Contains(D6_9.Show);
                                bool isD6_10Showin = PlayersDice.Contains(D6_10.Show);
                                if (!isD6Showin)
                                {
                                    D6.Roll();
                                    PlayersDice.Add(D6.Show);
                                    PlayersDiceValues.Add(D6.getValue());
                                }
                                if (!isD6_2Showin)
                                {
                                    D6_2.Roll();
                                    PlayersDice.Add(D6_2.Show);
                                    PlayersDiceValues.Add(D6_2.getValue());
                                }
                                if (!isD6_3Showin)
                                {
                                    D6_3.Roll();
                                    PlayersDice.Add(D6_3.Show);
                                    PlayersDiceValues.Add(D6_3.getValue());
                                }
                                if (!isD6_4Showin)
                                {
                                    D6_4.Roll();
                                    PlayersDice.Add(D6_4.Show);
                                    PlayersDiceValues.Add(D6_4.getValue());
                                }
                                if (!isD6_5Showin)
                                {
                                    D6_5.Roll();
                                    PlayersDice.Add(D6_5.Show);
                                    PlayersDiceValues.Add(D6_5.getValue());
                                }
                                if (!isD6_6Showin)
                                {
                                    D6_6.Roll();
                                    PlayersDice.Add(D6_6.Show);
                                    PlayersDiceValues.Add(D6_6.getValue());
                                }
                                if (!isD6_7Showin)
                                {
                                    D6_7.Roll();
                                    PlayersDice.Add(D6_7.Show);
                                    PlayersDiceValues.Add(D6_7.getValue());
                                }
                                if (!isD6_8Showin)
                                {
                                    D6_8.Roll();
                                    PlayersDice.Add(D6_8.Show);
                                    PlayersDiceValues.Add(D6_8.getValue());
                                }
                                if (!isD6_9Showin)
                                {
                                    D6_9.Roll();
                                    PlayersDice.Add(D6_9.Show);
                                    PlayersDiceValues.Add(D6_9.getValue());
                                }
                                if (!isD6_10Showin)
                                {
                                    D6_10.Roll();
                                    PlayersDice.Add(D6_10.Show);
                                    PlayersDiceValues.Add(D6_10.getValue());
                                }
                            }
                            #endregion
                            #region D8 If States
                            else if (inputDice == "W8" ^ inputDice == "1W8" ^ inputDice == "w8" ^ inputDice == "1w8" ^ inputDice == "D8" ^ inputDice == "1D8" ^ inputDice == "d8" ^ inputDice == "1d8")
                            {
                                bool isD8Showin = PlayersDice.Contains(D8.Show);
                                if (!isD8Showin)
                                {
                                    D8.Roll();
                                    PlayersDice.Add(D8.Show);
                                    PlayersDiceValues.Add(D8.getValue());
                                }
                            }
                            else if (inputDice == "2W8" ^ inputDice == "2w8" ^ inputDice == "2D8" ^ inputDice == "2d8")
                            {
                                bool isD8Showin = PlayersDice.Contains(D8.Show);
                                bool isD8_2Showin = PlayersDice.Contains(D8_2.Show);
                                if (!isD8Showin)
                                {
                                    D8.Roll();
                                    PlayersDice.Add(D8.Show);
                                    PlayersDiceValues.Add(D8.getValue());
                                }
                                if (!isD8_2Showin)
                                {
                                    D8_2.Roll();
                                    PlayersDice.Add(D8_2.Show);
                                    PlayersDiceValues.Add(D8_2.getValue());
                                }
                            }
                            else if (inputDice == "3W8" ^ inputDice == "3w8" ^ inputDice == "3D8" ^ inputDice == "3d8")
                            {
                                bool isD8Showin = PlayersDice.Contains(D8.Show);
                                bool isD8_2Showin = PlayersDice.Contains(D8_2.Show);
                                bool isD8_3Showin = PlayersDice.Contains(D8_3.Show);
                                if (!isD8Showin)
                                {
                                    D8.Roll();
                                    PlayersDice.Add(D8.Show);
                                    PlayersDiceValues.Add(D8.getValue());
                                }
                                if (!isD8_2Showin)
                                {
                                    D8_2.Roll();
                                    PlayersDice.Add(D8_2.Show);
                                    PlayersDiceValues.Add(D8_2.getValue());
                                }
                                if (!isD8_3Showin)
                                {
                                    D8_3.Roll();
                                    PlayersDice.Add(D8_3.Show);
                                    PlayersDiceValues.Add(D8_3.getValue());
                                }
                            }
                            else if (inputDice == "4W8" ^ inputDice == "4w8" ^ inputDice == "4D8" ^ inputDice == "4d8")
                            {
                                bool isD8Showin = PlayersDice.Contains(D8.Show);
                                bool isD8_2Showin = PlayersDice.Contains(D8_2.Show);
                                bool isD8_3Showin = PlayersDice.Contains(D8_3.Show);
                                bool isD8_4Showin = PlayersDice.Contains(D8_4.Show);
                                if (!isD8Showin)
                                {
                                    D8.Roll();
                                    PlayersDice.Add(D8.Show);
                                    PlayersDiceValues.Add(D8.getValue());
                                }
                                if (!isD8_2Showin)
                                {
                                    D8_2.Roll();
                                    PlayersDice.Add(D8_2.Show);
                                    PlayersDiceValues.Add(D8_2.getValue());
                                }
                                if (!isD8_3Showin)
                                {
                                    D8_3.Roll();
                                    PlayersDice.Add(D8_3.Show);
                                    PlayersDiceValues.Add(D8_3.getValue());
                                }
                                if (!isD8_4Showin)
                                {
                                    D8_4.Roll();
                                    PlayersDice.Add(D8_4.Show);
                                    PlayersDiceValues.Add(D8_4.getValue());
                                }
                            }
                            else if (inputDice == "5W8" ^ inputDice == "5w8" ^ inputDice == "5D8" ^ inputDice == "5d8")
                            {
                                bool isD8Showin = PlayersDice.Contains(D8.Show);
                                bool isD8_2Showin = PlayersDice.Contains(D8_2.Show);
                                bool isD8_3Showin = PlayersDice.Contains(D8_3.Show);
                                bool isD8_4Showin = PlayersDice.Contains(D8_4.Show);
                                bool isD8_5Showin = PlayersDice.Contains(D8_5.Show);
                                if (!isD8Showin)
                                {
                                    D8.Roll();
                                    PlayersDice.Add(D8.Show);
                                    PlayersDiceValues.Add(D8.getValue());
                                }
                                if (!isD8_2Showin)
                                {
                                    D8_2.Roll();
                                    PlayersDice.Add(D8_2.Show);
                                    PlayersDiceValues.Add(D8_2.getValue());
                                }
                                if (!isD8_3Showin)
                                {
                                    D8_3.Roll();
                                    PlayersDice.Add(D8_3.Show);
                                    PlayersDiceValues.Add(D8_3.getValue());
                                }
                                if (!isD8_4Showin)
                                {
                                    D8_4.Roll();
                                    PlayersDice.Add(D8_4.Show);
                                    PlayersDiceValues.Add(D8_4.getValue());
                                }
                                if (!isD8_5Showin)
                                {
                                    D8_5.Roll();
                                    PlayersDice.Add(D8_5.Show);
                                    PlayersDiceValues.Add(D8_5.getValue());
                                }
                            }
                            else if (inputDice == "6W8" ^ inputDice == "6w8" ^ inputDice == "6D8" ^ inputDice == "6d8")
                            {
                                bool isD8Showin = PlayersDice.Contains(D8.Show);
                                bool isD8_2Showin = PlayersDice.Contains(D8_2.Show);
                                bool isD8_3Showin = PlayersDice.Contains(D8_3.Show);
                                bool isD8_4Showin = PlayersDice.Contains(D8_4.Show);
                                bool isD8_5Showin = PlayersDice.Contains(D8_5.Show);
                                bool isD8_6Showin = PlayersDice.Contains(D8_6.Show);
                                if (!isD8Showin)
                                {
                                    D8.Roll();
                                    PlayersDice.Add(D8.Show);
                                    PlayersDiceValues.Add(D8.getValue());
                                }
                                if (!isD8_2Showin)
                                {
                                    D8_2.Roll();
                                    PlayersDice.Add(D8_2.Show);
                                    PlayersDiceValues.Add(D8_2.getValue());
                                }
                                if (!isD8_3Showin)
                                {
                                    D8_3.Roll();
                                    PlayersDice.Add(D8_3.Show);
                                    PlayersDiceValues.Add(D8_3.getValue());
                                }
                                if (!isD8_4Showin)
                                {
                                    D8_4.Roll();
                                    PlayersDice.Add(D8_4.Show);
                                    PlayersDiceValues.Add(D8_4.getValue());
                                }
                                if (!isD8_5Showin)
                                {
                                    D8_5.Roll();
                                    PlayersDice.Add(D8_5.Show);
                                    PlayersDiceValues.Add(D8_5.getValue());
                                }
                                if (!isD8_6Showin)
                                {
                                    D8_6.Roll();
                                    PlayersDice.Add(D8_6.Show);
                                    PlayersDiceValues.Add(D8_6.getValue());
                                }
                            }
                            else if (inputDice == "7W8" ^ inputDice == "7w8" ^ inputDice == "7D8" ^ inputDice == "7d8")
                            {
                                bool isD8Showin = PlayersDice.Contains(D8.Show);
                                bool isD8_2Showin = PlayersDice.Contains(D8_2.Show);
                                bool isD8_3Showin = PlayersDice.Contains(D8_3.Show);
                                bool isD8_4Showin = PlayersDice.Contains(D8_4.Show);
                                bool isD8_5Showin = PlayersDice.Contains(D8_5.Show);
                                bool isD8_6Showin = PlayersDice.Contains(D8_6.Show);
                                bool isD8_7Showin = PlayersDice.Contains(D8_7.Show);
                                if (!isD8Showin)
                                {
                                    D8.Roll();
                                    PlayersDice.Add(D8.Show);
                                    PlayersDiceValues.Add(D8.getValue());
                                }
                                if (!isD8_2Showin)
                                {
                                    D8_2.Roll();
                                    PlayersDice.Add(D8_2.Show);
                                    PlayersDiceValues.Add(D8_2.getValue());
                                }
                                if (!isD8_3Showin)
                                {
                                    D8_3.Roll();
                                    PlayersDice.Add(D8_3.Show);
                                    PlayersDiceValues.Add(D8_3.getValue());
                                }
                                if (!isD8_4Showin)
                                {
                                    D8_4.Roll();
                                    PlayersDice.Add(D8_4.Show);
                                    PlayersDiceValues.Add(D8_4.getValue());
                                }
                                if (!isD8_5Showin)
                                {
                                    D8_5.Roll();
                                    PlayersDice.Add(D8_5.Show);
                                    PlayersDiceValues.Add(D8_5.getValue());
                                }
                                if (!isD8_6Showin)
                                {
                                    D8_6.Roll();
                                    PlayersDice.Add(D8_6.Show);
                                    PlayersDiceValues.Add(D8_6.getValue());
                                }
                                if (!isD8_7Showin)
                                {
                                    D8_7.Roll();
                                    PlayersDice.Add(D8_7.Show);
                                    PlayersDiceValues.Add(D8_7.getValue());
                                }
                            }
                            else if (inputDice == "8W8" ^ inputDice == "8w8" ^ inputDice == "8D8" ^ inputDice == "8d8")
                            {
                                bool isD8Showin = PlayersDice.Contains(D8.Show);
                                bool isD8_2Showin = PlayersDice.Contains(D8_2.Show);
                                bool isD8_3Showin = PlayersDice.Contains(D8_3.Show);
                                bool isD8_4Showin = PlayersDice.Contains(D8_4.Show);
                                bool isD8_5Showin = PlayersDice.Contains(D8_5.Show);
                                bool isD8_6Showin = PlayersDice.Contains(D8_6.Show);
                                bool isD8_7Showin = PlayersDice.Contains(D8_7.Show);
                                bool isD8_8Showin = PlayersDice.Contains(D8_8.Show);
                                if (!isD8Showin)
                                {
                                    D8.Roll();
                                    PlayersDice.Add(D8.Show);
                                    PlayersDiceValues.Add(D8.getValue());
                                }
                                if (!isD8_2Showin)
                                {
                                    D8_2.Roll();
                                    PlayersDice.Add(D8_2.Show);
                                    PlayersDiceValues.Add(D8_2.getValue());
                                }
                                if (!isD8_3Showin)
                                {
                                    D8_3.Roll();
                                    PlayersDice.Add(D8_3.Show);
                                    PlayersDiceValues.Add(D8_3.getValue());
                                }
                                if (!isD8_4Showin)
                                {
                                    D8_4.Roll();
                                    PlayersDice.Add(D8_4.Show);
                                    PlayersDiceValues.Add(D8_4.getValue());
                                }
                                if (!isD8_5Showin)
                                {
                                    D8_5.Roll();
                                    PlayersDice.Add(D8_5.Show);
                                    PlayersDiceValues.Add(D8_5.getValue());
                                }
                                if (!isD8_6Showin)
                                {
                                    D8_6.Roll();
                                    PlayersDice.Add(D8_6.Show);
                                    PlayersDiceValues.Add(D8_6.getValue());
                                }
                                if (!isD8_7Showin)
                                {
                                    D8_7.Roll();
                                    PlayersDice.Add(D8_7.Show);
                                    PlayersDiceValues.Add(D8_7.getValue());
                                }
                                if (!isD8_8Showin)
                                {
                                    D8_8.Roll();
                                    PlayersDice.Add(D8_8.Show);
                                    PlayersDiceValues.Add(D8_8.getValue());
                                }
                            }
                            else if (inputDice == "9W8" ^ inputDice == "9w8" ^ inputDice == "9D8" ^ inputDice == "9d8")
                            {
                                bool isD8Showin = PlayersDice.Contains(D8.Show);
                                bool isD8_2Showin = PlayersDice.Contains(D8_2.Show);
                                bool isD8_3Showin = PlayersDice.Contains(D8_3.Show);
                                bool isD8_4Showin = PlayersDice.Contains(D8_4.Show);
                                bool isD8_5Showin = PlayersDice.Contains(D8_5.Show);
                                bool isD8_6Showin = PlayersDice.Contains(D8_6.Show);
                                bool isD8_7Showin = PlayersDice.Contains(D8_7.Show);
                                bool isD8_8Showin = PlayersDice.Contains(D8_8.Show);
                                bool isD8_9Showin = PlayersDice.Contains(D8_9.Show);
                                if (!isD8Showin)
                                {
                                    D8.Roll();
                                    PlayersDice.Add(D8.Show);
                                    PlayersDiceValues.Add(D8.getValue());
                                }
                                if (!isD8_2Showin)
                                {
                                    D8_2.Roll();
                                    PlayersDice.Add(D8_2.Show);
                                    PlayersDiceValues.Add(D8_2.getValue());
                                }
                                if (!isD8_3Showin)
                                {
                                    D8_3.Roll();
                                    PlayersDice.Add(D8_3.Show);
                                    PlayersDiceValues.Add(D8_3.getValue());
                                }
                                if (!isD8_4Showin)
                                {
                                    D8_4.Roll();
                                    PlayersDice.Add(D8_4.Show);
                                    PlayersDiceValues.Add(D8_4.getValue());
                                }
                                if (!isD8_5Showin)
                                {
                                    D8_5.Roll();
                                    PlayersDice.Add(D8_5.Show);
                                    PlayersDiceValues.Add(D8_5.getValue());
                                }
                                if (!isD8_6Showin)
                                {
                                    D8_6.Roll();
                                    PlayersDice.Add(D8_6.Show);
                                    PlayersDiceValues.Add(D8_6.getValue());
                                }
                                if (!isD8_7Showin)
                                {
                                    D8_7.Roll();
                                    PlayersDice.Add(D8_7.Show);
                                    PlayersDiceValues.Add(D8_7.getValue());
                                }
                                if (!isD8_8Showin)
                                {
                                    D8_8.Roll();
                                    PlayersDice.Add(D8_8.Show);
                                    PlayersDiceValues.Add(D8_8.getValue());
                                }
                                if (!isD8_9Showin)
                                {
                                    D8_9.Roll();
                                    PlayersDice.Add(D8_9.Show);
                                    PlayersDiceValues.Add(D8_9.getValue());
                                }
                            }
                            else if (inputDice == "10W8" ^ inputDice == "10w8" ^ inputDice == "10D8" ^ inputDice == "10d8")
                            {
                                bool isD8Showin = PlayersDice.Contains(D8.Show);
                                bool isD8_2Showin = PlayersDice.Contains(D8_2.Show);
                                bool isD8_3Showin = PlayersDice.Contains(D8_3.Show);
                                bool isD8_4Showin = PlayersDice.Contains(D8_4.Show);
                                bool isD8_5Showin = PlayersDice.Contains(D8_5.Show);
                                bool isD8_6Showin = PlayersDice.Contains(D8_6.Show);
                                bool isD8_7Showin = PlayersDice.Contains(D8_7.Show);
                                bool isD8_8Showin = PlayersDice.Contains(D8_8.Show);
                                bool isD8_9Showin = PlayersDice.Contains(D8_9.Show);
                                bool isD8_10Showin = PlayersDice.Contains(D8_10.Show);
                                if (!isD8Showin)
                                {
                                    D8.Roll();
                                    PlayersDice.Add(D8.Show);
                                    PlayersDiceValues.Add(D8.getValue());
                                }
                                if (!isD8_2Showin)
                                {
                                    D8_2.Roll();
                                    PlayersDice.Add(D8_2.Show);
                                    PlayersDiceValues.Add(D8_2.getValue());
                                }
                                if (!isD8_3Showin)
                                {
                                    D8_3.Roll();
                                    PlayersDice.Add(D8_3.Show);
                                    PlayersDiceValues.Add(D8_3.getValue());
                                }
                                if (!isD8_4Showin)
                                {
                                    D8_4.Roll();
                                    PlayersDice.Add(D8_4.Show);
                                    PlayersDiceValues.Add(D8_4.getValue());
                                }
                                if (!isD8_5Showin)
                                {
                                    D8_5.Roll();
                                    PlayersDice.Add(D8_5.Show);
                                    PlayersDiceValues.Add(D8_5.getValue());
                                }
                                if (!isD8_6Showin)
                                {
                                    D8_6.Roll();
                                    PlayersDice.Add(D8_6.Show);
                                    PlayersDiceValues.Add(D8_6.getValue());
                                }
                                if (!isD8_7Showin)
                                {
                                    D8_7.Roll();
                                    PlayersDice.Add(D8_7.Show);
                                    PlayersDiceValues.Add(D8_7.getValue());
                                }
                                if (!isD8_8Showin)
                                {
                                    D8_8.Roll();
                                    PlayersDice.Add(D8_8.Show);
                                    PlayersDiceValues.Add(D8_8.getValue());
                                }
                                if (!isD8_9Showin)
                                {
                                    D8_9.Roll();
                                    PlayersDice.Add(D8_9.Show);
                                    PlayersDiceValues.Add(D8_9.getValue());
                                }
                                if (!isD8_10Showin)
                                {
                                    D8_10.Roll();
                                    PlayersDice.Add(D8_10.Show);
                                    PlayersDiceValues.Add(D8_10.getValue());
                                }
                            }

                            #endregion
                            #region D10 If States
                            else if (inputDice == "W10" ^ inputDice == "1W10" ^ inputDice == "w10" ^ inputDice == "1w10" ^ inputDice == "D10" ^ inputDice == "1D10" ^ inputDice == "d10" ^ inputDice == "1d10")
                            {
                                bool isD10Showin = PlayersDice.Contains(D10.Show);
                                if (!isD10Showin)
                                {
                                    D10.Roll();
                                    PlayersDice.Add(D10.Show);
                                    PlayersDiceValues.Add(D10.getValue());
                                }
                            }
                            else if (inputDice == "2W10" ^ inputDice == "2w10" ^ inputDice == "2D10" ^ inputDice == "2d10")
                            {
                                bool isD10Showin = PlayersDice.Contains(D10.Show);
                                bool isD10_2Showin = PlayersDice.Contains(D10_2.Show);
                                if (!isD10Showin)
                                {
                                    D10.Roll();
                                    PlayersDice.Add(D10.Show);
                                    PlayersDiceValues.Add(D10.getValue());
                                }
                                if (!isD10_2Showin)
                                {
                                    D10_2.Roll();
                                    PlayersDice.Add(D10_2.Show);
                                    PlayersDiceValues.Add(D10_2.getValue());
                                }
                            }
                            else if (inputDice == "3W10" ^ inputDice == "3w10" ^ inputDice == "3D10" ^ inputDice == "3d10")
                            {
                                bool isD10Showin = PlayersDice.Contains(D10.Show);
                                bool isD10_2Showin = PlayersDice.Contains(D10_2.Show);
                                bool isD10_3Showin = PlayersDice.Contains(D10_3.Show);
                                if (!isD10Showin)
                                {
                                    D10.Roll();
                                    PlayersDice.Add(D10.Show);
                                    PlayersDiceValues.Add(D10.getValue());
                                }
                                if (!isD10_2Showin)
                                {
                                    D10_2.Roll();
                                    PlayersDice.Add(D10_2.Show);
                                    PlayersDiceValues.Add(D10_2.getValue());
                                }
                                if (!isD10_3Showin)
                                {
                                    D10_3.Roll();
                                    PlayersDice.Add(D10_3.Show);
                                    PlayersDiceValues.Add(D10_3.getValue());
                                }
                            }
                            else if (inputDice == "4W10" ^ inputDice == "4w10" ^ inputDice == "4D10" ^ inputDice == "4d10")
                            {
                                bool isD10Showin = PlayersDice.Contains(D10.Show);
                                bool isD10_2Showin = PlayersDice.Contains(D10_2.Show);
                                bool isD10_3Showin = PlayersDice.Contains(D10_3.Show);
                                bool isD10_4Showin = PlayersDice.Contains(D10_4.Show);
                                if (!isD10Showin)
                                {
                                    D10.Roll();
                                    PlayersDice.Add(D10.Show);
                                    PlayersDiceValues.Add(D10.getValue());
                                }
                                if (!isD10_2Showin)
                                {
                                    D10_2.Roll();
                                    PlayersDice.Add(D10_2.Show);
                                    PlayersDiceValues.Add(D10_2.getValue());
                                }
                                if (!isD10_3Showin)
                                {
                                    D10_3.Roll();
                                    PlayersDice.Add(D10_3.Show);
                                    PlayersDiceValues.Add(D10_3.getValue());
                                }
                                if (!isD10_4Showin)
                                {
                                    D10_4.Roll();
                                    PlayersDice.Add(D10_4.Show);
                                    PlayersDiceValues.Add(D10_4.getValue());
                                }
                            }
                            else if (inputDice == "5W10" ^ inputDice == "5w10" ^ inputDice == "5D10" ^ inputDice == "5d10")
                            {
                                bool isD10Showin = PlayersDice.Contains(D10.Show);
                                bool isD10_2Showin = PlayersDice.Contains(D10_2.Show);
                                bool isD10_3Showin = PlayersDice.Contains(D10_3.Show);
                                bool isD10_4Showin = PlayersDice.Contains(D10_4.Show);
                                bool isD10_5Showin = PlayersDice.Contains(D10_5.Show);
                                if (!isD10Showin)
                                {
                                    D10.Roll();
                                    PlayersDice.Add(D10.Show);
                                    PlayersDiceValues.Add(D10.getValue());
                                }
                                if (!isD10_2Showin)
                                {
                                    D10_2.Roll();
                                    PlayersDice.Add(D10_2.Show);
                                    PlayersDiceValues.Add(D10_2.getValue());
                                }
                                if (!isD10_3Showin)
                                {
                                    D10_3.Roll();
                                    PlayersDice.Add(D10_3.Show);
                                    PlayersDiceValues.Add(D10_3.getValue());
                                }
                                if (!isD10_4Showin)
                                {
                                    D10_4.Roll();
                                    PlayersDice.Add(D10_4.Show);
                                    PlayersDiceValues.Add(D10_4.getValue());
                                }
                                if (!isD10_5Showin)
                                {
                                    D10_5.Roll();
                                    PlayersDice.Add(D10_5.Show);
                                    PlayersDiceValues.Add(D10_5.getValue());
                                }
                            }
                            else if (inputDice == "6W10" ^ inputDice == "6w10" ^ inputDice == "6D10" ^ inputDice == "6d10")
                            {
                                bool isD10Showin = PlayersDice.Contains(D10.Show);
                                bool isD10_2Showin = PlayersDice.Contains(D10_2.Show);
                                bool isD10_3Showin = PlayersDice.Contains(D10_3.Show);
                                bool isD10_4Showin = PlayersDice.Contains(D10_4.Show);
                                bool isD10_5Showin = PlayersDice.Contains(D10_5.Show);
                                bool isD10_6Showin = PlayersDice.Contains(D10_6.Show);
                                if (!isD10Showin)
                                {
                                    D10.Roll();
                                    PlayersDice.Add(D10.Show);
                                    PlayersDiceValues.Add(D10.getValue());
                                }
                                if (!isD10_2Showin)
                                {
                                    D10_2.Roll();
                                    PlayersDice.Add(D10_2.Show);
                                    PlayersDiceValues.Add(D10_2.getValue());
                                }
                                if (!isD10_3Showin)
                                {
                                    D10_3.Roll();
                                    PlayersDice.Add(D10_3.Show);
                                    PlayersDiceValues.Add(D10_3.getValue());
                                }
                                if (!isD10_4Showin)
                                {
                                    D10_4.Roll();
                                    PlayersDice.Add(D10_4.Show);
                                    PlayersDiceValues.Add(D10_4.getValue());
                                }
                                if (!isD10_5Showin)
                                {
                                    D10_5.Roll();
                                    PlayersDice.Add(D10_5.Show);
                                    PlayersDiceValues.Add(D10_5.getValue());
                                }
                                if (!isD10_6Showin)
                                {
                                    D10_6.Roll();
                                    PlayersDice.Add(D10_6.Show);
                                    PlayersDiceValues.Add(D10_6.getValue());
                                }
                            }
                            else if (inputDice == "7W10" ^ inputDice == "7w10" ^ inputDice == "7D10" ^ inputDice == "7d10")
                            {
                                bool isD10Showin = PlayersDice.Contains(D10.Show);
                                bool isD10_2Showin = PlayersDice.Contains(D10_2.Show);
                                bool isD10_3Showin = PlayersDice.Contains(D10_3.Show);
                                bool isD10_4Showin = PlayersDice.Contains(D10_4.Show);
                                bool isD10_5Showin = PlayersDice.Contains(D10_5.Show);
                                bool isD10_6Showin = PlayersDice.Contains(D10_6.Show);
                                bool isD10_7Showin = PlayersDice.Contains(D10_7.Show);
                                if (!isD10Showin)
                                {
                                    D10.Roll();
                                    PlayersDice.Add(D10.Show);
                                    PlayersDiceValues.Add(D10.getValue());
                                }
                                if (!isD10_2Showin)
                                {
                                    D10_2.Roll();
                                    PlayersDice.Add(D10_2.Show);
                                    PlayersDiceValues.Add(D10_2.getValue());
                                }
                                if (!isD10_3Showin)
                                {
                                    D10_3.Roll();
                                    PlayersDice.Add(D10_3.Show);
                                    PlayersDiceValues.Add(D10_3.getValue());
                                }
                                if (!isD10_4Showin)
                                {
                                    D10_4.Roll();
                                    PlayersDice.Add(D10_4.Show);
                                    PlayersDiceValues.Add(D10_4.getValue());
                                }
                                if (!isD10_5Showin)
                                {
                                    D10_5.Roll();
                                    PlayersDice.Add(D10_5.Show);
                                    PlayersDiceValues.Add(D10_5.getValue());
                                }
                                if (!isD10_6Showin)
                                {
                                    D10_6.Roll();
                                    PlayersDice.Add(D10_6.Show);
                                    PlayersDiceValues.Add(D10_6.getValue());
                                }
                                if (!isD10_7Showin)
                                {
                                    D10_7.Roll();
                                    PlayersDice.Add(D10_7.Show);
                                    PlayersDiceValues.Add(D10_7.getValue());
                                }
                            }
                            else if (inputDice == "8W10" ^ inputDice == "8w10" ^ inputDice == "8D10" ^ inputDice == "8d10")
                            {
                                bool isD10Showin = PlayersDice.Contains(D10.Show);
                                bool isD10_2Showin = PlayersDice.Contains(D10_2.Show);
                                bool isD10_3Showin = PlayersDice.Contains(D10_3.Show);
                                bool isD10_4Showin = PlayersDice.Contains(D10_4.Show);
                                bool isD10_5Showin = PlayersDice.Contains(D10_5.Show);
                                bool isD10_6Showin = PlayersDice.Contains(D10_6.Show);
                                bool isD10_7Showin = PlayersDice.Contains(D10_7.Show);
                                bool isD10_8Showin = PlayersDice.Contains(D10_8.Show);
                                if (!isD10Showin)
                                {
                                    D10.Roll();
                                    PlayersDice.Add(D10.Show);
                                    PlayersDiceValues.Add(D10.getValue());
                                }
                                if (!isD10_2Showin)
                                {
                                    D10_2.Roll();
                                    PlayersDice.Add(D10_2.Show);
                                    PlayersDiceValues.Add(D10_2.getValue());
                                }
                                if (!isD10_3Showin)
                                {
                                    D10_3.Roll();
                                    PlayersDice.Add(D10_3.Show);
                                    PlayersDiceValues.Add(D10_3.getValue());
                                }
                                if (!isD10_4Showin)
                                {
                                    D10_4.Roll();
                                    PlayersDice.Add(D10_4.Show);
                                    PlayersDiceValues.Add(D10_4.getValue());
                                }
                                if (!isD10_5Showin)
                                {
                                    D10_5.Roll();
                                    PlayersDice.Add(D10_5.Show);
                                    PlayersDiceValues.Add(D10_5.getValue());
                                }
                                if (!isD10_6Showin)
                                {
                                    D10_6.Roll();
                                    PlayersDice.Add(D10_6.Show);
                                    PlayersDiceValues.Add(D10_6.getValue());
                                }
                                if (!isD10_7Showin)
                                {
                                    D10_7.Roll();
                                    PlayersDice.Add(D10_7.Show);
                                    PlayersDiceValues.Add(D10_7.getValue());
                                }
                                if (!isD10_8Showin)
                                {
                                    D10_8.Roll();
                                    PlayersDice.Add(D10_8.Show);
                                    PlayersDiceValues.Add(D10_8.getValue());
                                }
                            }
                            else if (inputDice == "9W10" ^ inputDice == "9w10" ^ inputDice == "9D10" ^ inputDice == "9d10")
                            {
                                bool isD10Showin = PlayersDice.Contains(D10.Show);
                                bool isD10_2Showin = PlayersDice.Contains(D10_2.Show);
                                bool isD10_3Showin = PlayersDice.Contains(D10_3.Show);
                                bool isD10_4Showin = PlayersDice.Contains(D10_4.Show);
                                bool isD10_5Showin = PlayersDice.Contains(D10_5.Show);
                                bool isD10_6Showin = PlayersDice.Contains(D10_6.Show);
                                bool isD10_7Showin = PlayersDice.Contains(D10_7.Show);
                                bool isD10_8Showin = PlayersDice.Contains(D10_8.Show);
                                bool isD10_9Showin = PlayersDice.Contains(D10_9.Show);
                                if (!isD10Showin)
                                {
                                    D10.Roll();
                                    PlayersDice.Add(D10.Show);
                                    PlayersDiceValues.Add(D10.getValue());
                                }
                                if (!isD10_2Showin)
                                {
                                    D10_2.Roll();
                                    PlayersDice.Add(D10_2.Show);
                                    PlayersDiceValues.Add(D10_2.getValue());
                                }
                                if (!isD10_3Showin)
                                {
                                    D10_3.Roll();
                                    PlayersDice.Add(D10_3.Show);
                                    PlayersDiceValues.Add(D10_3.getValue());
                                }
                                if (!isD10_4Showin)
                                {
                                    D10_4.Roll();
                                    PlayersDice.Add(D10_4.Show);
                                    PlayersDiceValues.Add(D10_4.getValue());
                                }
                                if (!isD10_5Showin)
                                {
                                    D10_5.Roll();
                                    PlayersDice.Add(D10_5.Show);
                                    PlayersDiceValues.Add(D10_5.getValue());
                                }
                                if (!isD10_6Showin)
                                {
                                    D10_6.Roll();
                                    PlayersDice.Add(D10_6.Show);
                                    PlayersDiceValues.Add(D10_6.getValue());
                                }
                                if (!isD10_7Showin)
                                {
                                    D10_7.Roll();
                                    PlayersDice.Add(D10_7.Show);
                                    PlayersDiceValues.Add(D10_7.getValue());
                                }
                                if (!isD10_8Showin)
                                {
                                    D10_8.Roll();
                                    PlayersDice.Add(D10_8.Show);
                                    PlayersDiceValues.Add(D10_8.getValue());
                                }
                                if (!isD10_9Showin)
                                {
                                    D10_9.Roll();
                                    PlayersDice.Add(D10_9.Show);
                                    PlayersDiceValues.Add(D10_9.getValue());
                                }
                            }
                            else if (inputDice == "10W10" ^ inputDice == "10w10" ^ inputDice == "10D10" ^ inputDice == "10d10")
                            {
                                bool isD10Showin = PlayersDice.Contains(D10.Show);
                                bool isD10_2Showin = PlayersDice.Contains(D10_2.Show);
                                bool isD10_3Showin = PlayersDice.Contains(D10_3.Show);
                                bool isD10_4Showin = PlayersDice.Contains(D10_4.Show);
                                bool isD10_5Showin = PlayersDice.Contains(D10_5.Show);
                                bool isD10_6Showin = PlayersDice.Contains(D10_6.Show);
                                bool isD10_7Showin = PlayersDice.Contains(D10_7.Show);
                                bool isD10_8Showin = PlayersDice.Contains(D10_8.Show);
                                bool isD10_9Showin = PlayersDice.Contains(D10_9.Show);
                                bool isD10_10Showin = PlayersDice.Contains(D10_10.Show);
                                if (!isD10Showin)
                                {
                                    D10.Roll();
                                    PlayersDice.Add(D10.Show);
                                    PlayersDiceValues.Add(D10.getValue());
                                }
                                if (!isD10_2Showin)
                                {
                                    D10_2.Roll();
                                    PlayersDice.Add(D10_2.Show);
                                    PlayersDiceValues.Add(D10_2.getValue());
                                }
                                if (!isD10_3Showin)
                                {
                                    D10_3.Roll();
                                    PlayersDice.Add(D10_3.Show);
                                    PlayersDiceValues.Add(D10_3.getValue());
                                }
                                if (!isD10_4Showin)
                                {
                                    D10_4.Roll();
                                    PlayersDice.Add(D10_4.Show);
                                    PlayersDiceValues.Add(D10_4.getValue());
                                }
                                if (!isD10_5Showin)
                                {
                                    D10_5.Roll();
                                    PlayersDice.Add(D10_5.Show);
                                    PlayersDiceValues.Add(D10_5.getValue());
                                }
                                if (!isD10_6Showin)
                                {
                                    D10_6.Roll();
                                    PlayersDice.Add(D10_6.Show);
                                    PlayersDiceValues.Add(D10_6.getValue());
                                }
                                if (!isD10_7Showin)
                                {
                                    D10_7.Roll();
                                    PlayersDice.Add(D10_7.Show);
                                    PlayersDiceValues.Add(D10_7.getValue());
                                }
                                if (!isD10_8Showin)
                                {
                                    D10_8.Roll();
                                    PlayersDice.Add(D10_8.Show);
                                    PlayersDiceValues.Add(D10_8.getValue());
                                }
                                if (!isD10_9Showin)
                                {
                                    D10_9.Roll();
                                    PlayersDice.Add(D10_9.Show);
                                    PlayersDiceValues.Add(D10_9.getValue());
                                }
                                if (!isD10_10Showin)
                                {
                                    D10_10.Roll();
                                    PlayersDice.Add(D10_10.Show);
                                    PlayersDiceValues.Add(D10_10.getValue());
                                }
                            }
                            #endregion
                            #region D12 If States
                            else if (inputDice == "W12" ^ inputDice == "1W12" ^ inputDice == "w12" ^ inputDice == "1w12" ^ inputDice == "D12" ^ inputDice == "1D12" ^ inputDice == "d12" ^ inputDice == "1d12")
                            {
                                bool isD12Showin = PlayersDice.Contains(D12.Show);
                                if (!isD12Showin)
                                {
                                    D12.Roll();
                                    PlayersDice.Add(D12.Show);
                                    PlayersDiceValues.Add(D12.getValue());
                                }
                            }
                            else if (inputDice == "2W12" ^ inputDice == "2w12" ^ inputDice == "2D12" ^ inputDice == "2d12")
                            {
                                bool isD12Showin = PlayersDice.Contains(D12.Show);
                                bool isD12_2Showin = PlayersDice.Contains(D12_2.Show);
                                if (!isD12Showin)
                                {
                                    D12.Roll();
                                    PlayersDice.Add(D12.Show);
                                    PlayersDiceValues.Add(D12.getValue());
                                }
                                if (!isD12_2Showin)
                                {
                                    D12_2.Roll();
                                    PlayersDice.Add(D12_2.Show);
                                    PlayersDiceValues.Add(D12_2.getValue());
                                }
                            }
                            else if (inputDice == "3W12" ^ inputDice == "3w12" ^ inputDice == "3D12" ^ inputDice == "3d12")
                            {
                                bool isD12Showin = PlayersDice.Contains(D12.Show);
                                bool isD12_2Showin = PlayersDice.Contains(D12_2.Show);
                                bool isD12_3Showin = PlayersDice.Contains(D12_3.Show);
                                if (!isD12Showin)
                                {
                                    D12.Roll();
                                    PlayersDice.Add(D12.Show);
                                    PlayersDiceValues.Add(D12.getValue());
                                }
                                if (!isD12_2Showin)
                                {
                                    D12_2.Roll();
                                    PlayersDice.Add(D12_2.Show);
                                    PlayersDiceValues.Add(D12_2.getValue());
                                }
                                if (!isD12_3Showin)
                                {
                                    D12_3.Roll();
                                    PlayersDice.Add(D12_3.Show);
                                    PlayersDiceValues.Add(D12_3.getValue());
                                }
                            }
                            else if (inputDice == "4W12" ^ inputDice == "4w12" ^ inputDice == "4D12" ^ inputDice == "4d12")
                            {
                                bool isD12Showin = PlayersDice.Contains(D12.Show);
                                bool isD12_2Showin = PlayersDice.Contains(D12_2.Show);
                                bool isD12_3Showin = PlayersDice.Contains(D12_3.Show);
                                bool isD12_4Showin = PlayersDice.Contains(D12_4.Show);
                                if (!isD12Showin)
                                {
                                    D12.Roll();
                                    PlayersDice.Add(D12.Show);
                                    PlayersDiceValues.Add(D12.getValue());
                                }
                                if (!isD12_2Showin)
                                {
                                    D12_2.Roll();
                                    PlayersDice.Add(D12_2.Show);
                                    PlayersDiceValues.Add(D12_2.getValue());
                                }
                                if (!isD12_3Showin)
                                {
                                    D12_3.Roll();
                                    PlayersDice.Add(D12_3.Show);
                                    PlayersDiceValues.Add(D12_3.getValue());
                                }
                                if (!isD12_4Showin)
                                {
                                    D12_4.Roll();
                                    PlayersDice.Add(D12_4.Show);
                                    PlayersDiceValues.Add(D12_4.getValue());
                                }
                            }
                            else if (inputDice == "5W12" ^ inputDice == "5w12" ^ inputDice == "5D12" ^ inputDice == "5d12")
                            {
                                bool isD12Showin = PlayersDice.Contains(D12.Show);
                                bool isD12_2Showin = PlayersDice.Contains(D12_2.Show);
                                bool isD12_3Showin = PlayersDice.Contains(D12_3.Show);
                                bool isD12_4Showin = PlayersDice.Contains(D12_4.Show);
                                bool isD12_5Showin = PlayersDice.Contains(D12_5.Show);
                                if (!isD12Showin)
                                {
                                    D12.Roll();
                                    PlayersDice.Add(D12.Show);
                                    PlayersDiceValues.Add(D12.getValue());
                                }
                                if (!isD12_2Showin)
                                {
                                    D12_2.Roll();
                                    PlayersDice.Add(D12_2.Show);
                                    PlayersDiceValues.Add(D12_2.getValue());
                                }
                                if (!isD12_3Showin)
                                {
                                    D12_3.Roll();
                                    PlayersDice.Add(D12_3.Show);
                                    PlayersDiceValues.Add(D12_3.getValue());
                                }
                                if (!isD12_4Showin)
                                {
                                    D12_4.Roll();
                                    PlayersDice.Add(D12_4.Show);
                                    PlayersDiceValues.Add(D12_4.getValue());
                                }
                                if (!isD12_5Showin)
                                {
                                    D12_5.Roll();
                                    PlayersDice.Add(D12_5.Show);
                                    PlayersDiceValues.Add(D12_5.getValue());
                                }
                            }
                            else if (inputDice == "6W12" ^ inputDice == "6w12" ^ inputDice == "6D12" ^ inputDice == "6d12")
                            {
                                bool isD12Showin = PlayersDice.Contains(D12.Show);
                                bool isD12_2Showin = PlayersDice.Contains(D12_2.Show);
                                bool isD12_3Showin = PlayersDice.Contains(D12_3.Show);
                                bool isD12_4Showin = PlayersDice.Contains(D12_4.Show);
                                bool isD12_5Showin = PlayersDice.Contains(D12_5.Show);
                                bool isD12_6Showin = PlayersDice.Contains(D12_6.Show);
                                if (!isD12Showin)
                                {
                                    D12.Roll();
                                    PlayersDice.Add(D12.Show);
                                    PlayersDiceValues.Add(D12.getValue());
                                }
                                if (!isD12_2Showin)
                                {
                                    D12_2.Roll();
                                    PlayersDice.Add(D12_2.Show);
                                    PlayersDiceValues.Add(D12_2.getValue());
                                }
                                if (!isD12_3Showin)
                                {
                                    D12_3.Roll();
                                    PlayersDice.Add(D12_3.Show);
                                    PlayersDiceValues.Add(D12_3.getValue());
                                }
                                if (!isD12_4Showin)
                                {
                                    D12_4.Roll();
                                    PlayersDice.Add(D12_4.Show);
                                    PlayersDiceValues.Add(D12_4.getValue());
                                }
                                if (!isD12_5Showin)
                                {
                                    D12_5.Roll();
                                    PlayersDice.Add(D12_5.Show);
                                    PlayersDiceValues.Add(D12_5.getValue());
                                }
                                if (!isD12_6Showin)
                                {
                                    D12_6.Roll();
                                    PlayersDice.Add(D12_6.Show);
                                    PlayersDiceValues.Add(D12_6.getValue());
                                }
                            }
                            else if (inputDice == "7W12" ^ inputDice == "7w12" ^ inputDice == "7D12" ^ inputDice == "7d12")
                            {
                                bool isD12Showin = PlayersDice.Contains(D12.Show);
                                bool isD12_2Showin = PlayersDice.Contains(D12_2.Show);
                                bool isD12_3Showin = PlayersDice.Contains(D12_3.Show);
                                bool isD12_4Showin = PlayersDice.Contains(D12_4.Show);
                                bool isD12_5Showin = PlayersDice.Contains(D12_5.Show);
                                bool isD12_6Showin = PlayersDice.Contains(D12_6.Show);
                                bool isD12_7Showin = PlayersDice.Contains(D12_7.Show);
                                if (!isD12Showin)
                                {
                                    D12.Roll();
                                    PlayersDice.Add(D12.Show);
                                    PlayersDiceValues.Add(D12.getValue());
                                }
                                if (!isD12_2Showin)
                                {
                                    D12_2.Roll();
                                    PlayersDice.Add(D12_2.Show);
                                    PlayersDiceValues.Add(D12_2.getValue());
                                }
                                if (!isD12_3Showin)
                                {
                                    D12_3.Roll();
                                    PlayersDice.Add(D12_3.Show);
                                    PlayersDiceValues.Add(D12_3.getValue());
                                }
                                if (!isD12_4Showin)
                                {
                                    D12_4.Roll();
                                    PlayersDice.Add(D12_4.Show);
                                    PlayersDiceValues.Add(D12_4.getValue());
                                }
                                if (!isD12_5Showin)
                                {
                                    D12_5.Roll();
                                    PlayersDice.Add(D12_5.Show);
                                    PlayersDiceValues.Add(D12_5.getValue());
                                }
                                if (!isD12_6Showin)
                                {
                                    D12_6.Roll();
                                    PlayersDice.Add(D12_6.Show);
                                    PlayersDiceValues.Add(D12_6.getValue());
                                }
                                if (!isD12_7Showin)
                                {
                                    D12_7.Roll();
                                    PlayersDice.Add(D12_7.Show);
                                    PlayersDiceValues.Add(D12_7.getValue());
                                }
                            }
                            else if (inputDice == "8W12" ^ inputDice == "8w12" ^ inputDice == "8D12" ^ inputDice == "8d12")
                            {
                                bool isD12Showin = PlayersDice.Contains(D12.Show);
                                bool isD12_2Showin = PlayersDice.Contains(D12_2.Show);
                                bool isD12_3Showin = PlayersDice.Contains(D12_3.Show);
                                bool isD12_4Showin = PlayersDice.Contains(D12_4.Show);
                                bool isD12_5Showin = PlayersDice.Contains(D12_5.Show);
                                bool isD12_6Showin = PlayersDice.Contains(D12_6.Show);
                                bool isD12_7Showin = PlayersDice.Contains(D12_7.Show);
                                bool isD12_8Showin = PlayersDice.Contains(D12_8.Show);
                                if (!isD12Showin)
                                {
                                    D12.Roll();
                                    PlayersDice.Add(D12.Show);
                                    PlayersDiceValues.Add(D12.getValue());
                                }
                                if (!isD12_2Showin)
                                {
                                    D12_2.Roll();
                                    PlayersDice.Add(D12_2.Show);
                                    PlayersDiceValues.Add(D12_2.getValue());
                                }
                                if (!isD12_3Showin)
                                {
                                    D12_3.Roll();
                                    PlayersDice.Add(D12_3.Show);
                                    PlayersDiceValues.Add(D12_3.getValue());
                                }
                                if (!isD12_4Showin)
                                {
                                    D12_4.Roll();
                                    PlayersDice.Add(D12_4.Show);
                                    PlayersDiceValues.Add(D12_4.getValue());
                                }
                                if (!isD12_5Showin)
                                {
                                    D12_5.Roll();
                                    PlayersDice.Add(D12_5.Show);
                                    PlayersDiceValues.Add(D12_5.getValue());
                                }
                                if (!isD12_6Showin)
                                {
                                    D12_6.Roll();
                                    PlayersDice.Add(D12_6.Show);
                                    PlayersDiceValues.Add(D12_6.getValue());
                                }
                                if (!isD12_7Showin)
                                {
                                    D12_7.Roll();
                                    PlayersDice.Add(D12_7.Show);
                                    PlayersDiceValues.Add(D12_7.getValue());
                                }
                                if (!isD12_8Showin)
                                {
                                    D12_8.Roll();
                                    PlayersDice.Add(D12_8.Show);
                                    PlayersDiceValues.Add(D12_8.getValue());
                                }
                            }
                            else if (inputDice == "9W12" ^ inputDice == "9w12" ^ inputDice == "9D12" ^ inputDice == "9d12")
                            {
                                bool isD12Showin = PlayersDice.Contains(D12.Show);
                                bool isD12_2Showin = PlayersDice.Contains(D12_2.Show);
                                bool isD12_3Showin = PlayersDice.Contains(D12_3.Show);
                                bool isD12_4Showin = PlayersDice.Contains(D12_4.Show);
                                bool isD12_5Showin = PlayersDice.Contains(D12_5.Show);
                                bool isD12_6Showin = PlayersDice.Contains(D12_6.Show);
                                bool isD12_7Showin = PlayersDice.Contains(D12_7.Show);
                                bool isD12_8Showin = PlayersDice.Contains(D12_8.Show);
                                bool isD12_9Showin = PlayersDice.Contains(D12_9.Show);
                                if (!isD12Showin)
                                {
                                    D12.Roll();
                                    PlayersDice.Add(D12.Show);
                                    PlayersDiceValues.Add(D12.getValue());
                                }
                                if (!isD12_2Showin)
                                {
                                    D12_2.Roll();
                                    PlayersDice.Add(D12_2.Show);
                                    PlayersDiceValues.Add(D12_2.getValue());
                                }
                                if (!isD12_3Showin)
                                {
                                    D12_3.Roll();
                                    PlayersDice.Add(D12_3.Show);
                                    PlayersDiceValues.Add(D12_3.getValue());
                                }
                                if (!isD12_4Showin)
                                {
                                    D12_4.Roll();
                                    PlayersDice.Add(D12_4.Show);
                                    PlayersDiceValues.Add(D12_4.getValue());
                                }
                                if (!isD12_5Showin)
                                {
                                    D12_5.Roll();
                                    PlayersDice.Add(D12_5.Show);
                                    PlayersDiceValues.Add(D12_5.getValue());
                                }
                                if (!isD12_6Showin)
                                {
                                    D12_6.Roll();
                                    PlayersDice.Add(D12_6.Show);
                                    PlayersDiceValues.Add(D12_6.getValue());
                                }
                                if (!isD12_7Showin)
                                {
                                    D12_7.Roll();
                                    PlayersDice.Add(D12_7.Show);
                                    PlayersDiceValues.Add(D12_7.getValue());
                                }
                                if (!isD12_8Showin)
                                {
                                    D12_8.Roll();
                                    PlayersDice.Add(D12_8.Show);
                                    PlayersDiceValues.Add(D12_8.getValue());
                                }
                                if (!isD12_9Showin)
                                {
                                    D12_9.Roll();
                                    PlayersDice.Add(D12_9.Show);
                                    PlayersDiceValues.Add(D12_9.getValue());
                                }
                            }
                            else if (inputDice == "10W12" ^ inputDice == "10w12" ^ inputDice == "10D12" ^ inputDice == "10d12")
                            {
                                bool isD12Showin = PlayersDice.Contains(D12.Show);
                                bool isD12_2Showin = PlayersDice.Contains(D12_2.Show);
                                bool isD12_3Showin = PlayersDice.Contains(D12_3.Show);
                                bool isD12_4Showin = PlayersDice.Contains(D12_4.Show);
                                bool isD12_5Showin = PlayersDice.Contains(D12_5.Show);
                                bool isD12_6Showin = PlayersDice.Contains(D12_6.Show);
                                bool isD12_7Showin = PlayersDice.Contains(D12_7.Show);
                                bool isD12_8Showin = PlayersDice.Contains(D12_8.Show);
                                bool isD12_9Showin = PlayersDice.Contains(D12_9.Show);
                                bool isD12_10Showin = PlayersDice.Contains(D12_10.Show);
                                if (!isD12Showin)
                                {
                                    D12.Roll();
                                    PlayersDice.Add(D12.Show);
                                    PlayersDiceValues.Add(D12.getValue());
                                }
                                if (!isD12_2Showin)
                                {
                                    D12_2.Roll();
                                    PlayersDice.Add(D12_2.Show);
                                    PlayersDiceValues.Add(D12_2.getValue());
                                }
                                if (!isD12_3Showin)
                                {
                                    D12_3.Roll();
                                    PlayersDice.Add(D12_3.Show);
                                    PlayersDiceValues.Add(D12_3.getValue());
                                }
                                if (!isD12_4Showin)
                                {
                                    D12_4.Roll();
                                    PlayersDice.Add(D12_4.Show);
                                    PlayersDiceValues.Add(D12_4.getValue());
                                }
                                if (!isD12_5Showin)
                                {
                                    D12_5.Roll();
                                    PlayersDice.Add(D12_5.Show);
                                    PlayersDiceValues.Add(D12_5.getValue());
                                }
                                if (!isD12_6Showin)
                                {
                                    D12_6.Roll();
                                    PlayersDice.Add(D12_6.Show);
                                    PlayersDiceValues.Add(D12_6.getValue());
                                }
                                if (!isD12_7Showin)
                                {
                                    D12_7.Roll();
                                    PlayersDice.Add(D12_7.Show);
                                    PlayersDiceValues.Add(D12_7.getValue());
                                }
                                if (!isD12_8Showin)
                                {
                                    D12_8.Roll();
                                    PlayersDice.Add(D12_8.Show);
                                    PlayersDiceValues.Add(D12_8.getValue());
                                }
                                if (!isD12_9Showin)
                                {
                                    D12_9.Roll();
                                    PlayersDice.Add(D12_9.Show);
                                    PlayersDiceValues.Add(D12_9.getValue());
                                }
                                if (!isD12_10Showin)
                                {
                                    D12_10.Roll();
                                    PlayersDice.Add(D12_10.Show);
                                    PlayersDiceValues.Add(D12_10.getValue());
                                }
                            }
                            #endregion
                            #region D20 If States
                            else if (inputDice == "W20" ^ inputDice == "1W20" ^ inputDice == "w20" ^ inputDice == "1w20" ^ inputDice == "D20" ^ inputDice == "1D20" ^ inputDice == "d20" ^ inputDice == "1d20")
                            {
                                bool isD20Showin = PlayersDice.Contains(D20.Show);
                                if (!isD20Showin)
                                {
                                    D20.Roll();
                                    PlayersDice.Add(D20.Show);
                                    PlayersDiceValues.Add(D20.getValue());
                                }
                            }
                            else if (inputDice == "2W20" ^ inputDice == "2w20" ^ inputDice == "2D20" ^ inputDice == "2d20")
                            {
                                bool isD20Showin = PlayersDice.Contains(D20.Show);
                                bool isD20_2Showin = PlayersDice.Contains(D20_2.Show);
                                if (!isD20Showin)
                                {
                                    D20.Roll();
                                    PlayersDice.Add(D20.Show);
                                    PlayersDiceValues.Add(D20.getValue());
                                }
                                if (!isD20_2Showin)
                                {
                                    D20_2.Roll();
                                    PlayersDice.Add(D20_2.Show);
                                    PlayersDiceValues.Add(D20_2.getValue());
                                }
                            }
                            else if (inputDice == "3W20" ^ inputDice == "3w20" ^ inputDice == "3D20" ^ inputDice == "3d20")
                            {
                                bool isD20Showin = PlayersDice.Contains(D20.Show);
                                bool isD20_2Showin = PlayersDice.Contains(D20_2.Show);
                                bool isD20_3Showin = PlayersDice.Contains(D20_3.Show);
                                if (!isD20Showin)
                                {
                                    D20.Roll();
                                    PlayersDice.Add(D20.Show);
                                    PlayersDiceValues.Add(D20.getValue());
                                }
                                if (!isD20_2Showin)
                                {
                                    D20_2.Roll();
                                    PlayersDice.Add(D20_2.Show);
                                    PlayersDiceValues.Add(D20_2.getValue());
                                }
                                if (!isD20_3Showin)
                                {
                                    D20_3.Roll();
                                    PlayersDice.Add(D20_3.Show);
                                    PlayersDiceValues.Add(D20_3.getValue());
                                }
                            }
                            else if (inputDice == "4W20" ^ inputDice == "4w20" ^ inputDice == "4D20" ^ inputDice == "4d20")
                            {
                                bool isD20Showin = PlayersDice.Contains(D20.Show);
                                bool isD20_2Showin = PlayersDice.Contains(D20_2.Show);
                                bool isD20_3Showin = PlayersDice.Contains(D20_3.Show);
                                bool isD20_4Showin = PlayersDice.Contains(D20_4.Show);
                                if (!isD20Showin)
                                {
                                    D20.Roll();
                                    PlayersDice.Add(D20.Show);
                                    PlayersDiceValues.Add(D20.getValue());
                                }
                                if (!isD20_2Showin)
                                {
                                    D20_2.Roll();
                                    PlayersDice.Add(D20_2.Show);
                                    PlayersDiceValues.Add(D20_2.getValue());
                                }
                                if (!isD20_3Showin)
                                {
                                    D20_3.Roll();
                                    PlayersDice.Add(D20_3.Show);
                                    PlayersDiceValues.Add(D20_3.getValue());
                                }
                                if (!isD20_4Showin)
                                {
                                    D20_4.Roll();
                                    PlayersDice.Add(D20_4.Show);
                                    PlayersDiceValues.Add(D20_4.getValue());
                                }
                            }
                            else if (inputDice == "5W20" ^ inputDice == "5w20" ^ inputDice == "5D20" ^ inputDice == "5d20")
                            {
                                bool isD20Showin = PlayersDice.Contains(D20.Show);
                                bool isD20_2Showin = PlayersDice.Contains(D20_2.Show);
                                bool isD20_3Showin = PlayersDice.Contains(D20_3.Show);
                                bool isD20_4Showin = PlayersDice.Contains(D20_4.Show);
                                bool isD20_5Showin = PlayersDice.Contains(D20_5.Show);
                                if (!isD20Showin)
                                {
                                    D20.Roll();
                                    PlayersDice.Add(D20.Show);
                                    PlayersDiceValues.Add(D20.getValue());
                                }
                                if (!isD20_2Showin)
                                {
                                    D20_2.Roll();
                                    PlayersDice.Add(D20_2.Show);
                                    PlayersDiceValues.Add(D20_2.getValue());
                                }
                                if (!isD20_3Showin)
                                {
                                    D20_3.Roll();
                                    PlayersDice.Add(D20_3.Show);
                                    PlayersDiceValues.Add(D20_3.getValue());
                                }
                                if (!isD20_4Showin)
                                {
                                    D20_4.Roll();
                                    PlayersDice.Add(D20_4.Show);
                                    PlayersDiceValues.Add(D20_4.getValue());
                                }
                                if (!isD20_5Showin)
                                {
                                    D20_5.Roll();
                                    PlayersDice.Add(D20_5.Show);
                                    PlayersDiceValues.Add(D20_5.getValue());
                                }
                            }
                            else if (inputDice == "6W20" ^ inputDice == "6w20" ^ inputDice == "6D20" ^ inputDice == "6d20")
                            {
                                bool isD20Showin = PlayersDice.Contains(D20.Show);
                                bool isD20_2Showin = PlayersDice.Contains(D20_2.Show);
                                bool isD20_3Showin = PlayersDice.Contains(D20_3.Show);
                                bool isD20_4Showin = PlayersDice.Contains(D20_4.Show);
                                bool isD20_5Showin = PlayersDice.Contains(D20_5.Show);
                                bool isD20_6Showin = PlayersDice.Contains(D20_6.Show);
                                if (!isD20Showin)
                                {
                                    D20.Roll();
                                    PlayersDice.Add(D20.Show);
                                    PlayersDiceValues.Add(D20.getValue());
                                }
                                if (!isD20_2Showin)
                                {
                                    D20_2.Roll();
                                    PlayersDice.Add(D20_2.Show);
                                    PlayersDiceValues.Add(D20_2.getValue());
                                }
                                if (!isD20_3Showin)
                                {
                                    D20_3.Roll();
                                    PlayersDice.Add(D20_3.Show);
                                    PlayersDiceValues.Add(D20_3.getValue());
                                }
                                if (!isD20_4Showin)
                                {
                                    D20_4.Roll();
                                    PlayersDice.Add(D20_4.Show);
                                    PlayersDiceValues.Add(D20_4.getValue());
                                }
                                if (!isD20_5Showin)
                                {
                                    D20_5.Roll();
                                    PlayersDice.Add(D20_5.Show);
                                    PlayersDiceValues.Add(D20_5.getValue());
                                }
                                if (!isD20_6Showin)
                                {
                                    D20_6.Roll();
                                    PlayersDice.Add(D20_6.Show);
                                    PlayersDiceValues.Add(D20_6.getValue());
                                }
                            }
                            else if (inputDice == "7W20" ^ inputDice == "7w20" ^ inputDice == "7D20" ^ inputDice == "7d20")
                            {
                                bool isD20Showin = PlayersDice.Contains(D20.Show);
                                bool isD20_2Showin = PlayersDice.Contains(D20_2.Show);
                                bool isD20_3Showin = PlayersDice.Contains(D20_3.Show);
                                bool isD20_4Showin = PlayersDice.Contains(D20_4.Show);
                                bool isD20_5Showin = PlayersDice.Contains(D20_5.Show);
                                bool isD20_6Showin = PlayersDice.Contains(D20_6.Show);
                                bool isD20_7Showin = PlayersDice.Contains(D20_7.Show);
                                if (!isD20Showin)
                                {
                                    D20.Roll();
                                    PlayersDice.Add(D20.Show);
                                    PlayersDiceValues.Add(D20.getValue());
                                }
                                if (!isD20_2Showin)
                                {
                                    D20_2.Roll();
                                    PlayersDice.Add(D20_2.Show);
                                    PlayersDiceValues.Add(D20_2.getValue());
                                }
                                if (!isD20_3Showin)
                                {
                                    D20_3.Roll();
                                    PlayersDice.Add(D20_3.Show);
                                    PlayersDiceValues.Add(D20_3.getValue());
                                }
                                if (!isD20_4Showin)
                                {
                                    D20_4.Roll();
                                    PlayersDice.Add(D20_4.Show);
                                    PlayersDiceValues.Add(D20_4.getValue());
                                }
                                if (!isD20_5Showin)
                                {
                                    D20_5.Roll();
                                    PlayersDice.Add(D20_5.Show);
                                    PlayersDiceValues.Add(D20_5.getValue());
                                }
                                if (!isD20_6Showin)
                                {
                                    D20_6.Roll();
                                    PlayersDice.Add(D20_6.Show);
                                    PlayersDiceValues.Add(D20_6.getValue());
                                }
                                if (!isD20_7Showin)
                                {
                                    D20_7.Roll();
                                    PlayersDice.Add(D20_7.Show);
                                    PlayersDiceValues.Add(D20_7.getValue());
                                }
                            }
                            else if (inputDice == "8W20" ^ inputDice == "8w20" ^ inputDice == "8D20" ^ inputDice == "8d20")
                            {
                                bool isD20Showin = PlayersDice.Contains(D20.Show);
                                bool isD20_2Showin = PlayersDice.Contains(D20_2.Show);
                                bool isD20_3Showin = PlayersDice.Contains(D20_3.Show);
                                bool isD20_4Showin = PlayersDice.Contains(D20_4.Show);
                                bool isD20_5Showin = PlayersDice.Contains(D20_5.Show);
                                bool isD20_6Showin = PlayersDice.Contains(D20_6.Show);
                                bool isD20_7Showin = PlayersDice.Contains(D20_7.Show);
                                bool isD20_8Showin = PlayersDice.Contains(D20_8.Show);
                                if (!isD20Showin)
                                {
                                    D20.Roll();
                                    PlayersDice.Add(D20.Show);
                                    PlayersDiceValues.Add(D20.getValue());
                                }
                                if (!isD20_2Showin)
                                {
                                    D20_2.Roll();
                                    PlayersDice.Add(D20_2.Show);
                                    PlayersDiceValues.Add(D20_2.getValue());
                                }
                                if (!isD20_3Showin)
                                {
                                    D20_3.Roll();
                                    PlayersDice.Add(D20_3.Show);
                                    PlayersDiceValues.Add(D20_3.getValue());
                                }
                                if (!isD20_4Showin)
                                {
                                    D20_4.Roll();
                                    PlayersDice.Add(D20_4.Show);
                                    PlayersDiceValues.Add(D20_4.getValue());
                                }
                                if (!isD20_5Showin)
                                {
                                    D20_5.Roll();
                                    PlayersDice.Add(D20_5.Show);
                                    PlayersDiceValues.Add(D20_5.getValue());
                                }
                                if (!isD20_6Showin)
                                {
                                    D20_6.Roll();
                                    PlayersDice.Add(D20_6.Show);
                                    PlayersDiceValues.Add(D20_6.getValue());
                                }
                                if (!isD20_7Showin)
                                {
                                    D20_7.Roll();
                                    PlayersDice.Add(D20_7.Show);
                                    PlayersDiceValues.Add(D20_7.getValue());
                                }
                                if (!isD20_8Showin)
                                {
                                    D20_8.Roll();
                                    PlayersDice.Add(D20_8.Show);
                                    PlayersDiceValues.Add(D20_8.getValue());
                                }
                            }
                            else if (inputDice == "9W20" ^ inputDice == "9w20" ^ inputDice == "9D20" ^ inputDice == "9d20")
                            {
                                bool isD20Showin = PlayersDice.Contains(D20.Show);
                                bool isD20_2Showin = PlayersDice.Contains(D20_2.Show);
                                bool isD20_3Showin = PlayersDice.Contains(D20_3.Show);
                                bool isD20_4Showin = PlayersDice.Contains(D20_4.Show);
                                bool isD20_5Showin = PlayersDice.Contains(D20_5.Show);
                                bool isD20_6Showin = PlayersDice.Contains(D20_6.Show);
                                bool isD20_7Showin = PlayersDice.Contains(D20_7.Show);
                                bool isD20_8Showin = PlayersDice.Contains(D20_8.Show);
                                bool isD20_9Showin = PlayersDice.Contains(D20_9.Show);
                                if (!isD20Showin)
                                {
                                    D20.Roll();
                                    PlayersDice.Add(D20.Show);
                                    PlayersDiceValues.Add(D20.getValue());
                                }
                                if (!isD20_2Showin)
                                {
                                    D20_2.Roll();
                                    PlayersDice.Add(D20_2.Show);
                                    PlayersDiceValues.Add(D20_2.getValue());
                                }
                                if (!isD20_3Showin)
                                {
                                    D20_3.Roll();
                                    PlayersDice.Add(D20_3.Show);
                                    PlayersDiceValues.Add(D20_3.getValue());
                                }
                                if (!isD20_4Showin)
                                {
                                    D20_4.Roll();
                                    PlayersDice.Add(D20_4.Show);
                                    PlayersDiceValues.Add(D20_4.getValue());
                                }
                                if (!isD20_5Showin)
                                {
                                    D20_5.Roll();
                                    PlayersDice.Add(D20_5.Show);
                                    PlayersDiceValues.Add(D20_5.getValue());
                                }
                                if (!isD20_6Showin)
                                {
                                    D20_6.Roll();
                                    PlayersDice.Add(D20_6.Show);
                                    PlayersDiceValues.Add(D20_6.getValue());
                                }
                                if (!isD20_7Showin)
                                {
                                    D20_7.Roll();
                                    PlayersDice.Add(D20_7.Show);
                                    PlayersDiceValues.Add(D20_7.getValue());
                                }
                                if (!isD20_8Showin)
                                {
                                    D20_8.Roll();
                                    PlayersDice.Add(D20_8.Show);
                                    PlayersDiceValues.Add(D20_8.getValue());
                                }
                                if (!isD20_9Showin)
                                {
                                    D20_9.Roll();
                                    PlayersDice.Add(D20_9.Show);
                                    PlayersDiceValues.Add(D20_9.getValue());
                                }
                            }
                            else if (inputDice == "10W20" ^ inputDice == "10w20" ^ inputDice == "10D20" ^ inputDice == "10d20")
                            {
                                bool isD20Showin = PlayersDice.Contains(D20.Show);
                                bool isD20_2Showin = PlayersDice.Contains(D20_2.Show);
                                bool isD20_3Showin = PlayersDice.Contains(D20_3.Show);
                                bool isD20_4Showin = PlayersDice.Contains(D20_4.Show);
                                bool isD20_5Showin = PlayersDice.Contains(D20_5.Show);
                                bool isD20_6Showin = PlayersDice.Contains(D20_6.Show);
                                bool isD20_7Showin = PlayersDice.Contains(D20_7.Show);
                                bool isD20_8Showin = PlayersDice.Contains(D20_8.Show);
                                bool isD20_9Showin = PlayersDice.Contains(D20_9.Show);
                                bool isD20_10Showin = PlayersDice.Contains(D20_10.Show);
                                if (!isD20Showin)
                                {
                                    D20.Roll();
                                    PlayersDice.Add(D20.Show);
                                    PlayersDiceValues.Add(D20.getValue());
                                }
                                if (!isD20_2Showin)
                                {
                                    D20_2.Roll();
                                    PlayersDice.Add(D20_2.Show);
                                    PlayersDiceValues.Add(D20_2.getValue());
                                }
                                if (!isD20_3Showin)
                                {
                                    D20_3.Roll();
                                    PlayersDice.Add(D20_3.Show);
                                    PlayersDiceValues.Add(D20_3.getValue());
                                }
                                if (!isD20_4Showin)
                                {
                                    D20_4.Roll();
                                    PlayersDice.Add(D20_4.Show);
                                    PlayersDiceValues.Add(D20_4.getValue());
                                }
                                if (!isD20_5Showin)
                                {
                                    D20_5.Roll();
                                    PlayersDice.Add(D20_5.Show);
                                    PlayersDiceValues.Add(D20_5.getValue());
                                }
                                if (!isD20_6Showin)
                                {
                                    D20_6.Roll();
                                    PlayersDice.Add(D20_6.Show);
                                    PlayersDiceValues.Add(D20_6.getValue());
                                }
                                if (!isD20_7Showin)
                                {
                                    D20_7.Roll();
                                    PlayersDice.Add(D20_7.Show);
                                    PlayersDiceValues.Add(D20_7.getValue());
                                }
                                if (!isD20_8Showin)
                                {
                                    D20_8.Roll();
                                    PlayersDice.Add(D20_8.Show);
                                    PlayersDiceValues.Add(D20_8.getValue());
                                }
                                if (!isD20_9Showin)
                                {
                                    D20_9.Roll();
                                    PlayersDice.Add(D20_9.Show);
                                    PlayersDiceValues.Add(D20_9.getValue());
                                }
                                if (!isD20_10Showin)
                                {
                                    D20_10.Roll();
                                    PlayersDice.Add(D20_10.Show);
                                    PlayersDiceValues.Add(D20_10.getValue());
                                }
                            }
                            #endregion
                            #region D100 If States
                            else if (inputDice == "W100" ^ inputDice == "1W100" ^ inputDice == "w100" ^ inputDice == "1w100" ^ inputDice == "D100" ^ inputDice == "1D100" ^ inputDice == "d100" ^ inputDice == "1d100")
                            {
                                bool isD100Showin = PlayersDice.Contains(D100.Show);
                                if (!isD100Showin)
                                {
                                    D100.Roll();
                                    PlayersDice.Add(D100.Show);
                                    PlayersDiceValues.Add(D100.getValue());
                                }
                            }
                            else if (inputDice == "2W100" ^ inputDice == "2w100" ^ inputDice == "2D100" ^ inputDice == "2d100")
                            {
                                bool isD100Showin = PlayersDice.Contains(D100.Show);
                                bool isD100_2Showin = PlayersDice.Contains(D100_2.Show);
                                if (!isD100Showin)
                                {
                                    D100.Roll();
                                    PlayersDice.Add(D100.Show);
                                    PlayersDiceValues.Add(D100.getValue());
                                }
                                if (!isD100_2Showin)
                                {
                                    D100_2.Roll();
                                    PlayersDice.Add(D100_2.Show);
                                    PlayersDiceValues.Add(D100_2.getValue());
                                }
                            }
                            else if (inputDice == "3W100" ^ inputDice == "3w100" ^ inputDice == "3D100" ^ inputDice == "3d100")
                            {
                                bool isD100Showin = PlayersDice.Contains(D100.Show);
                                bool isD100_2Showin = PlayersDice.Contains(D100_2.Show);
                                bool isD100_3Showin = PlayersDice.Contains(D100_3.Show);
                                if (!isD100Showin)
                                {
                                    D100.Roll();
                                    PlayersDice.Add(D100.Show);
                                    PlayersDiceValues.Add(D100.getValue());
                                }
                                if (!isD100_2Showin)
                                {
                                    D100_2.Roll();
                                    PlayersDice.Add(D100_2.Show);
                                    PlayersDiceValues.Add(D100_2.getValue());
                                }
                                if (!isD100_3Showin)
                                {
                                    D100_3.Roll();
                                    PlayersDice.Add(D100_3.Show);
                                    PlayersDiceValues.Add(D100_3.getValue());
                                }
                            }
                            else if (inputDice == "4W100" ^ inputDice == "4w100" ^ inputDice == "4D100" ^ inputDice == "4d100")
                            {
                                bool isD100Showin = PlayersDice.Contains(D100.Show);
                                bool isD100_2Showin = PlayersDice.Contains(D100_2.Show);
                                bool isD100_3Showin = PlayersDice.Contains(D100_3.Show);
                                bool isD100_4Showin = PlayersDice.Contains(D100_4.Show);
                                if (!isD100Showin)
                                {
                                    D100.Roll();
                                    PlayersDice.Add(D100.Show);
                                    PlayersDiceValues.Add(D100.getValue());
                                }
                                if (!isD100_2Showin)
                                {
                                    D100_2.Roll();
                                    PlayersDice.Add(D100_2.Show);
                                    PlayersDiceValues.Add(D100_2.getValue());
                                }
                                if (!isD100_3Showin)
                                {
                                    D100_3.Roll();
                                    PlayersDice.Add(D100_3.Show);
                                    PlayersDiceValues.Add(D100_3.getValue());
                                }
                                if (!isD100_4Showin)
                                {
                                    D100_4.Roll();
                                    PlayersDice.Add(D100_4.Show);
                                    PlayersDiceValues.Add(D100_4.getValue());
                                }
                            }
                            else if (inputDice == "5W100" ^ inputDice == "5w100" ^ inputDice == "5D100" ^ inputDice == "5d100")
                            {
                                bool isD100Showin = PlayersDice.Contains(D100.Show);
                                bool isD100_2Showin = PlayersDice.Contains(D100_2.Show);
                                bool isD100_3Showin = PlayersDice.Contains(D100_3.Show);
                                bool isD100_4Showin = PlayersDice.Contains(D100_4.Show);
                                bool isD100_5Showin = PlayersDice.Contains(D100_5.Show);
                                if (!isD100Showin)
                                {
                                    D100.Roll();
                                    PlayersDice.Add(D100.Show);
                                    PlayersDiceValues.Add(D100.getValue());
                                }
                                if (!isD100_2Showin)
                                {
                                    D100_2.Roll();
                                    PlayersDice.Add(D100_2.Show);
                                    PlayersDiceValues.Add(D100_2.getValue());
                                }
                                if (!isD100_3Showin)
                                {
                                    D100_3.Roll();
                                    PlayersDice.Add(D100_3.Show);
                                    PlayersDiceValues.Add(D100_3.getValue());
                                }
                                if (!isD100_4Showin)
                                {
                                    D100_4.Roll();
                                    PlayersDice.Add(D100_4.Show);
                                    PlayersDiceValues.Add(D100_4.getValue());
                                }
                                if (!isD100_5Showin)
                                {
                                    D100_5.Roll();
                                    PlayersDice.Add(D100_5.Show);
                                    PlayersDiceValues.Add(D100_5.getValue());
                                }
                            }
                            else if (inputDice == "6W100" ^ inputDice == "6w100" ^ inputDice == "6D100" ^ inputDice == "6d100")
                            {
                                bool isD100Showin = PlayersDice.Contains(D100.Show);
                                bool isD100_2Showin = PlayersDice.Contains(D100_2.Show);
                                bool isD100_3Showin = PlayersDice.Contains(D100_3.Show);
                                bool isD100_4Showin = PlayersDice.Contains(D100_4.Show);
                                bool isD100_5Showin = PlayersDice.Contains(D100_5.Show);
                                bool isD100_6Showin = PlayersDice.Contains(D100_6.Show);
                                if (!isD100Showin)
                                {
                                    D100.Roll();
                                    PlayersDice.Add(D100.Show);
                                    PlayersDiceValues.Add(D100.getValue());
                                }
                                if (!isD100_2Showin)
                                {
                                    D100_2.Roll();
                                    PlayersDice.Add(D100_2.Show);
                                    PlayersDiceValues.Add(D100_2.getValue());
                                }
                                if (!isD100_3Showin)
                                {
                                    D100_3.Roll();
                                    PlayersDice.Add(D100_3.Show);
                                    PlayersDiceValues.Add(D100_3.getValue());
                                }
                                if (!isD100_4Showin)
                                {
                                    D100_4.Roll();
                                    PlayersDice.Add(D100_4.Show);
                                    PlayersDiceValues.Add(D100_4.getValue());
                                }
                                if (!isD100_5Showin)
                                {
                                    D100_5.Roll();
                                    PlayersDice.Add(D100_5.Show);
                                    PlayersDiceValues.Add(D100_5.getValue());
                                }
                                if (!isD100_6Showin)
                                {
                                    D100_6.Roll();
                                    PlayersDice.Add(D100_6.Show);
                                    PlayersDiceValues.Add(D100_6.getValue());
                                }
                            }
                            else if (inputDice == "7W100" ^ inputDice == "7w100" ^ inputDice == "7D100" ^ inputDice == "7d100")
                            {
                                bool isD100Showin = PlayersDice.Contains(D100.Show);
                                bool isD100_2Showin = PlayersDice.Contains(D100_2.Show);
                                bool isD100_3Showin = PlayersDice.Contains(D100_3.Show);
                                bool isD100_4Showin = PlayersDice.Contains(D100_4.Show);
                                bool isD100_5Showin = PlayersDice.Contains(D100_5.Show);
                                bool isD100_6Showin = PlayersDice.Contains(D100_6.Show);
                                bool isD100_7Showin = PlayersDice.Contains(D100_7.Show);
                                if (!isD100Showin)
                                {
                                    D100.Roll();
                                    PlayersDice.Add(D100.Show);
                                    PlayersDiceValues.Add(D100.getValue());
                                }
                                if (!isD100_2Showin)
                                {
                                    D100_2.Roll();
                                    PlayersDice.Add(D100_2.Show);
                                    PlayersDiceValues.Add(D100_2.getValue());
                                }
                                if (!isD100_3Showin)
                                {
                                    D100_3.Roll();
                                    PlayersDice.Add(D100_3.Show);
                                    PlayersDiceValues.Add(D100_3.getValue());
                                }
                                if (!isD100_4Showin)
                                {
                                    D100_4.Roll();
                                    PlayersDice.Add(D100_4.Show);
                                    PlayersDiceValues.Add(D100_4.getValue());
                                }
                                if (!isD100_5Showin)
                                {
                                    D100_5.Roll();
                                    PlayersDice.Add(D100_5.Show);
                                    PlayersDiceValues.Add(D100_5.getValue());
                                }
                                if (!isD100_6Showin)
                                {
                                    D100_6.Roll();
                                    PlayersDice.Add(D100_6.Show);
                                    PlayersDiceValues.Add(D100_6.getValue());
                                }
                                if (!isD100_7Showin)
                                {
                                    D100_7.Roll();
                                    PlayersDice.Add(D100_7.Show);
                                    PlayersDiceValues.Add(D100_7.getValue());
                                }
                            }
                            else if (inputDice == "8W100" ^ inputDice == "8w100" ^ inputDice == "8D100" ^ inputDice == "8d100")
                            {
                                bool isD100Showin = PlayersDice.Contains(D100.Show);
                                bool isD100_2Showin = PlayersDice.Contains(D100_2.Show);
                                bool isD100_3Showin = PlayersDice.Contains(D100_3.Show);
                                bool isD100_4Showin = PlayersDice.Contains(D100_4.Show);
                                bool isD100_5Showin = PlayersDice.Contains(D100_5.Show);
                                bool isD100_6Showin = PlayersDice.Contains(D100_6.Show);
                                bool isD100_7Showin = PlayersDice.Contains(D100_7.Show);
                                bool isD100_8Showin = PlayersDice.Contains(D100_8.Show);
                                if (!isD100Showin)
                                {
                                    D100.Roll();
                                    PlayersDice.Add(D100.Show);
                                    PlayersDiceValues.Add(D100.getValue());
                                }
                                if (!isD100_2Showin)
                                {
                                    D100_2.Roll();
                                    PlayersDice.Add(D100_2.Show);
                                    PlayersDiceValues.Add(D100_2.getValue());
                                }
                                if (!isD100_3Showin)
                                {
                                    D100_3.Roll();
                                    PlayersDice.Add(D100_3.Show);
                                    PlayersDiceValues.Add(D100_3.getValue());
                                }
                                if (!isD100_4Showin)
                                {
                                    D100_4.Roll();
                                    PlayersDice.Add(D100_4.Show);
                                    PlayersDiceValues.Add(D100_4.getValue());
                                }
                                if (!isD100_5Showin)
                                {
                                    D100_5.Roll();
                                    PlayersDice.Add(D100_5.Show);
                                    PlayersDiceValues.Add(D100_5.getValue());
                                }
                                if (!isD100_6Showin)
                                {
                                    D100_6.Roll();
                                    PlayersDice.Add(D100_6.Show);
                                    PlayersDiceValues.Add(D100_6.getValue());
                                }
                                if (!isD100_7Showin)
                                {
                                    D100_7.Roll();
                                    PlayersDice.Add(D100_7.Show);
                                    PlayersDiceValues.Add(D100_7.getValue());
                                }
                                if (!isD100_8Showin)
                                {
                                    D100_8.Roll();
                                    PlayersDice.Add(D100_8.Show);
                                    PlayersDiceValues.Add(D100_8.getValue());
                                }
                            }
                            else if (inputDice == "9W100" ^ inputDice == "9w100" ^ inputDice == "9D100" ^ inputDice == "9d100")
                            {
                                bool isD100Showin = PlayersDice.Contains(D100.Show);
                                bool isD100_2Showin = PlayersDice.Contains(D100_2.Show);
                                bool isD100_3Showin = PlayersDice.Contains(D100_3.Show);
                                bool isD100_4Showin = PlayersDice.Contains(D100_4.Show);
                                bool isD100_5Showin = PlayersDice.Contains(D100_5.Show);
                                bool isD100_6Showin = PlayersDice.Contains(D100_6.Show);
                                bool isD100_7Showin = PlayersDice.Contains(D100_7.Show);
                                bool isD100_8Showin = PlayersDice.Contains(D100_8.Show);
                                bool isD100_9Showin = PlayersDice.Contains(D100_9.Show);
                                if (!isD100Showin)
                                {
                                    D100.Roll();
                                    PlayersDice.Add(D100.Show);
                                    PlayersDiceValues.Add(D100.getValue());
                                }
                                if (!isD100_2Showin)
                                {
                                    D100_2.Roll();
                                    PlayersDice.Add(D100_2.Show);
                                    PlayersDiceValues.Add(D100_2.getValue());
                                }
                                if (!isD100_3Showin)
                                {
                                    D100_3.Roll();
                                    PlayersDice.Add(D100_3.Show);
                                    PlayersDiceValues.Add(D100_3.getValue());
                                }
                                if (!isD100_4Showin)
                                {
                                    D100_4.Roll();
                                    PlayersDice.Add(D100_4.Show);
                                    PlayersDiceValues.Add(D100_4.getValue());
                                }
                                if (!isD100_5Showin)
                                {
                                    D100_5.Roll();
                                    PlayersDice.Add(D100_5.Show);
                                    PlayersDiceValues.Add(D100_5.getValue());
                                }
                                if (!isD100_6Showin)
                                {
                                    D100_6.Roll();
                                    PlayersDice.Add(D100_6.Show);
                                    PlayersDiceValues.Add(D100_6.getValue());
                                }
                                if (!isD100_7Showin)
                                {
                                    D100_7.Roll();
                                    PlayersDice.Add(D100_7.Show);
                                    PlayersDiceValues.Add(D100_7.getValue());
                                }
                                if (!isD100_8Showin)
                                {
                                    D100_8.Roll();
                                    PlayersDice.Add(D100_8.Show);
                                    PlayersDiceValues.Add(D100_8.getValue());
                                }
                                if (!isD100_9Showin)
                                {
                                    D100_9.Roll();
                                    PlayersDice.Add(D100_9.Show);
                                    PlayersDiceValues.Add(D100_9.getValue());
                                }
                            }
                            else if (inputDice == "10W100" ^ inputDice == "10w100" ^ inputDice == "10D100" ^ inputDice == "10d100")
                            {
                                bool isD100Showin = PlayersDice.Contains(D100.Show);
                                bool isD100_2Showin = PlayersDice.Contains(D100_2.Show);
                                bool isD100_3Showin = PlayersDice.Contains(D100_3.Show);
                                bool isD100_4Showin = PlayersDice.Contains(D100_4.Show);
                                bool isD100_5Showin = PlayersDice.Contains(D100_5.Show);
                                bool isD100_6Showin = PlayersDice.Contains(D100_6.Show);
                                bool isD100_7Showin = PlayersDice.Contains(D100_7.Show);
                                bool isD100_8Showin = PlayersDice.Contains(D100_8.Show);
                                bool isD100_9Showin = PlayersDice.Contains(D100_9.Show);
                                bool isD100_10Showin = PlayersDice.Contains(D100_10.Show);
                                if (!isD100Showin)
                                {
                                    D100.Roll();
                                    PlayersDice.Add(D100.Show);
                                    PlayersDiceValues.Add(D100.getValue());
                                }
                                if (!isD100_2Showin)
                                {
                                    D100_2.Roll();
                                    PlayersDice.Add(D100_2.Show);
                                    PlayersDiceValues.Add(D100_2.getValue());
                                }
                                if (!isD100_3Showin)
                                {
                                    D100_3.Roll();
                                    PlayersDice.Add(D100_3.Show);
                                    PlayersDiceValues.Add(D100_3.getValue());
                                }
                                if (!isD100_4Showin)
                                {
                                    D100_4.Roll();
                                    PlayersDice.Add(D100_4.Show);
                                    PlayersDiceValues.Add(D100_4.getValue());
                                }
                                if (!isD100_5Showin)
                                {
                                    D100_5.Roll();
                                    PlayersDice.Add(D100_5.Show);
                                    PlayersDiceValues.Add(D100_5.getValue());
                                }
                                if (!isD100_6Showin)
                                {
                                    D100_6.Roll();
                                    PlayersDice.Add(D100_6.Show);
                                    PlayersDiceValues.Add(D100_6.getValue());
                                }
                                if (!isD100_7Showin)
                                {
                                    D100_7.Roll();
                                    PlayersDice.Add(D100_7.Show);
                                    PlayersDiceValues.Add(D100_7.getValue());
                                }
                                if (!isD100_8Showin)
                                {
                                    D100_8.Roll();
                                    PlayersDice.Add(D100_8.Show);
                                    PlayersDiceValues.Add(D100_8.getValue());
                                }
                                if (!isD100_9Showin)
                                {
                                    D100_9.Roll();
                                    PlayersDice.Add(D100_9.Show);
                                    PlayersDiceValues.Add(D100_9.getValue());
                                }
                                if (!isD100_10Showin)
                                {
                                    D100_10.Roll();
                                    PlayersDice.Add(D100_10.Show);
                                    PlayersDiceValues.Add(D100_10.getValue());
                                }
                            }
                            #endregion
                            #endregion
                            else if (inputDice == "no" ^ inputDice == "done" ^ inputDice == "back" ^ inputDice == "No" ^ inputDice == "Done" ^ inputDice == "Back" ^ inputDice == "NO" ^ inputDice == "DONE" ^ inputDice == "BACK" ^ inputDice == "nein" ^ inputDice == "fertig" ^ inputDice == "zurück" ^ inputDice == "Nein" ^ inputDice == "Fertig" ^ inputDice == "Zurück" ^ inputDice == "NEIN" ^ inputDice == "FERTIG" ^ inputDice == "ZURÜCK" ^ inputDice == "n" ^ inputDice == "N" ^ inputDice == "" ^ inputDice == "nope" ^ inputDice == "Nope" ^ inputDice == "NOPE" ^ inputDice == "nee" ^ inputDice == "Nee" ^ inputDice == "NEE" ^ inputDice == "nö" ^ inputDice == "NÖ" ^ inputDice == "Nö" ^ inputDice == "fertsch" ^ inputDice == "Fertsch" ^ inputDice == "FERTSCH")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("     Sorry, den Würfel kenn' ich nicht.");
                                Console.WriteLine("     Bitte gib nur einzelne Buchstaben und Ganzzahlen an wie z.B. '2W10', oder 'W100'.");
                                Console.WriteLine("     Existierende Würfel sind W4, W6, W8, W10, W12, W20 und W100.");
                            }

                            Console.WriteLine();
                            Console.WriteLine("     Sollen noch mehr Würfel in den Becher?              (Nenn die Würfel, oder sage 'nein', 'fertig', 'n',");
                            Console.WriteLine("                                                         (oder drücke einfach 'Enter' um zu Würfeln.");
                            Console.Write("     ");
                        }

                        Console.WriteLine();
                        Console.WriteLine("     Du knallst den Würfelbecher auf den Tisch..");
                        Console.WriteLine();
                        Console.Write("     ");
                        foreach (Action func in PlayersDice)       // prints all chosen dice
                            func();
                        Console.WriteLine();
                        Console.WriteLine();
                        int diceSum = (from x in PlayersDiceValues select x).Sum();
                        Console.WriteLine("     {Ergebnis: " + diceSum + "} ");     // prints the sum of dice
                        Console.WriteLine();
                        Console.Write("     Drücke die Anikei-Taste.");
                        Console.ReadKey();

                        PlayersDiceValues.Clear();     // deleting all entries on HashSets and Lists
                        PlayersDice.Clear();
                        break;
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("     Möchtest du nochmal würfeln? (j/n) ");
                    var PlayersChoice = Console.ReadLine();
                    if (PlayersChoice == "j" ^ PlayersChoice == "J" ^ PlayersChoice == "ja" ^ PlayersChoice == "Ja" ^ PlayersChoice == "jup" ^ PlayersChoice == "Jup" ^ PlayersChoice == "y" ^ PlayersChoice == "Y" ^ PlayersChoice == "yes" ^ PlayersChoice == "Yes" ^ PlayersChoice == "yup" ^ PlayersChoice == "Yup" ^ PlayersChoice == "JA" ^ PlayersChoice == "JUP" ^ PlayersChoice == "YES" ^ PlayersChoice == "YUP")
                    {

                    }
                    else if (PlayersChoice == "N" ^ PlayersChoice == "n" ^ PlayersChoice == "no" ^ PlayersChoice == "done" ^ PlayersChoice == "back" ^ PlayersChoice == "No" ^ PlayersChoice == "Done" ^ PlayersChoice == "Back" ^ PlayersChoice == "NO" ^ PlayersChoice == "DONE" ^ PlayersChoice == "BACK" ^ PlayersChoice == "nein" ^ PlayersChoice == "fertig" ^ PlayersChoice == "zurück" ^ PlayersChoice == "Nein" ^ PlayersChoice == "Fertig" ^ PlayersChoice == "Zurück" ^ PlayersChoice == "NEIN" ^ PlayersChoice == "FERTIG" ^ PlayersChoice == "ZURÜCK" ^ PlayersChoice == "n" ^ PlayersChoice == "N" ^ PlayersChoice == "" ^ PlayersChoice == "nope" ^ PlayersChoice == "Nope" ^ PlayersChoice == "NOPE" ^ PlayersChoice == "nee" ^ PlayersChoice == "Nee" ^ PlayersChoice == "NEE")
                    {
                        GoOn = false;
                        start = false;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine();
                Console.WriteLine("         {{{{{   DAS ENDE ^^  }}}}}");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("     This dice roller was made by an 'undead fish'.");
                Console.WriteLine();
                Console.WriteLine("     Danke, dass du mein Spiel ausprobiert hast!"); // Thank you for watching, or using my code ^^. I hope its not too shitty crap.
                Console.WriteLine("     Für Fragen, Anregungen, oder Käferberichte, schreib mir gern an 'uf@something-with-tech-stuff.de'. ");
                Console.WriteLine();
                Console.WriteLine("     Drück nochmal die Anikei-Taste.");
                Console.Write("     ");
                Console.ReadKey();
            }   
            #endregion

            #endregion

            callFreeDiceRoll();
        }
    }
}
*/