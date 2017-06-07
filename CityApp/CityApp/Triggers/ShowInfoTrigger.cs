using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CityApp.Triggers
{
    public class ShowInfoTrigger : TriggerAction<Grid>
    {
        protected override void Invoke(Grid sender)
        {
            //var infoGrid = sender.Children.Where(view => typeof(Grid)).FirstOrDefault();
        }
    }
}
