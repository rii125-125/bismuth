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
using ICSharpCode.AvalonEdit.Highlighting;

namespace bismuthIDE;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        CodeEditor.SyntaxHighlighting = HighlightingManager.Instance.GetDefinition("C#");
    }

    private void RunButton_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Click button!");
    }
}