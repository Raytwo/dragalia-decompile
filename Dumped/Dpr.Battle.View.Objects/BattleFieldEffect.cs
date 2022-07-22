using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Effect;
using UnityEngine;

namespace Dpr.Battle.View.Objects;

public class BattleFieldEffect : EffectActivator
{
	private static List<BattleFieldEffect> _registedEffects;

	[SerializeField]
	[SearchableEnum]
	private EffectBattleID _effectBattleId;

	[SerializeField]
	private float _delayTime;

	private EffectInstance _effectInstance;

	private EffectData _effectData;

	private bool IsPlaying
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	protected override IEnumerator OnActivateOperation()
	{
		return null;
	}

	private void OnDestroy()
	{
	}

	public void Play([Optional] Action onComplete)
	{
	}

	public void Stop()
	{
	}

	public static void SetAllActivate(bool isActive)
	{
	}
}
