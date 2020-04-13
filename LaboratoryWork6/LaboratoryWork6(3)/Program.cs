using System;

namespace LaboratoryWork6_3_
{
    class MagazineList
    {
        private string[] list;

        private uint AmmountOfProducts;

        public MagazineList(uint Count)

        { // опис конструктора
            list = new string[Count];

            AmmountOfProducts = Count;
        }

        public uint Size

        {// отримання розміру масиву
            get
            {
                return AmmountOfProducts;
            }
        }
        public string this[int index]

        { // опис індексатора
            get
            {
                if (index >= 0  && index <= Size)

                    return list[index]; // отримання елементу

                else return "Wrong number of floor";
            }
            set
            {
                list[index] = value; // встановлення значення
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MagazineList lst = new MagazineList(3);
            lst[0] = "Apple";
            lst[1] = "Banana";
            lst[2] = "Rice";
            for (int i = 0; i < lst.Size; i++)
            {
                Console.WriteLine("In the magazine list: {0}", lst[i]);
            }
            Console.ReadKey();
        }
    }
}
