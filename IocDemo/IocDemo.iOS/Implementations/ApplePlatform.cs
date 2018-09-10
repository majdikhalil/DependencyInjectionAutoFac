using System;
using IoCDemo.Core;

namespace IocDemo.iOS.Implementations
{
    public class ApplePlatform : IPlatform
    {
        public string GetPlatformName()
        {
            return "iOS";
        }

        public string ContainerName
        {
            get
            {
                return "AutoFac";
            }
        }
    }
}
