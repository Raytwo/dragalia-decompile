using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Dpr.Battle.View.Playables;
using Dpr.SequenceEditor;
using Effect;
using Pml;
using UnityEngine;

namespace Dpr.Battle.View;

public static class BattleViewAssetManager
{
	public static List<UnityEngine.Object> NeedDestroyObjects;

	private static Dictionary<string, UnityEngine.Object> CachedAssetBundle
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static List<Tuple<string, EffectData>> CachedEffectData
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static List<Tuple<string, ObjectEntity>> CachedModelData
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static Dictionary<string, CameraFilePlayable> CachedCameraFilePlayables
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static void Initialize()
	{
	}

	public static void UnInitialize(bool isNeedDestroyObjects = false)
	{
	}

	public static bool HasCameraFilePlayable(string key)
	{
		return default(bool);
	}

	public static void AddCameraFilePlayable(string key, CameraFilePlayable playable)
	{
	}

	public static bool TryGetCameraFilePlayable(string key, out CameraFilePlayable playable)
	{
		return default(bool);
	}

	public static IEnumerator LoadBattleViewUISystem(string path, Action<GameObject> onComplete)
	{
		return null;
	}

	public static IEnumerator LoadModel(string path, Action<GameObject> onComplete)
	{
		return null;
	}

	public static IEnumerator LoadTrainer(TrainerSimpleParam param, Action<GameObject> onComplete)
	{
		return null;
	}

	public static IEnumerator LoadPoke(MonsNo monsNo, int formNo, Sex sex, bool isRare, Action<GameObject> onComplete)
	{
		return null;
	}

	public static IEnumerator LoadExceptionPoke(MonsNo monsNo, int formNo, Sex sex, bool isRare, string AssetBundleName, Action<GameObject> onComplete)
	{
		return null;
	}

	public static IEnumerator LoadSequenceFile(string path, Action<SequenceFile> onComplete)
	{
		return null;
	}

	public static IEnumerator LoadWaitCameraFile(string fileName, Action<GameObject> onComplete)
	{
		return null;
	}

	private static IEnumerator LoadAssetBundle<T>(string path, Action<UnityEngine.Object> onComplete) where T : UnityEngine.Object
	{
		return null;
	}

	private static void AddNeedDestroyObject(GameObject go, bool isCheckDead = false)
	{
	}
}
