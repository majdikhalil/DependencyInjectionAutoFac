using IoCDemo.Core;

namespace IocDemo
{
    public class DroidSettings : ISettings
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
                return "*****";
            }
        }
    }
}
