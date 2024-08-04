#region 1)  parameter olaraq  istenilen sayda integer eded daxil edile bilen ve method mene bu ededlerden en boyusunu
//qaytarmalidir

//Console.WriteLine(TheMostGreatestNumberInArray(5,2,7,9,3,0,-9,-11,4));
//Console.WriteLine(TheMostGreatestNumberInArray(-1,-7,-2,-9,-11,-3));

int TheMostGreatestNumberInArray(params int[] arr)
{
    int res = arr[0];
    foreach (var item in arr)
    {
        if (item>res)
        {
            res = item;
        }
    }
    return res;
}


#endregion

#region 2) parameter olaraq array qebul edir ve arraydaki ededlerin ededi ortasini geriye qaytaracaq

//Console.WriteLine(AvarageOfArrayElements(1,2,3,4));
decimal AvarageOfArrayElements(params int[] arr)
{
    decimal sum = 0;
    foreach (var item in arr)
    {
        sum += item;
    }
    return sum / arr.Length;
}

#endregion

#region 3)parametr olaraq 2 eded qebul edir en azi 1 i 9 a bolunurse true eks halda false qaytarir

//Console.WriteLine(IsDivided(3,9));

bool IsDivided(int num1,int num2)
{
    if (num1%9==0||num2%9==0)
    {
        return true;
    }
    return false;
}

#endregion

#region 4) parameter olaraq 2 eded qubul edir ve her ikisi  eded sadedirse “sade” murekkebdirse
//“murekkeb” qaytarir hec biri deyilse “something went wrong”

//Console.WriteLine(CheckState(2,1));

string CheckState(int num1,int num2)
{
    if (IsPrime(num1)&&IsPrime(num2))
    {
        return "Sadedir";
    }
    else if (!IsPrime(num1)&&!IsPrime(num2))
    {
        return "Murekkebdir";
    }
    return "Ne sade nede murekkebdir";
}


bool IsPrime(int num)
{
    if (num<2)
    {
        throw new Exception("Something went wrong");
    }
    
    for (int i = 2; i < num; i++)
    {
        if (num%i==0)
        {
            return false;
        }
    }
    return true;
}


#endregion


#region 5)parametr olaraq istenilen sayda string tipinden deyer girile biler ve bu stringleri tersine cevirib
//hamisini mene qaytarsin

//["Salam","Hardasan","Necesen"]->["Necesen","Hardasan","Salam"]-
//["Salam","Hardasan","Necesen"]->["malaS","nasadraH","neseceN"]+
//string[] res = ReverseWords("Salam", "Hardasan", "Necesen");
//foreach (var item in res)
//{
//    Console.WriteLine(item);
//}
 string[]ReverseWords(params string[] words)
{
    string[] reverseWords = new string[0]; 
    foreach (var word in words)
    {
        string temp = string.Empty;
        for (int i = word.Length-1; i >=0; i--)
        {
            temp += word[i];
        }
        Array.Resize(ref reverseWords, reverseWords.Length + 1);
        reverseWords[reverseWords.Length - 1] = temp;
    }
    return reverseWords;
}


#endregion

#region 6)parametr olaraq istenilen sayda string tipinden deyer girile biler bu sozlerin en uzun olaninin uzunluqunu geri qaytarsin 

//Console.WriteLine(TheMostLongestWordInArray("Salam","Hardasan","Necesen","Azerbijan"));
int TheMostLongestWordInArray(params string[] words)
{
    int len = words[0].Length;
    foreach (var item in words)
    {
        if (item.Length>len)
        {
            len = item.Length;
        }
    }
    return len;
}

#endregion

#region 7)parametr olaraq istenilen sayda string tipinden deyer girile biler bu sozlerin en uzun polindrom olanini geri qaytarsin 

//Console.WriteLine(TheMostLongestPolindromWord("salam","ana","50000005","1001","88888","202"));
Console.WriteLine(TheMostLongestPolindromWord("salam","102301","88887","2012","101","1001"));

string TheMostLongestPolindromWord(params string[] words)
{
    int len = 0;
    string res = "Something went wrong";
    foreach (var word in words)
    {
        if (IsPolindrom(word)&&word.Length>len)
        {
            len = word.Length;
            res = word;
        }
    }
    return res;
}

bool IsPolindrom(string word)
{
    string temp = string.Empty;
    for (int i = word.Length-1; i >=0; i--)
    {
        temp += word[i];
    }
    return temp == word;
}

#endregion

#region 8)metodunuz 1 ədəd qəbul edir və onun armstrong olub olmadıqını tapacaqsız armstrong ədədlər
//hər bir rəqəmlərinin rəqəmlərin sayı dərəcəsindın qüvvətləri cəmidi məsələn 
//153—> 1 ^ 3 + 5 ^ 3 + 3 ^ 3

//1234->1 ^ 4 + 2 ^ 4 + 3 ^ 4 + 4 ^ 4

//Console.WriteLine(LenOfNumber(110));
//Console.WriteLine(Power(5,3));
//Console.WriteLine(IsArmstrongNumber(5));
int LenOfNumber(int num)
{
    int count = 0;
    while (num>0)
    {
        count++;
        num /= 10;
    }
    return count;
}

int Power(int num,int pow)
{
    int res = 1;
    for (int i = 0; i < pow; i++)
    {
        res *= num;
    }
    return res;
}
//153->15->1
bool IsArmstrongNumber(int num)
{
    int temp = 0;
    int demoNum = num;
    int len = LenOfNumber(demoNum);
    while (demoNum > 0)
    {
        temp += Power(demoNum % 10, len);
        demoNum /= 10;
    }
    return temp == num;
}


#endregion
