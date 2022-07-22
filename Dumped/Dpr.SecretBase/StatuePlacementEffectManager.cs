using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Effect;
using UnityEngine;

namespace Dpr.SecretBase;

public class StatuePlacementEffectManager : MonoBehaviour
{
	public enum EffectID
	{
		PlacementStatueS,
		PlacementStatueM,
		PlacementStatueL
	}

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

	public void Play(EffectID id, Vector3 pos)
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
