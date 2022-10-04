// 1 Void метод. Группа методов. Ни чего не принимают и не возвращают
void Method()
{
    Console.WriteLine("Автор...");
}
// 2 Void метод. Группа методов. Принимают, но не возвращают
Method();

void Method2(string msg)
{
    Console.WriteLine(msg);
}

Method2("Текст сообщения");

void Method2_1(string msg,int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++; 
    }
    }

Method2_1(msg:"Текст сообщения",count: 4);
// 3 Группа методов. Что-то возвращают, но не принимают

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// 4 Группа методов. Что-то принимают, что-то возвращают

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "АБВ-");
Console.WriteLine(res);

string Method4_1(int count, string text)
{
        string result = String.Empty;
for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res1 = Method4_1(10, "ZXC -");
Console.WriteLine(res1);
