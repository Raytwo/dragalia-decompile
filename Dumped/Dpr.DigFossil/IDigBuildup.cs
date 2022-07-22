using System.Runtime.InteropServices;
using UnityEngine;

namespace Dpr.DigFossil;

public interface IDigBuildup
{
	void SetSprite([In] ref Sprite inMain, [In] ref Sprite inTop, [In] ref Sprite inUnder, [In] ref Sprite inTopCorner, [In] ref Sprite inUnderCorner);
}
