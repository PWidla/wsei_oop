using System;
using System.Collections.Generic;
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
using System.IO;
using System.Net;
using System.Net.Mime;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace lab9
{
    public partial class MainWindow : Window
    {
        public int pageNumber;
        public int pageSize;
        public string snippetsType;

        public MainWindow()
        {
            InitializeComponent();
        }

        public static PageReposne FetchSnippets(int pageNumber, int pageSize, string snippetsType)
        {
            string url = $"https://dirask.com/api/snippets?pageNumber={pageNumber}&pageSize={pageSize}&dataOrder=newest&dataGroup=batches&snippetsType={Uri.EscapeUriString(snippetsType)}";
            string data = FetchData(url);

            return JsonSerializer.Deserialize<PageReposne>(data);
        }

        public static string FetchData(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                ContentType type = new ContentType(response.ContentType ?? "text/plain;charset=" + Encoding.UTF8.WebName);
                Encoding encoding = Encoding.GetEncoding(type.CharSet ?? Encoding.UTF8.WebName);

                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream, encoding))
                {
                    return reader.ReadToEnd();
                }
            }
        }



        private void btnText_Click(object sender, RoutedEventArgs e)
        {
            Text();
        }

        private void Text()
        {
            if (cbElementsPerPage.SelectedIndex == 0)
            {
                this.pageSize = 1;
            }

            if (cbElementsPerPage.SelectedIndex == 1)
            {
                this.pageSize = 2;
            }

            if (cbElementsPerPage.SelectedIndex == 2)
            {
                this.pageSize = 3;
            }

            if (cbElementsPerPage.SelectedIndex == 3)
            {
                this.pageSize = 4;
            }

            if (cbElementsPerPage.SelectedIndex == 4)
            {
                this.pageSize = 5;
            }

            if (cbElementsPerPage.SelectedIndex == 5)
            {
                this.pageSize = 6;
            }

            if (cbElementsPerPage.SelectedIndex == 6)
            {
                this.pageSize = 7;
            }


            int pageNumber = this.pageNumber;
            int pageSize = this.pageSize;
            string snippetsType = "text";
            this.snippetsType = snippetsType;



            PageReposne reponse = FetchSnippets(pageNumber, pageSize, snippetsType);

            //Console.WriteLine($"PageNumber: {reponse.PageNumber}");
            //Console.WriteLine($"PagesCount: {reponse.PagesCount}");
            //Console.WriteLine($"PageSize:   {reponse.PageSize}  ");
            //Console.WriteLine($"TotalCount: {reponse.TotalCount}");

            //Console.WriteLine();
            //Console.WriteLine("Snippets:");
            List<SnippetReponse> content = new List<SnippetReponse>();



            foreach (SnippetReponse snippet in reponse.Batches)
            {
                content.Add(new SnippetReponse() { Size = snippet.Size, Name = snippet.Name, Type = snippet.Type, ModificationDate = snippet.ModificationDate });
            }


            snippetsGrid.ItemsSource = content;

        }

        private void btnBash_Click(object sender, RoutedEventArgs e)
        {
            Bash();

        }
        private void Bash() {
            if (cbElementsPerPage.SelectedIndex == 0)
            {
                this.pageSize = 1;
            }

            if (cbElementsPerPage.SelectedIndex == 1)
            {
                this.pageSize = 2;
            }

            if (cbElementsPerPage.SelectedIndex == 2)
            {
                this.pageSize = 3;
            }

            if (cbElementsPerPage.SelectedIndex == 3)
            {
                this.pageSize = 4;
            }

            if (cbElementsPerPage.SelectedIndex == 4)
            {
                this.pageSize = 5;
            }

            if (cbElementsPerPage.SelectedIndex == 5)
            {
                this.pageSize = 6;
            }

            if (cbElementsPerPage.SelectedIndex == 6)
            {
                this.pageSize = 7;
            }


            int pageNumber = this.pageNumber;
            int pageSize = this.pageSize;
            string snippetsType = "bash";
            this.snippetsType = snippetsType;



            PageReposne reponse = FetchSnippets(pageNumber, pageSize, snippetsType);

            //Console.WriteLine($"PageNumber: {reponse.PageNumber}");
            //Console.WriteLine($"PagesCount: {reponse.PagesCount}");
            //Console.WriteLine($"PageSize:   {reponse.PageSize}  ");
            //Console.WriteLine($"TotalCount: {reponse.TotalCount}");

            //Console.WriteLine();
            //Console.WriteLine("Snippets:");
            List<SnippetReponse> content = new List<SnippetReponse>();



            foreach (SnippetReponse snippet in reponse.Batches)
            {
                content.Add(new SnippetReponse() { Size = snippet.Size, Name = snippet.Name, Type = snippet.Type, ModificationDate = snippet.ModificationDate });
            }


            snippetsGrid.ItemsSource = content;

        }

        private void btnCpp_Click(object sender, RoutedEventArgs e)
        {
            Cpp();
        }
        private void Cpp() {
            if (cbElementsPerPage.SelectedIndex == 0)
            {
                this.pageSize = 1;
            }

            if (cbElementsPerPage.SelectedIndex == 1)
            {
                this.pageSize = 2;
            }

            if (cbElementsPerPage.SelectedIndex == 2)
            {
                this.pageSize = 3;
            }

            if (cbElementsPerPage.SelectedIndex == 3)
            {
                this.pageSize = 4;
            }

            if (cbElementsPerPage.SelectedIndex == 4)
            {
                this.pageSize = 5;
            }

            if (cbElementsPerPage.SelectedIndex == 5)
            {
                this.pageSize = 6;
            }

            if (cbElementsPerPage.SelectedIndex == 6)
            {
                this.pageSize = 7;
            }


            int pageNumber = this.pageNumber;
            int pageSize = this.pageSize;
            string snippetsType = "cpp";
            this.snippetsType = snippetsType;


            PageReposne reponse = FetchSnippets(pageNumber, pageSize, snippetsType);

            //Console.WriteLine($"PageNumber: {reponse.PageNumber}");
            //Console.WriteLine($"PagesCount: {reponse.PagesCount}");
            //Console.WriteLine($"PageSize:   {reponse.PageSize}  ");
            //Console.WriteLine($"TotalCount: {reponse.TotalCount}");

            //Console.WriteLine();
            //Console.WriteLine("Snippets:");
            List<SnippetReponse> content = new List<SnippetReponse>();



            foreach (SnippetReponse snippet in reponse.Batches)
            {
                content.Add(new SnippetReponse() { Size = snippet.Size, Name = snippet.Name, Type = snippet.Type, ModificationDate = snippet.ModificationDate });
            }


            snippetsGrid.ItemsSource = content;

        }

        private void btnCsharp_Click(object sender, RoutedEventArgs e)
        {
            Csharp();
        }
        private void Csharp() {
            if (cbElementsPerPage.SelectedIndex == 0)
            {
                this.pageSize = 1;
            }

            if (cbElementsPerPage.SelectedIndex == 1)
            {
                this.pageSize = 2;
            }

            if (cbElementsPerPage.SelectedIndex == 2)
            {
                this.pageSize = 3;
            }

            if (cbElementsPerPage.SelectedIndex == 3)
            {
                this.pageSize = 4;
            }

            if (cbElementsPerPage.SelectedIndex == 4)
            {
                this.pageSize = 5;
            }

            if (cbElementsPerPage.SelectedIndex == 5)
            {
                this.pageSize = 6;
            }

            if (cbElementsPerPage.SelectedIndex == 6)
            {
                this.pageSize = 7;
            }


            int pageNumber = this.pageNumber;
            int pageSize = this.pageSize;
            string snippetsType = "cs";
            this.snippetsType = snippetsType;


            PageReposne reponse = FetchSnippets(pageNumber, pageSize, snippetsType);

            //Console.WriteLine($"PageNumber: {reponse.PageNumber}");
            //Console.WriteLine($"PagesCount: {reponse.PagesCount}");
            //Console.WriteLine($"PageSize:   {reponse.PageSize}  ");
            //Console.WriteLine($"TotalCount: {reponse.TotalCount}");

            //Console.WriteLine();
            //Console.WriteLine("Snippets:");
            List<SnippetReponse> content = new List<SnippetReponse>();



            foreach (SnippetReponse snippet in reponse.Batches)
            {
                content.Add(new SnippetReponse() { Size = snippet.Size, Name = snippet.Name, Type = snippet.Type, ModificationDate = snippet.ModificationDate });
            }


            snippetsGrid.ItemsSource = content;

        }

        private void btnJava_Click(object sender, RoutedEventArgs e)
        {
            Java();
        }

        private void Java() {
            if (cbElementsPerPage.SelectedIndex == 0)
            {
                this.pageSize = 1;
            }

            if (cbElementsPerPage.SelectedIndex == 1)
            {
                this.pageSize = 2;
            }

            if (cbElementsPerPage.SelectedIndex == 2)
            {
                this.pageSize = 3;
            }

            if (cbElementsPerPage.SelectedIndex == 3)
            {
                this.pageSize = 4;
            }

            if (cbElementsPerPage.SelectedIndex == 4)
            {
                this.pageSize = 5;
            }

            if (cbElementsPerPage.SelectedIndex == 5)
            {
                this.pageSize = 6;
            }

            if (cbElementsPerPage.SelectedIndex == 6)
            {
                this.pageSize = 7;
            }


            int pageNumber = this.pageNumber;
            int pageSize = this.pageSize;
            string snippetsType = "java";
            this.snippetsType = snippetsType;


            PageReposne reponse = FetchSnippets(pageNumber, pageSize, snippetsType);

            //Console.WriteLine($"PageNumber: {reponse.PageNumber}");
            //Console.WriteLine($"PagesCount: {reponse.PagesCount}");
            //Console.WriteLine($"PageSize:   {reponse.PageSize}  ");
            //Console.WriteLine($"TotalCount: {reponse.TotalCount}");

            //Console.WriteLine();
            //Console.WriteLine("Snippets:");
            List<SnippetReponse> content = new List<SnippetReponse>();



            foreach (SnippetReponse snippet in reponse.Batches)
            {
                content.Add(new SnippetReponse() { Size = snippet.Size, Name = snippet.Name, Type = snippet.Type, ModificationDate = snippet.ModificationDate });
            }


            snippetsGrid.ItemsSource = content;

        }

        private void btnCSS_Click(object sender, RoutedEventArgs e)
        {
            CSS();
        }

        private void CSS() {
            if (cbElementsPerPage.SelectedIndex == 0)
            {
                this.pageSize = 1;
            }

            if (cbElementsPerPage.SelectedIndex == 1)
            {
                this.pageSize = 2;
            }

            if (cbElementsPerPage.SelectedIndex == 2)
            {
                this.pageSize = 3;
            }

            if (cbElementsPerPage.SelectedIndex == 3)
            {
                this.pageSize = 4;
            }

            if (cbElementsPerPage.SelectedIndex == 4)
            {
                this.pageSize = 5;
            }

            if (cbElementsPerPage.SelectedIndex == 5)
            {
                this.pageSize = 6;
            }

            if (cbElementsPerPage.SelectedIndex == 6)
            {
                this.pageSize = 7;
            }


            int pageNumber = this.pageNumber;
            int pageSize = this.pageSize;
            string snippetsType = "css";
            this.snippetsType = snippetsType;


            PageReposne reponse = FetchSnippets(pageNumber, pageSize, snippetsType);

            //Console.WriteLine($"PageNumber: {reponse.PageNumber}");
            //Console.WriteLine($"PagesCount: {reponse.PagesCount}");
            //Console.WriteLine($"PageSize:   {reponse.PageSize}  ");
            //Console.WriteLine($"TotalCount: {reponse.TotalCount}");

            //Console.WriteLine();
            //Console.WriteLine("Snippets:");
            List<SnippetReponse> content = new List<SnippetReponse>();



            foreach (SnippetReponse snippet in reponse.Batches)
            {
                content.Add(new SnippetReponse() { Size = snippet.Size, Name = snippet.Name, Type = snippet.Type, ModificationDate = snippet.ModificationDate });
            }


            snippetsGrid.ItemsSource = content;

        }

        private void btnHTML_Click(object sender, RoutedEventArgs e)
        {
            HTML();
        }

        private void HTML() {
            if (cbElementsPerPage.SelectedIndex == 0)
            {
                this.pageSize = 1;
            }

            if (cbElementsPerPage.SelectedIndex == 1)
            {
                this.pageSize = 2;
            }

            if (cbElementsPerPage.SelectedIndex == 2)
            {
                this.pageSize = 3;
            }

            if (cbElementsPerPage.SelectedIndex == 3)
            {
                this.pageSize = 4;
            }

            if (cbElementsPerPage.SelectedIndex == 4)
            {
                this.pageSize = 5;
            }

            if (cbElementsPerPage.SelectedIndex == 5)
            {
                this.pageSize = 6;
            }

            if (cbElementsPerPage.SelectedIndex == 6)
            {
                this.pageSize = 7;
            }


            int pageNumber = this.pageNumber;
            int pageSize = this.pageSize;
            string snippetsType = "html";
            this.snippetsType = snippetsType;


            PageReposne reponse = FetchSnippets(pageNumber, pageSize, snippetsType);

            //Console.WriteLine($"PageNumber: {reponse.PageNumber}");
            //Console.WriteLine($"PagesCount: {reponse.PagesCount}");
            //Console.WriteLine($"PageSize:   {reponse.PageSize}  ");
            //Console.WriteLine($"TotalCount: {reponse.TotalCount}");

            //Console.WriteLine();
            //Console.WriteLine("Snippets:");
            List<SnippetReponse> content = new List<SnippetReponse>();



            foreach (SnippetReponse snippet in reponse.Batches)
            {
                content.Add(new SnippetReponse() { Size = snippet.Size, Name = snippet.Name, Type = snippet.Type, ModificationDate = snippet.ModificationDate });
            }


            snippetsGrid.ItemsSource = content;

        }

        private void btnJS_Click(object sender, RoutedEventArgs e)
        {
            JS();
        }

        private void JS() {
            if (cbElementsPerPage.SelectedIndex == 0)
            {
                this.pageSize = 1;
            }

            if (cbElementsPerPage.SelectedIndex == 1)
            {
                this.pageSize = 2;
            }

            if (cbElementsPerPage.SelectedIndex == 2)
            {
                this.pageSize = 3;
            }

            if (cbElementsPerPage.SelectedIndex == 3)
            {
                this.pageSize = 4;
            }

            if (cbElementsPerPage.SelectedIndex == 4)
            {
                this.pageSize = 5;
            }

            if (cbElementsPerPage.SelectedIndex == 5)
            {
                this.pageSize = 6;
            }

            if (cbElementsPerPage.SelectedIndex == 6)
            {
                this.pageSize = 7;
            }


            int pageNumber = this.pageNumber;
            int pageSize = this.pageSize;
            string snippetsType = "javascript";
            this.snippetsType = snippetsType;


            PageReposne reponse = FetchSnippets(pageNumber, pageSize, snippetsType);

            //Console.WriteLine($"PageNumber: {reponse.PageNumber}");
            //Console.WriteLine($"PagesCount: {reponse.PagesCount}");
            //Console.WriteLine($"PageSize:   {reponse.PageSize}  ");
            //Console.WriteLine($"TotalCount: {reponse.TotalCount}");

            //Console.WriteLine();
            //Console.WriteLine("Snippets:");
            List<SnippetReponse> content = new List<SnippetReponse>();



            foreach (SnippetReponse snippet in reponse.Batches)
            {
                content.Add(new SnippetReponse() { Size = snippet.Size, Name = snippet.Name, Type = snippet.Type, ModificationDate = snippet.ModificationDate });
            }


            snippetsGrid.ItemsSource = content;

        }

        private void btnPHP_Click(object sender, RoutedEventArgs e)
        {
            PHP();
        }

        private void PHP() {
            if (cbElementsPerPage.SelectedIndex == 0)
            {
                this.pageSize = 1;
            }

            if (cbElementsPerPage.SelectedIndex == 1)
            {
                this.pageSize = 2;
            }

            if (cbElementsPerPage.SelectedIndex == 2)
            {
                this.pageSize = 3;
            }

            if (cbElementsPerPage.SelectedIndex == 3)
            {
                this.pageSize = 4;
            }

            if (cbElementsPerPage.SelectedIndex == 4)
            {
                this.pageSize = 5;
            }

            if (cbElementsPerPage.SelectedIndex == 5)
            {
                this.pageSize = 6;
            }

            if (cbElementsPerPage.SelectedIndex == 6)
            {
                this.pageSize = 7;
            }


            int pageNumber = this.pageNumber;
            int pageSize = this.pageSize;
            string snippetsType = "php";
            this.snippetsType = snippetsType;


            PageReposne reponse = FetchSnippets(pageNumber, pageSize, snippetsType);

            //Console.WriteLine($"PageNumber: {reponse.PageNumber}");
            //Console.WriteLine($"PagesCount: {reponse.PagesCount}");
            //Console.WriteLine($"PageSize:   {reponse.PageSize}  ");
            //Console.WriteLine($"TotalCount: {reponse.TotalCount}");

            //Console.WriteLine();
            //Console.WriteLine("Snippets:");
            List<SnippetReponse> content = new List<SnippetReponse>();



            foreach (SnippetReponse snippet in reponse.Batches)
            {
                content.Add(new SnippetReponse() { Size = snippet.Size, Name = snippet.Name, Type = snippet.Type, ModificationDate = snippet.ModificationDate });
            }


            snippetsGrid.ItemsSource = content;

        }

        private void btnPython_Click(object sender, RoutedEventArgs e)
        {
            Python();
        }

        private void Python() {
            if (cbElementsPerPage.SelectedIndex == 0)
            {
                this.pageSize = 1;
            }

            if (cbElementsPerPage.SelectedIndex == 1)
            {
                this.pageSize = 2;
            }

            if (cbElementsPerPage.SelectedIndex == 2)
            {
                this.pageSize = 3;
            }

            if (cbElementsPerPage.SelectedIndex == 3)
            {
                this.pageSize = 4;
            }

            if (cbElementsPerPage.SelectedIndex == 4)
            {
                this.pageSize = 5;
            }

            if (cbElementsPerPage.SelectedIndex == 5)
            {
                this.pageSize = 6;
            }

            if (cbElementsPerPage.SelectedIndex == 6)
            {
                this.pageSize = 7;
            }


            int pageNumber = this.pageNumber;
            int pageSize = this.pageSize;
            string snippetsType = "python";
            this.snippetsType = snippetsType;


            PageReposne reponse = FetchSnippets(pageNumber, pageSize, snippetsType);

            //Console.WriteLine($"PageNumber: {reponse.PageNumber}");
            //Console.WriteLine($"PagesCount: {reponse.PagesCount}");
            //Console.WriteLine($"PageSize:   {reponse.PageSize}  ");
            //Console.WriteLine($"TotalCount: {reponse.TotalCount}");

            //Console.WriteLine();
            //Console.WriteLine("Snippets:");
            List<SnippetReponse> content = new List<SnippetReponse>();



            foreach (SnippetReponse snippet in reponse.Batches)
            {
                content.Add(new SnippetReponse() { Size = snippet.Size, Name = snippet.Name, Type = snippet.Type, ModificationDate = snippet.ModificationDate });
            }


            snippetsGrid.ItemsSource = content;

        }

        private void btnSQL_Click(object sender, RoutedEventArgs e)
        {
            SQL();
        }

        private void SQL() {
            if (cbElementsPerPage.SelectedIndex == 0)
            {
                this.pageSize = 1;
            }

            if (cbElementsPerPage.SelectedIndex == 1)
            {
                this.pageSize = 2;
            }

            if (cbElementsPerPage.SelectedIndex == 2)
            {
                this.pageSize = 3;
            }

            if (cbElementsPerPage.SelectedIndex == 3)
            {
                this.pageSize = 4;
            }

            if (cbElementsPerPage.SelectedIndex == 4)
            {
                this.pageSize = 5;
            }

            if (cbElementsPerPage.SelectedIndex == 5)
            {
                this.pageSize = 6;
            }

            if (cbElementsPerPage.SelectedIndex == 6)
            {
                this.pageSize = 7;
            }


            int pageNumber = this.pageNumber;
            int pageSize = this.pageSize;
            string snippetsType = "sql";
            this.snippetsType = snippetsType;


            PageReposne reponse = FetchSnippets(pageNumber, pageSize, snippetsType);

            //Console.WriteLine($"PageNumber: {reponse.PageNumber}");
            //Console.WriteLine($"PagesCount: {reponse.PagesCount}");
            //Console.WriteLine($"PageSize:   {reponse.PageSize}  ");
            //Console.WriteLine($"TotalCount: {reponse.TotalCount}");

            //Console.WriteLine();
            //Console.WriteLine("Snippets:");
            List<SnippetReponse> content = new List<SnippetReponse>();



            foreach (SnippetReponse snippet in reponse.Batches)
            {
                content.Add(new SnippetReponse() { Size = snippet.Size, Name = snippet.Name, Type = snippet.Type, ModificationDate = snippet.ModificationDate });
            }


            snippetsGrid.ItemsSource = content;

        }




        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            pageNumber = 1;
            btn1.Background = btn1.Background == Brushes.Cyan ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Cyan;
            btn2.Background = btn2.Background == Brushes.Azure ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Azure;
            btn3.Background = btn3.Background == Brushes.Azure ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Azure;
            btn4.Background = btn4.Background == Brushes.Azure ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Azure;
            btn5.Background = btn5.Background == Brushes.Azure ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Azure;
            btn6.Background = btn6.Background == Brushes.Azure ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Azure;
            btn7.Background = btn7.Background == Brushes.Azure ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Azure;


            if (snippetsType == "text")
            {
                Text();
            }
            if (snippetsType == "bash")
            {
                Bash();
            }
            if (snippetsType == "cpp")
            {
                Cpp();
            }
            if (snippetsType == "csharp")
            {
                Csharp();
            }
            if (snippetsType == "java")
            {
                Java();
            }
            if (snippetsType == "css")
            {
                CSS();
            }
            if (snippetsType == "javascript")
            {
                JS();
            }
            if (snippetsType == "php")
            {
                PHP();
            }
            if (snippetsType == "python")
            {
                Python();
            }
            if (snippetsType == "sql")
            {
                SQL();
            }
        }
        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            pageNumber = 2;
            btn1.Background = btn1.Background == Brushes.Azure ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Azure;
            btn2.Background = btn2.Background == Brushes.Cyan ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Cyan;
            btn3.Background = btn3.Background == Brushes.Azure ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Azure;
            btn4.Background = btn4.Background == Brushes.Azure ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Azure;
            btn5.Background = btn5.Background == Brushes.Azure ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Azure;
            btn6.Background = btn6.Background == Brushes.Azure ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Azure;
            btn7.Background = btn7.Background == Brushes.Azure ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Azure;
            if (snippetsType == "text")
            {
                Text();
            }
            if (snippetsType == "bash")
            {
                Bash();
            }
            if (snippetsType == "cpp")
            {
                Cpp();
            }
            if (snippetsType == "csharp")
            {
                Csharp();
            }
            if (snippetsType == "java")
            {
                Java();
            }
            if (snippetsType == "css")
            {
                CSS();
            }
            if (snippetsType == "javascript")
            {
                JS();
            }
            if (snippetsType == "php")
            {
                PHP();
            }
            if (snippetsType == "python")
            {
                Python();
            }
            if (snippetsType == "sql")
            {
                SQL();
            }
        }
        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            pageNumber = 3;
            btn1.Background = btn1.Background == Brushes.Azure ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Azure;
            btn2.Background = btn2.Background == Brushes.Azure ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Azure;
            btn3.Background = btn3.Background == Brushes.Cyan ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Cyan;
            btn4.Background = btn4.Background == Brushes.Azure ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Azure;
            btn5.Background = btn5.Background == Brushes.Azure ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Azure;
            btn6.Background = btn6.Background == Brushes.Azure ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Azure;
            btn7.Background = btn7.Background == Brushes.Azure ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Azure;
            if (snippetsType == "text")
            {
                Text();
            }
            if (snippetsType == "bash")
            {
                Bash();
            }
            if (snippetsType == "cpp")
            {
                Cpp();
            }
            if (snippetsType == "csharp")
            {
                Csharp();
            }
            if (snippetsType == "java")
            {
                Java();
            }
            if (snippetsType == "css")
            {
                CSS();
            }
            if (snippetsType == "javascript")
            {
                JS();
            }
            if (snippetsType == "php")
            {
                PHP();
            }
            if (snippetsType == "python")
            {
                Python();
            }
            if (snippetsType == "sql")
            {
                SQL();
            }
        }
        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            pageNumber = 4;
            btn1.Background = btn1.Background == Brushes.Azure ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Azure;
            btn2.Background = btn2.Background == Brushes.Azure ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Azure;
            btn3.Background = btn3.Background == Brushes.Azure ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Azure;
            btn4.Background = btn4.Background == Brushes.Cyan ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Cyan;
            btn5.Background = btn5.Background == Brushes.Azure ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Azure;
            btn6.Background = btn6.Background == Brushes.Azure ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Azure;
            btn7.Background = btn7.Background == Brushes.Azure ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Azure;
            if (snippetsType == "text")
            {
                Text();
            }
            if (snippetsType == "bash")
            {
                Bash();
            }
            if (snippetsType == "cpp")
            {
                Cpp();
            }
            if (snippetsType == "csharp")
            {
                Csharp();
            }
            if (snippetsType == "java")
            {
                Java();
            }
            if (snippetsType == "css")
            {
                CSS();
            }
            if (snippetsType == "javascript")
            {
                JS();
            }
            if (snippetsType == "php")
            {
                PHP();
            }
            if (snippetsType == "python")
            {
                Python();
            }
            if (snippetsType == "sql")
            {
                SQL();
            }
        }
        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            pageNumber = 5;
            btn1.Background = btn1.Background == Brushes.Azure ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Azure;
            btn2.Background = btn2.Background == Brushes.Azure ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Azure;
            btn3.Background = btn3.Background == Brushes.Azure ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Azure;
            btn4.Background = btn4.Background == Brushes.Azure ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Azure;
            btn5.Background = btn5.Background == Brushes.Cyan ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Cyan;
            btn6.Background = btn6.Background == Brushes.Azure ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Azure;
            btn7.Background = btn7.Background == Brushes.Azure ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Azure;
            if (snippetsType == "text")
            {
                Text();
            }
            if (snippetsType == "bash")
            {
                Bash();
            }
            if (snippetsType == "cpp")
            {
                Cpp();
            }
            if (snippetsType == "csharp")
            {
                Csharp();
            }
            if (snippetsType == "java")
            {
                Java();
            }
            if (snippetsType == "css")
            {
                CSS();
            }
            if (snippetsType == "javascript")
            {
                JS();
            }
            if (snippetsType == "php")
            {
                PHP();
            }
            if (snippetsType == "python")
            {
                Python();
            }
            if (snippetsType == "sql")
            {
                SQL();
            }
        }
        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            pageNumber = 6;
            btn1.Background = btn1.Background == Brushes.Azure ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Azure;
            btn2.Background = btn2.Background == Brushes.Azure ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Azure;
            btn3.Background = btn3.Background == Brushes.Azure ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Azure;
            btn4.Background = btn4.Background == Brushes.Azure ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Azure;
            btn5.Background = btn5.Background == Brushes.Azure ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Azure;
            btn6.Background = btn6.Background == Brushes.Cyan ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Cyan;
            btn7.Background = btn7.Background == Brushes.Azure ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Azure;
            if (snippetsType == "text")
            {
                Text();
            }
            if (snippetsType == "bash")
            {
                Bash();
            }
            if (snippetsType == "cpp")
            {
                Cpp();
            }
            if (snippetsType == "csharp")
            {
                Csharp();
            }
            if (snippetsType == "java")
            {
                Java();
            }
            if (snippetsType == "css")
            {
                CSS();
            }
            if (snippetsType == "javascript")
            {
                JS();
            }
            if (snippetsType == "php")
            {
                PHP();
            }
            if (snippetsType == "python")
            {
                Python();
            }
            if (snippetsType == "sql")
            {
                SQL();
            }
        }
        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            pageNumber = 7;
            btn1.Background = btn1.Background == Brushes.Azure ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Azure;
            btn2.Background = btn2.Background == Brushes.Azure ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Azure;
            btn3.Background = btn3.Background == Brushes.Azure ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Azure;
            btn4.Background = btn4.Background == Brushes.Azure ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Azure;
            btn5.Background = btn5.Background == Brushes.Azure ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Azure;
            btn6.Background = btn6.Background == Brushes.Azure ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Azure;
            btn7.Background = btn7.Background == Brushes.Cyan ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#F0FFFF")) : Brushes.Cyan;
            if (snippetsType == "text")
            {
                Text();
            }
            if (snippetsType == "bash")
            {
                Bash();
            }
            if (snippetsType == "cpp")
            {
                Cpp();
            }
            if (snippetsType == "csharp")
            {
                Csharp();
            }
            if (snippetsType == "java")
            {
                Java();
            }
            if (snippetsType == "css")
            {
                CSS();
            }
            if (snippetsType == "javascript")
            {
                JS();
            }
            if (snippetsType == "php")
            {
                PHP();
            }
            if (snippetsType == "python")
            {
                Python();
            }
            if (snippetsType == "sql")
            {
                SQL();
            }
        }

        private void cbElementsPerPage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbElementsPerPage.SelectedIndex == 0)
            {
                this.pageSize = 1;
                if (snippetsType == "text")
                {
                    Text();
                }
                if (snippetsType == "bash")
                {
                    Bash();
                }
                if (snippetsType == "cpp")
                {
                    Cpp();
                }
                if (snippetsType == "csharp")
                {
                    Csharp();
                }
                if (snippetsType == "java")
                {
                    Java();
                }
                if (snippetsType == "css")
                {
                    CSS();
                }
                if (snippetsType == "javascript")
                {
                    JS();
                }
                if (snippetsType == "php")
                {
                    PHP();
                }
                if (snippetsType == "python")
                {
                    Python();
                }
                if (snippetsType == "sql")
                {
                    SQL();
                }
            }

            if (cbElementsPerPage.SelectedIndex == 1)
            {
                this.pageSize = 2;
                if (snippetsType == "text")
                {
                    Text();
                }
                if (snippetsType == "bash")
                {
                    Bash();
                }
                if (snippetsType == "cpp")
                {
                    Cpp();
                }
                if (snippetsType == "csharp")
                {
                    Csharp();
                }
                if (snippetsType == "java")
                {
                    Java();
                }
                if (snippetsType == "css")
                {
                    CSS();
                }
                if (snippetsType == "javascript")
                {
                    JS();
                }
                if (snippetsType == "php")
                {
                    PHP();
                }
                if (snippetsType == "python")
                {
                    Python();
                }
                if (snippetsType == "sql")
                {
                    SQL();
                }
            }

            if (cbElementsPerPage.SelectedIndex == 2)
            {
                this.pageSize = 3;
                if (snippetsType == "text")
                {
                    Text();
                }
                if (snippetsType == "bash")
                {
                    Bash();
                }
                if (snippetsType == "cpp")
                {
                    Cpp();
                }
                if (snippetsType == "csharp")
                {
                    Csharp();
                }
                if (snippetsType == "java")
                {
                    Java();
                }
                if (snippetsType == "css")
                {
                    CSS();
                }
                if (snippetsType == "javascript")
                {
                    JS();
                }
                if (snippetsType == "php")
                {
                    PHP();
                }
                if (snippetsType == "python")
                {
                    Python();
                }
                if (snippetsType == "sql")
                {
                    SQL();
                }
            }

            if (cbElementsPerPage.SelectedIndex == 3)
            {
                this.pageSize = 4;
                if (snippetsType == "text")
                {
                    Text();
                }
                if (snippetsType == "bash")
                {
                    Bash();
                }
                if (snippetsType == "cpp")
                {
                    Cpp();
                }
                if (snippetsType == "csharp")
                {
                    Csharp();
                }
                if (snippetsType == "java")
                {
                    Java();
                }
                if (snippetsType == "css")
                {
                    CSS();
                }
                if (snippetsType == "javascript")
                {
                    JS();
                }
                if (snippetsType == "php")
                {
                    PHP();
                }
                if (snippetsType == "python")
                {
                    Python();
                }
                if (snippetsType == "sql")
                {
                    SQL();
                }
            }

            if (cbElementsPerPage.SelectedIndex == 4)
            {
                this.pageSize = 5;
                if (snippetsType == "text")
                {
                    Text();
                }
                if (snippetsType == "bash")
                {
                    Bash();
                }
                if (snippetsType == "cpp")
                {
                    Cpp();
                }
                if (snippetsType == "csharp")
                {
                    Csharp();
                }
                if (snippetsType == "java")
                {
                    Java();
                }
                if (snippetsType == "css")
                {
                    CSS();
                }
                if (snippetsType == "javascript")
                {
                    JS();
                }
                if (snippetsType == "php")
                {
                    PHP();
                }
                if (snippetsType == "python")
                {
                    Python();
                }
                if (snippetsType == "sql")
                {
                    SQL();
                }
            }

            if (cbElementsPerPage.SelectedIndex == 5)
            {
                this.pageSize = 6;
                if (snippetsType == "text")
                {
                    Text();
                }
                if (snippetsType == "bash")
                {
                    Bash();
                }
                if (snippetsType == "cpp")
                {
                    Cpp();
                }
                if (snippetsType == "csharp")
                {
                    Csharp();
                }
                if (snippetsType == "java")
                {
                    Java();
                }
                if (snippetsType == "css")
                {
                    CSS();
                }
                if (snippetsType == "javascript")
                {
                    JS();
                }
                if (snippetsType == "php")
                {
                    PHP();
                }
                if (snippetsType == "python")
                {
                    Python();
                }
                if (snippetsType == "sql")
                {
                    SQL();
                }
            }

            if (cbElementsPerPage.SelectedIndex == 6)
            {
                this.pageSize = 7;
                if (snippetsType == "text")
                {
                    Text();
                }
                if (snippetsType == "bash")
                {
                    Bash();
                }
                if (snippetsType == "cpp")
                {
                    Cpp();
                }
                if (snippetsType == "csharp")
                {
                    Csharp();
                }
                if (snippetsType == "java")
                {
                    Java();
                }
                if (snippetsType == "css")
                {
                    CSS();
                }
                if (snippetsType == "javascript")
                {
                    JS();
                }
                if (snippetsType == "php")
                {
                    PHP();
                }
                if (snippetsType == "python")
                {
                    Python();
                }
                if (snippetsType == "sql")
                {
                    SQL();
                }
            }
        }
    }



    public class PageReposne
    {
        [JsonPropertyName("pageNumber")]
        public int PageNumber { get; set; }

        [JsonPropertyName("pagesCount")]
        public int PagesCount { get; set; }

        [JsonPropertyName("pageSize")]
        public int PageSize { get; set; }

        [JsonPropertyName("totalCount")]
        public int TotalCount { get; set; }

        [JsonPropertyName("batches")]
        public List<SnippetReponse> Batches { get; set; }
    }

    public class SnippetReponse
    {
        [JsonPropertyName("size")]
        public int Size { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("creationTime")]
        public DateTime? ModificationDate { get; set; }

        //[JsonPropertyName("creationTime")]
        //public DateTime? CreationTime { get; set; }

        //[JsonPropertyName("updateTime")]
        //public DateTime? UpdateTime { get; set; }
    }



}

