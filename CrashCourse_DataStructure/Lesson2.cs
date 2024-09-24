using System;
namespace CrashCourse_DataStructure
{
    class Lesson2
    {
        public static void L2_ClassesAndObjects()
        {
            Robot r1 = new Robot("Tom", "red", 30);
            Robot r2 = new Robot("Jerry", "blue", 40);

            r1.introduceSelf();
            r2.introduceSelf();

            Person p1 = new Person("Alice", "aggressive", false);
            Person p2 = new Person("Becky", "talkative", true);

            p1.IntroduceMe();
            p2.IntroduceMe();
        }
      
    }
    class Robot
    {
        public string name { get; set; }
        public string color { get; set; }
        public int weight { get; set; }

        public Robot(string name, string color, int weight)
        {
            this.name = name;
            this.color = color;
            this.weight = weight;
        }
        public void introduceSelf()
        {
            Console.WriteLine("Hi! I am a robot and my name is " + this.name);
        }
    }

    class Person
    {
        public string name { get; set; }
        public string personality { get; set; }
        public Boolean isSitting { get; set; }
        public Robot robotOwned { get; set; }

        public Person(string name, string personality, bool isSitting)
        {
            this.name = name;
            this.personality = personality;
            this.isSitting = isSitting;
        }

        public void sitDown()
        {
            Console.Write("I am sitting.");
            this.isSitting = true;
        }
        
        public void standUp()
        {
            Console.WriteLine("I am standing.");
            this.isSitting = false;
        }

        public void IntroduceMe()
        {
            Console.WriteLine("Hi, my name is " + this.name);
            if (isSitting)
            {
                Console.WriteLine("I am currently sitting.");
            }
            else
            {
                Console.WriteLine("I am currently standing.");
            }
        }
    }
}
