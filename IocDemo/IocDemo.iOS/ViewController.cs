using System;
using IoCDemo.Core;
using Autofac;
using UIKit;

namespace IocDemo.iOS
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            MainViewModel viewModel = null;

            using (var scope = App.Container.BeginLifetimeScope())
            {
                viewModel = App.Container.Resolve<MainViewModel>();
            }

            var platformName = viewModel.PlatformName;
            var container = viewModel.ContainerName;
            var userName = viewModel.UserName;
            var password = viewModel.Password;

            Console.WriteLine("Platform:{0} Container:{1} UserName:{2} Password:{3}", platformName, container, userName, password);

            platformLabel.Text = "Platform : " + platformName;
            containerLabel.Text = "Container : " + container;
            userNameLabel.Text = "UserName : " + userName;
            passwordLabel.Text = "Password : " + password;
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
