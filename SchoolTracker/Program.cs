﻿using System;
using System.Collections.Generic;

namespace SchoolTracker
{
    enum School{
        Harvard,
        MIT,
        Stanford
    }
    class Program
    {
        static List<Student> students = new List<Student>();
        static void Main(string[] args)
        {
            Logger.Log("Tracker started.", priority: 0);
            PayRoll payroll = new PayRoll();            
            payroll.PayAll();

            var adding = true;
            
            while (adding)
            {
                try
                {
                    Logger.Log("Adding new student.");
                    var newStudent = new Student();

                    newStudent.Name = Util.Console.Ask("Student Name:");

                    newStudent.Grade = Util.Console.AskInt("Student Grade: ");

                    newStudent.School = (School) Util.Console.AskInt("School Name (Corresponding #): \n 0: Harvard \n 1: MIT \n 2: Standford \n");

                    newStudent.Birthday = Util.Console.Ask("Student Birthday:");

                    newStudent.Address = Util.Console.Ask("Student Address:");

                    newStudent.Phone = Util.Console.AskInt("Student Phone:");

                    students.Add(newStudent);
                    Student.Count++;
                    Console.WriteLine("Student Count: {0}", students.Count);

                    Console.WriteLine("Add another student? y/n");

                    if (Console.ReadLine() != "y")
                        adding = false;
                    }

                    catch (FormatException msg)
                    {
                        Console.WriteLine(msg.Message);
                    }
                    
                    catch (Exception)
                    {
                        Console.WriteLine("Error adding student,  please try again.");
                }
            }

            ShowGrade("Tom");

            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade);
            }

            Exports();            
        }

        static void Import()
        {
            var importedStudent = new Student();
        }

        static void Exports()
        {
            foreach (var student in students)
            {
                switch(student.School)
                {
                    case School.Harvard:
                        Console.WriteLine("Exporting to Harvard.");
                        break;
                    case School.MIT:
                        Console.WriteLine("Exporting to MIT.");
                        break;
                    case School.Stanford:
                        Console.WriteLine("Exporting to Stanford.");
                        break;
                }
            }
        }

        static void ShowGrade(string name)
        {
            var found = students.Find(student => student.Name == name);

            Console.WriteLine("{0}'s Grade: {1}", found.Name, found.Grade);
        }
    }

    class Member
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
    }

    class Student : Member
    {
        static public int Count { get; set; } = 0;
        public int Grade { get; set; }
        public string Birthday { get; set; }
        public School School { get; set; }
    

        public Student()
        {

        }
        
        public Student(string name, int grade, string birthday, string address, int phone)
        {
            Name = name;
            Grade = grade;
            Birthday = birthday;
            Address = address;
            Phone = phone;
        }
    }
}
