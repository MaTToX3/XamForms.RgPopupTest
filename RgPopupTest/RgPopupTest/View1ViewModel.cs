using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace RgPopupTest
{
    public class View1ViewModel : BindableBase
    {
        public string Test { get; set; } = "Hello from View Model";
    }
}
