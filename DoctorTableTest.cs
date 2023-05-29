using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class DoctorTableTest
    {
        static void Main(string[] args)
        {
            try
            {
                DoctorTable objDoctorsTable = new DoctorTable();
                objDoctorsTable.AcceptDetails();
                objDoctorsTable.DisplayDetails();
                char input = 'Y';
                do
                {
                    int choice;
                    Console.WriteLine("\nSelect one of he following options; ");
                    Console.WriteLine(" 1.Remove\n 2.Remove All\n 3.Seach\n 4.Exit");
                    Console.Write("Enter your choice : ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            if (objDoctorsTable.Remove())
                            {
                                Console.WriteLine("\n-----After Removing------");
                                objDoctorsTable.DisplayDetails();
                            }
                            else
                                Console.WriteLine("Doctor with this does not exist");
                            break;
                        case 2:
                            objDoctorsTable.objDoctorDetails.Clear();
                            Console.WriteLine("\n------After removing all the doctors------");
                            Console.WriteLine("Total number of doctors : " + objDoctorsTable.objDoctorDetails.Count);
                            return;
                        case 3:
                            objDoctorsTable.Search();
                            break;
                        case 4:
                            return;
                        default:
                            Console.WriteLine("Invalid data Entry!");
                            break;
                    }
                } while (input == 'Y' || input == 'y');
            }catch (Exception objEx)
            {
                Console.WriteLine("Error : {0}", objEx.Message);
            }
        }
    }
}
