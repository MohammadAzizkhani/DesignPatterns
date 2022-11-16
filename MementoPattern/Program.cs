using MementoPattern;
using MementoPattern.Sample;

Originator editor = new();
Caretaker caretaker = new();

//Editor editor = new();
//History caretaker = new();

caretaker.Push(editor.CreateState());
editor.Content = "A";
caretaker.Push(editor.CreateState());
editor.Content = "B";
caretaker.Push(editor.CreateState());
editor.Content = "C";
caretaker.Push(editor.CreateState());
editor.Content = "D";


editor.Restore(caretaker.Pop());
editor.Restore(caretaker.Pop());

Console.WriteLine(editor.Content);