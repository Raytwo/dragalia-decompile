using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Dpr.BallDeco;
using Dpr.SequenceEditor;
using Effect;
using UnityEngine;

namespace Dpr.Battle.View.Objects;

public sealed class BtlvEffectInstance : BtlvPureObject
{
	private Vector3 _beforeTranslation;

	private EffectInstance _effect;

	private SEQ_DEF_EFF_DRAWTYPE _drawType;

	private bool _autoRotate;

	private BattleScreenObject _screenObject;

	public EffectInstance Effect
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public bool IsStop
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

	public bool IsScreenEffect => default(bool);

	public bool AutoRotate
	{
		set
		{
		}
	}

	public AffixSealData SealData
	{
		[CompilerGenerated]
		get
		{
			return default(AffixSealData);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public BtlvEffectInstance(EffectData effectData, SEQ_DEF_EFF_DRAWTYPE drawType = SEQ_DEF_EFF_DRAWTYPE.SEQ_DEF_EFF_DRAWTYPE_NORAML)
	{
	}

	public BtlvEffectInstance(EffectData effectData, AffixSealData sealData)
	{
	}

	public override void Dispose()
	{
	}

	public void Play([Optional] Action<EffectInstance> onComplete)
	{
	}

	public void Fade()
	{
	}

	public void Kill(bool immediate = true)
	{
	}

	public override bool IsActive()
	{
		return default(bool);
	}

	public override void OnUpdatePreJob(float deltaTime)
	{
	}

	public override void OnUpdatePostJob(float deltaTime)
	{
	}

	public void SetRenderCamera(BattleScreenObject screenObject)
	{
	}

	protected override void UpdateSRT()
	{
	}

	public void SetMultiplyColor(Vector4 color)
	{
	}
}
