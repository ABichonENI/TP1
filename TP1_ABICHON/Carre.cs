using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_ABICHON
{
	public class Carre : Forme
	{
		private int nbCote = 4;
		private int AireCarre;
		private int PerimetreCarre;
		public int Longueur { get; set; }

		public override void Aire()
		{
			AireCarre = (Longueur*Longueur) ;
		}

		public override void Perimetre()
		{
			PerimetreCarre = (4*Longueur);
		}
	}
}
