using System.Collections.Generic;
using Pml.PokePara;
using UnityEngine;

namespace Dpr.UI;

public class BoxInfinityScrollItem : MonoBehaviour
{
	public class BaseParam
	{
		public class ItemParam
		{
			public PokemonParam pokemonParam;

			public BoxItem.Param itemParam;
		}

		public int paramIndex;

		public List<ItemParam> itemParams;

		public BoxWindow.DisplayMode displayMode;
	}

	public virtual void Setup(BaseParam param)
	{
	}
}
