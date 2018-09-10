using System;
using IoCDemo.Core;

namespace IocDemo.iOS.Implementations
{
    public class AppleSettings : ISettings
    {
        public string UserName
        {
            get
            {
                return "majdi";
            }
        }
        public string Password
        {
            get
            {
                return "****";
            }
        }
    }
}
