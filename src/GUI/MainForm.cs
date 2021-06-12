using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Draw
{
	/// <summary>
	/// Върху главната форма е поставен потребителски контрол,
	/// в който се осъществява визуализацията
	/// </summary>
	public partial class MainForm : Form
	{
		/// <summary>
		/// Агрегирания диалогов процесор във формата улеснява манипулацията на модела.
		/// </summary>
		private DialogProcessor dialogProcessor = new DialogProcessor();
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		/// <summary>
		/// Изход от програмата. Затваря главната форма, а с това и програмата.
		/// </summary>
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Close();
		}

		void SaveToolStripMenuItemClick(object sender, EventArgs e)
		{
			 using (SaveFileDialog saveDlg = new SaveFileDialog())
			 {
				 // Configure the look and feel of the save dialog.
				saveDlg.InitialDirectory = ".";
				saveDlg.RestoreDirectory = true;
				saveDlg.FileName = "MyShapes";
	
			if (saveDlg.ShowDialog() == DialogResult.OK)
            {
				BinaryFormatter formatter = new BinaryFormatter();
                using (Stream fstream = new FileStream(saveDlg.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
					formatter.Serialize(fstream, dialogProcessor.ShapeList);
                    fstream.Close();
                    MessageBox.Show("Файлът е запазен");
                }
				dialogProcessor.ShapeList.Clear();
				viewPort.Invalidate();
            }
			}
		}


		void ImportToolStripMenuItemClick(object sender, EventArgs e)
		{
			 using (OpenFileDialog openDlg = new OpenFileDialog())
			 {
				 // Configure the look and feel of the save dialog.
				openDlg.InitialDirectory = ".";
				openDlg.RestoreDirectory = true;
	
			if (openDlg.ShowDialog() == DialogResult.OK)
            {
				BinaryFormatter formatter = new BinaryFormatter();
                using (Stream fstream = new FileStream(openDlg.FileName, FileMode.Open))
                {
					dialogProcessor.ShapeList = (List<Draw.Shape>)formatter.Deserialize(fstream);
                    fstream.Close();
                }                  
			}
			}
		}
		
		/// <summary>
		/// Събитието, което се прихваща, за да се превизуализира при изменение на модела.
		/// </summary>
		void ViewPortPaint(object sender, PaintEventArgs e)
		{
			dialogProcessor.ReDraw(sender, e);
		}
		
		/// <summary>
		/// Бутон, който поставя на произволно място правоъгълник със зададените размери.
		/// Променя се лентата със състоянието и се инвалидира контрола, в който визуализираме.
		/// </summary>
		void DrawRectangleSpeedButtonClick(object sender, EventArgs e)
		{
			dialogProcessor.AddRandomRectangle();
			
			statusBar.Items[0].Text = "Последно действие: Рисуване на правоъгълник";
			
			viewPort.Invalidate();
		}


		void AddRandomTaskShapeMenuItemClick(object sender, EventArgs e)
		{
			dialogProcessor.AddRandomTaskShape();
			
			statusBar.Items[0].Text = "Последно действие: Рисуване на правоъгълник";
			
			viewPort.Invalidate();
		}

		void addTaskMenuSpeedButtonClick(object sender, EventArgs e)
		{
			dialogProcessor.AddRandomRectangle();
			
			statusBar.Items[0].Text = "Последно действие: Рисуване на правоъгълник";
			
			viewPort.Invalidate();
		}


		/// <summary>
		/// Бутон, който поставя на произволно място квадрат със зададените размери.
		/// Променя се лентата със състоянието и се инвалидира контрола, в който визуализираме.
		/// </summary>
		void DrawSquareSpeedButtonClick(object sender, EventArgs e)
		{
			dialogProcessor.AddRandomSquare();
			
			statusBar.Items[0].Text = "Последно действие: Рисуване на квадрат";
			
			viewPort.Invalidate();
		}

		/// <summary>
		/// Бутон, който поставя на произволно място елипса със зададените размери.
		/// Променя се лентата със състоянието и се инвалидира контрола, в който визуализираме.
		/// </summary>
		void DrawEllipseSpeedButtonClick(object sender, EventArgs e)
		{
			dialogProcessor.AddRandomEllipse();

			statusBar.Items[0].Text = "Последно действие: Рисуване на елипса";

			viewPort.Invalidate();
		}

		/// <summary>
		/// Бутон, който поставя на произволно място точка със зададените размери.
		/// Променя се лентата със състоянието и се инвалидира контрола, в който визуализираме.
		/// </summary>
		void DrawCircleSpeedButtonClick(object sender, EventArgs e)
		{
			dialogProcessor.AddRandomCircle();

			statusBar.Items[0].Text = "Последно действие: Рисуване на точка";

			viewPort.Invalidate();
		}

		/// <summary>
		/// Смяна на бордър цвета на селектиран елемент.
		/// </summary>
		void ChangeBorderColorToolStripMenuItemClick(object sender, EventArgs e)
		{
			ColorDialog colorDialog = new ColorDialog();
			colorDialog.AllowFullOpen = false;
			colorDialog.ShowHelp = true;

			List<Shape> selection = dialogProcessor.Selection;

			if (pickUpSpeedButton.Checked && selection != null)
            {
				if (colorDialog.ShowDialog() == DialogResult.OK)
                {
					foreach (Shape item in selection)
                    {
						item.BorderColor = colorDialog.Color;
                    }
					statusBar.Items[0].Text = "Последно дейтсвие: Смяна на бордър цвят на примитив.";
					viewPort.Invalidate();
                }
            }
			else
            {
				MessageBox.Show("Моля, селектирайте примитив!");
            }
		}

		/// <summary>
		/// Смяна на прозрачността цвета на селектиран елемент.
		/// </summary>
		void ChangeTransperancyColorToolStripMenuItemClick(object sender, EventArgs e)
		{
			List<Shape> selection = dialogProcessor.Selection;

			if (pickUpSpeedButton.Checked && selection != null)
            {
				InputBox inputBox = new InputBox();
				string input = null;

				if (inputBox.Show("Смяна на прозрачност на бордър", "Прозрачност в проценти:", ref input) == DialogResult.OK)
                {
					foreach (Shape item in selection)
                    {
						item.BorderColor = Color.FromArgb(int.Parse(input), item.BorderColor);
                    }
					statusBar.Items[0].Text = "Последно дейтсвие: Смяна на бордър прозрачност на примитив.";
					viewPort.Invalidate();
                }
            }
			else
            {
				MessageBox.Show("Моля, селектирайте примитив!");
            }
		}

		/// <summary>
		/// Смяна на бордър дебелината на селектиран елемент.
		/// </summary>
		void ChangeBorderWidthToolStripMenuItemClick(object sender, EventArgs e)
		{
			List<Shape> selection = dialogProcessor.Selection;

			if (pickUpSpeedButton.Checked && selection != null)
            {
				InputBox inputBox = new InputBox();
				string input = null;

				if (inputBox.Show("Смяна на дебелината на бордър", "Дебелина (цяло число):", ref input) == DialogResult.OK)
                {
					foreach (Shape item in selection)
                    {
						item.BorderWidth = int.Parse(input); 
                    }
					statusBar.Items[0].Text = "Последно дейтсвие: Смяна на бордър дебелина на примитив.";
					viewPort.Invalidate();
                }
            }
			else
            {
				MessageBox.Show("Моля, селектирайте примитив!");
            }
		}

		void GroupToolStripMenuItemClick(object sender, EventArgs e)
        {
			List<Shape> selection = dialogProcessor.Selection;

			if (selection == null || selection.Count < 2)
            {
				MessageBox.Show("Моля, селектирайте поне 2 примитива!");
            } 
			else
            {
				InputBox inputBox = new InputBox();
				string input = null;

				if (inputBox.Show("Групиране на примитиви", "Наименование:", ref input) == DialogResult.OK)
                {
					GroupShape group = new GroupShape();
					group.GroupName = input;

					foreach (Shape item in selection.ToArray())
                    {
						selection.Remove(item);
						item.FillColor = Color.White;
						group.SubShape.Add(item);
                    }
					dialogProcessor.GroupShapes.Add(group);
					statusBar.Items[0].Text = "Последно дейтсвие: Групиране на примитиви.";
					viewPort.Invalidate();
                }
            }
        }

		void RegroupToolStripMenuItemClick(object sender, EventArgs e)
        {
			List<Shape> selection = dialogProcessor.Selection;

				InputBox inputBox = new InputBox();
				string input = null;

				if (inputBox.Show("Разгрупиране на примитиви", "Наименование:", ref input) == DialogResult.OK)
                {
					foreach (GroupShape item in dialogProcessor.GroupShapes.ToArray())
					{
						if(item.groupName == input)
						{
							dialogProcessor.GroupShapes.Remove(item);
						    item.FillColor = Color.White;
					    }
						else
						{
						MessageBox.Show("Такава група не съществува!");
						}
					}
					statusBar.Items[0].Text = "Последно дейтсвие: Разгрупиране на примитиви.";
					viewPort.Invalidate();
                }
        }

		void SelectGroupToolStripMenuItemClick(object sender, EventArgs e)
        {
			List<Shape> selection = dialogProcessor.Selection;

				InputBox inputBox = new InputBox();
				string input = null;

				if (inputBox.Show("Селектриране на група примитиви", "Наименование:", ref input) == DialogResult.OK)
                {
					foreach (GroupShape item in dialogProcessor.GroupShapes.ToArray())
					{
						if(item.groupName == input)
						{
							foreach (Shape sel in selection)
							{
								sel.FillColor = Color.White;
							}
							selection.Clear();

							foreach (Shape shape in item.SubShape)
							{
							selection.Add(shape);
							shape.FillColor = Color.Red;
							}
                        }
						statusBar.Items[0].Text = "Последно дейтсвие: Селектиране на примитиви.";
					}
				viewPort.Invalidate();
                }
        }

		/// <summary>
		/// Прихващане на координатите при натискането на бутон на мишката и проверка (в обратен ред) дали не е
		/// щракнато върху елемент. Ако е така то той се отбелязва като селектиран и започва процес на "влачене".
		/// Промяна на статуса и инвалидиране на контрола, в който визуализираме.
		/// Реализацията се диалогът с потребителя, при който се избира "най-горния" елемент от екрана.
		/// </summary>
		void ViewPortMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (pickUpSpeedButton.Checked) {
				Shape item = dialogProcessor.ContainsPoint(e.Location);
				if (item != null)
                {
					if (dialogProcessor.Selection.Contains(item))
                    {
						dialogProcessor.Selection.Remove(item);
						item.FillColor = Color.White;
                    } 
					else
                    {
						dialogProcessor.Selection.Add(item);
                    }
					statusBar.Items[0].Text = "Последно действие: Селекция на примитив";
					dialogProcessor.IsDragging = true;
					dialogProcessor.LastLocation = e.Location;
                }
			}

			viewPort.Invalidate();
		}

		/// <summary>
		/// Прихващане на преместването на мишката.
		/// Ако сме в режм на "влачене", то избрания елемент се транслира.
		/// </summary>
		void ViewPortMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (pickUpSpeedButton.Checked && !rotateShapeSpeedButton.Checked && !resizeSpeedButton.Checked)
            {
				if (dialogProcessor.IsDragging) {
					if (dialogProcessor.Selection != null) statusBar.Items[0].Text = "Последно действие: Влачене";
					dialogProcessor.TranslateTo(e.Location);
					dialogProcessor.IsDragging = true;
					dialogProcessor.LastLocation = e.Location;
				}
            } 

			if (rotateShapeSpeedButton.Checked && !resizeSpeedButton.Checked)
            {
				if (dialogProcessor.IsDragging) {
					if (dialogProcessor.Selection != null) statusBar.Items[0].Text = "Последно действие: Завъртане на примитив.";
					dialogProcessor.Rotate(e.Location);
					dialogProcessor.IsDragging = true;
					dialogProcessor.LastLocation = e.Location;
				}
            }

			if (resizeSpeedButton.Checked && !rotateShapeSpeedButton.Checked)
            {
				if (dialogProcessor.IsDragging) {
					if (dialogProcessor.Selection != null) statusBar.Items[0].Text = "Последно действие: Оразмеряване на примитив.";
					dialogProcessor.Resize(e.Location);
					dialogProcessor.IsDragging = true;
					dialogProcessor.LastLocation = e.Location;
				}
            }
			viewPort.Invalidate();
		}

		/// <summary>
		/// Прихващане на отпускането на бутона на мишката.
		/// Излизаме от режим "влачене".
		/// </summary>
		void ViewPortMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			dialogProcessor.IsDragging = false;
		}

		void KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {

			if (e.KeyCode == Keys.Delete && dialogProcessor.Selection != null)
            {
				foreach (Shape shape in dialogProcessor.Selection.ToArray())
                {
					dialogProcessor.ShapeList.Remove(shape);
					statusBar.Items[0].Text = "Последно действие: Изтриване на примитив.";
                }
				viewPort.Invalidate();
            }
        }

		void KeyDownDeleteAll(object sender, System.Windows.Forms.KeyEventArgs e)
        {
			if (e.KeyCode == Keys.Delete && e.Modifiers == Keys.Control)
            {
				dialogProcessor.ShapeList.Clear();
				viewPort.Invalidate();
            }
        }
	}
}
