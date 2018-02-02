using System;
using System.Windows.Forms;
using System.Drawing;
using C1.Win.C1FlexGrid;

namespace NEXCORE.Common
{
	/// <summary>

	///  
	/// </summary>
	public class CellNoteManager
	{


		private C1FlexGrid	_flex;				

		public CellNoteManager(C1FlexGrid flex)
		{

			_flex = flex;

			// attach event handlers
			_flex.DrawMode = DrawModeEnum.OwnerDraw;
            _flex.OwnerDrawCell += new OwnerDrawCellEventHandler(_flex_OwnerDrawCell);

		}




        private void _flex_OwnerDrawCell(object sender, C1.Win.C1FlexGrid.OwnerDrawCellEventArgs e)
        {
            try
            {


                // check if the cell has a note
                CellRange rg = _flex.GetCellRange(e.Row, e.Col);
                if (rg.UserData == (object)"notes")
                {
                    // default drawing
                    e.DrawCell();
                    // add the little red rectangle that indicaates there's a note on this cell
                    Point pt = new Point(e.Bounds.Right, e.Bounds.Y);
                    Point[] points = { new Point(pt.X - 4, pt.Y), pt, new Point(pt.X, pt.Y + 4) };
                    e.Graphics.FillPolygon(new SolidBrush(Color.FromArgb(159,180,195)), points); //Brushes.LightGray, points);
                }
            }
            catch 
            {

                
            }
        }          





	}
}
