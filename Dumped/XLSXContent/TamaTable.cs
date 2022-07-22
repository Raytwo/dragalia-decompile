using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class TamaTable : ScriptableObject
{
	[Serializable]
	public class Sheettable
	{
		public int TamaID;

		public int UgItemID;

		public string ItemNameLabel;

		public string DescriptionTextLabel;
	}

	public Sheettable[] table;

	public Sheettable this[int index] => null;
}
