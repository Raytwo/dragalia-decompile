using System;
using System.Collections;
using System.Collections.Generic;
using Pml;
using Pml.PokePara;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using XLSXContent;

namespace Dpr.SubContents;

public class TimeLineBinder : MonoBehaviour
{
	public interface IBindData
	{
		void Destroy();
	}

	public class PokemonData : IBindData
	{
		public UnityEngine.Object asset;

		public PokemonInfo.SheetCatalog catalog;

		public PokemonParam param;

		public float scale;

		public PokemonData(UnityEngine.Object asset, PokemonInfo.SheetCatalog catalog, PokemonParam param)
		{
		}

		public void Destroy()
		{
		}
	}

	public class BallData : IBindData
	{
		public UnityEngine.Object asset;

		public BallData(UnityEngine.Object asset)
		{
		}

		public void Destroy()
		{
		}
	}

	public class PokeNameData : IBindData
	{
		public string name;

		public PokeNameData(PokemonParam param)
		{
		}

		public void Destroy()
		{
		}
	}

	private PlayableDirector director;

	[SerializeField]
	private Transform Camera;

	[SerializeField]
	private List<BindModel> BindAssets;

	[SerializeField]
	private List<BindModelEffect> BindEffects;

	[SerializeField]
	private List<BindModelSound> BindSounds;

	[SerializeField]
	private EnvironmentSettings EnvSettings;

	[SerializeField]
	private EnvironmentController MyEnvironmentController;

	private EnvironmentController PrevEnvController;

	private TimelineAsset timeLineAsset;

	public Dictionary<string, IBindData> ExternalAssets;

	private Dictionary<int, UnityEngine.Object> PokeAssets;

	public Action OnTimeLineCallBack;

	public Action<PlayableDirector> OnComplete;

	public BattlePokemonEntity battlePokeEntity;

	public int Button01;

	public int Button02;

	private bool isActive;

	public int StartIndex;

	public int Button10;

	private PatcheelPattern ppp;

	private uint ppval;

	public int Button11;

	[SerializeField]
	private float DebugTime;

	public int Button010;

	private void Awake()
	{
	}

	public Coroutine Setup()
	{
		return null;
	}

	public void Play()
	{
	}

	public void Pause()
	{
	}

	public void Resume()
	{
	}

	public void Stop()
	{
	}

	public void SetTime(float time)
	{
	}

	public void GotoTimelineEnd()
	{
	}

	private void Update()
	{
	}

	public void SetOnComplete(Action<PlayableDirector> onComplete)
	{
	}

	public void Bind()
	{
	}

	public void MuteTrack(string name)
	{
	}

	public void UnMuteTrack(string name)
	{
	}

	public void RemoveEffectsNum(int num)
	{
	}

	public void RemoveBindAsset()
	{
	}

	private IEnumerator OpLoadAssets()
	{
		return null;
	}

	private IEnumerator OpSetup()
	{
		return null;
	}

	private void MyUpdate(float deltaTime)
	{
	}

	private void OnPlayableDirectorPlayed(PlayableDirector aDirector)
	{
	}

	private void OnPlayableDirectorStoped(PlayableDirector aDirector)
	{
	}

	private void OnPlayableDirectorPaused(PlayableDirector aDirector)
	{
	}

	public IEnumerator LoadPokeAsset(MonsNo monsNo, ushort formNo, Sex sex, bool isRare, bool isEgg, Action<UnityEngine.Object> OnLoad)
	{
		return null;
	}

	public Camera GetCamera()
	{
		return null;
	}

	public void AddLightLayer(string layerName)
	{
	}

	public List<BindModel> GetBindModels()
	{
		return null;
	}

	private void OnDestroy()
	{
	}

	private void BindAssetToEffect()
	{
	}

	private void DebugPattern()
	{
	}

	public void DeleteBindPoke(int pokeNum)
	{
	}

	public void ChangePokeBattleScale()
	{
	}

	public void ChangePokeMenuScale()
	{
	}

	public void TimeLineCall()
	{
	}

	public BattlePokemonEntity GetPokeEntity()
	{
		return null;
	}

	private void DebugSetTime()
	{
	}
}
