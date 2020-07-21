namespace TP1_ABICHON
{
	public class Cercle : Forme
	{
		private int aireCercle;
		private int perimetreCercle;
		public int Rayon { get; set; }

		public override void Aire()
		{
			aireCercle = ((int)(3.14 * Rayon * Rayon)) ;
		}

		public override void Perimetre()
		{
			perimetreCercle = ((int)(2*Rayon*3.14));
		}
	}
}