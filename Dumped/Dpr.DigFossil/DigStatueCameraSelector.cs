using System.Collections.Generic;
using UnityEngine;
using XLSXContent;

namespace Dpr.DigFossil;

public class DigStatueCameraSelector : MonoBehaviour, IDigStatueCameraSelector
{
	[SerializeField]
	private Camera camBox;

	[SerializeField]
	private List<Camera> statueCamera;

	private Camera currentCamera;

	public void SetCamera(StatueEffectRawData.Sheettable data)
	{
	}

	public void SwitchBoxCamera(bool isBox)
	{
	}

	private void ResetPostEffect(Camera camera)
	{
	}

	public void SetActive(bool isActive)
	{
	}
}
