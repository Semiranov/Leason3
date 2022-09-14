// Дан текст. В тексте нужно все пробелы заменить черточками, 
// маленькие буквы “к” заменить большими “К”, а большие “С” заменить маленькими “с”.

string text = "Я думаю, — сказал князь, улыбаясь, — что, ежели бы вас послали "
+ "вместо нашего милого Винценгероде, вы бы взяли приступом согласие прусского короля. "
+ "Вы так красноречивы. Вы дадите мне чаю?";

string Text(string txt, char oldsumb, char newsumb)
{   string res = String.Empty;
    for(int i = 0; i < txt.Length; i++)
    {
        if(txt[i] == oldsumb)
        {
            res = res + $"{newsumb}";
        }
        else
        {
            res = res + $"{txt[i]}";
        }
    }
    return res;
}

Console.WriteLine(text);
string newtext = Text(text, ' ', '_');
newtext = Text(newtext, 'С', 'с');
newtext = Text(newtext, 'к', 'К');
Console.WriteLine();
Console.WriteLine(newtext);