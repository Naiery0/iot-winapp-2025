using MySql.Data.MySqlClient;
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

namespace Day08Study;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public List<KeyValuePair<string, string>> divisionItems { get; set; }

    public MainWindow()
    {
        InitializeComponent();
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
        LoadDivisionFromDatabase();
        this.DataContext = this;
    }

    private void LoadDivisionFromDatabase()
    {
        divisionItems = new List<KeyValuePair<string, string>>(); 
        string connectionString = "Server=localhost;" +
                                  "Database=bookrentalshop;" +
                                  "Uid=root;" +
                                  "Pwd=12345;" +
                                  "Charset=utf8;";
        string query = "SELECT division, names FROM divtbl";

        using(MySqlConnection conn = new MySqlConnection(connectionString))
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

                    divisionItems.Add(new KeyValuePair<string, string>(division, names));
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"DB연결 실패 : {ex.Message}", "오류", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }
}