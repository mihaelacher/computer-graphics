using System;
using System.Drawing;
using System.Windows;
using System.Collections.Generic;
using System.Drawing.Drawing2D;

namespace Draw
{
	/// <summary>
	/// Класът, който ще бъде използван при управляване на диалога.
	/// </summary>
	public class DialogProcessor : DisplayProcessor
	{
		#region Constructor
		
		public DialogProcessor()
		{
		}
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Избран елемент.
		/// </summary>
		private List<Shape> selection = new List<Shape>();
		public List<Shape> Selection {
			get { return selection; }
			set { selection = value; }
		}

		private List<GroupShape> groupShapes = new List<GroupShape>();
		public virtual List<GroupShape> GroupShapes
        {
			get { return groupShapes; }
			set { groupShapes = value; }
        }
		
		/// <summary>
		/// Дали в момента диалога е в състояние на "влачене" на избрания елемент.
		/// </summary>
		private bool isDragging;
		public bool IsDragging {
			get { return isDragging; } 
			set { isDragging = value; }
		}
		
		/// <summary>
		/// Последна позиция на мишката при "влачене".
		/// Използва се за определяне на вектора на транслация.
		/// </summary>
		private PointF lastLocation;
		public PointF LastLocation {
			get { return lastLocation; }
			set { lastLocation = value; }
		}
		
		#endregion
		
		/// <summary>
		/// Добавя примитив - правоъгълник на произволно място върху клиентската област.
		/// </summary>
		public void AddRandomRectangle()
		{
			Random rnd = new Random();
			int x = rnd.Next(100,1000);
			int y = rnd.Next(100,600);
			
			RectangleShape rect = new RectangleShape(new Rectangle(x,y,100,200));
			rect.FillColor = Color.White;

			ShapeList.Add(rect);
		}
		
		/// <summary>
		/// Добавя примитив - квадрат на произволно място върху клиентската област.
		/// </summary>
		public void AddRandomSquare()
		{
			Random rnd = new Random();
			int x = rnd.Next(100,1000);
			int y = rnd.Next(100,600);
			
			RectangleShape rect = new RectangleShape(new Rectangle(x,y,100,100));
			rect.FillColor = Color.White;

			ShapeList.Add(rect);
		}

		/// <summary>
		/// Добавя примитив - елипса на произволно място върху клиентската област.
		/// </summary>
		public void AddRandomEllipse()
		{
			Random rnd = new Random();
			int x = rnd.Next(100, 1000);
			int y = rnd.Next(100, 600);

			EllipseShape ellipse = new EllipseShape();
			ellipse.Location = new PointF(x, y);
			ellipse.Width = 200;
			ellipse.Height = 100;
			ellipse.FillColor = Color.White;

			ShapeList.Add(ellipse);
		}

		/// <summary>
		/// Добавя примитив - точка на произволно място върху клиентската област.
		/// </summary>
		public void AddRandomCircle()
		{
			Random rnd = new Random();
			int x = rnd.Next(100, 1000);
			int y = rnd.Next(100, 600);

			EllipseShape circle = new EllipseShape();
			circle.Location = new PointF(x, y);
			circle.Width = 100;
			circle.Height = 100;
			circle.FillColor = Color.White;

			ShapeList.Add(circle);
		}

		/// <summary>
		/// Проверява дали дадена точка е в елемента.
		/// Обхожда в ред обратен на визуализацията с цел намиране на
		/// "най-горния" елемент т.е. този който виждаме под мишката.
		/// </summary>
		/// <param name="point">Указана точка</param>
		/// <returns>Елемента на изображението, на който принадлежи дадената точка.</returns>
		public Shape ContainsPoint(PointF point)
		{
			for(int i = ShapeList.Count - 1; i >= 0; i--){
				if (ShapeList[i].Contains(point)){
					Shape shape = ShapeList[i];
					shape.FillColor = Color.Red;
						
					return ShapeList[i];
				}	
			}
			return null;
		}

		/// <summary>
		/// Транслация на избраният елемент на вектор определен от <paramref name="p>p</paramref>
		/// </summary>
		/// <param name="p">Вектор на транслация.</param>
		public void TranslateTo(PointF p)
		{
			foreach (Shape item in selection) {

				item.Location = new PointF(item.Location.X + p.X - lastLocation.X, item.Location.Y + p.Y - lastLocation.Y);
			}
			
		}

		public void Rotate(PointF p)
        { 
			foreach (Shape item in selection)
            { 
				float X = item.Location.X + (item.Width / 2);
				float Y = item.Location.Y + (item.Height / 2);
				float xDiff =  p.X -X;
				float yDiff =  p.Y -Y;
				double angle = Math.Atan2(yDiff, xDiff) * 180.0 / Math.PI;
				Matrix myMatrix = new Matrix();
				myMatrix.RotateAt((float)angle, new PointF() { X = X, Y = Y });
				item.ShapeMatrix = myMatrix;
				item.Angle = (float)angle;
            }
			lastLocation = p;
        }

		public void Resize(PointF p)
        {
			foreach (Shape item in selection)
            {
				item.Width += p.X - lastLocation.X;
				item.Height += p.Y - lastLocation.Y;
            }
			lastLocation = p;
        }
	}
}
