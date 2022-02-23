using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecyclerView_App1 
{
    
    class NameAdapter : RecyclerView.Adapter
    {
        private List<string> _nameList;
        private int position;

        public event EventHandler<int> ItemClick;
        public NameAdapter(List<string> Name)
        {
            _nameList = Name;
        }
        public override int ItemCount => _nameList.Count;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            NameViewHolder nameViewHolder = holder as NameViewHolder;
            nameViewHolder.BindData(_nameList[position]);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout._newname_listrow_item,parent,false);
            return new NameViewHolder(view, OnClick);
        }
        public void OnClick(int view)
        {
            if (ItemClick != null)
            {
                ItemClick?.Invoke(this, position);
            }
            ItemClick?.Invoke(this, position);
        }
    }

    class NameViewHolder : RecyclerView.ViewHolder
    {
        public TextView nameText;
        public NameViewHolder(View itemView,Action<int> listner):base(itemView)
        {
            nameText = itemView.FindViewById<TextView>(Resource.Id._nameText);
            nameText.Click += (sender, e) => listner(base.LayoutPosition);
            
        }

        internal void BindData(string Name)
        {
            nameText.Text = Name;
        }
    }
}