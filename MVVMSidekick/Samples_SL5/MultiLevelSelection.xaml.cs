﻿using System.Reactive;
using System.Reactive.Linq;
using MVVMSidekick.ViewModels;
using MVVMSidekick.Views;
using MVVMSidekick.Reactive;
using MVVMSidekick.Services;
using MVVMSidekick.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Navigation;
using Samples.ViewModels;
namespace Samples
{
    public partial class MultiLevelSelection : MVVMPage
    {



        public MultiLevelSelection()
            : base(null)
        {
            this.InitializeComponent();
        }
        public MultiLevelSelection(MultiLevelSelection_Model model)
            : base(model)
        {
            this.InitializeComponent();
        }

    

    }
}




