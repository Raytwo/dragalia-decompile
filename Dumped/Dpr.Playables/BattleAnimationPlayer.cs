using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;

namespace Dpr.Playables;

[Serializable]
public class BattleAnimationPlayer
{
	public enum LayerIndex
	{
		BaseLayer,
		EyeLayer
	}

	private const int LAYER_NUM = 2;

	[SerializeField]
	protected AnimationLayer _baseLayer;

	[SerializeField]
	protected AnimationLayer _eyeLayer;

	protected List<AnimationLayer> _animationLayers;

	protected Animator _animator;

	protected PlayableGraph _graph;

	protected AnimationPlayableOutput _output;

	protected AnimationLayerMixerPlayable _layerMixer;

	[SerializeField]
	protected float _animationMasterSpeed;

	public void Initialize(Animator animator)
	{
	}

	public void Destroy()
	{
	}

	public void AdvanaceTime(float deltaTime)
	{
	}

	public AnimationLayer GetAnimationLayer(LayerIndex layers)
	{
		return null;
	}

	public void SetAnimSpeed(float animSpeed)
	{
	}

	public float GetAnimSpeed()
	{
		return default(float);
	}
}
