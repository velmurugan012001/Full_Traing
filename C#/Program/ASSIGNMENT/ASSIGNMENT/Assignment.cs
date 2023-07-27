/*class Assignment
{
    private int rows;

    public void coordinate(int X, int Y)

    {
        if (X > 0 && Y > 0)
        {
            Console.WriteLine("The corrdinate point (" + X + "," + Y + ") lies in the First quadrant.");
        }

        else if (X < 0 && Y > 0)
        {
            Console.WriteLine("The corrdinate point (" + X + "," + Y + ") lies in the Second quadrant.");
        }

        else if (X < 0 && Y < 0)
        {
            Console.WriteLine("The corrdinate point (" + X + "," + Y + ") lies in the Third quadrant.");
        }

        else if (X > 0 && Y < 0)
        {
            Console.WriteLine("The corrdinate point (" + X + "," + Y + ") lies in the Fourth quadrant.");
        }
        else
        { Console.WriteLine("The points are in Orgin"); }




    }
    public void marks(int phy, int chm, int ca)
    {
        int Total = (phy + chm + ca);
        Console.WriteLine("Total Marks =" + Total);
        int prg = (phy + chm + ca) / 3;
        Console.WriteLine("Percentage =" + prg);
        if (Total > 90)
        {
            Console.WriteLine("Division = First");

        }
        else if (Total < 70)
        {
            Console.WriteLine("Division = Second");
        }
        else if (Total < 50)
        {
            Console.WriteLine("Division = Thired");
        }
    }
    public void EB(int unit, int cutid, string name)
    {
        double chg, surchg = 0, gramt, netamt;
        if (unit < 200)
            chg = 1.20;
        else if (unit >= 200 && unit < 400)
            chg = 1.50;
        else if (unit >= 400 && unit < 600)
            chg = 1.80;
        else
            chg = 2.00;
        gramt = unit * chg;
        if (gramt > 300)
            surchg = gramt * 15 / 100.0;
        netamt = gramt + surchg;
        if (netamt < 100)
            netamt = 100;
        Console.Write("\nElectricity Bill\n");
        Console.Write("Customer IDNO                       :{0}\n", cutid);
        Console.Write("Customer Name                       :{0}\n", name);
        Console.Write("unit Consumed                       :{0}\n", unit);
        Console.Write("Amount Charges @Rs. {0}  per unit :{1}\n", chg, gramt);
        Console.Write("Surchage Amount                     :{0}\n", surchg);
        Console.Write("Net Amount Paid By the Customer     :{0}\n", netamt);
    }
    public void rowno(int row)
    {
        int k = 1;
        for (int i = 1; i <= row; i++)
        {
            for (int j = 1; j <= i; j++)
                Console.Write("{0} ", k++);
            Console.WriteLine();
        }

    }


    
    

        public void Alph(string str, int i, int wrd, int l)
        {

            l = 0;
            wrd = 1;
            while (l <= str.Length - 1)
            {
                if (str[l] == ' ' || str[l] == '\n' || str[l] == '\t')
                {
                    wrd++;
                }

                l++;
            }

            Console.Write("Total number of words in the string is : {0}\n", wrd);
        }





    public void Array(int i, int n)
    {
        //Reverse an array
        int[] arr1 = new int[10];
        Console.Write("Input number of elements in the array :\n", n);
        for (i = 0; i < n; i++)
        {
            Console.Write("element - {0} : ", i);
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("\n\nThe values store into the array in reverse are :\n");
        for (i = n - 1; i >= 0; i--)
        {
            Console.Write("{0} ", arr1[i]);
            Console.Write("\n");
        }
        //Dupicate Array
        int[] arr2 = new int[10];
        for (i = 0; i < n; i++)
        {
            arr2[i] = arr1[i];
        }
        Console.WriteLine("The copied values of arr1 into arr2");
        for (i = 0; i < n; i++)
        {
            Console.WriteLine("{0}  ", arr2[i]);
        }
        //sum of elements in an array
        int sum = 0;
        for (i = 0; i < n; i++)
        {
            sum += arr1[i];
        }

        Console.WriteLine("Sum of all elements stored in the array is : {0}", sum);
        //count total no of duplicate elements in an array
        int[] arr3 = new int[10];
        int mm = 1, ctr = 0, j;
        for (i = 0; i < n; i++)
        {
            for (j = 0; j < n; j++)
            {
                if (arr1[i] == arr2[j])
                {
                    arr3[j] = mm;
                    mm++;
                }
            }
            mm = 1;
        }
        for (i = 0; i < n; i++)
        {
            if (arr3[i] == 2) { ctr++; }
        }
        Console.Write("The number of duplicate elements is: {0} \n", ctr);
        //unique numbers in an array
        int k;
        Console.Write("\nThe unique elements found in the array are : ");
        for (i = 0; i < n; i++)
        {
            ctr = 0;
            for (j = 0; j < i - 1; j++)
            {
                if (arr2[i] == arr2[j])
                {
                    ctr++;
                }
            }
            for (k = i + 1; k < n; k++)
            {
                if (arr2[i] == arr2[k])
                {
                    ctr++;
                }
                if (arr2[i] == arr2[i + 1])
                {
                    i++;
                }
            }

            if (ctr == 0)
            {
                Console.Write("{0} \n", arr2[i]);
            }
        }
        //second largest number in an array
        int lrg1, lrg2;
        lrg1 = 0;
        j = 0;

        for (i = 0; i < n; i++)
        {
            if (lrg1 < arr2[i])
            {
                lrg1 = arr2[i];
                j = i;
            }
        }
        lrg2 = 0;
        for (i = 0; i < n; i++)
        {
            if (i == j)
            {
                i++;  /* ignoring the largest element 
                i--;
            }
            else
            {
                if (lrg2 < arr2[i])
                {
                    lrg2 = arr2[i];
                }
            }
        }

        Console.Write("The Second largest element in the array is :  {0} ", lrg2);
    }


  public void StringPalindrom(string name)
{
    string rev;
    char[] ch = name.ToCharArray();
        Array.Reverse(ch);
    rev = new string(ch);
    bool b = name.Equals(rev, StringComparison.OrdinalIgnoreCase);
    if (b == true)
    {
        Console.WriteLine("" + name + " is a Palindrome!");
    }
    else
    {
        Console.WriteLine(" " + name + " is not a Palindrome!");
    }

}
  public void NumberPalindrom(int num)
{
    int r, sum = 0, temp;
    temp = num;
    while (num > 0)
    {
        r = num % 10;
        sum = (sum * 10) + r;
        num = num / 10;
    }
    if (temp == sum)
        Console.Write("Number is Palindrome.");
    else
        Console.Write("Number is not Palindrome");
}

    }*/
    

