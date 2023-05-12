using FireStationApp.Logics;
using MahApps.Metro.Controls;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.IO;
using System.Windows;


namespace FireStationApp
{
    /// <summary>
    /// FireStaionList.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class FireStationList : MetroWindow
    {
        public FireStationList()
        {
            InitializeComponent();
        }


        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            #region <CVS 파일 읽어와서 DB에 저장>

            string filepath = "C:/Source/MM5JO/DB_Binding/DataBase/FireStationList.csv"; // 불러올 CVS 파일 경로

            using (StreamReader reader = new StreamReader(filepath))
            {
                reader.ReadLine();
                /*
                 StreamReader의 ReadLine()은 파일의 한 줄을 읽어오는 메서드임.
                 사용하려는 파일의 첫번째 줄은 속성값이기때문에 ReadLine() 한 번 호출해서 첫번째 줄 저장 안하고 읽기만 하는 것
                 */

                for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
                // 두번째 줄 부터 읽어올거라서 변수 line에 reder.ReadLine(); 대입
                // 반복을 진행하면서 line에 reader.ReadLine()을 대입하면 다음 줄을 읽어옴
                // 마지막 조건 line = reader.ReadLine() 없으면 처음 읽어오는 값(두번째 줄)로 무한루프걸림!!!!!
                {
                    string[] values = line.Split(',');  // values 배열에 CSV 파일의 한 줄 저장

                    /* 
                    CVS 파일에 있는 내용만 확인할때는 foreach로 출력
                    foreach (string value in values)
                    {
                        Debug.WriteLine(value);
                    }
                    */

                    for (int i = 0; i < values.Length; i++)
                    {
                        Debug.WriteLine($"valuse[{i}] : {values[i]}");
                    }
                    /* DB 저장하기 위해서 배열의 각 인덱스에 어느 정보값이 들어있는지 확인하기 위해 for문 사용
                     valuse[0] : 항만
                     valuse[1] : 청학119안전센터
                     valuse[2] : 부산광역시 영도구 태종로 274(청학동)
                     valuse[3] : 129.0565274
                     valuse[4] : 35.0981886
                     valuse[5] : 051-760-6941
                     */

                    using (MySqlConnection conn = new MySqlConnection(Commons.MyConnString))
                    {
                        if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
                        
                        var query = @"INSERT INTO firestationtb
			                                        (District,
			                                        StationName,
			                                        Address,
			                                        Longitude,
			                                        Latitude,
			                                        Tel)
                                            VALUES
			                                        (@District,
			                                        @StationName,
			                                        @Address,
			                                        @Longitude,
			                                        @Latitude,
			                                        @Tel)";
                        
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@District", values[0]);
                        cmd.Parameters.AddWithValue("@StationName", values[1]);
                        cmd.Parameters.AddWithValue("@Address", values[2]);
                        cmd.Parameters.AddWithValue("@Longitude", values[3]);
                        cmd.Parameters.AddWithValue("@Latitude", values[4]);
                        cmd.Parameters.AddWithValue("@Tel", values[5]);
                        cmd.ExecuteNonQuery();
                    }  
                }
            }
            #endregion
        }
    }
}
