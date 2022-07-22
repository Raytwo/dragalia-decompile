using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;

[Serializable]
public class AnimationPlayer
{
	private PlayableGraph _graph;

	private Playable _mixer;

	private AnimationPlayableOutput _output;

	private Animator _animator;

	private AnimationClipPlayable[] _playables;

	private float _increase;

	private float _weight;

	private int _activePort;

	private RuntimeAnimatorController _savedAnimatorController;

	[SerializeField]
	private AnimationClip[] _clips;

	[SerializeField]
	private AvatarMask _avatarMask;

	[SerializeField]
	private AnimationClip _layerClip;

	[SerializeField]
	private AvatarMask _additiveAvatarMask;

	[SerializeField]
	private AnimationClip _additiveLayerClip;

	private int _additiveLayerIndex;

	private AnimationClipPlayable _layerClipPlayable;

	private AnimationClipPlayable _additiveClipPlayable;

	public AnimationClip[] clips
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public AvatarMask avatarMask
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public AnimationClip layerClip
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public AvatarMask additiveAvatarMask
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public AnimationClip additiveLayerClip
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int currentIndex
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool forceLoop
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

	public bool forcePlay
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

	public AnimationClipPlayable currentPlayable => default(AnimationClipPlayable);

	public float currentPlayingTime => default(float);

	public float currentRemaingTime => default(float);

	public float layerWeight
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public bool IsValidCurrentPlayable => default(bool);

	public bool IsPlayingEnd => default(bool);

	public bool IsPlaying => default(bool);

	public AnimationClipPlayable layerClipPlayable => default(AnimationClipPlayable);

	public AnimatorCullingMode cullingMode
	{
		get
		{
			return default(AnimatorCullingMode);
		}
		set
		{
		}
	}

	public void InitializePlayables(Animator animator)
	{
	}

	public void Destroy()
	{
	}

	public void AdvanaceTime(float deltaTime)
	{
	}

	public void Play(int index, float duration = 0f, float startTime = 0f)
	{
	}

	public void Stop()
	{
	}

	public void Resume()
	{
	}

	public void SetSpeed(float speed)
	{
	}

	public void SetTimeUpdateMode(DirectorUpdateMode mode)
	{
	}

	public void SetAdditiveLayerTime(float time)
	{
	}

	public void Evalute()
	{
	}

	public void PlayFrame(int index, float duration = 0f, float startFrame = 0f, bool forceplay = false)
	{
	}

	public void SetAnimSpeed(float speed)
	{
	}

	public void ResetAnimSpeed()
	{
	}

	public void RePlay(float startFrame = 0f)
	{
	}
}
