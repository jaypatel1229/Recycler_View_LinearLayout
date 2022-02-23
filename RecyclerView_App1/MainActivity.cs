using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.RecyclerView.Widget;
using System;
using System.Collections.Generic;

namespace RecyclerView_App1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private RecyclerView recyclerView;
        private ListView _NameList;
        private List<string> _nameList;
        private NameAdapter _nameAdapter;
        RecyclerView.LayoutManager layoutManager;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            recyclerView = FindViewById<RecyclerView>(Resource.Id._nameRecyclerView);
            _NameList = FindViewById<ListView>(Resource.Id._nameList);

            GenerateDumyRecord();
           

            layoutManager = new LinearLayoutManager(this);
            recyclerView.SetLayoutManager(layoutManager);
            _nameAdapter = new NameAdapter(_nameList);

            recyclerView.SetAdapter(_nameAdapter);
            _nameAdapter.ItemClick += _nameAdapterItem_Click;


        }
        private void _nameAdapterItem_Click(object sender,int i)
        {
            Toast.MakeText(this, "Hii" +_nameList[i].ToString(),ToastLength.Short).Show();
        }

        private void GenerateDumyRecord()
        {
            _nameList = new List<string>();

            _nameList.Add("Hinal");
            _nameList.Add("Vruti");
            _nameList.Add("Aman");
            _nameList.Add("Rakul");
            _nameList.Add("Prit");
            _nameList.Add("Manish");
            _nameList.Add("Hiral");
            _nameList.Add("Hinal");
            _nameList.Add("Vruti");
            _nameList.Add("Aman");
            _nameList.Add("Rakul");
            _nameList.Add("Prit");
            _nameList.Add("Manish");
            _nameList.Add("Hiral");
            _nameList.Add("Hinal");
            _nameList.Add("Vruti");
            _nameList.Add("Aman");
            _nameList.Add("Rakul");
            _nameList.Add("Prit");
            _nameList.Add("Manish");
            _nameList.Add("Hiral");
            _nameList.Add("Hinal");
            _nameList.Add("Vruti");
            _nameList.Add("Aman");
            _nameList.Add("Rakul");
            _nameList.Add("Prit");
            _nameList.Add("Manish");
            _nameList.Add("Hiral");
            _nameList.Add("Hinal");
            _nameList.Add("Vruti");
            _nameList.Add("Aman");
            _nameList.Add("Rakul");
            _nameList.Add("Prit");
            _nameList.Add("Manish");
            _nameList.Add("Hiral");
            _nameList.Add("Hinal");
            _nameList.Add("Vruti");
            _nameList.Add("Aman");
            _nameList.Add("Rakul");
            _nameList.Add("Prit");
            _nameList.Add("Manish");
            _nameList.Add("Hiral");

            //foreach (string name in _nameList)
            //    _nameList.Add(name);

        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}