﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_4
{
    internal interface IPerson
    {
        //phương thức insert
        void Insert(object obj);
        //phương thức xóa
        void Delete(object obj);
        //phương thức sửa
        void Update(object obj);
        //phương thức hiển thị
        void Display(object obj);
    }
}
