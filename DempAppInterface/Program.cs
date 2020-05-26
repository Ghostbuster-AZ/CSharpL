using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DempAppInterface
{
    interface Guru99Interface
    {
        void SetTutorial(int pID, string pName);
        String GetTutorial();
    }

    class Guru99Tutorial : Guru99Interface
    {
        protected int TutorialID;
        protected string TutorialName;

        public void SetTutorial(int pID, string pName)
        {
            TutorialID = pID;
            TutorialName = pName;
        }
        public String GetTutorial()
        {
            return TutorialName;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Guru99Tutorial pTutor = new Guru99Tutorial();

            pTutor.SetTutorial(1, ".Net by Guru99");

            Console.WriteLine(pTutor.GetTutorial());

            Console.ReadKey();
        }
    }
}
