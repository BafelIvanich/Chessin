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

namespace Chessin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Board board = new Board();
            board.SetupBoard();
            GameGrid.Rows = board.width;
            GameGrid.Rows = board.height;

            for (int r = 0; r < board.width; r++)
            {
                for (int c = 0; c < board.height; c++)
                {
                    Label label = new Label();
                    label.Content = board.Grid[r, c].ToString();
                    GameGrid.Children.Add(label);
                }
            }
        }
    }
}