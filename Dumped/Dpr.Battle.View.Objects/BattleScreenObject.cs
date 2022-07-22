using UnityEngine;

namespace Dpr.Battle.View.Objects;

public sealed class BattleScreenObject : BtlvBehaviour
{
	public enum CameraType
	{
		ScreenEffect,
		ForeFrontEffect
	}

	[SerializeField]
	private Camera[] _cameras;

	private RefCounted[] _refCounteds;

	public void Initialize(Transform cluster)
	{
	}

	public void UnInitialize()
	{
	}

	public Camera GetCamera(CameraType type)
	{
		return null;
	}

	public void Release(CameraType type)
	{
	}

	public void AllReleaseForce()
	{
	}
}
