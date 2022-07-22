using UnityEngine;

namespace Dpr.UI;

public class NowloadingController : MonoBehaviour
{
	[SerializeField]
	private Animator _animatorLoading;

	private float _waitTime;

	private float _progressTime;

	private bool _isWaiting;

	private void Awake()
	{
	}

	public void Open(float waitTime = 5f, int sortOrder = 16390)
	{
	}

	public void Close()
	{
	}

	private void Setup(float waitTime = 5f, int sortOrder = 16390)
	{
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void SetActive(bool active)
	{
	}
}
