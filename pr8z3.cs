Random r = new Random();

while (true)
{
    int zagad = r.Next(1, 101);
    int p = 0;
    bool a = false;

    while (a == false)
    {
        int var = Convert.ToInt32(Console.ReadLine());
        if (var < 1 || var > 100)
        {
            Console.WriteLine("ужас, напиши норм");
            continue;
        }

        p++;

        if (var == zagad)
        {
            Console.WriteLine($"угадал через {p} попытку");
            a = true;
        }
        else if (var < zagad)
        {
            Console.WriteLine("фе, бери больше");
        }
        else
        {
            Console.WriteLine("загнул чота, меньше надо");
        }
    }
    Console.Write("хочешь снова?");
    string opyat = Console.ReadLine().ToString();

    if (opyat != "yes")
    {

        break;
    }
}