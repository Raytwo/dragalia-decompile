using UnityEngine;

namespace Dpr.Contest;

public class BarLine : MonoBehaviour
{
	private const float OVER_LIFE_TIME = 2f;

	private RectTransform rect;

	private Vector3 iconPos;

	private float arriveSec;

	private float lifeTime;

	private float resetTime;

	private float moveSpeed;

	public void Create(float arriveSec, float moveSpeed, float resetTime)
	{
	}

	public void ResetParam(float arriveSec, float resetTime)
	{
	}

	public void OnUpdate(float elapsedTime)
	{
	}

	private void UpdatePosition(float lifeTime)
	{
	}

	private void SetActive(bool active)
	{
	}
}
