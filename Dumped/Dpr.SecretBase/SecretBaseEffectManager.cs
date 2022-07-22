using System.Collections;
using System.Collections.Generic;
using Effect;
using UnityEngine;

namespace Dpr.SecretBase;

public class SecretBaseEffectManager : MonoBehaviour
{
	private List<EffectFieldID> effectIds;

	private readonly Dictionary<int, EffectData> effectData;

	private EffectInstance effecttInstance;

	private void Play(int index, Vector3 pos)
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
