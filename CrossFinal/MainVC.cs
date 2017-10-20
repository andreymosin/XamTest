using System;
using CrossFinal.Shared;

using UIKit;

namespace CrossFinal
{
    public partial class MainVC : UIViewController
    {

        private MyClass _myClass;

        public MainVC() : base("MainVC", null)
        {
            _myClass = new MyClass();
        }



        public override async void ViewDidLoad()
        {
            base.ViewDidLoad();

            var data = await _myClass.GetDataAsync();

            var category = data.Categories[0];

            TestLabel.Text = category.name;

            //TestLabel.Text = "Ahoj";

            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

