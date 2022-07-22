using System;
using System.Collections;
using System.Collections.Generic;
using SmartPoint.AssetAssistant;
using UnityEngine;
using XLSXContent;

public class OpcFactry : MonoBehaviour
{
	[Serializable]
	public struct CharaData
	{
		public int stationIndex;

		public string assetName;

		public int colorId;

		public int avatarId;
	}

	private const string ASSET_PASS_FIELD = "persons/field/";

	[SerializeField]
	private List<OpcController> _OpcControllers;

	[SerializeField]
	private UnionCharacterTable.SheetSheet1[] _DataTable;

	[SerializeField]
	private int _CreateMaxCharacterCount;

	private IEnumerator OpLoadCharacter(string path, RequestEventCallback callback)
	{
		return null;
	}

	public void RemoveCharacter(int stationIndex)
	{
	}

	private OpcController GetOpc(int id)
	{
		return null;
	}

	public bool IsOverCreateCount()
	{
		return default(bool);
	}
}
