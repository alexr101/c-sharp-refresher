using System;
using classesrefresher.ClassVisibility;
using classesrefresher.ClassMembers;
using classesrefresher.Methods;
using classesrefresher.BasicClasses;

namespace classesrefresher
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bcCore BasicClasses = new bcCore();
            cmCore classMembers = new cmCore();
            mCore methods = new mCore();
            cvCore classVisibility = new cvCore();
        }
    }
}


