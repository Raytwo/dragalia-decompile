using System;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;

namespace Dpr.Playables;

[Serializable]
public class AnimationLayer
{
	[SerializeField]
	protected int _layerIndex;

	[SerializeField]
	protected AnimationClip[] _clips;

	[SerializeField]
	protected float _weight;

	[SerializeField]
	protected AvatarMask _avatarMask;

	[SerializeField]
	protected AnimationLayerBlending _blending;

	[SerializeField]
	protected float _animationSpeed;

	[SerializeField]
	protected bool _isForceLoop;

	protected int _currentIndex;

	protected int _activePort;

	protected float _increase;

	protected float _blendWeight;

	protected Animator _animator;

	protected AnimationMixerPlayable _animationMixer;

	protected AnimationClipPlayable[] _clipPlayables;

	public int LayerIndex
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public AnimationClip[] Clips
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public float Weight
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public AvatarMask AvatarMask
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public AnimationLayerBlending Blending
	{
		get
		{
			return default(AnimationLayerBlending);
		}
		set
		{
		}
	}

	public float AnimationSpeed
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public int CurrentIndex
	{
		get
		{
			return default(int);
		}
		private set
		{
		}
	}

	public bool IsForceLoop
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public AnimationMixerPlayable AnimationMixer => default(AnimationMixerPlayable);

	public AnimationClipPlayable CurrentPlayable => default(AnimationClipPlayable);

	public float CurrentPlayingTime => default(float);

	public float CurrentRemaingTime => default(float);

	public bool IsPlayingEnd => default(bool);

	public AnimationLayer Initialzie(Animator animator, PlayableGraph graph, int layerIndex = 0)
	{
		return null;
	}

	public void Destroy()
	{
	}

	public void OnUpdate(float deltaTime)
	{
	}

	public void Play(int index, float duration = 0f, float startTime = 0f)
	{
	}
}
