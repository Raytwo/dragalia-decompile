using System;

[Serializable]
public class PokemonVariationData
{
	[Serializable]
	public class MaterialParam
	{
		public string variation;

		public bool createFlag;
	}

	public MaterialParam[] mMaterialParams;
}
