using MementoPattern;
Originator editor = new();
Caretaker caretaker = new();

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