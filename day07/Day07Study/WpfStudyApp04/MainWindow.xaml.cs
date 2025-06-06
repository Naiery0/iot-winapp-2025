﻿using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfStudyApp04;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public ObservableCollection<string> fruitItems { get; set; }
    public Dictionary<string, string> countryItems { get; set; }
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
        fruitItems = new ObservableCollection<string>
        {
            "용과",
            "망고스틴",
            "애플망고",
            "자몽",
            "두리안"
        };

        countryItems = new Dictionary<string, string>
        {
            {"KR", "대한민국"},
            {"US", "미국"},
            {"JP", "일본"},
            {"CN", "중국"},
            {"IN", "인도"},
            {"PH", "필리핀"},
        };

        LoadDicisionFromDatabase();

        CboCollection.ItemsSource = fruitItems;
        CboCountries.ItemsSource = countryItems;
        // WPF xaml의 전체의 데이터컨텍스트에 현재값 바인딩 
        // 
        //this.DataContext = this;
        CboFruits.DataContext = this;
    }

    private void LoadDicisionFromDatabase()
    {
        // DB 연결 문자열 (DB 연결 정보)
        string connectionString = "Server=localhost;Database=bookrentalshop;Uid=root;Pwd=12345;Charset=utf8;";
        string query = "SELECT division, names FROM divtbl";

        List<KeyValuePair<string, string>> divisions = new List<KeyValuePair<string, string>>();

        // DB연결, 처리, 할당
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var division = reader.GetString("division");
                    var names = reader.GetString("names");

                    divisions.Add(new KeyValuePair<string, string>(division, names));
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"DB연결 실패! : {ex.Message}", "오류", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }// conn.Close()는 자동으로 실행
        CboDivision.ItemsSource = divisions;
    }

    private void CboCountries_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        string value = ((KeyValuePair<string, string>)CboCountries.SelectedItem).Value;
        MessageBox.Show(value, "선택한 국가", MessageBoxButton.OK, MessageBoxImage.Information);
    }
}