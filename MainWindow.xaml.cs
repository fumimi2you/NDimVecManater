using Microsoft.Win32;
using System.Windows;

namespace NDimVecManater
{

    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        VecMgr VM;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == false)
            {
                return;
            }

            VM = new VecMgr();

            VM.ReadData(dialog.FileName);

            VM.RefineWords();

            VM.CalcMinMaxVector();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "TXTファイル(*.txt)|*.txt";
            if (dialog.ShowDialog() == false)
            {
                return;
            }

            VM.SaveData(dialog.FileName);
        }

        private void BtnSaveMinMax_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "TXTファイル(*.txt)|*.txt";
            if (dialog.ShowDialog() == false)
            {
                return;
            }

            VM.SaveMinMax(dialog.FileName);
        }
    }
}
