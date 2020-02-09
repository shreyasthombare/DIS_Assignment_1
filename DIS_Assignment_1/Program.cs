using System;

namespace DIS_Assignment_1
{
    public class Program
    {

        /*n – number of lines for the pattern, integer (int)
        * summary   : This method prints number pattern of integers using recursion
        * For example n = 5 will display the output as: 
        * 54321
        * 4321
        * 321
        * 21
        * 1
        * returns      : N/A
        * return type  : void
        */


        public static void PrintPattern(int n)  //prints the pattern using recursion 
        {
            int j;
            

                for(j=n;j>=1;j--)
                {
                    Console.Write(j);
                    
                }
                Console.Write("\n");
                if (n != 0)
                {
                PrintPattern(n - 1);
                }
                           
        }

        /*n2 – number of terms of the series, integer (int)
        * This method prints the following series till n terms: 1, 3, 6, 10, 15, 21……
        * For example, if n2 = 6, output will be
        * 1,3,6,10,15,21
        * Returns : N/A
        * Return type: void
        * Hint: Series is 1,1+2=3,1+2+3=6,1+2+3+4=10,1+2+3+4+5=15, 1+2+3+4+5+6=21……
        */

       public static void PrintSeries(int n2)  
        {
            int i,sum;
            Console.WriteLine("Series is");
            sum = 0;
            for(i=1; i<=n2; i++)    //loop will add elements into the previous elements and thus will print the series
            {
                sum = sum + i;
                Console.Write(sum + "\t");
            }
            Console.WriteLine("\n");

        }

        /* On planet “USF” which is similar to that of Earth follows different clock
          * where instead of hours they have U , instead of minutes they have S , instead
          * of seconds they have F. Similar to earth where each day has 24 hours, each hour
          * has 60 minutes and each minute has 60 seconds , USF planet’s day has 36 U , each
          *U has 60 S and each S has 45 F. 
          * Your task is to write a method usfTime which takes 12HR  format and return string 
          * representing input time in USF time format.
          * Input format: A string s with time in 12 hour clock format (i.e. hh:mm:ssAM or * hh:mm:ssPM) where 01<= hh<=12, 00<=mm,ss,<=60
          * Output format: a string with converted time in USF clock format (i.e. UU:SS:FF ) 
          * where 01<= UU<=36, 00<=SS<=59,00<=FF<=45
          * 
          *  Sample Input : 09:15:35PM   // pm means we have to add 12 hence 9+12 = 21 ie 21:15:35 will be 76535 sec divide sec by 2700 and multiply value after decimal point by 60 and 45 respectively. 
          * Sample Output: 28:20:35 
          * 
          * returns      : String
          * return type  : string
          * 
          * Hint: One way of doing this is by calculating total number of seconds in Input time
          * and dividing those seconds according to USF time.
          */

        public static string UsfTime(string[] s)
        {
            int hr, min, sec, total_sec_min, total_sec_hr, total_sec, new_hr, new_sec;
            decimal temp_hr, temp_min, temp_sec, new_min;
            string time;

            Int32.TryParse(s[0], out hr);         //Convert string to int
            Int32.TryParse(s[1], out min);
            Int32.TryParse(s[2], out sec);
            time = s[3];

            if (hr <= 12 && time == "PM" || time == "pm")   //Converting 12 hr format to 24 hr format
            {
                hr = hr + 12;
            }

            total_sec_hr = hr * 3600;
            total_sec_min = min * 60;

            total_sec = total_sec_hr + total_sec_min + sec;

            temp_hr = (decimal)total_sec / 2700;
            new_hr = Convert.ToInt32(temp_hr);
            temp_min = temp_hr - new_hr;

            temp_min = temp_min * 60;

            new_min = Math.Floor(temp_min);

            temp_sec = temp_min - new_min;
            temp_sec = temp_sec * 45;
            new_sec = Convert.ToInt32(temp_sec);

            string str_hr = Convert.ToString(new_hr);
            string str_min = Convert.ToString(new_min);
            string str_sec = Convert.ToString(new_sec);

            string final_str = str_hr + str_min + str_sec;
            Console.WriteLine("\nCurrent time on USF Planet is");
            Console.Write(str_hr + "::" + str_min + "::" + str_sec);
            Console.WriteLine();
            return final_str;
        }


        /*n- total number of integers( 110 )
        * k-number of numbers per line ( 11)
        * USF Numbers : This method prints the numbers 1 to 110, 11 numbers per line.
        * The method shall print 'U' in place of numbers which are multiple of 3,"S" for 
        * multiples of 5,"F" for multiples of 7, 'US' in place of numbers which are multiple 
        * of 3 and 5,'SF' in place of numbers which are multiple of 5 and 7 and so on. 
        * The output shall look like 
        * 1 2 U 4 S U F 8 U S 11 
        * U 13 F US 16 17 U 19 S UF 22
        * 23 U S 26 U F 29 US 31 32 U....
        * 
        * returns      : N/A
        * return type  : void
        */

        public static void UsfNumbers(int n3, int k)
        {
            int j,temp;

            temp = 1;

            while (temp <= n3)
            {
                for (j = 1; j <= k; j++)
                {

                    if (temp % 3 == 0 && temp % 5 == 0 && temp % 7 == 0)  // Condition check for USF
                    {
                        Console.Write("\t USF");
                        temp += 1;
                    }

                    else if (temp % 3 == 0 && temp % 5 == 0)  // Condition check for US
                    {
                        Console.Write("\t US");
                        temp += 1;
                    }

                    else if (temp % 5 == 0 && temp % 7 == 0) // Condition check for SF
                    {
                        Console.Write("\t SF");
                        temp += 1;
                    }
                    else if (temp % 3 == 0 && temp % 7 == 0)  // Condition check for U F
                    {
                        Console.Write("\t UF");
                        temp += 1;
                    }

                    else if (temp % 3 == 0)   // Condition check for U
                    {
                        Console.Write("\t U");
                        temp += 1;
                    }  
                    else if (temp % 5 == 0)    // Condition check for S
                    {
                        Console.Write("\t S");
                        temp += 1;
                    }
                    else if (temp % 7 == 0)    // Condition check for F
                    {
                        Console.Write("\t F");
                        temp += 1;
                    }
                    else                                // default condition
                    {
                        Console.Write("\t" + temp);
                        temp += 1;
                    }
               
                }
                Console.Write("\n");
            }    
                      
        }


        /*You are given a list of unique words, the task is to find all the pairs of 
        * distinct indices (i,j) in the given list such that, the concatenation of two
        * words i.e. words[i]+words[j] is a palindrome.
        * Example:
        * Input: ["abcd","dcba","lls","s","sssll"]
        * Output: [[0,1],[1,0],[3,2],[2,4]] 
        * Explanation: The palindromes are ["dcbaabcd","abcddcba","slls","llssssll"]
        * Example:
        * Input: ["bat","tab","cat"]
        * Output: [[0,1],[1,0]] 
        * Explanation: The palindromes are ["battab","tabbat"]
        * 
        * returns      : N/A
        * return type  : void
        */

        public static Boolean Pallindromecheck(string var)    // This subroutine checks for pallindrome string
        {

            int length = var.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (var[i] != var[length - i - 1])
                    return false;
            }
            return true;
        }


        public static void PalindromePairs(string[] words, int size)
         {
            
            int i,j,k,length,d;
            string[] check = new string[30];
            string temp;
            char[] var = new char[20]; 
            k = 0;
            


            for (i=0;i<size;i++)
            {
           
                for (j = size-1; j>=0; j--)
                {
                     
                    check[k] = String.Concat(words[i], words[j]);   //Concatenates every conbination of the string
                    length = check[k].Length;
                    temp = check[k];
                    if(Pallindromecheck(temp))
                    {
                        Console.WriteLine("["+i+","+j+"]");
                    }
                    
                }
                k = k + 1;
            }



        }

        

        /*You are playing a stone game with one of your friends. There are N number of 
        * stones in a bag, each time one of you take turns to take out 1 to 3 stones. 
        * The player who takes out the last stone will be the winner. In this case you
        * will be the first player to remove the stone(s)(Player 1).
        * 
        * Write a method to determine whether you can win the game given the number of 
        * stones in the bag. Print false if you cannot win the game, otherwise print any
        * one set of moves where you are winning the game. Array should contain moves by
        * both the players.
        * Input: 4
        * Output: false
        *Explanation: As there are 4 stones in the bag, you will never win the game. 
        * No matter 1,2 or 3 stones you take out, the last stone will always be removed by   * your friend.
        * Input: 5
        * Output: [1,1,3]   or [1,2,2] or [1,3,1]
        *Player 1 picks up 1 stone then player 2 picks up 1 or 2 or 3 stones and the  
        * remaining stones are picked up by player 1.
        * Explanation: As there are 5 stones in the bag, you take out one stone.
        * As there are 4 stones in the bag and it’s your friend’s turn. He will never win 
        * the game because no matter 1,2 or 3 stones he takes out, you will the one to take 
        * out the last stone.
        * 
        * returns      : N/A
        * return type  : void
        */

        public static void Stones(int n4)
        {

            int temp1,temp2;

            if (n4 % 4 == 0)    //Check if the number of stones is a multiple of 4 then Player 1 will not win the game
            {
                Console.WriteLine("FALSE");
            }
            else if(n4 < 4)    //if number of stones is less than four then select all stones in the first turn
            {
                Console.Write("["+n4+"]");
            }
            else
            {
                temp1 = n4 % 4;
                
                    for (int j = 1; j <= 3; j++)
                    {
                        temp2 = n4 - (temp1 + j);    //calculate combination of 
                       /* if(temp2 > 3)                   
                        {
                        Console.Write("["+temp1 + "," + j +"");
                        Stones(temp2);         
                        }*/
                        Console.Write("["+temp1 + "," + j + "," + temp2+"]\n");
                        
                        
                    }
                
            }


        }
        static void Main(string[] args)
        {
         //First question
         Console.WriteLine("1) Enter Number to print pattern\t");
         int n1 = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Pattern is");
         Program.PrintPattern(n1);
         
         //second question
         Console.WriteLine("2) Enter Number to print series\t");
         int n2 = Convert.ToInt32(Console.ReadLine());
         Program.PrintSeries(n2);
         
         //third question           
         int i;
         string[] s = new String[4];
         Console.WriteLine("3) Enter Time in hr::mn::sec::AM/PM format");
         for (i = 0; i < 4; i++)
         {
             s[i] = Console.ReadLine();

         }
         Console.WriteLine("Time on Planet earth is");
         for (i = 0; i < 4; i++)
         {
             Console.Write(s[i] + "\t");

         }

         Program.UsfTime(s);
         
          
         //Forth Question
         Console.WriteLine("\n4) Enter Number of integers\t");
         int n3 = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("How many integers on each line\t");
         int k = Convert.ToInt32(Console.ReadLine());
         Program.UsfNumbers(n3,k);
         

         //fifth question 
         string[] words= new string[20];
         Console.WriteLine("\n5) Enter Number of Elements in the array \t");
         int size = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Enter array elements\n");
         for ( i = 0; i < size; i++)
         {
            words[i] = Console.ReadLine();

         }
         Console.WriteLine("Entered array is");
         for (i = 0; i < size; i++)
         {
            Console.Write(words[i] + "\t");

         }
         Console.WriteLine();
         Console.WriteLine("The Pallindrome pairs in the array\n");
         Program.PalindromePairs(words,size);
            
         //Sixth Question
         Console.WriteLine("\n6) Enter Number of Stones in the bag \t");
         int n4 = Convert.ToInt32(Console.ReadLine());
         Program.Stones(n4);

        }
    }
}


