using System;
using Lab_5_Ind_1;

namespace Lab_6_Ind_1
{
    class Mercedes : Car, IMovable, Models
    {
        //fields
        public enum Model
        {
            W123,
            W201,
            W140,
            W210,
            Gelandewagen
        }

        //constructors
        public Mercedes(string Name, string Color, string ComfortLevel, uint YearMade, uint NumberOfSeats, uint TrunkSize, Model NeededModel, CarType NeededType)
        {
            name = Name;
            color = Color;
            comfortLevel = ComfortLevel;
            yearMade = YearMade;
            numberOfSeats = NumberOfSeats;
            trunkSize = TrunkSize;
            CurrentModel = NeededModel;
            CurrentType = NeededType;
        }

        //properties
        public Model CurrentModel { get; }

        public CarType CurrentType { get; }

        //methods
        public override void Beep()
        {
            Console.WriteLine("Get low, get low, get looow!");
        }

        public void ShowModels()
        {
            Console.WriteLine("The models of Mercedes are: ");
            for (Model toShow = Model.W123; toShow <= Model.Gelandewagen; toShow++)
            {
                Console.WriteLine(toShow);
            }
            Console.WriteLine();
        }
    }
}
