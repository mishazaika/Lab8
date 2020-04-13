using System;

namespace LaboratoryWork6_4_
{
    class Student
    {
        private int[] marks;
        private uint AmmountOfStudents;
        public Student(uint Count)

        { // опис конструктора
            marks = new int[Count];

            AmmountOfStudents = Count;
        }

        public uint Size

        {// отримання розміру масиву
            get
            {
                return AmmountOfStudents;
            }
        }
        public int this[int index]

        { // опис індексатора
            get
            {
                if (index >= 0 && index <= Size)

                    return marks[index]; // отримання елементу

                else return 0;
            }
            set
            {
                marks[index] = value; // встановлення значення
            }
        }

        public void Average()
        {
            double average = 0;
            for(int i =0; i< marks.Length; i++)
            {
                average += marks[i];
            }
            average = average / marks.Length;
            Console.WriteLine("Середнє значення: " + average);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student(10);
            st1[0] = 60;
            st1[1] = 75;
            st1[2] = 81;
            st1[4] = 66;
            st1[5] = 73;
            st1[6] = 92;
            st1[7] = 90;
            st1[8] = 90;
            st1[9] = 60;
            st1.Average();
        }
    }
}
