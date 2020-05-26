using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DempAppClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Guru99Tutorial pTutor = new Guru99Tutorial();
            pTutor.RenameTutorial(".net by guru99");
            Console.WriteLine(pTutor.GetTutorial());

            Tutorial tutor = new Tutorial();
            tutor.setTutorial(1,"C#");
            Console.WriteLine(tutor.GetTutorial());
            tutor.setTutorial("2C#");
            Console.WriteLine(tutor.GetTutorial());

            Console.ReadKey();
        }
        class Guru99Tutorial : Tutorial
        {
            public void RenameTutorial(String pNewName)
            {
                TutorialName = pNewName;
            }
        }
        class Tutorial
        {
            protected int TutorialID;
            protected String TutorialName;
            //Constructor
            public Tutorial()
            {
                TutorialID = 0;
                TutorialName = "Default";
            }

            public void setTutorial(int id, string name)
            {
                TutorialID = id;
                TutorialName = name;
            }
            public void setTutorial(string name)
            {
                TutorialName = name;
            }

            public String GetTutorial()
            {
                return TutorialName;
            }
        }
    }
}
