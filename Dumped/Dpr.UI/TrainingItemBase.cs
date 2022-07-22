using UnityEngine;

namespace Dpr.UI;

public class TrainingItemBase : MonoBehaviour
{
	protected static readonly int animState0Normal;

	protected static readonly int animState0Select;

	protected static readonly int animState1Enable;

	protected static readonly int animState1Disable;

	public int index;

	protected Animator _animator;

	protected bool _isEnabled;

	protected bool _isSelected;

	public bool isEnabled => default(bool);

	protected virtual void Awake()
	{
	}

	public virtual void Setup()
	{
	}

	public virtual void Select(bool enabled)
	{
	}

	public virtual void Enable(bool enabled)
	{
	}
}
