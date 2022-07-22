using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class FieldEventEntity : FieldObjectEntity
{
	public enum ShapeType
	{
		None,
		Box,
		Circle
	}

	public enum CorrectionDir
	{
		Up,
		Down,
		Left,
		Right
	}

	public ShapeType shapeType;

	public float radius;

	public Vector2 offset;

	public Vector2 size;

	[SearchableEnum]
	public ZoneID transitionZone;

	public int locatorIndex;

	public bool playOnAwake;

	public int clipIndex;

	public List<TweenClip> clips;

	protected bool checkHeight;

	private Animator _animator;

	private PlayableGraph _graph;

	private PlayableOutput _output;

	public CorrectionDir correctionDir;

	[SerializeField]
	private bool isLandingEntity;

	private bool _hit;

	public override string entityType => null;

	public bool isCompleted => default(bool);

	protected override void Awake()
	{
	}

	protected override void OnUpdate(float deltaTime)
	{
	}

	protected override void OnLateUpdate(float deltaTime)
	{
	}

	public void Play(int index)
	{
	}

	public void ForceAnimeEnd(int index)
	{
	}

	public void RewindAll()
	{
	}

	public void Rewind(int index)
	{
	}

	protected override void OnDestroy()
	{
	}

	protected override void ProcessSequence(float deltaTime)
	{
	}
}
