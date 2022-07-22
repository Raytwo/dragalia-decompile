using System.Collections;
using UnityEngine;

public class FieldAnimeCamera : MonoBehaviour
{
	public static FieldAnimeCamera instance;

	private Camera _camera;

	private Animator _animator;

	private bool _isPlay;

	private new Transform transform;

	private string assetbundleName;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public float GetFov()
	{
		return default(float);
	}

	public float GetFocalLength()
	{
		return default(float);
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

	public void LoadRuntimeAnimatorController(string assetname)
	{
	}

	public void ReleaseSetRuntimeAnimatorController()
	{
	}

	private IEnumerator Load(string assetname)
	{
		return null;
	}

	public bool IsNull()
	{
		return default(bool);
	}

	private void UnloadAsset()
	{
	}
}
