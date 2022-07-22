using System;
using Pml;
using Pml.PokePara;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class LocalKoukanData : ScriptableObject
{
	[Serializable]
	public class Sheetdata
	{
		public MonsNo target;

		public string name_label;

		public int trainerid;

		public MonsNo monsno;

		public string nickname_label;

		public int level;

		public Seikaku seikaku;

		public int tokusei;

		public ItemNo itemno;

		public int rand;

		public Sex sex;

		public int language;

		public WazaNo[] waza;
	}

	public Sheetdata[] data;

	public Sheetdata this[int index] => null;
}
