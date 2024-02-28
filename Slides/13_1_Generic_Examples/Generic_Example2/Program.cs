var float_stack = new MyFloatStack(10);
float_stack.Push(1.5f);
float_stack.Push(2.4f);
float_stack.Push(5.7f);
float_stack.Push(3.9f);
float_stack.Push(8.1f);
float_stack.Pop();
float_stack.Pop();
float_stack.Pop();
float_stack.Pop();
float_stack.Pop();

class MyFloatStack
{
    int stackPointer = 0;
    float[] StackArray;
    public MyFloatStack(int value)
    {
        StackArray = new float[value]; 
    }
    public void Push(float value)
    {
        StackArray[stackPointer] = value;
        System.Console.WriteLine($"push value {value} at location {stackPointer}");
        stackPointer++;
        System.Console.WriteLine($"now stack pointer = {stackPointer}");
    }
    public float Pop()
    {
        float value = StackArray[stackPointer-1];
        System.Console.WriteLine($"Pop value  {value} from stack");
        stackPointer--;
        System.Console.WriteLine($"now stack pointer = {stackPointer}");
        return value;
    }
}