using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Win32;

namespace WPF2
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool textChanged = false;
        bool loading = false;
        IsolatedStorageFile saveFile = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void text_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(loading)
            {
                loading = false;
                return;
            }

            if(!textChanged)
            {
                filename.Text += "*";
                saveButton.IsEnabled = true;
                textChanged = true;
            }
        }

        private async void openButton_Click(object sender, RoutedEventArgs e)
        {
            if(textChanged)
            {
                MessageBoxResult result = MessageBox.Show("Plik został zmieniony. Czy na pewno chcesz wczytać nowy plik?", "Ostrzerzenie", MessageBoxButton.OKCancel, MessageBoxImage.Warning);

                if (result != MessageBoxResult.OK) return;
            }

            OpenFile();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFile();
        }




        private async void OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Pliki(*.txt, *.xml, *.xaml)|*.txt|*.xml|*.xaml";
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Otwórz plik";

            bool? result = openFileDialog.ShowDialog();
            if (result == true)
            {
                string content = fileReader(openFileDialog.OpenFile());

                loading = true;

                text.Text = content;
                textChanged = false;
                filename.Text = openFileDialog.SafeFileName;
            }
        }

        private async void SaveFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Pliki(*.txt, *.xml, *.xaml)|*.txt|*.xml|*.xaml";
            saveFileDialog.Title = "Zapisz plik";

            bool? result = saveFileDialog.ShowDialog();
            if (result == true)
            {
                fileWriter(saveFileDialog.FileName, text.Text);

                textChanged = false;
                filename.Text = saveFileDialog.SafeFileName;
            }

        }


        private String fileReader(Stream stream)
        {
            String result = "";
            using(StreamReader reader = new StreamReader(stream))
            {
                while (reader.Peek() != -1)
                {
                    result += reader.ReadLine() + Environment.NewLine;
                }
            }

            return result;
        }
        private void fileWriter(String path, String content)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.Write(content);
            }
        }
    }
}
