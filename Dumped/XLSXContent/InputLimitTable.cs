using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class InputLimitTable : ScriptableObject
{
	[Serializable]
	public class SheetJ : SheetInputLimitTable
	{
	}

	[Serializable]
	public class SheetEFIGS : SheetInputLimitTable
	{
	}

	[Serializable]
	public class SheetK : SheetInputLimitTable
	{
	}

	[Serializable]
	public class SheetSC : SheetInputLimitTable
	{
	}

	[Serializable]
	public class SheetTC : SheetInputLimitTable
	{
	}

	public SheetJ[] J;

	public SheetEFIGS[] EFIGS;

	public SheetK[] K;

	public SheetSC[] SC;

	public SheetTC[] TC;

	public SheetJ this[int index] => null;
}
