using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3._4
{
    public struct Person //creation of struct person
    {
        public string first_name;
        public string last_name;
        public sbyte per_age;

    }

    public struct Student //creation of struct student
    {
        public Person st_data;
        public uint stud_id;
        public string college_name;
        public string city_name;
        public string col_address;

    }

    internal class Program
    {

        static void Main(string[] args)
        {

            //hard coding the first student
            Student student1;
            student1.st_data.first_name = "Bruno";
            student1.st_data.last_name = "Lopes";
            student1.st_data.per_age = 34;
            student1.stud_id = 1234567;
            student1.college_name = "Lasalle";
            student1.city_name = "Montreal";
            student1.col_address = "adress 1";

            Student[] student = new Student[5]; //creating an array of students type Student

            List<Student> stdlist = new List<Student>(); //creating the list of students type Student
            var st = new Student();
            student[0] = student1; //including the student 1 in the array of students
            int countArray = 1;
            int opt = 0;

            do
            { //menu with options

            label0:
                Console.WriteLine("-------------------------------\n");
                Console.WriteLine($"Number of students: {countArray}");
                Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------------\n");
                Console.WriteLine("Enter with the option\n\n1) Add a student in the Array\n2) Add a student in the List\n3) Display the students from the Array\n4) Display the students from the List\n5) Add student from Array into the List\n6) Clean the List\n7) quit the application");
                Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------------\n");
                try
                {
                    opt = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------------\n");
                    if (opt < 1 || opt > 7)
                    {
                        Console.WriteLine("Enter with one of the options numers 1, 2, 3, 4, 5, 6 or 7");
                        goto label0;
                    }

                }
                catch (Exception ex0)
                {
                    Console.WriteLine(ex0.Message + "Enter with a valid number from the list");
                    goto label0;
                }

                switch (opt)
                {

                    case 1:
                        {

                            if (countArray < student.Length)
                            {
                                Console.WriteLine("Enter with information of student:");

                                Console.Write("First Name: ");

                                student[countArray].st_data.first_name = Console.ReadLine();

                                Console.Write("Last Name: ");

                                student[countArray].st_data.last_name = Console.ReadLine();

                            label1:
                                Console.Write("Age: ");
                                try
                                {
                                    student[countArray].st_data.per_age = Convert.ToSByte(Console.ReadLine());
                                    if (student[countArray].st_data.per_age < 18 || student[countArray].st_data.per_age > 65)
                                    {
                                        Console.WriteLine("Enter with a valid age (between 18 and 65)");
                                        goto label1;

                                    }
                                }
                                catch (Exception ex3)
                                {
                                    Console.WriteLine(ex3.Message + "Enter with a valid age");
                                    goto label1;
                                }
                            label2:
                                Console.Write("Student ID: ");
                                try
                                {
                                    student[countArray].stud_id = Convert.ToUInt32(Console.ReadLine());

                                }
                                catch (Exception ex4)
                                {
                                    Console.WriteLine(ex4.Message + "Enter with a valid ID");
                                    goto label2;
                                }

                                Console.Write("College Name: ");

                                student[countArray].college_name = Console.ReadLine();


                                Console.Write("City: ");

                                student[countArray].city_name = Console.ReadLine();

                                Console.Write("Address: ");

                                student[countArray].col_address = Console.ReadLine();

                                countArray++;
                                
                            }
                            else
                            {
                                Console.WriteLine("Sorry, the number of students are completed");

                            }


                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter with information of student:");

                            Console.Write("First Name: ");
                            st.st_data.first_name = Console.ReadLine();

                            Console.Write("Last Name: ");
                            st.st_data.last_name = Console.ReadLine();

                        label3:
                            Console.Write("Age: ");
                            try
                            {
                                st.st_data.per_age = Convert.ToSByte(Console.ReadLine());
                                if (st.st_data.per_age < 18 || st.st_data.per_age > 65)
                                {
                                    Console.WriteLine("Enter with a valid age (between 18 and 65)");
                                    goto label3;
                                }
                            }
                            catch (Exception ex5)
                            {
                                Console.WriteLine(ex5.Message + "Enter with a valid age");
                            }

                        label4:
                            Console.Write("Student ID: ");
                            try
                            {
                                st.stud_id = Convert.ToUInt32(Console.ReadLine());

                            }
                            catch (Exception ex4)
                            {
                                Console.WriteLine(ex4.Message + "Enter with a valid ID");
                                goto label4;
                            }

                            Console.Write("College Name: ");

                            st.college_name = Console.ReadLine();


                            Console.Write("City: ");

                            st.city_name = Console.ReadLine();

                            Console.Write("Address: ");

                            st.col_address = Console.ReadLine();

                           

                            stdlist.Add(st);
                            countArray++;

                            break;
                        }

                    case 3:
                        {
                            for (int i = 0; i < student.Length; i++)
                            {
                                if (student[i].st_data.first_name != null)
                                {
                                    
                                    Console.WriteLine($"STUDENT {i + 1}: {student[i].st_data.first_name,-15} {student[i].st_data.last_name,-15}, {student[i].st_data.per_age,10} years old.\nStudent ID: {student[i].stud_id,10}, study at {student[i].college_name,-15}\n City: {student[i].city_name,-15}, Address: {student[i].col_address,-15}");
                                    Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------------\n");
                                }


                            }

                            break;

                        }
                    case 4:
                        {
                            for(int i=0; i < stdlist.Count; i++)
                            {

                                if(stdlist[i].st_data.per_age != 0)
                                {
                                    Console.WriteLine("STUDENT " + i + 1 + ": {0,-10} {1,-10}, {2,8} years old.\nStudent ID: {3,8}, study at {4,-10}\n City: {5,-10}, Address: {6,-10}", stdlist[i].st_data.first_name, stdlist[i].st_data.last_name, stdlist[i].st_data.per_age, stdlist[i].stud_id, stdlist[i].college_name, stdlist[i].city_name, stdlist[i].col_address);
                                    Console.WriteLine("\n=======================================================================================================================\n");


                                }


                            }
                            break;
                        }

                    case 5:
                        {
                            stdlist.AddRange(student);
                            Console.WriteLine("The students from the array were added into the list");
                            
                            break;
                        }
                    case 6:
                        {
                            stdlist.Clear();
                            Console.WriteLine("The list was cleared");
                            break;
                        }
                    
                    case 7:
                        {
                            label5:
                            Console.WriteLine("Are you sure do you want to quit?");
                            Console.WriteLine("1) YES\n2) NO");
                            int quit = Convert.ToInt16(Console.ReadLine());
                            if (quit == 1 || quit == 2)
                            {
                                switch (quit)
                                {
                                    case 1:
                                        {
                                            Console.WriteLine("bye bye");
                                            break;
                                        }
                                    case 2:
                                        {
                                            goto label0;
                                        }

                                }

                            }
                            else 
                            {
                                Console.WriteLine("Enter with a valid option (1 or 2)");
                                goto label5;
                            
                            }
                            
                            break;
                        }
                }

            } while (opt != 7);

        }
    }
}
