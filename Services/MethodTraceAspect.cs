using AspectInjector.Broker;
using System;

namespace Services
{
    public class MethodTraceAspect
    {
        [Advice(InjectionPoints.Before, InjectionTargets.Method)]
        public void Trace([AdviceArgument(AdviceArgumentSource.TargetName)] string methodName)
        {
            Console.WriteLine($@"{methodName}: {DateTime.Now}");
        }
    }
}
