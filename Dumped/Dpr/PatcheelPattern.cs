using System;
using UnityEngine;

namespace Dpr;

public class PatcheelPattern : MonoBehaviour
{
	[Serializable]
	public class UVData
	{
		public SkinnedMeshRenderer renderer;

		public Vector2[] UVs;

		public int value;
	}

	private const int PATCH_NUM = 4;

	private const int UV_TBL_SIZE = 256;

	public UVData[] UVDatas;

	public void Awake()
	{
	}

	public void SetPattern(uint personalRand = 1719155066u)
	{
	}

	public static void SetPattern(GameObject obj, uint personalRand)
	{
	}
}
