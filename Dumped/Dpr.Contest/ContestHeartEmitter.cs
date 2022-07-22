using System;
using System.Collections.Generic;
using Effect;
using UnityEngine;

namespace Dpr.Contest;

public class ContestHeartEmitter
{
	private const int GENERATE_DANCE_NORMAL_HEART_OBJ_NUM = 15;

	private const int GENERATE_DANCE_LARGE_HEART_OBJ_NUM = 7;

	private VisualHeartEffect[] visualNormalHeartArray;

	private VisualHeartEffect[] visualLargeHeartArray;

	private DanceHeartEffect[] danceNormalHeartArray;

	private DanceHeartEffect[] danceLargeHeartArray;

	private List<VisualHeartEffect> activeVisualHeartList;

	private HeartBeziePath[] bezieParams;

	private NPCHeartParam npcHeartParam;

	private EffectData normalHeartFxData;

	private EffectData largeHeartFxData;

	private EffectManager fxManagerPtr;

	private ContestSettings contestSettingPtr;

	private Vector2 screenHalfSize;

	private int visualNormalArrayIndex;

	private int visualLargeArrayIndex;

	private bool bLoadedVisualHeartFx;

	private bool bLoadedDanceHeartFx;

	public bool IsLoaded => default(bool);

	public void Setup(ContestPlayerEntity[] playerEntityArray, Transform visualHeartContent, Transform danceHeartContent, ContestSettings contestSetting)
	{
	}

	private void GenerateVisualHeartPool(Transform visualHeartContent, ContestPlayerEntity[] playerEntityArray)
	{
	}

	private int CalcGenerateVisualNormalHeartNum(ContestPlayerEntity[] playerEntityArray)
	{
		return default(int);
	}

	private int CalcGenerateVisualLargeHeartNum(ContestPlayerEntity[] playerEntityArray)
	{
		return default(int);
	}

	private void GenerateDanceHeartPool(Transform danceHeartContent)
	{
	}

	private void LoadFxData(EffectContestID fxID, int poolCount, Action<EffectData> onComplete)
	{
	}

	public void Reset()
	{
	}

	public void OnFinalize()
	{
	}

	public void CreateVisualHeartFx(int emitNum, Vector2 emitPos, bool isLarge)
	{
	}

	public DanceHeartEffect CreatePlayerHeart(Vector2 from, Vector2 to, EmitHeartPattern pattern, Action onComplete)
	{
		return null;
	}

	public DanceHeartEffect CreateNPCHeart(Vector2 from, Vector2 to, EmitHeartPattern pattern, Action onComplete)
	{
		return null;
	}

	private DanceHeartEffect FindDeactiveDanceNormalHeart()
	{
		return null;
	}

	private DanceHeartEffect FindDeactiveDanceLargeHeart()
	{
		return null;
	}

	public void UpdateVisualHeart(float deltaTime)
	{
	}

	public void StopVisualHeartFx()
	{
	}

	public void StopDanceHeartFx()
	{
	}
}
