using PizzaStore.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var haNoipizzaStore = new HaNoiPizzaStore();
            haNoipizzaStore.OrderPizza("cheese");
            var khanhHoapizzaStore = new KhanhHoaPizzaStore();
            khanhHoapizzaStore.OrderPizza("cheese");
            var saiGonpizzaStore = new SaiGonPizzaStore();
            saiGonpizzaStore.OrderPizza("cheese");


            //int firstNumber = 0, SecondNumber = 1, nextNumber, numberOfElements;
            //Console.Write("Nhap vao so phan tu day Fibonacci ban muon in: ");
            //numberOfElements = int.Parse(Console.ReadLine());


            //if (numberOfElements < 2)
            //{
            //    Console.Write("Vui long nhap so phan tu lon hon 2: ");
            //}
            //else
            //{
            //    //In so thu nhat va so thu 2
            //    Console.Write("Day so Fibonacci la: " + firstNumber + " " + SecondNumber);
            //    for (int i = 2; i < numberOfElements; i++)
            //    {
            //        //Ap dung thuat toan day Fibonacci
            //        nextNumber = firstNumber + SecondNumber;
            //        Console.Write(" " + nextNumber);
            //        firstNumber = SecondNumber; 
            //        SecondNumber = nextNumber;
            //    }
            //}

            //int number = 0;
            ////Su dung vong lap for de lap den so ma nguoi dung nhap vao
            //Console.Write("Day Fibonacci: ");
            //for (int i = 0; i < numberOfElements; i++)
            //{
            //    //gọi hàm InFibonacci() với tham số truyền vào là number
            //    Console.Write(InFibonacci(number) + " ");
            //    number++;
            //}

            //// In so Infibonacci thu n
            //int a = InFibonacci(numberOfElements - 1);
            //Console.WriteLine(a);



            Console.ReadKey();
        }


        //static int InFibonacci(int num)
        //{
        //    if (num == 0)
        //        return 0;
        //    else if (num == 1)
        //        return 1;
        //    else
        //        return (InFibonacci(num - 1) + InFibonacci(num - 2));
        //}
    }
}
