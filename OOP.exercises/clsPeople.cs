using System;
namespace OOP.exercises
{
	internal class clsPeople
	{

        public string Name { get; set; }
        public string LastName { get; set; }
        public int Lenght { get; set; }
        public int Kilo { get; set; }
        public int Age { get; set; }


        public clsPeople( string Ad, string Soyad, int Boy, int kilo, int Yaş)
		{

            Name = Ad;
            LastName = Soyad;
            Lenght = Boy;
            Kilo = kilo;
            Age = Yaş;



		}

        public void Tanis()
        {
            Console.WriteLine("Adım : " + Name + "\n" + " Soyadım : " + LastName + "\n" + "Boyum : " + Lenght + "\n" + "Kilom : " + Kilo + "\n" + "Yaşım : " + Age + "\n"); 
        }

	}
}

