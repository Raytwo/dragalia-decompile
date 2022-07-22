using System.Runtime.CompilerServices;
using Dpr;
using Effect;
using Pml;
using Pml.PokePara;
using SmartPoint.AssetAssistant;
using UnityEngine;
using XLSXContent;

public class FieldWazaCutIn
{
	private enum ParamIndex
	{
		CameraFov,
		EffectZ,
		EffectScale,
		PokemonX,
		PokemonY,
		PokemonZ,
		PokemonScale,
		PokemonRotY,
		PokemonAppearOfsX,
		PokemonDisappearOfsX,
		PokemonPreAppearTime,
		PokemonAppearTime,
		PokemonStopTime,
		PokemonDisappearTime,
		EffectPreKillTime
	}

	private enum CutInPhase
	{
		None,
		Capture,
		CaptureFadeIn,
		WaitPlayEffect,
		SetupLight,
		PreAppear,
		Appear,
		Stop,
		Disappear,
		PreKill
	}

	private class CameraParamBackup
	{
		private bool orthographic;

		private float farClipPlane;

		private float nearClipPlane;

		private float fieldOfView;

		private bool valid;

		public void Set(Camera camera)
		{
		}

		public void Restore(Camera camera)
		{
		}
	}

	public float PokemonVisibleTimeOffset;

	private GameObject LoadedPokemonObject;

	private AssetRequestOperation PokemonObjectLoad;

	private GameObject PokemonObject;

	private EffectInstance Effect;

	private FieldFloatMove Time;

	private FieldFloatMove CaptureAlpha;

	private int PokemonUniqueId;

	private MonsNo MonsNo;

	private int FormNo;

	private Vector3 PokemonPosition;

	private FieldWazaCutInComponents Components;

	private bool IsForceCaptureInvisible;

	private bool CaptureAlphaUpdateSkip;

	private CutInPhase Phase;

	private CameraParamBackup CameraBackup;

	public bool IsInitialized
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool IsBusy => default(bool);

	public bool IsLoaded => default(bool);

	public bool IsPlayedEffect => default(bool);

	public bool IsOverrideEnvironmentSettings
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public void Initialize()
	{
	}

	public void Load(MonsNo monsNo)
	{
	}

	public void Load(PokemonParam param)
	{
	}

	public void Load(MonsNo monsNo, ushort formNo, Sex sex, bool isRare)
	{
	}

	public void Release()
	{
	}

	public void Play()
	{
	}

	private void PlayCutIn()
	{
	}

	private static int GetAnimationIndex(BaseEntity entity, string clipName)
	{
		return default(int);
	}

	private void End()
	{
	}

	public void Update(float deltaTime)
	{
	}

	public void ForceCaptureInvisible()
	{
	}

	private float GetParam(ParamIndex paramIndex)
	{
		return default(float);
	}

	private FieldWazaCutInParam.SheetPokemonParam GetPokemonParam(int uniqueId)
	{
		return null;
	}

	private void CalcPokemonPosRot(FieldWazaCutInParam.SheetPokemonParam param, out Vector3 pos, out Vector3 rot, out Vector3 scale)
	{
	}

	private void SetEnviroment()
	{
	}

	private void ResetEnviroment()
	{
	}

	public EnvironmentSettings GetEnvironmentSettings()
	{
		return null;
	}

	private void SetupLightParam()
	{
	}

	private void SetupCamera()
	{
	}

	private void ResetCamera()
	{
	}
}
