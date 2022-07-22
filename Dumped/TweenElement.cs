using System;
using DG.Tweening;
using UnityEngine;

[Serializable]
public class TweenElement
{
	[SerializeField]
	public AnimationType animationType;

	[SerializeField]
	public Transform target;

	[SerializeField]
	public Ease easeType;

	[SerializeField]
	public Vector3 value;

	[SerializeField]
	public float delay;

	[SerializeField]
	public float duration;

	[NonSerialized]
	public Tween tween;
}
