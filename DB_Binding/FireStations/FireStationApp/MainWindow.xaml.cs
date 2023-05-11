using MahApps.Metro.Controls;
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

namespace FireStationApp
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAccident_Click(object sender, RoutedEventArgs e)
        {
            var firestationlist = new FireStationList();
            firestationlist.Owner = this; // TrailerWindow의 부모는 MainWindow
            firestationlist.WindowStartupLocation = WindowStartupLocation.CenterOwner; // 부모창의 정중앙에 위치
            // trailerWinow.Show(); // 모달리스 => 자식창 연 상태에서 부모창을 건들 수 있어서 사용X
            firestationlist.ShowDialog();  // 모달창
        }
    }
}
