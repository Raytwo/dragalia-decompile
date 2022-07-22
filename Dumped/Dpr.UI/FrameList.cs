using System;
using UnityEngine.UI;

namespace Dpr.UI;

[Serializable]
public class FrameList
{
	public enum ImageIndex
	{
		Image,
		Eff01,
		Eff02
	}

	public Image[] FrameUpLeft;

	public Image[] FrameUpRight;

	public Image[] FrameDownLeft;

	public Image[] FrameDownRight;

	public FrameList(Image[] images)
	{
	}
}
