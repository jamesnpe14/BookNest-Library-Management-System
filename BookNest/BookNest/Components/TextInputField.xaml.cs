﻿using System;
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

namespace BookNest.Components
{
    public partial class TextInputField : UserControl
    {

        public string Placeholder
        {
            get { return (string)GetValue(PlaceholderProperty); }
            set { SetValue(PlaceholderProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Placeholder.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PlaceholderProperty =
            DependencyProperty.Register("Placeholder", typeof(string), typeof(TextInputField), new PropertyMetadata("Placeholder"));

        public TextInputField()
        {
            InitializeComponent();
        }

        private void TextInputFieldTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(TextInputFieldTextBox.Text))
            {
                PlaceholderLabel.Visibility = Visibility.Visible;
            }
            else
            {
                PlaceholderLabel.Visibility = Visibility.Collapsed;

            }
        }

    }
}
