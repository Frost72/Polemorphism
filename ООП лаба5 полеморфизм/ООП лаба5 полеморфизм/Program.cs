using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_лаба5_полеморфизм
{
    public abstract class Figure
    {
        public abstract double Ploshad();



        public abstract double Perimetr();

        public abstract void Print();
      
        
    }
    public class Circule : Figure
    {
        public double Radius { get; set; }
        public Circule(double radius)
        {
            Radius = radius;
        }
        public override double Ploshad()
        {
            return Math.PI * Radius * Radius;
        }
        public override double Perimetr()
        {
            return 2 * Math.PI * Radius;
        }
        public override void Print() 
        {
            
            Console.WriteLine("R=" + Radius + ",S=" + Ploshad() + ",P=" + Perimetr());
        }
    }
    public class Pramygolnic : Figure
    {
        public double Lenght { get; set; }
        public double Width { get; set; }
        public Pramygolnic(double lenght, double width)
        {
            Lenght = lenght;
            Width = width;
        }

        public override double Ploshad() 
        {
            return Lenght * Width;
        }
        public override double Perimetr()
        {
            return 2*(Lenght+Width);
        }
        public override void Print()
        {
            
            Console.WriteLine("L="+ Lenght+",W="+Width+",S="+Ploshad()+",P="+Perimetr());
        }
    }
    public class Trapecia : Figure
    {
        public double Osnovanie1 { get; set; }
        public double Osnovanie2 { get; set; }
        public double Rebro1 { get; set; }
        public double Rebro2 { get; set;}
        public double Hight { get; set; }
        public Trapecia(double osnovanie1, double osnovanie2, double rebro1, double rebro2, double hight)
        {
            Osnovanie1 = osnovanie1;
            Osnovanie2 = osnovanie2;
            Rebro1 = rebro1;
            Rebro2 = rebro2;
            Hight = hight;
        }

        public override double Ploshad()
        {
            return (Osnovanie1 + Osnovanie2)*Hight/2;
        }
        public override double Perimetr()
        {
            return Osnovanie1+Osnovanie2+Rebro1+Rebro2;
        }
        public override void Print()
        { 
            
            Console.WriteLine("O1=" + Osnovanie1 + ",O2=" + Osnovanie2 + ",Re1=" + Rebro1 + ",Re2=" + Rebro2 + ",H=" + Hight + ",S=" + Ploshad() + ",P=" + Perimetr());
           
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Collections.Generic.List<Figure> f= new System.Collections.Generic.List<Figure>();
            f.Add(new Circule(2));
            f.Add(new Pramygolnic(2, 3));
            f.Add(new Trapecia(2, 3, 2, 4, 3));
            foreach(Figure f2 in f)
            {
                f2.Print();
            }
            
            Console.ReadKey();
        }
    }
}
