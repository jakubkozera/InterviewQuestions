namespace InterviewQuestions;

internal class SampleClass : AbstractClass, Interface1, Interface2
{
    public void Foo() // optional
    {
        Console.WriteLine("SampleClass Foo");
    }

    public string MyInterfaceProperty { get; set; }

    public void FooInterface2()
    {
        throw new NotImplementedException();
    }

    protected override void FooClass()
    {
        throw new NotImplementedException();
    }
}