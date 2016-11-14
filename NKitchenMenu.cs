using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using NKitchen.ViewModel;
using NKitchen.Model;

namespace NKitchen
{
    [Activity(Label = "Menu", MainLauncher = true)]
    public class NKitchenMenu : Activity
    {
        private ListView lst;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.MenuLayout);
            lst = FindViewById<ListView>(Resource.Id.menuListView);
            lst.Adapter = new MenuListAdaptor(this, DishViewModel.getAllDishes());
            
        }
    }
}