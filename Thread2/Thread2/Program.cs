int countDouble = 0;
int countOdd = 0;

object Double = new();
object Odd = new();
void generate(object obj)
{
    int a = 0;
    Random rnd = new Random();
    for (int i = 1; i<100; i++)
    {
        a = rnd.Next(1, 100);
        if (a%2 == 0)
            lock (Double) { countDouble++; }
        else lock (Odd) { countOdd++; }

    }
}

string[] tasks = new string[]
{
    "Task 1",
    "Task 2",
    "Task 3",
    "Task 4",
    "Task 5",
    "Task 6",
    "Task 7",
    "Task 8",
    "Task 9",
    "Task 10"
};

foreach (string task in tasks)
{
    ThreadPool.QueueUserWorkItem(new WaitCallback(generate), task);
}



Console.WriteLine("countDouble - " + countDouble);
Console.WriteLine("countOdd - " + countOdd);
