  
using System;

namespace Lab_8_Ind_1
{
    class BMW : Car, IMovable, IModels
    {
        //fields
        public enum Model
        {
            Z8,
            I8,
            M5,
            M3,
            X5
        }

        private Model currentModel;
        private CarType currentType;
        private bool available = true;

        //constructor
        public BMW(string Name, string Color, string ComfortLevel, uint YearMade, uint NumberOfSeats, uint TrunkSize, Model NeededModel, CarType NeededType)
        {
            name = Name;
            color = Color;
            comfortLevel = ComfortLevel;
            yearMade = YearMade;
            numberOfSeats = NumberOfSeats;
            trunkSize = TrunkSize;
            currentModel = NeededModel;
            currentType = NeededType;
        }

        //destructor
        ~BMW() { Console.WriteLine("LUL"); }

        //properties
        public Model CurrentModel
        {
            get => currentModel;
        }

        public CarType CurrentType
        {
            get => currentType;
        }

        public bool Available { get; set; }

        //methods
        public override void Beep()
        {
            Console.WriteLine("E-RON-DON-DON!!!\a\n");
        }

        public void ShowModels()
        {
            Console.WriteLine("The models of BMW are: ");
            for (Model toShow = Model.Z8; toShow <= Model.X5; toShow++)
            {
                Console.WriteLine(toShow);
            }
            Console.WriteLine();
        }

        public delegate void PurchaseHandler(string message);
        public event PurchaseHandler Notify;
        public void Purchase(int money)
        {
            if (money < price)
                Notify?.Invoke("Something went wrong!");
            else
                Console.WriteLine("Successful!");
        }


    }
}
