using System.Collections.Generic;


List<string> tasks = new List<string> { "Код", "Тест", "Код" };
tasks.Add("Отчёт");
tasks.Insert(1, "План");
Console.WriteLine(tasks.Count);
bool InsertTaskSafe(List<string> tasks, int index, string title)
{
    if (index < 0 || index > tasks.Count)
    {
        return false;
    }

    tasks.Insert(index, title);
    return true;
}
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
List<string> removedTasks = new List<string> { "Код", "Тест", "Код" };

bool removed = removedTasks.Remove("Код");
Console.WriteLine(removed);
PrintTasks(removedTasks);
Console.WriteLine(removedTasks.Remove("Экзамен"));
Console.WriteLine(removedTasks.Count);
removedTasks.RemoveAt(1);
PrintTasks(removedTasks);


bool RemoveTaskAtSafe(List<string> tasks, int index)
{
    if (index < 0 || index >= tasks.Count)
    {
        return false;
    }
    tasks.RemoveAt(index);
    return true;
}

int index = searchableTasks.IndexOf("Код");

if (index >= 0)
{
    Console.WriteLine($"Первый индекс: {index}");
}
else
{
    Console.WriteLine("Задача не найдена");
}