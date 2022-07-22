using System;
using Pml;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class UgEncount : ScriptableObject
{
	[Serializable]
	public class Sheettable
	{
		public MonsNo monsno;

		public int version;

		public int zukanflag;
	}

	public Sheettable[] table;

	public Sheettable this[int index] => null;
}
