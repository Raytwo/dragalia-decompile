using System.Collections;
using System.Runtime.CompilerServices;
using Effect;
using UnityEngine;

public class EncEffectSequenceController
{
	public enum ePlayState
	{
		Loading,
		PlayStandBy,
		Play,
		Finish,
		Release
	}

	private EncEffectSequenceData _sequence;

	private float _updateTime;

	private EffectInstance _effectInstance;

	private FieldManager _field;

	private Vector3 _cameraPositionOffset;

	private Vector3 _cameraRotationOffset;

	public ePlayState PlayState
	{
		[CompilerGenerated]
		get
		{
			return default(ePlayState);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public EncEffectSequenceController(string assetname, FieldManager field)
	{
	}

	private IEnumerator EffectLoad(string assetname)
	{
		return null;
	}

	private IEnumerator LoadGymEffect()
	{
		return null;
	}

	private IEnumerator LoadLeagueEffect()
	{
		return null;
	}

	private IEnumerator LoadTowerEffect()
	{
		return null;
	}

	public void Release()
	{
	}

	public void Play()
	{
	}

	public void ForceFinish()
	{
	}

	private void update(float deltatime)
	{
	}

	private void CommandRunning(EncEffectSequenceData.KeyData data)
	{
	}

	private void ProcCommandStart(EncEffectSequenceData.KeyData data)
	{
	}

	private void ProcCommandUpdate(EncEffectSequenceData.KeyData data)
	{
	}

	private void ProcCommandEnd(EncEffectSequenceData.KeyData data)
	{
	}

	public void LegendCamera()
	{
	}

	private void SetLegendCamera(int index, ref Vector3 pos, ref Vector3 rot)
	{
	}
}
