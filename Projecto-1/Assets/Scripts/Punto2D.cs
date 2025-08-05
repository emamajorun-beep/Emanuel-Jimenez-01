using UnityEngine;
using System;

namespace packages2d
{
[Serializable]
public class punto2D 
    {
        private double X;
        private double Y;
             
        public punto2D()
        {
        } 
        public punto2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X1 { get => X; set => X = value; }
        public double Y1 { get => Y; set => Y = value; }
    }
}