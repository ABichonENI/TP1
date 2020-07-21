using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_ABICHON
{
	class Rectangle : Forme
	{
		private int aireRectangle;
		private int perimetreRectangle;
		public int Largeur { get; set; }
		public int Longueur { get; set; }

		public override void Aire()
		{
			aireRectangle = (Longueur*Largeur);
		}

		public override void Perimetre()
		{
			perimetreRectangle= (2*(Longueur+Largeur));
		}
	}
}
