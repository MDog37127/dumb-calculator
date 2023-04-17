using System;

public class Solver: ISolve
{
    string calc = "";
    public void Accumulate(string s)
    {
        calc += s;
    }
    void Clear()
    {
        calc = ""; 
    }
    double Solve()
    {

    }
}
