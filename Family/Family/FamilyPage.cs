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
            Content = new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
              
                FormattedText = new FormattedString
                {
                    Spans =
                    {
                        new Span
                        {
                            Text = "Greetings, and Welcome to my family app. My Family Memebers are:",
                             FontAttributes = FontAttributes.Bold

                        },
                        new Span
                        {
                            Text = Environment.NewLine + "Blake",
                            FontAttributes = FontAttributes.Bold,
                            ForegroundColor = Color.Red,


                        },
                        new Span
                        {
                            Text = Environment.NewLine + "Chelsea",
                            FontAttributes = FontAttributes.Italic,
                            ForegroundColor = Color.Green

                        },
                        new Span
                        {
                            Text = Environment.NewLine + "Karson",
                            FontAttributes = FontAttributes.None,
                            ForegroundColor = Color.Blue,
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))

                        }
                    }  
                }
                

            };

        }
    }
}
