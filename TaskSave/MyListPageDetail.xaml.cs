using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TaskSave
{
    public partial class MyListPageDetail : ContentPage
    {
        public MyListPageDetail(string name, string age)
        {
            //details
            InitializeComponent();
            FirstName.Text = name;
            Age.Text = age;

        }
    }
}
