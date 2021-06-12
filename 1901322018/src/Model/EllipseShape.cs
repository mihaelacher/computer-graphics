using System;
using System.Drawing;

namespace Draw
{
	/// <summary>
	/// Класът елипса е основен примитив, който е наследник на базовия Shape.
	/// </summary>
    [Serializable]
	public class EllipseShape : Shape
	{
		#region Constructor

		public EllipseShape() : base()
		{
		}

		public EllipseShape(EllipseShape ellipse) : base(ellipse)
		{
		}

		#endregion

		public override bool Contains(PointF point)
		{
			float X = Location.X + (Width / 2);
			float Y = Location.Y + (Height / 2);

			return (Math.Pow(point.X - X, 2) / Math.Pow(Width, 2))
				+ (Math.Pow(point.Y - Y, 2) / Math.Pow(Height, 2)) <= 1; 
		}

		public override void DrawSelf(Graphics grfx)
		{
			base.DrawSelf(grfx);

			grfx.FillEllipse(new SolidBrush(FillColor), Location.X, Location.Y, Width, Height);
			grfx.DrawEllipse(new Pen(BorderColor, BorderWidth), Location.X, Location.Y, Width, Height);
		}
	}
}