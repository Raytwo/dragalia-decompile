using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLSXContent;

namespace Dpr.UnderGround;

public class UgFieldDataManager
{
	public struct FossilPosData
	{
		public ZoneID zoneID;

		public UnderGroundFossilPos.SheetData[] PosDataList;

		public FossilPosData(UnderGroundFossilPos.SheetData[] data)
		{
		}

		public Vector2Int GetRandomPos(int pointNo)
		{
			return default(Vector2Int);
		}

		public bool CheckWallPos(Vector2Int grid, out DIR wallDir)
		{
			return default(bool);
		}

		public DIR CheckRightOrLeft(Vector2Int wallGrid)
		{
			return default(DIR);
		}
	}

	public List<FossilPosData> FossilPosDataList;

	public List<UnderGroundFossilNum.SheetData> FossilNumData;

	private const string Path_MasterData = "masterdata";

	public Object[] SecretBaseHoles;

	public Object Hyouta;

	public void Destroy()
	{
	}

	public Object GetSecretBaseObject()
	{
		return null;
	}

	public IEnumerator LoadMD()
	{
		return null;
	}

	public IEnumerator LoadAsset()
	{
		return null;
	}
}
