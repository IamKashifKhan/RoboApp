using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android;
using Android.App;
using Android.Bluetooth;
using Android.Content;
using Android.Locations;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Support.V4.Content;
using Android.Views;
using Android.Widget;
using Plugin.CurrentActivity;
using RoboApp.Droid.Services;
using RoboApp.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(BlueToothManager))]

namespace RoboApp.Droid.Services
{
    public class BlueToothManager : IBlueToothM
    {

        static readonly int RC_LAST_LOCATION_PERMISSION_CHECK = 1000;
        private readonly Context context;

        public async Task OpenBluetooth()
        {
            Android.Bluetooth.BluetoothAdapter bluetoothAdapter = BluetoothAdapter.DefaultAdapter;

            // is bluetooth enabled?
            if (bluetoothAdapter.IsEnabled)
            {
                //  bluetoothAdapter.Disable();

            }
            else
            {


                bluetoothAdapter.Enable();

                MainActivity activity = Forms.Context as MainActivity;
                var permissionCheck = ContextCompat.CheckSelfPermission(activity.BaseContext.ApplicationContext, Manifest.Permission.AccessCoarseLocation);
                var permissionCheck1 = ContextCompat.CheckSelfPermission(activity.BaseContext.ApplicationContext, Manifest.Permission.AccessFineLocation);


            }


            // or

        }

        public bool CheckLocationPermission()
        {

            MainActivity activity = Forms.Context as MainActivity;

            var permissionCheck = ContextCompat.CheckSelfPermission(activity.BaseContext.ApplicationContext, Manifest.Permission.AccessCoarseLocation);
            var permissionCheck1 = ContextCompat.CheckSelfPermission(activity.BaseContext.ApplicationContext, Manifest.Permission.AccessFineLocation);


            if (permissionCheck1 == Android.Content.PM.Permission.Granted)
            {
                LocationManager locationManager = (LocationManager)Forms.Context.GetSystemService(Context.LocationService);

                if (locationManager.IsProviderEnabled(LocationManager.GpsProvider) == false)
                {
                    //Intent gpsSettingIntent = new Intent(Settings.ActionLocationSourceSettings);
                    //         //Forms.Context.StartActivity(gpsSettingIntent);
                    //         GoogleApiClient googleApiClient = new GoogleApiClient.Builder(context)
                    //.AddApi(LocationServices.API).Build();
                    //         googleApiClient.Connect();

                    //         LocationRequest locationRequest = LocationRequest.Create();
                    //         locationRequest.SetPriority(LocationRequest.PriorityHighAccuracy);
                    //         locationRequest.SetInterval(10000);
                    //         locationRequest.SetFastestInterval(10000 / 2);

                    //         LocationSettingsRequest.Builder builder = new LocationSettingsRequest.Builder().AddLocationRequest(locationRequest);
                    //         builder.SetAlwaysShow(true);


                    Forms.Context.StartActivity(new Android.Content.Intent(Android.Provider.Settings.ActionLocat‌​ionSourceSettings));
                }
                return true;
            }
            else
            {

                return false;
            }
        }
        public async Task AskLocationPermission()
        {
            MainActivity activity = Forms.Context as MainActivity;
            ActivityCompat.RequestPermissions(activity, new[] { Manifest.Permission.AccessFineLocation }, 1000);



        }
        public void CloseApp()
        {
            Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
        }

        public void MakeToastMessage(string Message)
        {
            Activity activity = CrossCurrentActivity.Current.Activity;
            Toast.MakeText(Forms.Context, Message, ToastLength.Long).Show();






        }

    }

}