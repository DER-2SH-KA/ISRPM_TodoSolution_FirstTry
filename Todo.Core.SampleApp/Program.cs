// See https://aka.ms/new-console-template for more information

using Todo.Core;

Console.WriteLine("Hello, World!");

TodoList todoList = new TodoList();

Console.WriteLine("Введите название задачи для добавления:");

todoList.Add(Console.ReadLine() ?? "Untitle");

IReadOnlyList<TodoItem> items = todoList.Items;

Console.WriteLine("Текущие значения списка задач:");
foreach (TodoItem item in items) { Console.WriteLine(item.Title); }
