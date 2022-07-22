using UnityEngine;

namespace Dpr.DigFossil;

public class DigCameraManager : MonoBehaviour
{
	public enum CameraSet
	{
		Game,
		ItemResult,
		BoxResult
	}

	[SerializeField]
	private Camera mainCamera;

	[SerializeField]
	private DigStatueCameraSelector resultCamera;

	public void SetCamera(CameraSet set)
	{
	}
}
