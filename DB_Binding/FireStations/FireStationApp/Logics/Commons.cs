using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireStationApp.Logics
{
    public class Commons
    {
        // 연결 문자열 담을 변수

        /*  5조 DB 연결시 해당 내용으로 바꾸기
        public static readonly string MyConnString = "Server=210.119.12.82;" +
                                                     "Port=3306;" +
                                                     "Database=chaeyeontunnel;" +
                                                     "Uid=root;" +
                                                     "Pwd=12345;";
        */

        public static readonly string MyConnString = "Server=localhost;" +
                                                     "Port=3306;" +
                                                     "Database=chaeyeontunnel;" +
                                                     "Uid=root;" +
                                                     "Pwd=12345;";
    }
}
