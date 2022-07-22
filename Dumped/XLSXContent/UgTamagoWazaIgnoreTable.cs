using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class UgTamagoWazaIgnoreTable : ScriptableObject
{
	[Serializable]
	public class SheetSheet1
	{
		public ushort MonsNo;

		public ushort[] Waza;
	}

	public SheetSheet1[] Sheet1;

	public SheetSheet1 this[int index] => null;
}
