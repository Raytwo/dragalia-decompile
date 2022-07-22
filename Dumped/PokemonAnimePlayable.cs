using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;

public class PokemonAnimePlayable : MonoBehaviour
{
	public string[] mStates;

	private PlayableGraph graph;

	private AnimationPlayableOutput output;

	private AnimationClipPlayable clipPlayable;

	private AnimationClipPlayable clipPlayableLoop;

	[HideInInspector]
	public AnimationLayerMixerPlayable layer;

	[SerializeField]
	public AnimationClip[] clips;

	[SerializeField]
	private AnimationClip cliploop;

	[SerializeField]
	private AvatarMask avatarMask;

	private float mTime;

	private bool pauseFlag;

	private Animator animator;

	private AnimatorCallEvent callEvent;

	public void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void ChangeAnimation(string animName)
	{
	}

	public float GetAnimationLength(string animName)
	{
		return default(float);
	}

	public AnimationClipPlayable GetCurrentAnimationClipPlayable()
	{
		return default(AnimationClipPlayable);
	}

	public bool IsLooping(string animName)
	{
		return default(bool);
	}

	public void SetPauseFrame(bool pFlag, float time = 0f)
	{
	}

	private void OnDestroy()
	{
	}
}
