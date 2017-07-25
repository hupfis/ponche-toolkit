﻿using PoncheToolkit.EffectsCreator.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace PoncheToolkit.EffectsCreator.Controls
{
    /// <summary>
    /// Interaction logic for CustomButton.xaml
    /// </summary>
    public partial class OpenFileDialogButton : Button
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public OpenFileDialogButton()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The DialogFilter property.
        /// </summary>
        public static readonly DependencyProperty DialogFilterProperty =
            DependencyProperty.Register("DialogFilter",
                typeof(string),
                typeof(OpenFileDialogButton));

        /// <summary>
        /// The DialogFilter value.
        /// </summary>
        [Browsable(true)]
        [Category("CustomProps")]
        [Description("DialogFilter")]
        public string DialogFilter
        {
            get { return (string)GetValue(DialogFilterProperty); }
            set { SetValue(DialogFilterProperty, value); }
        }
    }
}