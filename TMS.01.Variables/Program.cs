using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS._01.Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //На всех примитивных типах данных(bool, byste, sbyte, short, ushort, int, uint, long, ulong, double, float, char)
            //Проверить работу всех существующих типов операторов(унарные/ бинарные / тернарные)
            //Если какой либо оператор не применим к типу данных - закомментировать строку с его использованием и оставить комментарий что данный оператор не поддерживается
            //На гите создаем репозиторий с именем Lab1_<имя.фамилия> и заливаем получившуюся прогу туда

           
            bool Ba = true;
            bool Bb = false;
            //bool BSum = Ba + Bb;                        //addition doesnt work with boolean type
            //bool BDiff = Ba - Bb;                       //subtraction doesnt work with boolean type
            //bool BMult = Ba * Bb;                       //multiplication doesnt work with boolean type
            //bool BDiv = Ba % Bb;                        //division doesnt work with boolean type
            //Console.WriteLine($"Addition: {BSum}");
            //Console.WriteLine($"Subtraction: {BDiff}");
            //Console.WriteLine($"Product: {BMult}");
            //Console.WriteLine($"Quotient: {BDiv}");

            Console.WriteLine("BYTE");            
            byte ByA = 54;
            byte ByB = 3;
            byte BySum = (byte)(ByA + ByB);                         //operations work with converting to byte, at first BySum/ByDiff/ByMult/ByDiv has int type
            byte ByDiff = (byte)(ByA - ByB);                        
            byte ByMult = (byte)(ByA * ByB);                        
            byte ByDiv = (byte)(ByA / ByB);                         
            Console.Write($"Addition: {BySum} ");
            Console.Write($"Subtraction: {ByDiff} ");
            Console.Write($"Product: {ByMult} ");
            Console.Write($"Quotient: {ByDiv} ");
            Console.WriteLine();

            Console.WriteLine("SHORT");
            short ShA = 100;
            short ShB = 3;
            short ShSum = (short)(ShA + ShB);                       //the same as byte
            short ShDiff = (short)(ShA - ShB);
            short ShMult = (short)(ShA * ShB);
            short ShDiv = (short)(ShA / ShB);
            Console.Write($"Addition: {ShSum} ");
            Console.Write($"Subtraction: {ShDiff} ");
            Console.Write($"Product: {ShMult} ");
            Console.Write($"Quotient: {ShDiv} ");
            Console.WriteLine();

            Console.WriteLine("INT");
            int Ia = 100;
            int Ib = 3;
            int ISum = Ia + Ib;
            int IDiff = Ia - Ib;
            int IMult = Ia * Ib;
            int IDiv = Ia / Ib;
            Console.Write($"Addition: {ISum} ");
            Console.Write($"Subtraction: {IDiff} ");
            Console.Write($"Product: {IMult} ");
            Console.Write($"Quotient: {IDiv} ");
            Console.WriteLine();

            Console.WriteLine("LONG");
            long La = 100;
            long Lb = 3;
            long LSum = La + Lb;
            long LDiff = La - Lb;
            long LMult = La * Lb;
            long LDiv = La / Lb;
            Console.Write($"Addition: {LSum} ");
            Console.Write($"Subtraction: {LDiff} ");
            Console.Write($"Product: {LMult} ");
            Console.Write($"Quotient: {LDiv} ");
            Console.WriteLine();

            Console.WriteLine("FLOAT");
            float Fa = 10.3f;
            float Fb = 3.3f;
            float FSum = Fa + Fb;
            float FDiff = Fa - Fb;
            float FMult = Fa * Fb;
            float FDiv = Fa / Fb;
            Console.Write($"Addition: {FSum} ");
            Console.Write($"Subtraction: {FDiff} ");
            Console.Write($"Product: {FMult} ");
            Console.Write($"Quotient: {FDiv} ");
            Console.WriteLine();

            Console.WriteLine("DOUBLE");
            double Da = 10.3;
            double Db = 3.3;
            double DSum = Da + Db;
            double DDiff = Da - Db;
            double DMult = Da * Db;
            double DDiv = Da / Db;
            Console.Write($"Addition: {DSum} ");
            Console.Write($"Subtraction: {DDiff} ");
            Console.Write($"Product: {DMult }");
            Console.Write($"Quotient: {DDiv} ");
            Console.WriteLine();

            Console.WriteLine("DECIMAL");
            decimal DeA = 10.3m;
            decimal DeB = 3.3m;
            decimal DeSum = DeA + DeB;
            decimal DeDiff = DeA - DeB;
            decimal DeMult = DeA * DeB;
            decimal DeDiv = DeA / DeB;
            Console.Write($"Addition: {DeSum} ");
            Console.Write($"Subtraction: {DeDiff} ");
            Console.Write($"Product: {DeMult} ");
            Console.Write($"Quotient: {DeDiv} ");
            Console.WriteLine();

            //char ChA = 'A';
            //char ChB = 'B';
            //char ChSum = ChA + ChB;                       //addition doesnt work with char type
            //char ChDiff = ChA - ChB;                      //subtraction doesnt work with char type
            //char ChMult = ChA * ChB;                      //product doesnt work with char type
            //char ChDiv = ChA / ChB;                       //quotient doesnt work with char type
            //Console.WriteLine($"Addition: {ChSum}");
            //Console.WriteLine($"Subtraction: {ChDiff}");
            //Console.WriteLine($"Product: {ChMult}");
            //Console.WriteLine($"Quotient: {ChDiv}");

            Console.WriteLine("STRING");
            string StA = "Thanks God";
            string StB = " it's Frieday";
            string StSum = StA + StB;
            //string StDiff = StA - StB;                    //subtraction doesnt work with string type
            //string StMult = StA * StB;                    //product doesnt work with string type
            //string StDiv = StA / StB;                     //quotient doesnt work with string type
            Console.Write($"Addition: {StSum} ");
            //Console.Write($"Subtraction: {StDiff} ");
            //Console.Write($"Product: {StMult} ");
            //Console.Write($"Quotient: {StDiv} ");
            Console.WriteLine();




            Console.ReadLine();
        }
    }
}
