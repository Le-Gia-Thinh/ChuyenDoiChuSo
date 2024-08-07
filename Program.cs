using System;
 namespace ChuyenDoiChuSo {

    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Nhap so nguyen:");
            int n = int.Parse(Console.ReadLine());
            
            if ( n < 0 || n > 1000){
                Console.WriteLine ("out of ability")   ;       }
                if ( n == 0){
                    Console.WriteLine("Zero");}

            string word = "" ;
            if (n / 100 > 0)
            {
                switch (n  / 100)
                {
                    case 1: word += "one hundred"; break;
                    case 2: word += "two hundred"; break;
                    case 3: word += "three hundred"; break;
                    case 4: word += "four hundred"; break;
                    case 5: word += "five hundred"; break;
                    case 6: word += "six hundred"; break;
                    case 7: word += "seven hundred"; break;
                    case 8: word += "eight hundred"; break;
                    case 9: word += "nine hundred"; break;
                }
            }
            n %= 100;
            if (n >= 0 && n < 20){
             word += " and "; 
            switch (n / 10 )
                {   case 10: word += "ten"; break;
                    case 11: word += "eleven"; break;
                    case 12: word += "twelve"; break;
                    case 13: word += "thirteen"; break;
                    case 14: word += "fourteen"; break;
                    case 15: word += "fifteen"; break;
                    case 16: word += "sixteen"; break;
                    case 17: word += "seventeen"; break;
                    case 18: word += "eighteen"; break;
                    case 19: word += "nineteen"; break; }
            }else {
            
                if ( n /10 > 0 ){
                    word += " and ";
                     switch (n / 10)
                    {
                        case 2: word += "twenty"; break;
                        case 3: word += "thirty"; break;
                        case 4: word += "forty"; break;
                        case 5: word += "fifty"; break;
                        case 6: word += "sixty"; break;
                        case 7: word += "seventy"; break;
                        case 8: word += "eighty"; break;
                        case 9: word += "ninety"; break;
                    }
                }
            }
            n %= 10 ;
           if (n> 0)
                { word += "-";
                    switch (n)
                    {
                        case 1: word += "one"; break;
                        case 2: word += "two"; break;
                        case 3: word += "three"; break;
                        case 4: word += "four"; break;
                        case 5: word += "five"; break;
                        case 6: word += "six"; break;
                        case 7: word += "seven"; break;
                        case 8: word += "eight"; break;
                        case 9: word += "nine"; break;
                    }
                }

            Console.WriteLine(word);
        }
     }
 }
    
    