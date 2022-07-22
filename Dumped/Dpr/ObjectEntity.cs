using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Dpr.BallDeco;
using Dpr.Battle.View;
using Dpr.Battle.View.Objects;
using Effect;
using Pml;
using UnityEngine;
using UnityEngine.Playables;

namespace Dpr;

public class ObjectEntity : BaseEntity, ITranslationObject
{
	public const int BALL_LIGHT_EFFECT_INDEX = -1;

	private static Dictionary<string, EffectData> _sealEffectDataDic;

	[SerializeField]
	private AnimationPlayer _animationPlayer;

	[SerializeField]
	private Transform[] _locators;

	[SerializeField]
	private BattleModelParticleEntity[] _modelParticleEntities;

	[SerializeField]
	private DirectorUpdateMode _updateMode;

	private Vector3 _translation;

	private Vector3 _translationOffset;

	private Vector3 _scale;

	private Vector3 _scaleOffset;

	private Vector3 _rotVec;

	private Vector3 _rotVecOffset;

	private BtlvObjectFollowInfo _objectFollowInfo;

	private List<BtlvEffectInstance> _sealEffectInstances;

	public override string entityType => null;

	public bool IsSuspendUpdate
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

	public bool IsEffectLoaded => default(bool);

	protected override void Awake()
	{
	}

	protected override void OnDestroy()
	{
	}

	protected override void OnEnable()
	{
	}

	protected override void OnDisable()
	{
	}

	public virtual void Initialize()
	{
	}

	public void SetVisible(bool value)
	{
	}

	public void OnUpdatePreJob(float deltaTime)
	{
	}

	public void OnUpdatePostJob(float deltaTime)
	{
	}

	public void Play(int index, float duration = 0f, float startTime = 0f, bool isLoop = false)
	{
	}

	public void Stop()
	{
	}

	public override AnimationPlayer GetAnimationPlayer()
	{
		return null;
	}

	public void SetAnimSpeed(float speed)
	{
	}

	public Transform GetLocator(int index)
	{
		return null;
	}

	public Transform GetLocatorByName(string name)
	{
		return null;
	}

	public void SetTranslationVec(Vector3 translation)
	{
	}

	public Vector3 GetTranslationVec()
	{
		return default(Vector3);
	}

	public void SetTranslationOffset(Vector3 translation)
	{
	}

	public Vector3 GetTranslationOffset()
	{
		return default(Vector3);
	}

	public void SetScaleVec(Vector3 scale)
	{
	}

	public Vector3 GetScaleVec()
	{
		return default(Vector3);
	}

	public void SetScaleOffset(Vector3 scale)
	{
	}

	public Vector3 GetScaleOffset()
	{
		return default(Vector3);
	}

	public void SetRotationVec(Vector3 rot)
	{
	}

	public Vector3 GetRotationVec()
	{
		return default(Vector3);
	}

	public void SetRotationVecOffset(Vector3 rot)
	{
	}

	public Vector3 GetRotationVecOffset()
	{
		return default(Vector3);
	}

	public bool IsActive()
	{
		return default(bool);
	}

	public void PlayModelParticle(int index, [Optional] Action onComplete)
	{
	}

	public void StopModelParticle(int index, float fadeTime = 0f)
	{
	}

	public static void ReleaseSealEffectData()
	{
	}

	public static IEnumerator PreLoadSealEffects(BallId ballId, AffixSealData[] sealDatas)
	{
		return null;
	}

	public void PlaySealEffect(BallId ballId, AffixSealData[] affixSealDatas, byte sealCnt, float adjustHeight = 1f)
	{
	}

	public void GetPlaySealEffect(BallId ballId, [In] ref AffixSealData[] affixSealDatas, ref List<BtlvEffectInstance> sealEffects, ref BtlvEffectInstance lightEffect)
	{
	}

	public List<BtlvEffectInstance> GetSealEffectInstances()
	{
		return null;
	}

	private void UpdateSRT()
	{
	}

	public Vector3 GetCalcTranslation()
	{
		return default(Vector3);
	}

	public Vector3 GetCalcScale()
	{
		return default(Vector3);
	}

	public Vector3 GetCalcRot()
	{
		return default(Vector3);
	}

	public void AttachModel(ITranslationObject iPtrObject, Transform joint, bool isFollowPos, bool isFollowRot, bool isFollowScl, bool followAnimScl, bool followLocalScl)
	{
	}

	public void DetachModel()
	{
	}
}
