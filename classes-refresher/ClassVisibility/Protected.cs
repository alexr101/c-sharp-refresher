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
            public string Name 
            { 
                get { return name; } 
                set { name = value; } 
            }
        }

        Protected protectedClass = new Protected();

    }

    public class Outer2:Outer
    {
        Outer.Protected protectedClass = new Outer.Protected();

        public Outer2()
        {
		    protectedClass.Name = "protected class";
			Console.WriteLine(protectedClass.Name);  
        }
    }

    public class Outer3
    {
        // Inaccessible because the inner class is protected.
        // Outer.Protected protectedClass = new Outer.Protected(); 
    }
}
