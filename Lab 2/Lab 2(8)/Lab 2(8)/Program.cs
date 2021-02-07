using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_8_
{
    class Program
    {
        static void Main(string[] args)
        {
            double total_number_of_physics = 100;
            double physics_marks = 90;
            double percentage_of_physics = (physics_marks * 100) / total_number_of_physics;

            if (percentage_of_physics >= 90)
            {
                Console.WriteLine("Physics Grade: A+");
            }
            else if (percentage_of_physics >= 85 || percentage_of_physics < 90)
            {
                Console.WriteLine("Physics Grade: A");
            }
            else if (percentage_of_physics >= 80 || percentage_of_physics < 85)
            {
                Console.WriteLine("Physics Grade: B+");
            }
            else if (percentage_of_physics >= 75 || percentage_of_physics < 80)
            {
                Console.WriteLine("PhysicsGrade: B");
            }
            else if (percentage_of_physics >= 70 || percentage_of_physics < 75)
            {
                Console.WriteLine("Physics Grade: A+");
            }
            else if (percentage_of_physics < 50)
            {
                Console.WriteLine("Physics Grade: F");
            }

            double total_number_of_chemistry = 50;
            double chemistry_marks = 46;
            double percentage_of_chemistry = (chemistry_marks * 100) / total_number_of_chemistry;


            if (percentage_of_chemistry >= 90)
            {
                Console.WriteLine("Chemistry Grade: A+");
            }
            else if (percentage_of_chemistry >= 85 && percentage_of_chemistry < 90)
            {
                Console.WriteLine("Chemistry Grade: A");
            }
            else if (percentage_of_chemistry >= 80 && percentage_of_chemistry < 85)
            {
                Console.WriteLine("Chemistry Grade: B+");
            }
            else if (percentage_of_chemistry >= 75 && percentage_of_chemistry < 80)
            {
                Console.WriteLine("Chemistry Grade: B");
            }
            else if (percentage_of_chemistry >= 70 && percentage_of_chemistry < 75)
            {
                Console.WriteLine("Chemistry Grade: A+");
            }
            else if (percentage_of_chemistry < 50)
            {
                Console.WriteLine("Chemistry Grade: F");
            }

            double total_number_of_biology = 80;
            double biology_marks = 66;
            double percentage_of_biology = (biology_marks * 100) / total_number_of_biology;

            if (percentage_of_biology >= 90)
            {
                Console.WriteLine("Biology Grade: A+");
            }
            else if (percentage_of_biology >= 85 && percentage_of_biology < 90)
            {
                Console.WriteLine("Biology Grade: A");
            }
            else if (percentage_of_biology >= 80 && percentage_of_biology < 85)
            {
                Console.WriteLine("Biology Grade: B+");
            }
            else if (percentage_of_biology >= 75 && percentage_of_biology < 80)
            {
                Console.WriteLine("Biology Grade: B");
            }
            else if (percentage_of_biology >= 70 && percentage_of_biology < 75)
            {
                Console.WriteLine("Biology Grade: A+");
            }
            else if (percentage_of_biology < 50)
            {
                Console.WriteLine("Biology Grade: F");
            }

            double total_number_of_mathematics = 70;
            double mathematics_marks = 56;
            double percentage_of_mathematics = (mathematics_marks * 100) / total_number_of_mathematics;

            if (percentage_of_mathematics >= 90)
            {
                Console.WriteLine("Mathematics Grade: A+");
            }
            else if (percentage_of_mathematics > 84 && percentage_of_mathematics < 90)
            {
                Console.WriteLine("Mathematics Grade: A");
            }
            else if (percentage_of_mathematics > 79 && percentage_of_mathematics < 85)
            {
                Console.WriteLine("Mathematics Grade: B+");
            }
            else if (percentage_of_mathematics > 74 && percentage_of_mathematics < 80)
            {
                Console.WriteLine("Mathematics Grade: B");
            }
            else if (percentage_of_mathematics > 69 && percentage_of_mathematics < 75)
            {
                Console.WriteLine("Mathematics Grade: A+");
            }
            else if (percentage_of_mathematics < 50)
            {
                Console.WriteLine("Mathematics Grade: F");
            }

            double total_number_of_computer = 80;
            double computer_marks = 60;
            double percentage_of_computer = (computer_marks * 100) / total_number_of_computer;

            if (percentage_of_computer >= 90)
            {
                Console.WriteLine("Computer Grade: A+");
            }
            else if (percentage_of_computer >= 85 && percentage_of_computer < 90)
            {
                Console.WriteLine("Computer Grade: A");
            }
            else if (percentage_of_computer >= 80 && percentage_of_computer < 85)
            {
                Console.WriteLine("Computer Grade: B+");
            }
            else if (percentage_of_computer >= 75 && percentage_of_computer < 80)
            {
                Console.WriteLine("Computer Grade: B");
            }
            else if (percentage_of_computer >= 70 && percentage_of_computer < 75)
            {
                Console.WriteLine("Computer Grade: A+");
            }
            else if (percentage_of_computer < 50)
            {
                Console.WriteLine("Computer Grade: F");
            }
        }
    }
}
