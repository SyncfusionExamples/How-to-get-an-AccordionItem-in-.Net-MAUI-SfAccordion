# How to get an AccordionItem in .Net MAUI SfAccordion

This article demonstrates how to get an AccordionItem in the  [.NET MAUI SfAccordion](https://www.syncfusion.com/maui-controls/maui-accordion). In this example, we will get which AccordionItem is expanded or collapsed using ClassId property.

**XAML:**

Binding ClassId in AccordionItem

 ```xml
    <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="SfAccordion_Sample.MainPage"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Accordion;assembly=Syncfusion.Maui.Expander"
             xmlns:local="clr-namespace:SfAccordion_Sample">

    <ContentPage.BindingContext>
        <local:ItemInfoRepository/>
    </ContentPage.BindingContext>

    <ContentPage.Content>
        <syncfusion:SfAccordion x:Name="Accordion" ExpandMode="SingleOrNone" Margin="5" BindableLayout.ItemsSource="{Binding Info}">
            <syncfusion:SfAccordion.Behaviors>
                <local:Behavior/>
            </syncfusion:SfAccordion.Behaviors>
            <BindableLayout.ItemTemplate>
                <DataTemplate>
                    <syncfusion:AccordionItem x:Name="AccordionItem" ClassId="{Binding ClassID}">
                        <syncfusion:AccordionItem.Header>
                            <Grid HeightRequest="50">
                                <Label Text="{Binding Name}" VerticalOptions="Center"/>
                            </Grid>
                        </syncfusion:AccordionItem.Header>
                        <syncfusion:AccordionItem.Content>
                            <Grid Padding="5" BackgroundColor="NavajoWhite">
                                <Label Text="{Binding Description}"/>
                            </Grid>
                        </syncfusion:AccordionItem.Content>
                    </syncfusion:AccordionItem>
                </DataTemplate>
            </BindableLayout.ItemTemplate>
        </syncfusion:SfAccordion>
    </ContentPage.Content>

</ContentPage>
 ```

**C#**

Perform operation based on ClassId

 ```c#
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
 ```

Download the complete sample from [GitHub](https://github.com/SyncfusionExamples/How-to-get-an-AccordionItem-in-.Net-MAUI-SfAccordion.git)