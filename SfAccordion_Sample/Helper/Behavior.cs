using Syncfusion.Maui.Accordion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfAccordion_Sample
{
    public class Behavior : Behavior<SfAccordion>
    {
        SfAccordion Accordion;
        protected override void OnAttachedTo(SfAccordion bindable)
        {
            Accordion = bindable;
            Accordion.Expanded += Bindable_Expanded;
            Accordion.Collapsed += Bindable_Collapsed;
            base.OnAttachedTo(bindable);
        }

        private void Bindable_Expanded(object sender, ExpandedAndCollapsedEventArgs e)
        {
            var index = e.Index;
            var item = Accordion.Items[index];
            if (item.ClassId == "Item1")
            {
                App.Current.MainPage.DisplayAlert("Informtion", "Accordion Item1 Expanded", "Ok");
            }
            else if (item.ClassId == "Item2")
            {
                App.Current.MainPage.DisplayAlert("Informtion", "Accordion Item2 Expanded", "Ok");
            }
            else if (item.ClassId == "Item3")
            {
                App.Current.MainPage.DisplayAlert("Informtion", "Accordion Item3 Expanded", "Ok");
            }
            else if (item.ClassId == "Item4")
            {
                App.Current.MainPage.DisplayAlert("Informtion", "Accordion Item4 Expanded", "Ok");
            }
        }

        private void Bindable_Collapsed(object sender, ExpandedAndCollapsedEventArgs e)
        {
        }

        protected override void OnDetachingFrom(SfAccordion bindable)
        {
            Accordion.Expanded -= Bindable_Expanded;
            Accordion.Collapsed -= Bindable_Collapsed;
            Accordion = null;
            base.OnDetachingFrom(bindable);
        }
    }
}
