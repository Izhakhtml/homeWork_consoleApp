using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkConsoleApp
{
    //////////////////////////////////// 1 try by parameter
    //class Bank <T> 
    //{
    //    public string color;
    //    public int heigth;
    //    public T value;
    //public Bank(string color,int heigth,T value)
    //{
    //    this.color = color;
    //    this.heigth = heigth;
    //    this.value = value;
    //}
    //public int CompareTo(object obj)
    //{
    //     Bank<T> bank = (Bank<T>)obj;
    //     if (this.value == bank.value)
    //     {
    //         return -1;
    //     }
    //}
    //}

    class Bank : IComparable
    {
        public string color;
        public double heigth;
        public int value;
        public Bank(string color,double heigth, int value)
        {
            this.color = color;
            this.heigth = heigth;
            this.value = value;
        }
        public Bank() { }
        public int CompareTo(object obj)
        {
            Bank bank = (Bank)obj;
            if (this.value < bank.value)return -1;
            if (this.value > bank.value) return 1;
            return 0;
        }
        public void Print()
        {
            Console.WriteLine($"color:{this.color} heigth:{this.heigth} value:{this.value}");
        }
    }
}
