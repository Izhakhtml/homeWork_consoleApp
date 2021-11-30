using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkConsoleApp
{
    class Square <T>
    {
        public T part1;
        public T part2;
        public T part3;
        public T part4;
        public string color;
        //public T space;
        public Square(T part1, T part2, T part3, T part4, string color)
        {
            this.part1 = part1;
            this.part2 = part2;
            this.part3 = part3;
            this.part4 = part4;
            this.color = color;
        }
       
    }
}
