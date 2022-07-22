using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class UgRandMark : ScriptableObject
{
	[Serializable]
	public class Sheettable
	{
		public int id;

		public string FileName;

		public int size;

		public int min;

		public int max;

		public int smax;

		public int mmax;

		public int lmax;

		public int llmax;

		public int watermax;

		public int[] typerate;
	}

	public Sheettable[] table;

	public Sheettable this[int index] => null;
}
