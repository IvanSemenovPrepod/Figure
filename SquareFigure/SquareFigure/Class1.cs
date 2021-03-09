using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFigure
{
    public class Figure
    {
		public double p { get; set; }
		public double s { get; set; }
		/// <summary>
		/// площадь круга
		/// </summary>
		/// <param name="r">радиус окружности</param>
		public Figure(double r)
		{
			p = Math.PI * r * 2;
			s = Math.PI * r * r;
		}
		/// <summary>
		/// Площадь прямоугольника
		/// </summary>
		/// <param name="a">сторона а</param>
		/// <param name="b">сторона б</param>
		public Figure(double a, double b)
		{
			p = 2 * (a + b);
			s = a * b;
		}
	    //Координаты x y указываем через пробел, пары координат разделяем запятой, например 0 0,0 4,3 0
		/// <summary>
		/// площадь фигуры
		/// </summary>
		/// <param name="r">координаты точек</param>
	    
		public Figure(string str)
		{
			string[] strOfPoints = str.Split(',');
			int size = strOfPoints.Length;
			double[][] points = new double[size + 1][];
			for (int i = 0; i < size; i++)
			{
				points[i] = new double[2];
				string[] pt = strOfPoints[i].Split(' ');
				points[i][0] = Convert.ToDouble(pt[0]);
				points[i][1] = Convert.ToDouble(pt[1]);
			}
			points[size] = new double[2];
			points[size][0] = points[0][0];
			points[size][1] = points[0][1];

			double sum = 0;

			for (int i = 0; i < size; i++)
			{
				sum += (points[i][1] * points[i + 1][0]) - (points[i][0] * points[i + 1][1]);
			}
			s = sum / 2;
		}
	}
}
