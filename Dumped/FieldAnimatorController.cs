using UnityEngine;

public class FieldAnimatorController : MonoBehaviour
{
	private Animator _animator;

	private bool _isPlay;

	private new Transform transform;

	private Transform _returnParent;

	public void SetChild(Transform tran)
	{
	}

	public Transform GetReturnParent()
	{
		return null;
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void Play(string statename)
	{
	}

	public void Stop()
	{
	}

	public void OnStateMachineExit()
	{
	}

	public bool IsPlay()
	{
		return default(bool);
	}

	public bool IsPlay(string statename)
	{
		return default(bool);
	}

	public bool Ready()
	{
		return default(bool);
	}

	public Animator GetAnimator()
	{
		return null;
	}
}
