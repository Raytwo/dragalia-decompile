using System.Collections.Generic;
using DPData;
using UnityEngine;
using UnityEngine.U2D;
using XLSXContent;

namespace Dpr.UnderGround;

public class StatueBuff : MonoBehaviour
{
	public Transform IconsParent;

	public GameObject IconPrefab;

	public List<UIStatueBuffIcon> Icons;

	public SpriteAtlas IconAtlas;

	private int statueGridNum;

	public UgPokeLottery.PokeSlot[] DebugPokeSlots;

	public Dictionary<int, int> AddTypeKakurituDic;

	private List<UgSecretBase> secretBases;

	public int Button01;

	public int Button02;

	public int Button03;

	private StatueEffectRawData statueData => null;

	public void UpdateStatueParam()
	{
	}

	public void UpdateIcons()
	{
	}

	public void ClearIcons()
	{
	}

	public void GetStatues()
	{
	}

	public void ClearSecBase()
	{
	}

	private void CalcStatueData()
	{
	}

	public (int, int) GetMaxStatueEff(UgSecretBase Base)
	{
		return default((int, int));
	}

	public int GetPlusSlotNum()
	{
		return default(int);
	}

	public void OnDestroy()
	{
	}
}
