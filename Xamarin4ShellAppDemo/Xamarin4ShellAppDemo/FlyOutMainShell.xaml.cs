﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin4ShellAppDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlyOutMainShell : Shell
    {
        public FlyOutMainShell()
        {
            InitializeComponent();
        }
    }
}