var int_stack = new MyIntStack(10);
int_stack.Push(1);
int_stack.Push(2);
int_stack.Push(5);
int_stack.Push(3);
int_stack.Push(8);
int_stack.Pop();
int_stack.Pop();
int_stack.Pop();
int_stack.Pop();
int_stack.Pop();

class MyIntStack
{
    int stackPointer = 0;
    int[] StackArray;
    public MyIntStack(int value)
    {
        StackArray = new int[value]; 
    }
    public void Push(int value)
    {
        StackArray[stackPointer] = value;
        System.Console.WriteLine($"push value {value} at location {stackPointer}");
        stackPointer++;
        System.Console.WriteLine($"now stack pointer = {stackPointer}");
    }
    public int Pop()
    {
        int value = StackArray[stackPointer-1];
        System.Console.WriteLine($"Pop value  {value} from stack");
        stackPointer--;
        System.Console.WriteLine($"now stack pointer = {stackPointer}");
        return value;
    }
}