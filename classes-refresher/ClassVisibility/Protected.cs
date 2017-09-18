using System;
namespace classesrefresher
{
    // protected classes cannot be OUTER classes (exposed in the namespace)
    // They are accessible only from their wrapping class or 
    // classes that inherit from their wrapper class
    public class Outer
    {
        protected class Protected 
        {
            private string name;
            public string Name { get; set; }
        }

        Protected protectedClass = new Protected();

    }

    public class Outer2 : Outer
    {
        Outer.Protected protectedClass = new Outer.Protected();
        protectedClass.name = "protected class";
        Console.log(protectedClass.name);
    }

    public class Outer3
    {
        // Inaccessible because the inner class is protected.
        // Outer.Protected protectedClass = new Outer.Protected(); 
    }
}
