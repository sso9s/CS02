﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_bmi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double weight, height;

            Console.Write("키(cm): ");
            height = double.Parse(Console.ReadLine());

            Console.Write("체중(kg): ");
            weight = double.Parse(Console.ReadLine());

            double bmi = weight / (height / 100 * height / 100);            
            Console.WriteLine("BMI = " + bmi + "입니다.");
            Console.WriteLine("BMI = {0}입니다.", bmi); // 매개변수가 많아질 수로 이 방법이 편함

            // 문자열 + 문자열 -> 문자열
            // 문자열 + 숫자 -> 문자열
        }
    }
}