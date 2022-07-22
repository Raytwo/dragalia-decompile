using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class EffectTable : ScriptableObject
{
	[Serializable]
	public class SheetEffects
	{
		public string Label;

		public string AssetBundleName;

		public string Type;

		public int PoolCount;

		public string Category;

		public string Group;
	}

	public SheetEffects[] Effects;

	public SheetEffects this[int index] => null;
}
