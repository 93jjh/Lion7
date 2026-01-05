using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_12_31
{
    internal class Program
    {
       
        static void Main(string[] args)
        {

            //int age; // 정수형 변수를 담을 수 있음
            //age = 10;

            //Console.WriteLine(age);

            //int level = 100;

            //Console.WriteLine(level);


            //리터럴 : 코드에서 고정된 값을 의미

            //int number = 10; // 정수형 리터럴
            //double pi = 3.14; // 실수형 리터럴
            //char letter = 'a'; // 문자 리터럴
            //string name = "Alice"; // 문자열 리터럴

            //Console.WriteLine(number);
            //Console.Write(pi);
            //Console.WriteLine(letter);
            //Console.WriteLine(name);

            //int 플레이스코어 = 100;
            //double 파이 = 3.14;
            //char 등급 = 'A';
            //string 플레이어이름 = "홍길동";

            //Console.WriteLine(플레이스코어);
            //Console.WriteLine(파이);
            //Console.Write(등급 + "\n");
            //Console.WriteLine(플레이어이름);


            //int posX = 0, posY = 50, posZ = 100;

            //int red = 255, green = 128, blue = 0;

            //Console.WriteLine($"x: {posX}, y: {posY}, z: {posZ}");
            //Console.WriteLine($"red: {red}, green: {green}, blue: {blue}");


            int level        = 9;
            int vigor        = 15;
            int mind         = 10;
            int endurance    = 11;
            int strenghth    = 14;
            int dexterity    = 13;
            int intelligence = 9;
            int faith        = 9;
            int arcane       = 7;

            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine($"┃    level          {level}   ┃ ");
            Console.WriteLine($"┃    vigor          {vigor       }  ┃ ");
            Console.WriteLine($"┃    mind           {mind        }  ┃ ");
            Console.WriteLine($"┃    endurance      {endurance   }  ┃ ");
            Console.WriteLine($"┃    strenghth      {strenghth   }  ┃ ");
            Console.WriteLine($"┃    dexterity      {dexterity   }  ┃ ");
            Console.WriteLine($"┃    intelligence   {intelligence}   ┃ ");
            Console.WriteLine($"┃    faith          {faith       }   ┃ ");
            Console.WriteLine($"┃    arcane         {arcane      }   ┃ ");
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━┛");
        }
    }
}
