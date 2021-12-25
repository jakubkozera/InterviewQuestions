BaseClass someClass = new SomeClass();

someClass.FooVirtual();

someClass.Foo();

internal class BaseClass
{
    public virtual void FooVirtual()
    {
        Console.WriteLine("FooVirtual base");
    }

    public void Foo()
    {
        Console.WriteLine("Foo base");
    }
}

internal class SomeClass : BaseClass
{
    public override void FooVirtual()
    {
        Console.WriteLine("SomeClass FooVirtual");
    }

    public new void Foo()
    {
        Console.WriteLine("Foo");
    }
}