﻿using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Login01.Logics
{
    public class Commons
    {
        // MySQL 연결 문자열 담을 변수
        public static readonly string MyConnString = "Server=210.119.12.82;" +
                                                     "Port=3306;" +
                                                     "Database=chaeyeontunnel;" +
                                                     "Uid=root;" +
                                                     "Pwd=12345;";

        // 메트로 다이얼로그창을 위한 정적 메서드
        public static async Task<MessageDialogResult> ShowMessageAsync(string title, string message, MessageDialogStyle style = MessageDialogStyle.Affirmative)
        {
            return await ((MetroWindow)Application.Current.MainWindow).ShowMessageAsync(title, message, style, null);
        }
    }
}
