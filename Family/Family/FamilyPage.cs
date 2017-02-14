using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Family
{
    class FamilyPage : ContentPage
    {

        public FamilyPage()
        {
            BackgroundColor = Color.Aqua;

            var stacklayout = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children =
                {
                        new Label
                        {
                            Text = "Greetings, and Welcome to my family app. My Family Memebers are:",
                             FontAttributes = FontAttributes.Bold

                        },
                        new Label
                        {
                            Text = Environment.NewLine + "Blake",
                            FontAttributes = FontAttributes.Bold,
                            BackgroundColor = Color.Red,


                        },
                        new Label
                        {
                            Text = Environment.NewLine + "Chelsea",
                            FontAttributes = FontAttributes.Italic,
                            BackgroundColor = Color.Green

                        },
                        new Label
                        {
                            Text = Environment.NewLine + "Karson",
                            FontAttributes = FontAttributes.None,
                            BackgroundColor = Color.Blue,
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))

                        },
                         new Label
                        {
                            Text = Environment.NewLine + "Tyke",
                            FontAttributes = FontAttributes.None,
                            BackgroundColor = Color.Blue,
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                            VerticalOptions = LayoutOptions.FillAndExpand

                        }
                }
                
                
            };
           Content = new ScrollView
           {
              Orientation = ScrollOrientation.Both,
              Content = stacklayout
           };
        }
            
    }
}
