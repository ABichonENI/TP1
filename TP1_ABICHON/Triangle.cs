using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_ABICHON
{
	public class Triangle : Forme
	{
		private int aireTriangle;

		private int perimetreTriangle;

		public int A { get; set; }
		public int B { get; set; }
		public int C { get; set; }

		public override void Aire()
		{
			;
		}

		public override void Perimetre()
		{
			this.perimetreTriangle = A + B +C ;
		}

		public override string ToString()
		{
			return "test";
		}
	}
}
