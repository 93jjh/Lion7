using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _2026_01_05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //const double Pi = 3.14159;

            //const int MaxScore = 100;

            //Console.WriteLine("pi: " + Pi);
            //Console.WriteLine("Max Score: " + MaxScore);


            //const int MaxPlayer = 4;
            //const int Gold = 1000;
            //const string Version = "1.0.0";

            //Console.WriteLine("=== 게임 설정 ===");
            //Console.WriteLine($"최대 플레이어: {MaxPlayer}명");
            //Console.WriteLine($"시작골드: {Gold}G");
            //Console.WriteLine("버전: " + Version);


            //int integerNum = 10;
            //float floatNum = 3.14f;
            //double doubleNum = 3.14159;

            //Console.WriteLine(integerNum);
            //Console.WriteLine(floatNum);
            //Console.WriteLine(doubleNum);


            /*
            byte level = 50;
            short attack = 1500;
            int gold = 123456789;
            long experience = 999999999999L; // L 접미사 필수

            Console.WriteLine($"소지금 {gold:N0} 골드");
            Console.WriteLine($"경험치 {experience:N0}");


            // 타입별 최대값 확인
            Console.WriteLine("\n=== 타입별 최대값 ===");
            Console.WriteLine($"byte 최대값: {byte.MaxValue}");
            */


            //float singlePrecision = 3.14f; // 4 바이트
            //double doublePrecision = 3.1415926535; // 8 바이트
            //decimal highPresicion = 3.1415926535897932384626433833m; // 16 바이트

            //Console.WriteLine(singlePrecision);
            //Console.WriteLine(doublePrecision);
            //Console.WriteLine(highPresicion);

            //int integerValue = 100;
            //long longValue = 100L;
            //float floatValue = 3.14f;
            //double doubleValue = 3.14;
            //decimal decimalValue = 3.14m;


            //Console.WriteLine(integerValue);
            //Console.WriteLine(longValue);
            //Console.WriteLine(floatValue);
            //Console.WriteLine(decimalValue);
            //Console.WriteLine(decimalValue);



            // char 형식 : 단일문자

            //char letter = 'a';
            //char symbol = '#';
            //char number = '3';

            //Console.WriteLine(letter);
            //Console.WriteLine(symbol);
            //Console.WriteLine(number);



            //float MOVESPEED = 5.5f;
            //double ATTACKSPEED = 1.25;
            //decimal ITEMPRICE = 12.99m;

            //Console.WriteLine("=== 캐릭터 능력치 ===");
            //Console.WriteLine($"이동속도 {MOVESPEED}");
            //Console.WriteLine($"공격속도 {ATTACKSPEED}");
            //Console.WriteLine($"아이템 가격 {ITEMPRICE}");


            //string 형식: 여러 문자를 저장
            //string greeting = "Hello, World";
            //string name = "Alice";
            //Console.WriteLine(greeting);
            //Console.WriteLine(name);

            //char grade = 'A';
            //char symbol = '★';
            //char number = '9';

            //string playerName = "홍길동";
            //string welcomeMessage = "게임에 오신 것을 환영합니다";
            //string emptyString = " ";


            //Console.WriteLine("=== RPG 게임 ===");
            //Console.WriteLine("플레이어: " + playerName);
            //Console.WriteLine("등급 " + grade + emptyString + symbol);
            //Console.WriteLine(welcomeMessage);





            //bool isRinnong = true;
            //bool isFinished = false;

            //Console.WriteLine(isRinnong);
            //Console.WriteLine(isFinished);


            //bool playing = true;
            //bool stopping = false;
            //bool key = false;
            //bool opendoor = false;
            //bool live = true;

            //int hp = 80;
            //bool health = true;
            //bool danger = false;

            //Console.WriteLine("=== 게임상태 ===");
            //Console.WriteLine("게임 실행중: " + playing);
            //Console.WriteLine("일시정지: " + stopping);
            //Console.WriteLine("열쇠 소지:" + key);
            //Console.WriteLine("문 열림: " + opendoor);
            //Console.WriteLine("플레이어 생존: " + live);


            //int number = 100;
            //string numberAsString = number.ToString(); // 정수를 문자열로 변화
            //Console.WriteLine(numberAsString);

            //bool flag = true;
            //string flagAsString = flag.ToString();
            //Console.WriteLine(flagAsString); // 논리값을 문자열로 변화


            //로딩중
            Console.WriteLine("로딩중....");
            Console.Write("진행률 : [");
            Console.Write("■");
            Thread.Sleep(500);

            Console.Write("■");
            Thread.Sleep(500);

            Console.Write("■");
            Thread.Sleep(500);

            Console.Write("■");
            Thread.Sleep(500);

            Console.Write("■");
            Thread.Sleep(500);

            Console.Write("■");
            Thread.Sleep(500);

            Console.Write("■");
            Thread.Sleep(500);

            Console.Write("■");
            Thread.Sleep(500);

            Console.Write("■");
            Thread.Sleep(500);

            Console.Write("] 100% \n");
        }
    }
    
}
