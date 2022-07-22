using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Dpr.FureaiHiroba;
using Dpr.SubContents;
using Pml;
using UnityEngine;

namespace Dpr.Field.Walking;

public class WalkingCharacterController : MonoBehaviour
{
	public WalkingCharacterModel model;

	public WalkingCharacterView view;

	public AI AI;

	protected PokeEffect effectManager;

	public Emoticon emoticon;

	public bool isChousei;

	public Func<List<FureaiPokeModel>> getWalkingCharacters;

	public VoicePlayerAmbient voicePlayer;

	public bool isFureai;

	public bool isFieldWalking;

	public bool isSubWalking;

	public float bodySize;

	public float walkDistance;

	public float runDistance;

	public float walkSpeed;

	public float runSpeed;

	public float nowSpeed;

	public float nowDistance;

	public bool nowRunMode;

	public float targetDistance;

	public float targetDistanceOffset;

	public GameObject DebugBodySizeView;

	public int Button05;

	public int DebugAnimIndex;

	public int Button06;

	public int Button07;

	public WalkData walkModel => null;

	public event Action<int> NeedEffect
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	protected void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void PlayVoice(MonsNo monsNo, int formNo, int voiceNo)
	{
	}

	public virtual void SetModel(WalkingCharacterModel model)
	{
	}

	public virtual AIModel CreateAIModel()
	{
		return null;
	}

	public virtual void AISetting()
	{
	}

	public void SetView(WalkingCharacterView view)
	{
	}

	protected virtual void OnNeedEffect(int EffectID)
	{
	}

	protected virtual void ModelUpdate(float deltaTime)
	{
	}

	public virtual void MyUpdate(float deltaTime)
	{
	}

	public virtual void CheckAttribute()
	{
	}

	protected virtual List<FureaiPokeModel> GetWalkingCharacters()
	{
		return null;
	}

	public virtual void MyLateUpdate(float deltaTime)
	{
	}

	protected void Chousei()
	{
	}

	public void ChangePositionNPC()
	{
	}

	public void TestAnim()
	{
	}

	public void InitAnimationPlayer()
	{
	}
}
