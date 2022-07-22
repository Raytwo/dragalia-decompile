using System.Collections.Generic;
using Audio;
using UnityEngine;

public class AudioAmbient : MonoBehaviour
{
	[SerializeField]
	private uint _playEventId;

	[SerializeField]
	private List<Vector3> _positions;

	protected AudioInstance _audioInstance;

	protected virtual void Start()
	{
	}

	protected virtual void Play()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	protected virtual void Update()
	{
	}

	protected float DistanceSqLinePoint(Vector3 l0, Vector3 l1, Vector3 p, out Vector3 crossPos)
	{
		return default(float);
	}

	public void SetSwitch(uint groupId, uint state)
	{
	}
}
