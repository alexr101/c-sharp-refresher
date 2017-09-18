using System;

namespace classesrefresher.ClassVisibility
{
    public class cvCore : Outer
    {
        public cvCore()
        {
            Public publicClass = new Public();
            publicClass.Write();

            // accessible only because we are inheriting from Protected class'
            // wrapper Outer class
            Outer.Protected protectedClass = new Outer.Protected();

            Internal internalClass = new Internal(); // see log and class file

            PIOuter.ProtectedInternal pi = new PIOuter.ProtectedInternal();

        }
    }
}
