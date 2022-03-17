// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] vs = new int[3];
vs[0] = 1;
vs[1] = 2;
vs[2] = 0;

//ReformatDate("20th Oct 2052");
//ScoreOfParentheses(vs);
LengthOfLongestSubstring("pwwkewxxx");

static int LengthOfLongestSubstring(string s)
{
    string word = "";
    int max = 0;

    for (int i = 0; i < s.Length; i++)
    {
        if (!word.Contains(s[i]))
        {
            word += s[i].ToString();
        }
        else if (word.Length > max)
        {
            max = word.Length;
            word = word.Substring(word.IndexOf(s[i]) + 1, word.Length - word.IndexOf(s[i]) - 1);
            word += s[i].ToString();
        }
    }

    return (word.Length > max ? word.Length : max);
}

static string ReformatDate(string date)
{
    string[] fullDate = date.Split(' ');

    string day = ("0" + fullDate[0].Replace("st", "").Replace("nd", "").Replace("rd", "").Replace("th", ""));
    day = day.Substring(day.Length - 2, 2);

    string month = ("0" + fullDate[1].Replace("Jan", "01")
        .Replace("Feb", "02")
        .Replace("Mar", "03")
        .Replace("Apr", "04")
        .Replace("May", "05")
        .Replace("Jun", "06")
        .Replace("Jul", "07")
        .Replace("Aug", "08")
        .Replace("Sep", "09")
        .Replace("Oct", "10")
        .Replace("Nov", "11")
        .Replace("Dec", "12"));

    string year = fullDate[2];

    return string.Format($"{year}-{month}-{day}");
}

static int ScoreOfParentheses(int[] nums)
{
    var tmplist = nums.OrderBy(x => x).Where(x => x > 0).Distinct().ToList();
    int size = tmplist.Count;
    var list = tmplist.Where(x => x <= size).ToList();
    int shouldBe = 1;

    for (int i = 0; i < list.Count; i++)
    {
        if (list[i] != shouldBe)
            return shouldBe;
        else
            shouldBe++;
    }

    if (shouldBe - 1 == nums.Length)
        return shouldBe;
    else
    {
        return shouldBe;
    }
}


static int ScoreOfParentheses2(int[] nums)
{
    var list = nums.OrderBy(x => x).Where(x => x > 0).ToList();
    int current = list[0];
    int x = 1;
    for (int i = 1; i < list.Count; i++)
    {
        if (list[i] - current > 1)
        {
            return current + 1;
        }
        else
            current = list[i];

        x++;
    }

    if (x == nums.Length)
        return 0;
    else
    {
        return x + 1;
    }
}