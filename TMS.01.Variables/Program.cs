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


            Console.WriteLine("BOOL");
            bool Ba = true;
            bool Bb = false;
            //bool BSum = Ba + Bb;                          //addition doesnt work with boolean type
            //bool BDiff = Ba - Bb;                         //subtraction doesnt work with boolean type
            //bool BMult = Ba * Bb;                         //multiplication doesnt work with boolean type
            //bool BDiv = Ba / Bb;                          //division doesnt work with boolean type
            //bool BRem = Ba % Bb;                          //remainder of division doesnt work with boolean type
            //bool BIn = ++Ba;                              //increment doesnt work with boolean type
            //bool BDec = --Ba;                             //decrement doesnt work with boolean type
            bool BLogMult = Ba & Bb;
            bool BLogSum = Ba | Bb;
            bool BLogExcep = Ba ^ Bb;
            //bool BShiftR = Ba >> Bb;                     //Shift Right doesnt work with boolean type
            //bool BShiftL = Ba << Bb;                     //Shift Left doesnt work with boolean type
            //bool BInv = ~ Ba;                            //Inversion doesnt work with boolean type
            //Console.Write($"Addition: {BSum} ");
            //Console.Write($"Subtraction: {BDiff} ");
            //Console.Write($"Product: {BMult} ");
            //Console.Write($"Quotient: {BDiv} ");
            //Console.Write($"Remainder of division: {BRem} ");
            //Console.Write($"Increment: {BIn} ");
            //Console.Write($"Decrement: {BDec} ");
            Console.Write($"Logical Product: {BLogMult} ");
            Console.Write($"Logical Addition: {BLogSum} ");
            Console.Write($"Logical Exception: {BLogExcep} ");
            //Console.Write($"Shift Right: {BShiftR} ");
            //Console.Write($"Shift Left: {BShiftL} ");
            //Console.Write($"Inversion: {BInv} ");
            Console.WriteLine();

            Console.WriteLine("BYTE");            
            byte ByA = 54;
            byte ByB = 3;
            byte BySum = (byte)(ByA + ByB);                         //operations work with converting to byte
            byte ByDiff = (byte)(ByA - ByB);                        
            byte ByMult = (byte)(ByA * ByB);                        
            byte ByDiv = (byte)(ByA / ByB);
            byte ByRem = (byte)(ByA % ByB);
            byte ByIn = ++ByA;
            byte ByDec = --ByA;
            byte ByLogMult = (byte)(ByA & ByB);
            byte ByLogSum = (byte)(ByA | ByB);
            byte ByLogExcep = (byte)(ByA ^ ByB);
            byte ByShiftR = (byte)(ByA >> ByB);
            byte ByShiftL = (byte)(ByA << ByB);
            byte ByInv = (byte)(~ ByA);
            Console.Write($"Addition: {BySum} ");
            Console.Write($"Subtraction: {ByDiff} ");
            Console.Write($"Product: {ByMult} ");
            Console.Write($"Quotient: {ByDiv} ");
            Console.Write($"Remainder of division: {ByRem} ");
            Console.Write($"Increment: {ByIn} ");
            Console.Write($"Decrement: {ByDec} ");
            Console.Write($"Logical Product: {ByLogMult} ");
            Console.Write($"Logical Addition: {ByLogSum} ");
            Console.Write($"Logical Exception: {ByLogExcep} ");
            Console.Write($"Inversion: {ByInv} ");
            Console.Write($"Shift Right: {ByShiftR} ");
            Console.Write($"Shift Left: {ByShiftL} ");
            Console.WriteLine();

            Console.WriteLine("SBYTE");
            sbyte SByA = 23;
            sbyte SByB = 2;
            sbyte SBySum = (sbyte)(SByA + SByB);                         //operations work with converting to byte
            sbyte SByDiff = (sbyte)(SByA - SByB);
            sbyte SByMult = (sbyte)(SByA * SByB);
            sbyte SByDiv = (sbyte)(SByA / SByB);
            sbyte SByRem = (sbyte)(SByA % SByB);
            sbyte SByIn = ++ SByA;
            sbyte SByDec = -- SByA;
            sbyte SByLogMult = (sbyte)(SByA & SByB);
            sbyte SByLogSum = (sbyte)(SByA | SByB);
            sbyte SByLogExcep = (sbyte)(SByA ^ SByB);
            sbyte SByShiftR = (sbyte)(SByA >> SByB);
            sbyte SByShiftL = (sbyte)(SByA << SByB);
            sbyte SByInv = (sbyte)(~SByA);
            Console.Write($"Addition: {SBySum} ");
            Console.Write($"Subtraction: {SByDiff} ");
            Console.Write($"Product: {SByMult} ");
            Console.Write($"Quotient: {SByDiv} ");
            Console.Write($"Remainder of division: {SByRem} ");
            Console.Write($"Increment: {SByIn} ");
            Console.Write($"Decrement: {SByDec} ");
            Console.Write($"Logical Product: {SByLogMult} ");
            Console.Write($"Logical Addition: {SByLogSum} ");
            Console.Write($"Logical Exception: {SByLogExcep} ");
            Console.Write($"Inversion: {SByInv} ");
            Console.Write($"Shift Right: {SByShiftR} ");
            Console.Write($"Shift Left: {SByShiftL} ");
            Console.WriteLine();

            Console.WriteLine("SHORT");
            short ShA = 100;
            short ShB = 3;
            short ShSum = (short)(ShA + ShB);                       //the same as byte
            short ShDiff = (short)(ShA - ShB);
            short ShMult = (short)(ShA * ShB);
            short ShDiv = (short)(ShA / ShB);
            short ShRem = (short)(ShA % ShB);
            short ShIn = ++ ShA;
            short ShDec = -- ShA;
            short ShLogMult = (short)(ShA & ShB);
            short ShLogSum = (short)(ShA | ShB);
            short ShLogExcep = (short)(ShA ^ ShB);
            short ShShiftR = (short)(ShA >> ShB);
            short ShShiftL = (short)(ShA << ShB);
            short ShInv = (short)(~ShA);
            Console.Write($"Addition: {ShSum} ");
            Console.Write($"Subtraction: {ShDiff} ");
            Console.Write($"Product: {ShMult} ");
            Console.Write($"Quotient: {ShDiv} ");
            Console.Write($"Remainder of division: {ShRem} ");
            Console.Write($"Increment: {ShIn} ");
            Console.Write($"Decrement: {ShDec} ");
            Console.Write($"Logical Product: {ShLogMult} ");
            Console.Write($"Logical Addition: {ShLogSum} ");
            Console.Write($"Logical Exception: {ShLogExcep} ");
            Console.Write($"Inversion: {ShInv} ");
            Console.Write($"Shift Right: {ShShiftR} ");
            Console.Write($"Shift Left: {ShShiftL} ");
            Console.WriteLine();

            Console.WriteLine("USHORT");
            ushort UShA = 623;
            ushort UShB = 30;
            ushort UShSum = (ushort)(UShA + UShB);                       //the same as byte
            ushort UShDiff = (ushort)(UShA - UShB);
            ushort UShMult = (ushort)(UShA * UShB);
            ushort UShDiv = (ushort)(UShA / UShB);
            ushort UShRem = (ushort)(UShA % UShB);
            ushort UShIn = ++ UShA;
            ushort UShDec = -- UShA;
            ushort UShLogMult = (ushort)(UShA & UShB);
            ushort UShLogSum = (ushort)(UShA | UShB);
            ushort UShLogExcep = (ushort)(UShA ^ UShB);
            ushort UShShiftR = (ushort)(UShA >> UShB);
            ushort UShShiftL = (ushort)(UShA << UShB);
            ushort UShInv = (ushort)(~ UShA);
            Console.Write($"Addition: {UShSum} ");
            Console.Write($"Subtraction: {UShDiff} ");
            Console.Write($"Product: {UShMult} ");
            Console.Write($"Quotient: {UShDiv} ");
            Console.Write($"Remainder of division: {UShRem} ");
            Console.Write($"Increment: {UShIn} ");
            Console.Write($"Decrement: {UShDec} ");
            Console.Write($"Logical Product: {UShLogMult} ");
            Console.Write($"Logical Addition: {UShLogSum} ");
            Console.Write($"Logical Exception: {UShLogExcep} ");
            Console.Write($"Inversion: {UShInv} ");
            Console.Write($"Shift Right: {UShShiftR} ");
            Console.Write($"Shift Left: {UShShiftL} ");
            Console.WriteLine();

            Console.WriteLine("INT");
            int Ia = 100;
            int Ib = 3;
            int ISum = Ia + Ib;
            int IDiff = Ia - Ib;
            int IMult = Ia * Ib;
            int IDiv = Ia / Ib;
            int IRem = Ia % Ib;
            int IIn = ++Ia;
            int IDec = --Ia;
            int ILogMult = Ia & Ib;
            int ILogSum = Ia | Ib;
            int ILogExcep = Ia ^ Ib;
            int IShiftR = Ia >> Ib;
            int IShiftL = Ia << Ib;
            int IInv = ~Ia;
            Console.Write($"Addition: {ISum} ");
            Console.Write($"Subtraction: {IDiff} ");
            Console.Write($"Product: {IMult} ");
            Console.Write($"Quotient: {IDiv} ");
            Console.Write($"Remainder of division: {IRem} ");
            Console.Write($"Increment: {IIn} ");
            Console.Write($"Decrement: {IDec} ");
            Console.Write($"Logical Product: {ILogMult} ");
            Console.Write($"Logical Addition: {ILogSum} ");
            Console.Write($"Logical Exception: {ILogExcep} ");
            Console.Write($"Inversion: {IInv} ");
            Console.Write($"Shift Right: {IShiftR} ");
            Console.Write($"Shift Left: {IShiftL} ");
            Console.WriteLine();

            Console.WriteLine("UINT");
            uint UIa = 3021;
            uint UIb = 3023;
            uint UISum = UIa + UIb;
            uint UIDiff = UIa - UIb;
            uint UIMult = UIa * UIb;
            uint UIDiv = UIa / UIb;
            uint UIRem = UIa % UIb;
            uint UIIn = ++ UIa;
            uint UIDec = -- UIa;
            uint UILogMult = UIa & UIb;
            uint UILogSum = UIa | UIb;
            uint UILogExcep = UIa ^ UIb;
            //uint UIShiftR = UIa >> UIb;           //Shift Right doesnt work with uint type
            //uint UIShiftL = UIa << UIb;           //Shift Left doesnt work with uint type
            uint UIInv = ~ UIa;
            Console.Write($"Addition: {UISum} ");
            Console.Write($"Subtraction: {UIDiff} ");
            Console.Write($"Product: {UIMult} ");
            Console.Write($"Quotient: {UIDiv} ");
            Console.Write($"Remainder of division: {UIRem} ");
            Console.Write($"Increment: {UIIn} ");
            Console.Write($"Decrement: {UIDec} ");
            Console.Write($"Logical Product: {UILogMult} ");
            Console.Write($"Logical Addition: {UILogSum} ");
            Console.Write($"Logical Exception: {UILogExcep} ");
            Console.Write($"Inversion: {UIInv} ");
            //Console.Write($"Shift Right: {UIShiftR} ");
            //Console.Write($"Shift Left: {UIShiftL} ");
            Console.WriteLine();

            Console.WriteLine("LONG");
            long La = 100;
            long Lb = 3;
            long LSum = La + Lb;
            long LDiff = La - Lb;
            long LMult = La * Lb;
            long LDiv = La / Lb;
            long LRem = La % Lb;
            long LIn = ++ La;
            long LDec = -- La;
            long LLogMult = La & Lb;
            long LLogSum = La | Lb;
            long LLogExcep = La ^ Lb;
            //long LShiftR = La >> Lb;                      //Shift Right doesnt work with long type
            //long LShiftL = La << Lb;                      //Shift Left doesnt work with long type
            long LInv = ~La;
            Console.Write($"Addition: {LSum} ");
            Console.Write($"Subtraction: {LDiff} ");
            Console.Write($"Product: {LMult} ");
            Console.Write($"Quotient: {LDiv} ");
            Console.Write($"Remainder of division: {LRem} ");
            Console.Write($"Increment: {LIn} ");
            Console.Write($"Decrement: {LDec} ");
            Console.Write($"Logical Product: {LLogMult} ");
            Console.Write($"Logical Addition: {LLogSum} ");
            Console.Write($"Logical Exception: {LLogExcep} ");
            Console.Write($"Inversion: {LInv} ");
            //Console.Write($"Shift Right: {LShiftR} ");
            //Console.Write($"Shift Left: {LShiftL} ");
            Console.WriteLine();

            Console.WriteLine("ULONG");
            ulong ULa = 3256;
            ulong ULb = 85693;
            ulong ULSum = ULa + ULb;
            ulong ULDiff = ULa - ULb;
            ulong ULMult = ULa * ULb;
            ulong ULDiv = ULa / ULb;
            ulong ULRem = ULa % ULb;
            ulong ULIn = ++ ULa;
            ulong ULDec = -- ULa;
            ulong ULLogMult = ULa & ULb;
            ulong ULLogSum = ULa | ULb;
            ulong ULLogExcep = ULa ^ ULb;
            //ulong ULShiftR = ULa >> ULb;                      //Shift Right doesnt work with ulong type
            //ulong ULShiftL = ULa << ULb;                      //Shift Left doesnt work with ulong type
            ulong ULInv = ~ULa;
            Console.Write($"Addition: {ULSum} ");
            Console.Write($"Subtraction: {ULDiff} ");
            Console.Write($"Product: {ULMult} ");
            Console.Write($"Quotient: {ULDiv} ");
            Console.Write($"Remainder of division: {ULRem} ");
            Console.Write($"Increment: {ULIn} ");
            Console.Write($"Decrement: {ULDec} ");
            Console.Write($"Logical Product: {ULLogMult} ");
            Console.Write($"Logical Addition: {ULLogSum} ");
            Console.Write($"Logical Exception: {ULLogExcep} ");
            Console.Write($"Inversion: {ULInv} ");
            //Console.Write($"Shift Right: {ULShiftR} ");
            //Console.Write($"Shift Left: {ULShiftL} ");
            Console.WriteLine();

            Console.WriteLine("FLOAT");
            float Fa = 10.3f;
            float Fb = 3.3f;
            float FSum = Fa + Fb;
            float FDiff = Fa - Fb;
            float FMult = Fa * Fb;
            float FDiv = Fa / Fb;
            float FRem = Fa % Fb;
            float FIn = ++ Fa;
            float FDec = -- Fa;
            //float FLogMult = Fa & Fb;                     //Logical Product doesnt work with float type
            //float FLogSum = Fa | Fb;                      //Logical Addition doesnt work with float type
            //float FLogExcep = Fa ^ Fb;                    //Logical Exception doesnt work with float type
            //float FShiftR = Fa >> Fb;                     //Shift Right doesnt work with float type
            //float FShiftL = Fa << Fb;                     //Shift Left doesnt work with float type
            //float FInv = ~ Fa;                            //Inversion doesnt work with float type
            Console.Write($"Addition: {FSum} ");
            Console.Write($"Subtraction: {FDiff} ");
            Console.Write($"Product: {FMult} ");
            Console.Write($"Quotient: {FDiv} ");
            Console.Write($"Remainder of division: {FRem} ");
            Console.Write($"Increment: {FIn} ");
            Console.Write($"Decrement: {FDec} ");
            //Console.Write($"Logical Product: {FLogMult} ");
            //Console.Write($"Logical Addition: {FLogSum} ");
            //Console.Write($"Logical Exception: {FLogExcep} ");            
            //Console.Write($"Shift Right: {FShiftR} ");
            //Console.Write($"Shift Left: {FShiftL} ");
            //Console.Write($"Inversion: {FInv} ");
            Console.WriteLine();

            Console.WriteLine("DOUBLE");
            double Da = 10.3;
            double Db = 3.3;
            double DSum = Da + Db;
            double DDiff = Da - Db;
            double DMult = Da * Db;
            double DDiv = Da / Db;
            double DRem = Da % Db;
            double DIn = ++Da;
            double DDec = --Da;
            //double DLogMult = Da & Db;                //Logical Product doesnt work with double type
            //double DLogSum = Da | Db;                 //Logical Addition doesnt work with double type
            //double DLogExcep = Da ^ Db;               //Logical Exception doesnt work with double type
            //double DShiftR = Da >> Db;                //Shift Right doesnt work with double type
            //double DShiftL = Da << Db;                //Shift Left doesnt work with double type
            //double DInv = ~Da;                        //Inversion doesnt work with double type
            Console.Write($"Addition: {DSum} ");
            Console.Write($"Subtraction: {DDiff} ");
            Console.Write($"Product: {DMult }");
            Console.Write($"Quotient: {DDiv} ");
            Console.Write($"Remainder of division: {DRem} ");
            Console.Write($"Increment: {DIn} ");
            Console.Write($"Decrement: {DDec} ");
            //Console.Write($"Logical Product: {DLogMult} ");
            //Console.Write($"Logical Addition: {DLogSum} ");
            //Console.Write($"Logical Exception: {DLogExcep} ");
            //Console.Write($"Inversion: {DInv} ");
            //Console.Write($"Shift Right: {DShiftR} ");
            //Console.Write($"Shift Left: {DShiftL} ");
            Console.WriteLine();

            Console.WriteLine("DECIMAL");
            decimal DeA = 10.3m;
            decimal DeB = 3.3m;
            decimal DeSum = DeA + DeB;
            decimal DeDiff = DeA - DeB;
            decimal DeMult = DeA * DeB;
            decimal DeDiv = DeA / DeB;
            decimal DeRem = DeA % DeB;
            decimal DeIn = ++ DeA;
            decimal DeDec = -- DeA;
            //decimal DeLogMult = DeA & DeB;                //Logical Product doesnt work with decimal type
            //decimal DeLogSum = DeA | DeB;                 //Logical Addition doesnt work with decimal type
            //decimal DeLogExcep = DeA ^ DeB;               //Logical Exception doesnt work with decimal type
            //decimal DeShiftR = DeA >> DeB;                //Shift Right doesnt work with decimal type
            //decimal DeShiftL = DeA << DeB;                //Shift Left doesnt work with decimal type
            //decimal DeInv = ~ DeA;                        //Inversion doesnt work with decimal type
            Console.Write($"Addition: {DeSum} ");
            Console.Write($"Subtraction: {DeDiff} ");
            Console.Write($"Product: {DeMult} ");
            Console.Write($"Quotient: {DeDiv} ");
            Console.Write($"Remainder of division: {DeRem} ");
            Console.Write($"Increment: {DeIn} ");
            Console.Write($"Decrement: {DeDec} ");
            //Console.Write($"Logical Product: {DeLogMult} ");
            //Console.Write($"Logical Addition: {DeLogSum} ");
            //Console.Write($"Logical Exception: {DeLogExcep} ");
            //Console.Write($"Inversion: {DeInv} ");
            //Console.Write($"Shift Right: {DeShiftR} ");
            //Console.Write($"Shift Left: {DeShiftL} ");
            Console.WriteLine();

            //char ChA = 'A';                               //nothing works wiht char type :)))
            //char ChB = 'B';
            //char ChSum = ChA + ChB;                       //addition doesnt work with char type
            //char ChDiff = ChA - ChB;                      //subtraction doesnt work with char type
            //char ChMult = ChA * ChB;                      //product doesnt work with char type
            //char ChDiv = ChA / ChB;                       //quotient doesnt work with char type
            //char ChRem = ChA % ChB;
            //char ChIn = ++ ChA;
            //char ChDec = -- ChA;
            //char ChLogMult = ChA & ChB;
            //char ChLogSum = ChA | ChB;
            //char ChLogExcep = ChA ^ ChB;
            //char ChShiftR = ChA >> ChB;
            //char ChShiftL = ChA << ChB;
            //char ChInv = ~ ChA;
            //Console.WriteLine($"Addition: {ChSum}");
            //Console.WriteLine($"Subtraction: {ChDiff}");
            //Console.WriteLine($"Product: {ChMult}");
            //Console.WriteLine($"Quotient: {ChDiv}");

            Console.WriteLine("STRING");
            string StA = "Thanks God";                      //almost nothing works with string type except addition (+) 
            string StB = " it's Friday";
            string StSum = StA + StB;
            //string StDiff = StA - StB;                    //subtraction doesnt work with string type
            //string StMult = StA * StB;                    //product doesnt work with string type
            //string StDiv = StA / StB;                     //quotient doesnt work with string type
            //string StRem = StA % StB;
            //string StIn = ++StA;
            //string StDec = --StA;
            //string StLogMult = StA & StB;
            //string StLogSum = StA | StB;
            //string StLogExcep = StA ^ StB;
            //string StShiftR = StA >> StB;
            //string StShiftL = StA << StB;
            //string StInv = ~StA;
            Console.Write($"Addition: {StSum} ");
            //Console.Write($"Subtraction: {StDiff} ");
            //Console.Write($"Product: {StMult} ");
            //Console.Write($"Quotient: {StDiv} ");
            Console.WriteLine();




            Console.ReadLine();
        }
    }
}
