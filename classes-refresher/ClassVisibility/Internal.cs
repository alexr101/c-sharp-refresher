using System;
namespace classesrefresher
{
    // this one's interesting.
    // You won't need in most programs, but it encapsulates your classes to its wrapping
    // assembly (project). So another program can't accidentally access your internal
    // functionality.
    // no good here because I'm only using one program to test everything...
    internal class Internal
    {
        public Internal()
        {
            Console.WriteLine("Accessible only within program. I'm good for buiding modular code."); 
        }
    }
}
