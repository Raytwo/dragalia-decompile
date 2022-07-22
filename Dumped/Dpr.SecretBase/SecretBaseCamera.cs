using UnityEngine;

namespace Dpr.SecretBase;

public class SecretBaseCamera : MonoBehaviour
{
	[SerializeField]
	private Transform lookAt;

	[SerializeField]
	private Camera mainCamera;

	[SerializeField]
	private Camera pedestalCamera;

	[SerializeField]
	private SecretBaseMasterDataManager masterData;

	private int viewIndex;

	public void SetViewIndex(int index)
	{
	}

	public void IncrementViewIndex()
	{
	}

	public void ResetLookAt()
	{
	}

	public void TargetLookAt(PlacementData target)
	{
	}

	public void SetRenderTexture(RenderTexture texture)
	{
	}
}
