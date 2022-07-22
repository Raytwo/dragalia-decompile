using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;

public class PokemonPlayable : MonoBehaviour
{
	public PlayableGraph _graph;

	public Playable _mixer;

	public AnimationPlayableOutput _output;

	private Animator _animator;

	public AvatarMask _avatarMask;

	public List<AnimationClip> _clips;

	private List<AnimationClipPlayable> _playables;

	private float _increase;

	private float _weight;

	private int _activePort;

	private RuntimeAnimatorController _savedAnimatorController;

	public int animationIndex
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public List<AnimationClip> clips => null;

	public bool isValid => default(bool);

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

	public AnimationClipPlayable GetPlayable()
	{
		return default(AnimationClipPlayable);
	}

	public void SetAnimationSpeed(int index, double speed)
	{
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void PlayAnimation(int index, float startTime = 0f)
	{
	}

	public void ChangeAnimation(int index, float duration = 0f, float startTime = 0f)
	{
	}

	private void OnUpdate(float deltaTime)
	{
	}

	public void CreatePlayables()
	{
	}
}
