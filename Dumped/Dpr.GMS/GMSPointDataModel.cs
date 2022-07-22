using System.Runtime.InteropServices;
using UnityEngine;

namespace Dpr.GMS;

public class GMSPointDataModel : GMSPointData
{
	private Vector2 screenPos;

	private Vector3 normal;

	private int dataCount;

	private bool bIsView;

	private bool bHasData;

	public bool HasData => default(bool);

	public bool IsMaxData => default(bool);

	public int DataCount => default(int);

	public PointHistoryDataModel[] HistoryDataArray => null;

	public Vector3 Normal => default(Vector3);

	public bool IsView => default(bool);

	public Vector2 ScreenPos => default(Vector2);

	public void CreateData(ushort index, string pointTitle, [In] ref Vector3 point)
	{
	}

	public PointHistoryDataModel GetHistoryDataByIndex(int index)
	{
		return null;
	}

	public PointHistoryDataModel GetFirstHistoryData()
	{
		return null;
	}

	public void SetHistoryData(int index, PointHistoryDataModel newHistoryData)
	{
	}

	public void AddHistoryData(PointHistoryDataModel newHistoryData)
	{
	}

	public void ChangeMarkHistoryData(int index)
	{
	}

	public void DeleteHistoryData(int index)
	{
	}

	private void CheckHasHistoryData()
	{
	}

	public void SortHistoryData()
	{
	}

	public Sprite GetPointMarkIconSpr()
	{
		return null;
	}

	public void ChangeViewStatus(bool canView)
	{
	}

	public void SetScreenPosition(Vector2 screenPos)
	{
	}
}
