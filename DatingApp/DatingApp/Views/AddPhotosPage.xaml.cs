﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DatingApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddPhotosPage : ContentPage
    {
        public AddPhotosPage()
        {
            InitializeComponent();
        }

        private void GoBack(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}