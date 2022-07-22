using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class StoneStatuEeffect : ScriptableObject
{
	[Serializable]
	public class Sheettable
	{
		public ushort statueId;

		public int UgItemID;

		public int MSLabelId;
	}

	public Sheettable[] table;

	public Sheettable this[int index] => null;
}
