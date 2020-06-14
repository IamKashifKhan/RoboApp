using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using RoboApp.Enums;
using RoboApp.Helpers.Extensions;
using RoboApp.Models;
using Xamarin.Forms;

namespace RoboApp
{
    public partial class CalibrationPage : ContentPage
    {
        ObservableCollection<RoboControl> Robostatus = new ObservableCollection<RoboControl>();
         public CalibrationPage()
        {
            InitializeComponent();
            LoadData();
            CalibrationListView.ItemSelected += (sender, e) => { ((ListView)sender).SelectedItem = null; };

        }

        private void LoadData()
        {
            for (int i = 0; i<10; i++)
            {
                Robostatus.Add(new RoboControl { MotorType = i, Datatime = DateTime.Now, Zero_Degree = "0", Current_Degree = i.ToString(), Istrue = true, Back="0", Center= "0", Forward = "0" });
            }
            CalibrationListView.ItemsSource = null;
            CalibrationListView.ItemsSource = Robostatus;

        }

        private void Add_zero_deg(System.Object sender, System.EventArgs e)
        {
            var Liked = (Button)sender;
            var Para = Liked.BindingContext;
            var item = (RoboControl)Para;
            var zerodeg = int.Parse(item.Zero_Degree);
            zerodeg++;
            item.Zero_Degree = zerodeg.ToString();

        }
        private  void Sub_zero_deg(object sender, EventArgs e)
        {
            var Liked = (Button)sender;
            var Para = Liked.BindingContext;
            var item = (RoboControl)Para;
            var zerodeg = int.Parse(item.Zero_Degree);
            zerodeg--;
            item.Zero_Degree = zerodeg.ToString();
        }
        private void Add_current_deg(System.Object sender, System.EventArgs e)
        {
            var Liked = (Button)sender;
            var Para = Liked.BindingContext;
            var item = (RoboControl)Para;
            var currentdeg = int.Parse(item.Current_Degree);
            currentdeg++;
            item.Current_Degree = currentdeg.ToString();
        }

        private  void Sub_current_deg(object sender, EventArgs e)
        {
            var Liked = (Button)sender;
            var Para = Liked.BindingContext;
            var item = (RoboControl)Para;
            var currentdeg = int.Parse(item.Current_Degree);
            currentdeg--;
            item.Current_Degree = currentdeg.ToString();
        }
        private void Add_forward(object sender, EventArgs e)
        {
            var Liked = (Button)sender;
            var Para = Liked.BindingContext;
            var item = (RoboControl)Para;
            var forward = int.Parse(item.Forward);
            forward++;
            item.Forward = forward.ToString();
        }
        private void Sub_forward(object sender, EventArgs e)
        {
            var Liked = (Button)sender;
            var Para = Liked.BindingContext;
            var item = (RoboControl)Para;
            var forward = int.Parse(item.Forward);
            forward--;
            item.Forward = forward.ToString();
        }
        private void Add_backward(object sender, EventArgs e)
        {
            var Liked = (Button)sender;
            var Para = Liked.BindingContext;
            var item = (RoboControl)Para;
            var backward = int.Parse(item.Back);
            backward++;
            item.Back = backward.ToString();
        }
        private void Sub_backward(object sender, EventArgs e)
        {
            var Liked = (Button)sender;
            var Para = Liked.BindingContext;
            var item = (RoboControl)Para;
            var backward = int.Parse(item.Back);
            backward--;
            item.Back = backward.ToString();
        }
        private void Add_center(object sender, EventArgs e)
        {
            var Liked = (Button)sender;
            var Para = Liked.BindingContext;
            var item = (RoboControl)Para;
            var center = int.Parse(item.Center);
            center++;
            item.Center = center.ToString();
        }
        private void Sub_center(object sender, EventArgs e)
        {
            var Liked = (Button)sender;
            var Para = Liked.BindingContext;
            var item = (RoboControl)Para;
            var center = int.Parse(item.Center);
            center--;
            item.Center = center.ToString();
        }
        void PartBtnClicked(System.Object sender, System.EventArgs e)
        {
            if (sender is Button partbtn)
            {

                var indextoscroll = int.Parse(partbtn.AutomationId);

                CalibrationListView.ScrollTo(Robostatus[indextoscroll], ScrollToPosition.Start, false);

                //if (partbtn.AutomationId == MotorType.Head.GetMotorDescription())
                //{
                //    string[] options = { "tf", "time", "0 deg", "current degree" };
                //  // SetGridChildren(options);
                //}
            }
        }
        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
             
        }
        
        //private void SetGridChildren(string[] options)
        //{
        //    if (CalibrationGrid.Children.Count != 0)
        //    {
        //        CalibrationGrid.Children.Clear();
        //        CalibrationGrid.RowDefinitions.Clear();

        //    }
        //    Entry[] entries = new Entry[options.Length];
        //    Button[] AddBtn = new Button[options.Length];
        //    Button[] SubBtn = new Button[options.Length];
        //    int i = 0;
        //    foreach (var item in options)
        //    {
        //        CalibrationGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(60, GridUnitType.Absolute) });
        //        entries[i] = new Entry
        //        {
        //            Placeholder = $"Enter {item}",
        //            TextColor = Color.Black,
        //            PlaceholderColor = Color.Gray,
        //            Visual = VisualMarker.Material,
        //        };
        //        AddBtn[i] = new Button
        //        {
        //            BackgroundColor = Color.Green,
        //            TextColor = Color.White,
        //            Text = "+",
        //            HeightRequest =40,
        //        };
        //        SubBtn[i] = new Button
        //        {
        //            BackgroundColor = Color.Red,
        //            TextColor = Color.White,
        //            Text = "-",
        //            HeightRequest = 40,
        //        };

        //        CalibrationGrid.Children.Add(entries[i], 0, i);
        //        CalibrationGrid.Children.Add(AddBtn[i], 1, i);
        //        CalibrationGrid.Children.Add(SubBtn[i], 2, i);
        //        i++;

        //    }
        //}
    }
}
