using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class WazaOboeTable : ScriptableObject
{
	[Serializable]
	public class SheetWazaOboe
	{
		public int id;

		public ushort[] ar;
	}

	public SheetWazaOboe[] WazaOboe;
}
