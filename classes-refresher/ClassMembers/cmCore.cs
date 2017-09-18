using System;
namespace classesrefresher.ClassMembers
{
    public class cmCore
    {
        public cmCore()
        {
			StaticVsInstanceMethods staticTest = new StaticVsInstanceMethods();

			StaticVsInstanceMethods.StaticMethod();
			staticTest.InstanceMethod();
        }
    }
}
