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

            BackgroundColor = Color.Black;
            var stacklayout = new StackLayout
            {

                Orientation = StackOrientation.Vertical,

                Children =
                {
                        new Label
                        {
                            Text = "Greetings, and Welcome to my family app. My Family Memebers are:",
                             FontAttributes = FontAttributes.Bold,
                             VerticalOptions = LayoutOptions.FillAndExpand,
                             HorizontalOptions = LayoutOptions.Center,
                             TextColor = Color.Maroon,
                             BackgroundColor = Color.White,
                             FontSize = 36
                        },
                        new Label
                        {
                            Text = "Blake - That is me and I am the father of the family. I am currently a CNC Machinist, and have been for the last 6 years. I should be done with school this fall.",
                            FontAttributes = FontAttributes.Bold,
                            VerticalOptions = LayoutOptions.FillAndExpand,
                            HorizontalOptions = LayoutOptions.Center,
                            TextColor = Color.Red,
                            FontSize = 24
                        },
                        new Image
                        {
                          VerticalOptions = LayoutOptions.Center,
                          HorizontalOptions = LayoutOptions.Center,
                          Source = ImageSource.FromResource("Family.profile.jpg")
                        },
                        new Label
                        {
                            Text = "Chelsea - Is the mother and she is also in college. She is in her last class right now.",
                            //Text = Environment.NewLine + "Chelsea - Is the mother and she is also in college. She is in her last class right now.",
                            VerticalOptions = LayoutOptions.FillAndExpand,
                            HorizontalOptions = LayoutOptions.Center,
                            BackgroundColor = Color.Green,
                            FontSize = 28
                        },
                        new Image
                        {
                          VerticalOptions = LayoutOptions.Center,
                          HorizontalOptions = LayoutOptions.Center,
                          Source = ImageSource.FromResource("Family.Chelsea.jpg")
                        },
                        new Label
                        {
                            Text = "Karson - He is our 6 year old son, and the absolute bright spot in our lifes. He is in first grade and reading like a champ. He is my mini me and that may be a bad thing in some ways, but he is perfect.",
                            FontAttributes = FontAttributes.Bold,
                            VerticalOptions = LayoutOptions.FillAndExpand,
                            HorizontalOptions = LayoutOptions.Center,
                            BackgroundColor = Color.Yellow,
                            TextColor = Color.Green,
                            FontSize = 34 //Device.GetNamedSize(NamedSize.Large, typeof(Label))

                        },
                        new Image
                        {
                          VerticalOptions = LayoutOptions.Center,
                          HorizontalOptions = LayoutOptions.Center,
                          Source = ImageSource.FromResource("Family.Karson.jpg")
                        },
                        new Label
                        {
                            Text = "Tyke - He is a rescued dog. We got him from a rescue house that my step-sister runs. We got lucky because he is truely a one in a million animal.",
                            VerticalOptions = LayoutOptions.FillAndExpand,
                            HorizontalOptions = LayoutOptions.FillAndExpand,
                            FontAttributes = FontAttributes.Bold,
                            FontSize = 20 //Device.GetNamedSize(NamedSize.Large, typeof(Label))

                        },
                        new Image
                        {
                          VerticalOptions = LayoutOptions.Center,
                          HorizontalOptions = LayoutOptions.Center,
                          Source = ImageSource.FromResource("Family.Tyke.jpg")
                        }

                }
            };
            Content = new ScrollView
            {
                Orientation = ScrollOrientation.Vertical,
                Content = stacklayout
            };

        }
    }
}
