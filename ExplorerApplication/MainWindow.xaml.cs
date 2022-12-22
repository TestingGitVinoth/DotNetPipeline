using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExplorerApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

       // private object dummyNode = null;
        public MainWindow()
        {
            InitializeComponent();


            //foreach (string s in Directory.GetLogicalDrives())
            //{
            //    TreeViewItem item = new TreeViewItem();
            //    item.Header = s;
            //    item.Tag = s;
            //    item.FontWeight = FontWeights.Normal;
            //   item.Items.Add(dummyNode);
            //    //item.Expanded += new RoutedEventHandler(folder_Expanded);
            //    TreeView.Items.Add(item);
            //}

            string[] filedata = Directory.GetFiles(@"D:\");
            string[] folderdata = Directory.GetDirectories(@"D:\");

            foreach (string i in folderdata)
            {
                string current = i.Remove(0, 3);
                FileList.Items.Add(current);
            }

            // Displaying the file name one by one
            foreach (string i in filedata)
            {
                string current = i.Remove(0, 3);
                FileList.Items.Add(current);
            }


            foreach (string i in folderdata)
            {
                string current = i.Remove(0, 3);
                TreeView.Items.Add(current);
                string[] currentPath = Directory.GetDirectories(i);
                foreach (string j in currentPath)
                {
                    
                    dynamic name = new TreeViewItem();
                    name =j;
                    TreeView.Items.Add(j);

                }
            }

            // Displaying the file name one by one
            foreach (string i in filedata)
            {
                string current = i.Remove(0, 3);
                TreeView.Items.Add(current);
            }
        }

    }
}
