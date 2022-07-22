using System;
using Effect;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class EffectDatabase : ScriptableObject
{
	[Serializable]
	public class SheetFieldEffectData : EffectManager.FieldLoadParam
	{
	}

	[Serializable]
	public class SheetBattleEffectData : EffectManager.LoadParam
	{
	}

	[Serializable]
	public class SheetContestEffectData : EffectManager.LoadParam
	{
	}

	[Serializable]
	public class SheetMenuEffetData : EffectManager.LoadParam
	{
	}

	public SheetFieldEffectData[] FieldEffectData;

	public SheetBattleEffectData[] BattleEffectData;

	public SheetContestEffectData[] ContestEffectData;

	public SheetMenuEffetData[] MenuEffetData;

	public SheetFieldEffectData this[int index] => null;
}
