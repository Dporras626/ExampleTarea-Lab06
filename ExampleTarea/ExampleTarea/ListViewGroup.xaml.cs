using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExampleTarea
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGroup : ContentPage
    {
        public ObservableCollection<Group> Groups { get; set; }
        public ListViewGroup()
        {
            InitializeComponent();
            Groups = new ObservableCollection<Group>
        {
            new Group("A")
            {
                new Item { Title = "Real", Subtitle = "Madrid" },
                new Item { Title = "Atletico", Subtitle = "Madrid" },
                new Item { Title = "Real", Subtitle = "Betis" },
                new Item { Title = "Alianza", Subtitle = "Lima" }
            },
            new Group("B")
            {
                new Item { Title = "Diego", Subtitle = "Porras" },
                new Item { Title = "Sideral", Subtitle = "Carrion" },
                new Item { Title = "Rafael", Subtitle = "Cardozo" },
                new Item { Title = "Leao", Subtitle = "Butron" }
            },
            new Group("C")
            {
                new Item { Title = "Lionel", Subtitle = "Messi" },
                new Item { Title = "Cuto", Subtitle = "Guadalupe" },
                new Item { Title = "Reymo", Subtitle = "Mance" },
                new Item { Title = "Carlos", Subtitle = "Saravia" }
            },
        };
            GroupedView.ItemsSource = Groups;
        }
    }
}