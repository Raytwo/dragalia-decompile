using Pml;
using UnityEngine;

namespace Dpr.Contest;

public sealed class ResultDataModel : ResultData
{
	private float playerNumDivid;

	private Sprite resultMessageSpr;

	public void ResetData()
	{
	}

	public void OnFinalize()
	{
	}

	public ResultPlayerDataModel GetPlayerData()
	{
		return null;
	}

	public int GetPersonalTotalScore()
	{
		return default(int);
	}

	public bool IsUserWin()
	{
		return default(bool);
	}

	public Sprite GetResultMessageSpr()
	{
		return null;
	}

	public float CalcVisualGaugeRatio(int playerIndex)
	{
		return default(float);
	}

	public float CalcDanceGaugeRatio(int playerIndex)
	{
		return default(float);
	}

	public float CalcWazaGaugeRatio(int playerIndex)
	{
		return default(float);
	}

	public void ApplyContestPoint()
	{
	}

	private uint CalcAddRankPoint()
	{
		return default(uint);
	}

	private float CalcRatio(float a, float b)
	{
		return default(float);
	}

	public void SetPlayerDataModelArray(ResultPlayerDataModel[] playerDataModelArray)
	{
	}

	public void CreateVoiceEventName(MonsNo monsNo, uint formNo, int voiceNo)
	{
	}
}
