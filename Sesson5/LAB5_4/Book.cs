﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_4
{
    //cài đặt lớp sách
    internal class Book
    {
        //khai báo trường
        private string name;
        //khai báo mảng chương
        private Chapter[] chapters;
        //constructor không tham số
        public Book()
        {

        }
        //constructor cos tham số, là số chương
        public Book(string name, int n)
        {
            this.name = name;
            chapters = new Chapter[n];
        }
        //định nghĩa các thuộc tính
        public string Name
        {
            get { return name; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");
                name = value;
            }
        }
        //indexer thứ, nhất có một tham số kiểu int
        public Chapter this[int index]
        {
            get
            {
                if (index < 0 || index > chapters.Length - 1)
                    return null;
                return chapters[index];
            }
            set
            {
                if (index<0 || index > chapters.Length - 1)
                    throw new ArgumentOutOfRangeException("index");
                chapters[index] = value;
            }
        }
        //indexer thứ 2 có một tham số kiểu string overload indexer
        public Chapter this[string name]
        {
            get
            {
                foreach (Chapter ch in chapters)
                {
                    if(ch.Name == name)
                    {
                        return ch;
                    }
                }
                return null;
            }
        }
    }
}
