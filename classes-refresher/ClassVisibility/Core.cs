using System;

namespace classesrefresher.ClassVisibility
{
    public class Core : Outer
    {
        public Core()
        {
            Public publicClass = new Public();
            publicClass.Write();

            // accessible only because we are inheriting from Protected class'
            // wrapper Outer class
            Outer.Protected protectedClass = new Outer.Protected();
        }
    }
}
