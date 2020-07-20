namespace TP1_ABICHON
{
	public class Cercle : Forme
	{
		private int AireCercle;
		private int PerimetreCercle;
		public int Rayon { get; set; }

		public override void Aire()
		{
			AireCercle = ((int)(3.14 * Rayon * Rayon)) ;
		}

		public override void Perimetre()
		{
			PerimetreCercle = ((int)(2*Rayon*3.14));
		}
	}
}