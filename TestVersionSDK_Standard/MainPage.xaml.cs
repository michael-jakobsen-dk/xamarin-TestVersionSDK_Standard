using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestVersionSDK_Standard.Data;
using Xamarin.Forms;

namespace TestVersionSDK_Standard
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        readonly IList<Story> stories = new ObservableCollection<Story>();
        readonly StoryManager manager = new StoryManager();
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            UpdateStoryList();
        }

        void UpdateStoryList()
        {
           
            var storyCollection = manager.GetAll();
            stories.Clear();


            foreach (Story story in storyCollection)
            {
                stories.Add(story);
            }
        
        }
    }
}
