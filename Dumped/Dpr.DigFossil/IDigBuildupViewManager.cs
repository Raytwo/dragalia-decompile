using System.Runtime.InteropServices;
using UnityEngine;

namespace Dpr.DigFossil;

public interface IDigBuildupViewManager
{
	void Initialize([In] ref int[,] map);

	Sprite GetSprite(int durability);

	void ApplyDurability([In] ref int[,] map);
}
