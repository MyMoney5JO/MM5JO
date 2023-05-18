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

namespace Login01
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen; // MainWindow 화면 정중앙에 띄우기
        }

        // 메인 윈도우 실행시 LoginWindow 먼저 불러오도록 하는 로드 이벤트 핸들러
        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var subWindow = new LoginWindow();
            subWindow.Owner = this; // LoginWindow의 부모는 MainWindow
            subWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner; // MainWindow의 정중앙에 위치
            subWindow.ShowDialog();  // 모달창
        }
    }
}
