using System;

public class Solver: ISolve
{
    string calc = "";
    public void Accumulate(string s)
    {
        calc += s;
    }
    public void Clear()
    {
        calc = ""; 
    }
    public double Solve()
    {
        calc = "[" + calc + "]";
        int numhead = 0;
        int numtail = 0;
        int denhead = 0;
        int dentail = 0;
        bool numfound = false;
        string before = "";
        string after = "";
        string num = "";
        string den = "";
        double numerator = 0;
        double denominator = 0;

        while (calc.Contains('*'))
        {
            for(int i = 0; i < calc.Length; i++)
            {
                if (numfound == false)
                {
                    if (calc[i] == '[' || calc[i] == '/' || calc[i] == '%' || calc[i] == '+' || calc[i] == '-')
                    {
                        numhead = i + 1;
                    }
                }
                if (denhead != 0)
                {

                    if (calc[i] == ']' || calc[i] == '/' || calc[i] == '%' || calc[i] == '+' || calc[i] == '-' || calc[i] == '*')
                    {
                        dentail = i;
                    }
                }
                else if (calc[i] == '*')
                {
                    numtail = i;
                    denhead = i + 1;
                    numfound = true;
                }
                if(dentail!=0)
                {
                    break;
                }
                //for loop for each action, 4 substring for each piece
            }
            if (dentail != 0)
            {
                before = calc.Substring(0, numhead);
                num = calc.Substring(numhead, numtail - numhead);
                den = calc.Substring(denhead, dentail- denhead);
                after = calc.Substring(dentail, calc.Length - dentail);

                if (num.Contains('!') == true)
                {
                    num = num.Substring(1, num.Length - 1);
                    numerator = (Convert.ToDouble(num) * -1);
                }
                else
                {
                    numerator = Convert.ToDouble(num);
                }
                if (den.Contains('!') == true)
                {
                    den = den.Substring(1, den.Length - 1);
                    denominator = (Convert.ToDouble(den) * -1);
                }
                else
                {
                    denominator = Convert.ToDouble(den);
                }
                double total = numerator * denominator;
                if (total < 0)
                {
                    total *= -1;
                    calc = before + "!" + Convert.ToString(total) + after;
                }
                else
                {
                    calc = before + Convert.ToString(numerator * denominator) + after;
                }
                numhead = 0;
                numtail = 0;
                denhead = 0;
                dentail = 0;
                numfound = false;
                before = "";
                after = "";
                num = "";
                den = "";
                numerator = 0;
                denominator = 0;
            }
        }
        numhead = 0;
        numtail = 0;
        denhead = 0;
        dentail = 0;
        numfound = false;
        before = "";
        after = "";
        num = "";
        den = "";
        numerator = 0;
        denominator = 0;

        while (calc.Contains('/'))
        {
            for (int i = 0; i < calc.Length; i++)
            {
                if (numfound == false)
                {
                    if (calc[i] == '[' || calc[i] == '%' || calc[i] == '+' || calc[i] == '-')
                    {
                        numhead = i + 1;
                    }
                }
                if (denhead != 0)
                {

                    if (calc[i] == ']' || calc[i] == '/' || calc[i] == '%' || calc[i] == '+' || calc[i] == '-')
                    {
                        dentail = i;
                    }
                }
                else if (calc[i] == '/')
                {
                    numtail = i;
                    denhead = i + 1;
                    numfound = true;
                }
                if (dentail != 0)
                {
                    break;
                }
                //for loop for each action, 4 substring for each piece
            }
            if (dentail != 0)
            {
                before = calc.Substring(0, numhead);
                num = calc.Substring(numhead, numtail - numhead);
                den = calc.Substring(denhead, dentail - denhead);
                after = calc.Substring(dentail, calc.Length - dentail);

                if (num.Contains('!') == true)
                {
                    num = num.Substring(1, num.Length - 1);
                    numerator = (Convert.ToDouble(num) * -1);
                }
                else
                {
                    numerator = Convert.ToDouble(num);
                }
                if (den.Contains('!') == true)
                {
                    den = den.Substring(1, den.Length - 1);
                    denominator = (Convert.ToDouble(den) * -1);
                }
                else
                {
                    denominator = Convert.ToDouble(den);
                }
                double total = numerator/denominator;
                if (total < 0)
                {
                    total *= -1;
                    calc = before + "!" + Convert.ToString(total) + after;
                }
                else
                {
                    calc = before + Convert.ToString(numerator / denominator) + after;
                }
                numhead = 0;
                numtail = 0;
                denhead = 0;
                dentail = 0;
                numfound = false;
                before = "";
                after = "";
                num = "";
                den = "";
                numerator = 0;
                denominator = 0;
            }
        }
        numhead = 0;
        numtail = 0;
        denhead = 0;
        dentail = 0;
        numfound = false;
        before = "";
        after = "";
        num = "";
        den = "";
        numerator = 0;
        denominator = 0;

        while (calc.Contains('%'))
        {
            for (int i = 0; i < calc.Length; i++)
            {
                if (numfound == false)
                {
                    if (calc[i] == '[' || calc[i] == '+' || calc[i] == '-')
                    {
                        numhead = i + 1;
                    }
                }
                if (denhead != 0)
                {

                    if (calc[i] == ']' || calc[i] == '%' || calc[i] == '+' || calc[i] == '-')
                    {
                        dentail = i;
                    }
                }
                else if (calc[i] == '%')
                {
                    numtail = i;
                    denhead = i + 1;
                    numfound = true;
                }
                if (dentail != 0)
                {
                    break;
                }
                //for loop for each action, 4 substring for each piece
            }
            if (dentail != 0)
            {
                before = calc.Substring(0, numhead);
                num = calc.Substring(numhead, numtail - numhead);
                den = calc.Substring(denhead, dentail - denhead);
                after = calc.Substring(dentail, calc.Length - dentail);

                if (num.Contains('!') == true)
                {
                    num = num.Substring(1, num.Length - 1);
                    numerator = (Convert.ToDouble(num) * -1);
                }
                else
                {
                    numerator = Convert.ToDouble(num);
                }
                if (den.Contains('!') == true)
                {
                    den = den.Substring(1, den.Length - 1);
                    denominator = (Convert.ToDouble(den) * -1);
                }
                else
                {
                    denominator = Convert.ToDouble(den);
                }
                double total = numerator % denominator;
                if (total < 0)
                {
                    total *= -1;
                    calc = before + "!" + Convert.ToString(total) + after;
                }
                else
                {
                    calc = before + Convert.ToString(numerator % denominator) + after;
                }
                numhead = 0;
                numtail = 0;
                denhead = 0;
                dentail = 0;
                numfound = false;
                before = "";
                after = "";
                num = "";
                den = "";
                numerator = 0;
                denominator = 0;
            }
        }
        numhead = 0;
        numtail = 0;
        denhead = 0;
        dentail = 0;
        numfound = false;
        before = "";
        after = "";
        num = "";
        den = "";
        numerator = 0;
        denominator = 0;

        while (calc.Contains('+'))
        {
            for (int i = 0; i < calc.Length; i++)
            {
                if (numfound == false)
                {
                    if (calc[i] == '[' || calc[i] == '-')
                    {
                        numhead = i + 1;
                    }
                }
                if (denhead != 0)
                {

                    if (calc[i] == ']' || calc[i] == '+' || calc[i] == '-')
                    {
                        dentail = i;
                    }
                }
                else if (calc[i] == '+')
                {
                    numtail = i;
                    denhead = i + 1;
                    numfound = true;
                }
                if (dentail != 0)
                {
                    break;
                }
                //for loop for each action, 4 substring for each piece
            }
            if (dentail != 0)
            {
                before = calc.Substring(0, numhead);
                num = calc.Substring(numhead, numtail - numhead);
                den = calc.Substring(denhead, dentail - denhead);
                after = calc.Substring(dentail, calc.Length - dentail);

                if (num.Contains('!') == true)
                {
                    num = num.Substring(1, num.Length - 1);
                    numerator = (Convert.ToDouble(num) * -1);
                }
                else
                {
                    numerator = Convert.ToDouble(num);
                }
                if (den.Contains('!') == true)
                {
                    den = den.Substring(1, den.Length - 1);
                    denominator = (Convert.ToDouble(den) * -1);
                }
                else
                {
                    denominator = Convert.ToDouble(den);
                }
                double total = numerator + denominator;
                if (total < 0)
                {
                    total *= -1;
                    calc = before + "!" + Convert.ToString(total) + after;
                }
                else
                {
                    calc = before + Convert.ToString(numerator + denominator) + after;
                }
                numhead = 0;
                numtail = 0;
                denhead = 0;
                dentail = 0;
                numfound = false;
                before = "";
                after = "";
                num = "";
                den = "";
                numerator = 0;
                denominator = 0;
            }
        }
        numhead = 0;
        numtail = 0;
        denhead = 0;
        dentail = 0;
        numfound = false;
        before = "";
        after = "";
        num = "";
        den = "";
        numerator = 0;
        denominator = 0;

        while (calc.Contains('-'))
        {
            for (int i = 0; i < calc.Length; i++)
            {
                if (numfound == false)
                {
                    if (calc[i] == '[')
                    {
                        numhead = i + 1;
                    }
                }
                if (denhead != 0)
                {

                    if (calc[i] == ']' || calc[i] == '-')
                    {
                        dentail = i;
                    }
                }
                else if (calc[i] == '-')
                {
                    numtail = i;
                    denhead = i + 1;
                    numfound = true;
                }
                if (dentail != 0)
                {
                    break;
                }
                //for loop for each action, 4 substring for each piece
            }
            if (dentail != 0)
            {
                before = calc.Substring(0, numhead);
                num = calc.Substring(numhead, numtail - numhead);
                den = calc.Substring(denhead, dentail - denhead);
                after = calc.Substring(dentail, calc.Length - dentail);

                if (num.Contains('!') == true)
                {
                    num = num.Substring(1, num.Length - 1);
                    numerator = (Convert.ToDouble(num) * -1);
                }
                else
                {
                    numerator = Convert.ToDouble(num);
                }
                if (den.Contains('!') == true)
                {
                    den = den.Substring(1, den.Length - 1);
                    denominator = (Convert.ToDouble(den) * -1);
                }
                else
                {
                    denominator = Convert.ToDouble(den);
                }
                double total = numerator - denominator;
                if (total < 0)
                {
                    total *= -1;
                    calc = before + "!" + Convert.ToString(total) + after;
                }
                else
                {
                    calc = before + Convert.ToString(numerator - denominator) + after;
                }
                numhead = 0;
                numtail = 0;
                denhead = 0;
                dentail = 0;
                numfound = false;
                before = "";
                after = "";
                num = "";
                den = "";
                numerator = 0;
                denominator = 0;
            }
        }
        double returner = 0;
        calc = calc.Substring(1, calc.Length - 2);
        if (den.Contains('!') == true)
        {
            calc = den.Substring(1, den.Length - 1);
            returner = (Convert.ToDouble(calc) * -1);
        }
        else
        {
            returner = Convert.ToDouble(calc);
        }
        return returner;
    }
}
