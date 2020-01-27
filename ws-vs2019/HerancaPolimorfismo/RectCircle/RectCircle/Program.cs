﻿using System;
using RectCircle.Entities;
using RectCircle.Entities.Enums;
using System.Collections.Generic;
using System.Globalization;

namespace RectCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Shape #{i+1} data: ");
                
                Console.Write("Rectangle or circle? (r / c): ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Color (Black / Blue / Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (ch == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());

                    Console.Write("Width: ");
                    double height = double.Parse(Console.ReadLine());

                    list.Add(new Rectangle(width, height, color));
                    Console.WriteLine("====================================");
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    list.Add(new Circle(radius, color));
                    Console.WriteLine("====================================");

                }
                }

                Console.WriteLine();
            Console.WriteLine("*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=");
            Console.WriteLine("SHAPE AREAS:");

                foreach(Shape shape in list)
                {
                    Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
                }

            }
        }
    }

