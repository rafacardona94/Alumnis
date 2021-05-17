using System;
//Add functionalities such as Lists
using System.Collections.Generic;

namespace C__Course
{
    class Program
    {
        static void Main(string[] args)
        {
        //Create an array
            // string[] name = new string[lenght];
                //Add to array: name[i] = *;
                //Sort alphabetically: Array.Sort(name);

        //Create a list
            //List<string> name = new List<string>();
                //Add to list: name.Add();

        //Create while loop
            //while (condition) {}
                // == equal to
                // != not equal to        
                // > <  
        int totalStu;
        int totalSubj;

        Console.WriteLine("How many students are in the class?: ");
            totalStu = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("How many subjects are to evaluate?: ");
            totalSubj = Convert.ToInt32(Console.ReadLine());
        
        string[] students = new string [totalStu];
        string[] subjects = new string [totalSubj];
        List<int> averageGrad = new List<int>();
        
        //Add students to "students" array
        Console.WriteLine("Type the names of the students:");
        
            for (int countStu = 0; countStu < students.Length; countStu++)
                {
                    students[countStu] = Console.ReadLine();
                    
                }
        //Add subjects to the "subjects" array   
        Console.WriteLine("Type name of the subjects to evaluate:");
        
            for (int inputSubj = 0; inputSubj < subjects.Length; inputSubj++)
                {
                    subjects[inputSubj] = Console.ReadLine();
                    
                }

        
        //Add a grade to each subject
        for (int gradesIn = 0; gradesIn <= students.Length -1; gradesIn++)
        {
            averageGrad.Add(0);
            Console.WriteLine("Input the grades of " + students[gradesIn] + ":");
            for (int subjCount =0; subjCount <= subjects.Length -1; subjCount++)
            {
                Console.WriteLine(subjects[subjCount] + ":");
                averageGrad[gradesIn] = averageGrad[gradesIn] + Convert.ToInt32(Console.ReadLine());    
            }
            

        }    
        //Set the average grade to pass.
        int averageToPass;    

        Console.WriteLine("What is the average grade to pass the year?");
        averageToPass = Convert.ToInt32(Console.ReadLine());
           
            while (averageToPass > 10)
            {
                Console.WriteLine("Average grade must be between 0 and 10");
                Console.WriteLine("What is the average grade to pass the year?");
                    averageToPass = Convert.ToInt32(Console.ReadLine());
            }
        
        
        //Show averages and wich students pass or failed
        Console.WriteLine("Results:");

        for (int results=0; results <= students.Length-1; results++)   
        {
            if (averageGrad[results] / subjects.Length >= averageToPass)
            {
                Console.WriteLine(students[results] + " has passed with an average grade of: " + averageGrad[results] / subjects.Length);    
            }
            else
            {
                Console.WriteLine(students[results] + " has failed with an average grade of: " + averageGrad[results] / subjects.Length);    
            }
        }
        

           //Wait before closing
            Console.ReadKey();

        }
    }
}
