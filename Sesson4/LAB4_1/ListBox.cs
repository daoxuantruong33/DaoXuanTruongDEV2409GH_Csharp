﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_1
{
    internal class ListBox:Window
    {
        //khai báo trường mới
        private string listBoxContents;
        //phương thức khởi tạo
        public ListBox(int top, int left, string contents)
        : base(top,left) //gọi constructor lớp cơ sở
        {
            listBoxContents = contents;
        }
        //ghi đè phương thức DrawWindow
        public override void DrawWindow()
        {
            base.DrawWindow(); //gọi phương thức lớp cơ sở
            Console.WriteLine("Writing string to the listbox: {0}", listBoxContents);
        }
    }
}
