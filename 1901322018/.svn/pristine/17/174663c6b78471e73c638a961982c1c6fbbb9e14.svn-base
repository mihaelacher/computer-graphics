using System;
using System.Drawing;
using System.Collections.Generic;

namespace Draw
{
	[Serializable]
	public class GroupShape : Shape
	{
		#region Constructor

		public GroupShape() : base()
		{
		}

		public GroupShape(EllipseShape ellipse) : base(ellipse)
		{
		}

		#endregion

		public List<Shape> SubShape = new List<Shape>();

		public String groupName;
		public virtual String GroupName
        {
			get { return groupName; }
			set { groupName = value; }
        }

		public override bool Contains(PointF point)
		{
			bool contains = true;

			foreach (Shape item in SubShape)
            {
				if (!item.Contains(point))
                {
					contains = false;
					break;
                }				
            }
			return contains;
		}

		public override void DrawSelf(Graphics grfx)
		{
			foreach (Shape item in SubShape)
            {
				item.DrawSelf(grfx);
			}
		}
	}
}