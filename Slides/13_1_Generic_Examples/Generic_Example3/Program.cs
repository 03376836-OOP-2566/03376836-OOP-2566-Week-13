using System.Text;
using System;

var int_stack = new MyStack<int>(10);
int_stack.Push(5);
int_stack.Pop();

var double_stack = new MyStack<double>(10);
double_stack.Push(5.2);
double_stack.Pop();

var string_stack = new MyStack<string>(10);
string_stack.Push("World");
string_stack.Push(" ");
string_stack.Push("Hello");

StringBuilder sb = new StringBuilder();
sb.Append(string_stack.Pop());
sb.Append(string_stack.Pop());
sb.Append(string_stack.Pop());

System.Console.WriteLine($"merged pop string is  \"{sb.ToString()}\"");

class MyStack <T>
{
    int stackPointer = 0;
    T[] StackArray;
    public MyStack(int value)
    {
        StackArray = new T[value]; 
    }
    public void Push(T value)
    {
        StackArray[stackPointer] = value;
        System.Console.WriteLine($"push value {value} at location {stackPointer}");
        stackPointer++;
        System.Console.WriteLine($"now stack pointer = {stackPointer}");
    }
    public T Pop()
    {
        T value = StackArray[stackPointer-1];
        System.Console.WriteLine($"Pop value  {value} from stack");
        stackPointer--;
        System.Console.WriteLine($"now stack pointer = {stackPointer}");
        return value;
    }
}