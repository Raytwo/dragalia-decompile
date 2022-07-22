using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

[Serializable]
public class TweenClip
{
	[SerializeField]
	public string name;

	[SerializeField]
	public List<TweenElement> elements;

	[SerializeField]
	public AnimationClip animationClip;

	private Sequence sequence;

	public bool isComplete => default(bool);

	public void Build(Transform root)
	{
	}

	public void Destroy()
	{
	}

	public void Play()
	{
	}

	public void Rewind()
	{
	}
}
