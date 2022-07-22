using System.Collections;
using System.Collections.Generic;
using Effect;
using UnityEngine;

public class FieldEffect : EffectActivator
{
	[SerializeField]
	private EffectFieldID _effectId;

	private EffectInstance _effectInstance;

	private EffectData _effectData;

	private static List<FieldEffect> requests;

	public EffectManager.FieldLoadParam param => null;

	public EffectInstance effectInstance
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static void AppendRequest(FieldEffect fieldEffect)
	{
	}

	public static IEnumerator DispathRequests()
	{
		return null;
	}

	protected override IEnumerator OnActivateOperation()
	{
		return null;
	}

	private void OnDestroy()
	{
	}
}
