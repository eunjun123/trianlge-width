using System;
class triangle
{
    static void Main(string[] args)
    {
        int a, b, c; // 삼각형 세변의 길이 변수
        double l; // 세변의 길이합 나누기 2
        double Sum; // 세변의 지수값을 합할 변수
        double s; // 삼각형의 넓이

        Console.Write("삼각형의 세변의 값을 입력하세요: "); // 삼각형의 세변의 값 입력받기
        a = Console.Read() - '0';
        b = Console.Read() - '0';
        c = Console.Read() - '0';

        l = (double)(a + b + c) / 2.0; // ㅣ값 구하기

        Sum = l * (l - a); 
        Sum *= (l - b);
        Sum *= (l - c); 

        s=Math.Sqrt(Sum);

        Console.WriteLine("{0},{1},{2} 세변의 삼각형의 넓이 : {3:0.##}", a, b, c, s);
    } 
}