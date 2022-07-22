using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Effect;
using Pml;
using UnityEngine;

namespace Dpr.SecretBase;

public class SecretBaseCrystalEffectManager : MonoBehaviour
{
	[SerializeField]
	private Transform crystalRoot;

	private const int EffectLevelMax = 3;

	private List<EffectFieldID> effectIds;

	private readonly Dictionary<int, EffectData> effectData;

	private EffectInstance effecttInstance;

	public bool IsLoadCompleted
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

	public void PlayCrystalEffect(PokeType type, int level)
	{
	}

	public void StopyCrystalEffect()
	{
	}

	private void Play(int index)
	{
	}

	public IEnumerator Load()
	{
		return null;
	}

	private void OnDestroy()
	{
	}

	private void Clear()
	{
	}
}
