using System;

namespace Hello
{
    internal class Program
    {
        public class Class1
        {

            public string name;
            private double age;
            private double Experience;


            public void setname(string name)
            {
                this.name = name;
            }
            public void setage(double age)
            {
                this.age = age;
            }
            public void setexp(double Experience)
            {
                this.Experience = Experience;
            }

            public bool getage()
            {
                bool pass = true;

                if (age >= 18)
                {
                    pass = true;
                }
                else
                {
                    pass = false;
                }
                return pass;
            }

            public bool getexp()

            {
                bool pass = true;

                switch (Experience)
                {
                    case 1:
                        pass = false;
                        break;

                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:

                        pass = true;
                        break;

                    default:
                        pass = true;
                        break;
                }
                return pass;
            }

            public void result()
            {
                if (getexp() == true && getage() == true)
                {
                    Console.WriteLine("congratulation \n welcome to our organization ");
                }
                else
                {
                    Console.WriteLine(
                        "Sorry \n you are not able to be part of our company  \n\n :Your age should be 18+ with Experience of atleast To years "
                                     );
                }

            }
        }


        static void Main(string[] args)
        {
            Class1 obj = new Class1();

            Console.WriteLine(" how old you are?");
            double age = double.Parse(Console.ReadLine());

            Console.WriteLine(" how many year experience do you have in computer Science background?");
            double Exp = double.Parse(Console.ReadLine());


            obj.setage(age);
            obj.setexp(Exp);
            obj.getage();
            obj.getexp();
            obj.result();
            Console.ReadLine();

        }
    }
}
