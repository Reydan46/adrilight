﻿using adrilight.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace adrilight.View.SettingsWindowComponents
{
    /// <summary>
    /// Interaction logic for LightingMode.xaml
    /// </summary>
    public partial class SpotSetup : UserControl
    {
        public SpotSetup()
        {
            InitializeComponent();
        }



        public class SpotSetupSelectableViewPart : ISelectableViewPart
        {
            private readonly Lazy<SpotSetup> lazyContent;

            public SpotSetupSelectableViewPart(Lazy<SpotSetup> lazyContent)
            {
                this.lazyContent = lazyContent ?? throw new ArgumentNullException(nameof(lazyContent));
            }

            public int Order => 50;

            public string ViewPartName => "Настройка области захвата";

            public object Content { get => lazyContent.Value; }
        }
    }
}
