var intStack = new Stack<int>(10);

intStack.Push(1);
intStack.Push(3);
intStack.Push(5);
System.Console.WriteLine(intStack.Pop());
System.Console.WriteLine(intStack.Pop());
System.Console.WriteLine(intStack.Pop());

var stringStack = new Stack<string>(10);

 stringStack.Push("World");
 stringStack.Push(" ");
 stringStack.Push("Hello");
System.Console.WriteLine(stringStack.Pop());
System.Console.WriteLine(stringStack.Pop());
System.Console.WriteLine(stringStack.Pop());

var personStack = new Stack<Person>(10);

personStack.Push(new Person{Name = "A"});
personStack.Push(new Person{Name = "B"});
personStack.Push(new Person{Name = "C"});
System.Console.WriteLine(personStack.Pop().Name);
System.Console.WriteLine(personStack.Pop().Name);
System.Console.WriteLine(personStack.Pop().Name);

class Person
{

    public string Name { get; set; }
}


class Stack <T>
{
    T [] StackArray;
    int StackPointer =0;
    public Stack(int StackSize)
    {
        StackArray = new T[StackSize];

    }
    public void Push(T value)
    {
        StackArray[StackPointer] = value;
        StackPointer ++;
    }
    public T Pop()
    {   
        T value;
        StackPointer --;
        value = StackArray[StackPointer];
        return value;
    }
} 
