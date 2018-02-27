using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ElawadyDataStructureTest;

namespace task_2
{
    class Program :ElawadyDataStructureTest.Test.GradeCalc
    {
        static void Main(string[] args)
        {



            Subject math1 = new Subject("math1", 1);
            Subject phsycis1 = new Subject("physics1", 2);
            Subject mechanics1 = new Subject("mechanics1", 3);
            Subject chemistry = new Subject("chemistry", 4);
            Subject english1 = new Subject("english1", 5);
            Subject computer = new Subject("computer", 6);
            Subject math2 = new Subject("math2", 7);
            Subject phsycis2 = new Subject("physics2", 8);
            Subject mechanics2 = new Subject("mechanics2", 9);
            Subject drawing = new Subject("drawing", 10);
            Subject production = new Subject("production", 11);
            Subject english2 = new Subject("english2", 12);
            Subject math3 = new Subject("math3", 13);
            Subject programming = new Subject("programming", 14);
            Subject logic = new Subject("logic", 15);
            Subject circuit = new Subject("circuit", 16);
            Subject electronics1 = new Subject("electronics1", 17);
            Subject word = new Subject("word", 18);
            Subject math4 = new Subject("math4", 19);
            Subject programmingApplication = new Subject("programming application", 20);
            Subject measure = new Subject("measure", 21);
            Subject circuit2 = new Subject("circuit2", 22);
            Subject electronics2 = new Subject("electronics2", 23);
            Subject excel = new Subject("excel", 24);
            Subject digital = new Subject("digital", 25);
            Subject datastructure = new Subject("data structure", 26);
            Subject numerical = new Subject("numerical", 27);
            Subject communication1 = new Subject("communication1", 28);
            Subject energy = new Subject("energy", 29);
            Subject engineeringtech = new Subject("engineeringtech", 30);
            Subject math5 = new Subject("math5", 31);
            Subject oop = new Subject("oop", 32);
            Subject comArtc = new Subject("comArtc", 33);
            Subject mechine = new Subject("mechine", 34);
            Subject communication2 = new Subject("communication 2", 35);
            Subject embded = new Subject("embded", 36);
            Subject database = new Subject("data base", 37);
            Subject micro = new Subject("micro", 38);
            Subject control = new Subject("control", 39);
            Subject choise1 = new Subject("choise 1", 40);
            Subject choise2 = new Subject("choise 2", 41);
            Subject choise3 = new Subject("choise 3", 42);
            Subject choise4 = new Subject("choise4", 43);
            Subject choise5 = new Subject("choise5", 44);
            Subject choise6 = new Subject("choise6", 45);
            Subject choise7 = new Subject("choise7", 46);
            Subject choise8 = new Subject("choise8", 49);
            Subject choise9 = new Subject("choise9", 50);
            Subject choise10 = new Subject("choise10", 51);
            Subject choise11 = new Subject("choise11", 52);
            Subject choise12 = new Subject("choise12", 53);
            Subject choise13 = new Subject("choise13", 54);
            Subject choise14 = new Subject("choise14", 55);
            Subject choise15 = new Subject("choise15", 56);
            Subject choise16 = new Subject("choise16", 57);
            Subject choise17 = new Subject("choise17", 58);int x = 5;
            Subject choise18 = new Subject("choise18", 59);
            Subject choise19 = new Subject("choise19", 60);
            Subject choise20 = new Subject("choise20", 61);
            List<Subject> firstterm = new List<Subject>();
            firstterm.Add(math1);
            firstterm.Add(phsycis1);
            firstterm.Add(electronics1);
            firstterm.Add(mechanics1);
            firstterm.Add(chemistry);
            firstterm.Add(computer);

            List<Subject> secondterm = new List<Subject>();
            secondterm.Add(english2);
            secondterm.Add(math2);
            secondterm.Add(mechanics2);
            secondterm.Add(phsycis2);
            secondterm.Add(production);
            secondterm.Add(drawing);
            List<Subject> third = new List<Subject>();
            third.Add(math3);
            third.Add(programming);
            third.Add(logic);
            third.Add(circuit);
            third.Add(electronics1);
            third.Add(word);
            List<Subject> fourth = new List<Subject>();
            fourth.Add(math4);
            fourth.Add(programmingApplication);
            fourth.Add(measure);
            fourth.Add(circuit2);
            fourth.Add(electronics2);
            fourth.Add(excel);
            List<Subject> fifth = new List<Subject>();
            fifth.Add(digital);
            fifth.Add(datastructure);
            fifth.Add(numerical);
            fifth.Add(communication1);
            fifth.Add(energy);
            fifth.Add(engineeringtech);
            List<Subject> sixth = new List<Subject>();
            sixth.Add(math5);
            sixth.Add(oop);
            sixth.Add(comArtc);
            sixth.Add(mechine);
            sixth.Add(communication2);
            List<Subject> seventh = new List<Subject>();
            seventh.Add(embded);
            seventh.Add(database);
            seventh.Add(micro);
            seventh.Add(control);
            seventh.Add(choise1);
            seventh.Add(choise2);
            List<Subject> eight = new List<Subject>();
            eight.Add(choise3);
            eight.Add(choise4);
            eight.Add(choise5);
            eight.Add(choise6);
            eight.Add(choise7);
            eight.Add(choise8);
            List<Subject> ninth = new List<Subject>();
            ninth.Add(choise9);
            ninth.Add(choise10);
            ninth.Add(choise11);
            ninth.Add(choise12);
            ninth.Add(choise13);
            ninth.Add(choise14);
            List<Subject> ten = new List<Subject>();
            ten.Add(choise15);
            ten.Add(choise16);
            ten.Add(choise17);
            ten.Add(choise18);
            ten.Add(choise19);
            ten.Add(choise20);

            List<Subject>[] subjectsArray = new List<Subject>[10];

            subjectsArray[0] = firstterm;
            subjectsArray[1] = secondterm;
            subjectsArray[2] = third;
            subjectsArray[3] = fourth;
            subjectsArray[4] = fifth;
            subjectsArray[5] = sixth;
            subjectsArray[6] = seventh;
            subjectsArray[7] = eight;
            subjectsArray[8] = ninth;
            subjectsArray[9] = ten;

            SumbitPeek.offset = 0.0f;///الثغره 

            Test.GetGrade(subjectsArray);















        }
    }
}
