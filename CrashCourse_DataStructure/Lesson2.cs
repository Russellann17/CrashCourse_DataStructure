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
            r1.lokkingAt = r2;
            r2.lokkingAt = r1;

            Person p1 = new Person("Alice", "aggressive", false);
            Person p2 = new Person("Becky", "talkative", true);

            p1.robotOwned = r2;
            p2.robotOwned = r1;

            p1.robotOwned.introduceSelf();
            p2.robotOwned.introduceSelf();
        }
      
    }
    class Robot
    {
        public string name { get; set; }
        public string color { get; set; }
        public int weight { get; set; }
        public Robot lokkingAt { get; set; }

        public Robot(string name, string color, int weight)
        {
            this.name = name;
            this.color = color;
            this.weight = weight;
        }
        public void introduceSelf()
        {
            Console.WriteLine("Hi! My name is " + this.name);
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
            this.isSitting = true;
        }
        
        public void standUp()
        {
            this.isSitting = false;
        }
    }
}
