using UnityEngine;

namespace Dpr.Contest;

public sealed class StageModelObject
{
	public GameObject modelObj;

	private AudienceGenerator generator;

	private Transform modelTransform;

	public Vector3 Position => default(Vector3);

	public StageModelObject(GameObject modelObj)
	{
	}

	public void MovePosition(float moveX, Camera camera)
	{
	}

	public void SetAudienceUpdateFlag(bool flag)
	{
	}

	public void Dispose()
	{
	}
}
