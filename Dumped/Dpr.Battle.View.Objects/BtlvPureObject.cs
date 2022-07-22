using System;
using Dpr.SequenceEditor;
using UnityEngine;

namespace Dpr.Battle.View.Objects;

public class BtlvPureObject : ITranslationObject, IDisposable
{
	private Vector3 _translation;

	private Vector3 _translationOffset;

	private Vector3 _scale;

	private Vector3 _scaleOffset;

	private Vector3 _rotVec;

	private Vector3 _rotVecOffset;

	protected bool _isSuspendUpdate;

	protected string _name;

	protected PokeFollowInfo _pokeFollowInfo;

	protected BtlvObjectFollowInfo _objectFollowInfo;

	public virtual void Dispose()
	{
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

	public virtual bool IsActive()
	{
		return default(bool);
	}

	public virtual void OnUpdatePreJob(float deltaTime)
	{
	}

	public virtual void OnUpdatePostJob(float deltaTime)
	{
	}

	protected virtual void UpdateSRT()
	{
	}

	public Vector3 GetCalcTranslation()
	{
		return default(Vector3);
	}

	public Vector3 GetCalcRot()
	{
		return default(Vector3);
	}

	public Vector3 GetCalcScale()
	{
		return default(Vector3);
	}

	public void AttachPoke(BOPokemon pokemon, SEQ_DEF_NODE node, bool isFollowRot, bool isFollowScl, bool isFollowAnimRot)
	{
	}

	public void DetachPoke()
	{
	}

	public void AttachModel(ITranslationObject iPtrObject, Transform joint, bool isFollowPos, bool isFollowRot, bool isFollowScl, bool followAnimScl, bool followLocalScl)
	{
	}

	public void DetachModel()
	{
	}
}
