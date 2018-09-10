using System;
using IoCDemo.Core;

namespace IocDemo
{
    public class DroidPlatform : IPlatform
    {
        public string GetPlatformName()
        {
            return "Android";
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