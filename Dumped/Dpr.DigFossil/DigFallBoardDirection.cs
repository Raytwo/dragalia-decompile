using System;
using UnityEngine;

namespace Dpr.DigFossil;

public class DigFallBoardDirection : MonoBehaviour
{
	[SerializeField]
	private RectTransform curtain;

	[SerializeField]
	private float fallSpeed;

	private Action onFinishDirection;

	private Vector3 defaultRootPos;

	private Vector3 velocity;

	private bool isCompleted;

	public void Initialize()
	{
	}

	public void OnUpdate()
	{
	}

	public void StartDirection(Action onFinishDirection)
	{
	}

	public void SetActive(bool bisActive)
	{
	}

	public float GetDirectionTime()
	{
		return default(float);
	}

	private void Start()
	{
	}
}
