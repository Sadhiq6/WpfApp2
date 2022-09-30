using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;


namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<User> users = new List<User>();

        public class User
        {
            public string Name { get; set; }
            public string Occupation { get; set; }

        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            users.Add(new User { Name = "John Doe", Occupation = "gardener" });
            users.Add(new User { Name = "Roger Roe", Occupation = "driver" });
            users.Add(new User { Name = "Lucy Smith", Occupation = "teacher" });                       
            
            var data = Properties.Resources.check;

            var tpl = Scriban.Template.Parse(data);
            var result = tpl.Render(new { users = users });
            htmlcontent.Text = result;
        }
    }
}
