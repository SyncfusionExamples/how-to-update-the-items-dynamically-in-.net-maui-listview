using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

namespace ListViewMaui
{
    public class Behavior : Behavior<ContentPage>
    {
        #region Fields

        private Syncfusion.Maui.ListView.SfListView listView;
       
        #endregion

        #region Overrides
        protected override void OnAttachedTo(ContentPage bindable)
        {
            InitializeTimer();
            listView = bindable.FindByName<Syncfusion.Maui.ListView.SfListView>("listView");
            listView.PropertyChanged += ListView_PropertyChanged;
            base.OnAttachedTo(bindable);
        }
        private void ListView_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "ItemsSource")
                InitializeTimer();
        }

        private async void InitializeTimer()
        {
            await WaitAndExecute(2000, () =>
            {
                var viewmodel = new ContactInfoRepository();
                listView.ItemsSource = viewmodel.ContactInfo;
            });
        }

        private async Task WaitAndExecute(int milisec, Action actionToExecute)
        {
            await Task.Delay(milisec);
            actionToExecute();
        }
        protected override void OnDetachingFrom(ContentPage bindable)
        {
            listView = null;
            base.OnDetachingFrom(bindable);
        }
        #endregion
    }
}
