using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    abstract class Tutorial
    {
        public virtual void Set()
        {

        }
    }
    class Guru99Tutorial : Tutorial
    {
        protected int TutorialID;
        protected String TutorialName;
        //Constructor

        public void setTutorial(int id, string name)
        {
            TutorialID = id;
            TutorialName = name;
        }
        public void setTutorial(string name)
        {
            TutorialName = name;
        }
    }

}
