using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
Console.Write("Сколько задач добавить сначала: ");
int count = Convert.ToInt32(Console.ReadLine());

List<string> tasks = new List<string>();

for (int i = 0; i < count; i++)
{
    Console.Write($"Задача {i + 1}: ");
    string d = Console.ReadLine() ?? "";
    tasks.Add(d);
}
//1
void PrintTasks(List<string> tasks)
{
    if (tasks.Count == 0)
    {
        Console.WriteLine("Список пуст");
        return;
    }

    for (int i = 0; i < tasks.Count; i++)
    {
        Console.WriteLine($"{i}: {tasks[i]}");
    }
}

//2
Console.Write("Название новой задачи: ");
string b = Console.ReadLine();
tasks.Add(b);
//3

Console.Write("Задача для вставки: ");
string title = Console.ReadLine();
Console.Write("Индекс вставки: ");
int index = Convert.ToInt32(Console.ReadLine());

void InsertTaskSafe(List<string> tasks, int index, string title)
{
    if (index < 0 || index > tasks.Count)
    {
        System.Console.WriteLine("Недопустимый индекс вставки");
    }

    tasks.Insert(index, title);
    System.Console.WriteLine("Задача вставлена");
}
//4
System.Console.WriteLine("название задачи для удаления");
string m = Console.ReadLine();
if (tasks.Contains(m))
{
    tasks.Remove(m);
    System.Console.WriteLine("Первое совпадение удалено");
}
else
{
    System.Console.WriteLine("Задача не найдена");
}
//5
Console.Write("Индекс задачи для удаления: ");
int g = Convert.ToInt32(Console.ReadLine());

void RemoveTaskAtSafe(List<string> tasks, int g)
{
    if (g < 0 || g >= tasks.Count)
    {
        System.Console.WriteLine("Недопустимый индекс удаления");
    }
    tasks.RemoveAt(g);
    System.Console.WriteLine("Задача по индексу удалена");
}

//6

Console.Write("название задачи для поиска: ");
string p = Console.ReadLine();
int u = tasks.IndexOf(p);
if (u >= 0)
{
    Console.WriteLine($"Первый индекс: {u}");
}
else
{
    Console.WriteLine("Задача не найдена");
}
//7
Console.WriteLine();
Console.WriteLine(">>> Итоговый список дел <<<");
Console.WriteLine();
Console.WriteLine($"Количество задач: {tasks.Count}");
PrintTasks(tasks);