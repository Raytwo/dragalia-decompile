using System.Collections;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

namespace Dpr.DigFossil;

public class DigCameraShaker : MonoBehaviour, IDigCameraShaker
{
	[SerializeField]
	private Transform targetCamera;

	private Vector3 defaultPosition;

	private Tweener tweenHandler;

	public bool IsEnable
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

	public void DoShake(float strength, float period)
	{
	}

	private IEnumerator OnEnd(float period)
	{
		return null;
	}

	private void Start()
	{
	}
}
