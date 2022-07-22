using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.U2D;

namespace Dpr.DigFossil;

public class DigBuildupViewManager : MonoBehaviour, IDigBuildupViewManager
{
	private static class Bit
	{
		private const int BUILDUP_TOP_BIT = 1;

		private const int BUILDUP_UNDER_BIT = 16;

		private const int BUILDUP_TOP_CORNER_BIT = 256;

		private const int BUILDUP_UNDER_CORNER_BIT = 4096;

		private const int SHIFT_LEFT = 0;

		private const int SHIFT_RIGHT = 1;

		private const int SHIFT_UP = 2;

		private const int SHIFT_DOWN = 3;

		private const int SHIFT_LEFT_UP = 0;

		private const int SHIFT_LEFT_DOWN = 1;

		private const int SHIFT_RIGHT_UP = 2;

		private const int SHIFT_RIGHT_DOWN = 3;

		public static uint Top => default(uint);

		public static uint TopLeft => default(uint);

		public static uint TopRight => default(uint);

		public static uint TopUp => default(uint);

		public static uint TopDown => default(uint);

		public static uint Under => default(uint);

		public static uint UnderLeft => default(uint);

		public static uint UnderRight => default(uint);

		public static uint UnderUp => default(uint);

		public static uint UnderDown => default(uint);

		public static uint TopCorner => default(uint);

		public static uint TopCornerLeftUp => default(uint);

		public static uint TopCornerLeftDown => default(uint);

		public static uint TopCornerRightUp => default(uint);

		public static uint TopCornerRightDown => default(uint);

		public static uint UnderCorner => default(uint);

		public static uint UnderCornerLeftUp => default(uint);

		public static uint UnderCornerLeftDown => default(uint);

		public static uint UnderCornerRightUp => default(uint);

		public static uint UnderCornerRightDown => default(uint);

		public static uint TopLeftUp => default(uint);

		public static uint TopLeftDown => default(uint);

		public static uint TopRightUp => default(uint);

		public static uint TopRightDown => default(uint);

		public static uint UnderLeftUp => default(uint);

		public static uint UnderLeftDown => default(uint);

		public static uint UnderRightUp => default(uint);

		public static uint UnderRightDown => default(uint);
	}

	[SerializeField]
	private GameObject buildupPrefab;

	[SerializeField]
	private List<Sprite> sprites;

	[SerializeField]
	private SpriteAtlas atlas;

	private IDigBuildup[,] buildups;

	private const int BUILDUP_DURABILITY_BOUNDARY = 3;

	public void Initialize([In] ref int[,] map)
	{
	}

	public Sprite GetSprite(int durability)
	{
		return null;
	}

	public void ApplyDurability([In] ref int[,] inMap)
	{
	}

	public void GetTexture([In] ref int[,] inMap, int x, int y, out Sprite outMain, out Sprite outTop, out Sprite outUnder, out Sprite outTopCorner, out Sprite outUnderCorner)
	{
	}

	private bool IsCheckUnderBuildup(int durability)
	{
		return default(bool);
	}

	private bool IsCheckTopBuildup(int durability)
	{
		return default(bool);
	}

	void IDigBuildupViewManager.Initialize([In] ref int[,] map)
	{
	}

	void IDigBuildupViewManager.ApplyDurability([In] ref int[,] map)
	{
	}
}
