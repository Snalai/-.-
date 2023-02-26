void funk(string[] Str)
{   
    int Len = Str.Length;
    int Widt = 0;
    int WidtNewStr = -1;
    for (int i = 0; i < Len; i++)
    {
        if (Str[i].Length <= 3)
        {
            Widt++;
        }
    }
    string[] NewStr = new string[Widt];
    for (int i = 0; i < Len; i++)
    {
        if (Str[i].Length <= 3)
        {
            WidtNewStr++;
            NewStr[WidtNewStr] = Str[i];
        }
    }
}
string[] Str = { "hello", "2", "world", ":-" };
funk(Str);





