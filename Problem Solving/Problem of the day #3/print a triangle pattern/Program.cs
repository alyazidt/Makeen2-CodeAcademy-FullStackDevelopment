using System;

class TrianglePattern
{
    static void Main()
    {

        /* 
         
           
        Problem of the day #3 :
            Print the triangle after reading the height.

                  input : 4
          
                  output : 
                                                            1
                                                          1 2 1
                                                        1 2 4 2 1
                                                      1 2 4 8 4 2 1



        */

        Console.Write("Enter the height: ");
        int height = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < height; i++)
        {
            int[] num = new int[i + 1];
            num[0] = 1;



            for (int j = 1; j <= i; j++)
            {
                num[j] = num[j - 1] * 2;
            }


            int totalWidth = height * 4;



            string line = "";

            for (int j = 0; j <= i; j++)
            {
                line += num[j] + " ";
            }




            for (int j = i - 1; j >= 0; j--)
            {
                line += num[j] + " ";
            }


            Console.WriteLine(line.Trim().PadLeft((totalWidth + line.Length) / 2));
        }
    }
}
