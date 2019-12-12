using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using muxc = Microsoft.UI.Xaml.Controls;

namespace TreeViewAnomalies
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            for (byte b1 = 0; b1 < 20; b1++)
            {
                muxc.TreeViewNode rootnode = new muxc.TreeViewNode() { Content = $"parent item {b1}" };
                for (byte b2 = 0; b2 < 8; b2++)
                {
                    rootnode.Children.Add(new muxc.TreeViewNode() { Content = $"child item {b1},{b2}" });
                }
                TvTree2.RootNodes.Add(rootnode);
            }
        }

        private async void BtnShow1_Click(object _1, RoutedEventArgs _2)
        {
            TvTree2.RootNodes[(int)SldrParent.Value].IsExpanded = true;
            if (SldrChild.Value == -1)
                TvTree2.SelectedNode = TvTree2.RootNodes[(int)SldrParent.Value];
            else
                TvTree2.SelectedNode = TvTree2.RootNodes[(int)SldrParent.Value].Children[(int)SldrChild.Value];
            await DlgTree1.ShowAsync();
            if (TvTree2.SelectedNode == null)
                TxtChoice.Text = "Chosen item: none";
            else
                TxtChoice.Text = $"Chosen item: {TvTree2.SelectedNode.ToString()}";
        }
    }
}
