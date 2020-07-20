using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_ABICHON
{
	class Rectangle : Forme
	{
		private int AireRectangle;
		private int PerimetreRectangle;
		public int Largeur { get; set; }
		public int Longueur { get; set; }

		public override void Aire()
		{
			AireRectangle = (Longueur*Largeur);
		}

		public override void Perimetre()
		{
			PerimetreRectangle= (2*(Longueur+Largeur));
		}
	}
}
