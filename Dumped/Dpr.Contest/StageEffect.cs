using System;
using Effect;
using UnityEngine;

namespace Dpr.Contest;

public class StageEffect
{
	private class EffectParam
	{
		public EffectData fxData;

		public EffectInstance instance;
	}

	private EffectInstance[] stageLightFxArray;

	private EffectData stageLightFxData;

	private EffectManager fxManager;

	private EffectParam[] monitorFxArray;

	private EffectParam confettiFxParam;

	private EffectParam resultLightFxParam;

	private Transform monitorFxParent;

	private int nowMonitorIndex;

	private int loadCount;

	private int loadedCount;

	public bool IsLoading => default(bool);

	public int NowMonitorIndex => default(int);

	public void Initialize()
	{
	}

	public void OnFinalize()
	{
	}

	public void ResetLoadCount()
	{
	}

	public void LoadStageLight(uint userRank, LightSetting[] lightDataArray, Vector3 offsetPos)
	{
	}

	public void PauseAllStageLight()
	{
	}

	public float GetMonitorFxTime()
	{
		return default(float);
	}

	public void LoadMonitorEffects(Transform parent, Vector3 offsetPosition, int startMonitorIndex, EffectContestID[] monitorFxIDs)
	{
	}

	private void LoadMonitorFx(int index, EffectContestID effectID, bool playAwake, Vector3 offsetPosition)
	{
	}

	public void LoadConfettiFx()
	{
	}

	public void LoadResultSpotLightFx()
	{
	}

	private void LoadContestFx(EffectContestID effectID, Action<EffectData> onCompleteLoad)
	{
	}

	public ParticleSystem GetMonitorFx(int index)
	{
		return null;
	}

	public void SwitchMonitor()
	{
	}

	public void MoveMonitorPositionX(float moveX)
	{
	}

	public void PlayConfettiFx(Vector3 confettiPos)
	{
	}

	public void PlayResultLight(Vector3 lightPos)
	{
	}

	public void StopStageLightFx()
	{
	}

	public void PlayStageLightFx()
	{
	}

	public void StopMonitorFx()
	{
	}

	public void PlayMonitorFx()
	{
	}

	public void StopConfettiFx()
	{
	}
}
