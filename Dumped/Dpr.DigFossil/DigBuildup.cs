using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.DigFossil;

public class DigBuildup : MonoBehaviour, IDigBuildup
{
	[SerializeField]
	private Image main;

	[SerializeField]
	private Image top;

	[SerializeField]
	private Image under;

	[SerializeField]
	private Image topCorner;

	[SerializeField]
	private Image underCorner;

	public void SetSprite([In] ref Sprite inMain, [In] ref Sprite inTop, [In] ref Sprite inUnder, [In] ref Sprite inTopCorner, [In] ref Sprite inUnderCorner)
	{
	}

	private void SetTexture(ref Image refImage, [In] ref Sprite inSprite)
	{
	}

	void IDigBuildup.SetSprite([In] ref Sprite inMain, [In] ref Sprite inTop, [In] ref Sprite inUnder, [In] ref Sprite inTopCorner, [In] ref Sprite inUnderCorner)
	{
	}
}
