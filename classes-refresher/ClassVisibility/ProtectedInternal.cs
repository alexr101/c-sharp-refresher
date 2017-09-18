using System;
namespace classesrefresher
{
    public class PIOuter
    {
		// Accessible by outer programs like protected classes
        // Accessible in THIS program like internal classes (accessible)
		protected internal class ProtectedInternal
        {
            public ProtectedInternal()
            {
                Console.WriteLine("Protected from OUTSIDE programs OR Internal INSIDE its program");
            }
        }
    }

    public class PIOuter2
    {
        PIOuter.ProtectedInternal pi = new PIOuter.ProtectedInternal();
    }
}
