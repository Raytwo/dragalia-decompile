using System.Collections.Generic;
using UnityEngine;
using XLSXContent;

namespace Dpr.MsgWindow;

public class MsgWindowDataContainer
{
	private Dictionary<int, RoadsignViewData> roadsignViewDataTable;

	private Dictionary<int, string> speakerNameTable;

	private Dictionary<int, uint> soundTagDataTable;

	private RoadsignTexData[] roadsignTextureArray;

	private Sprite[] windowFrameSprArray;

	private Sprite[] windowBGSprArray;

	private Sprite[] textureResourceArray;

	private Object[] assetResourceArray;

	private int loadedCount;

	public bool Loading => default(bool);

	public Dictionary<int, RoadsignViewData> RoadsignViewDataTable => null;

	public Dictionary<int, string> SpeakerNameTable => null;

	public Dictionary<int, uint> SoundTagDataTable => null;

	public Sprite[] WindowFrameSprArray => null;

	public Sprite[] WindowBGSprArray => null;

	public void Dispose()
	{
	}

	public Sprite GetCommonSprByIndex(int index)
	{
		return null;
	}

	public GameObject GetInstantiadedAssetByIndex(int index, Transform parent)
	{
		return null;
	}

	public void FormatMsgWindowData(MsgWindowData msgWindowData)
	{
	}

	private void CreateSpeakerNameTable(MsgWindowData.SheetSpeakerNameData[] speakerNameDatas)
	{
	}

	private void CreateRoadsignTextureArray(MsgWindowData.SheetRoadsignResourceData[] resourceDatas)
	{
	}

	private void CreateRoadsignViewDataTable(MsgWindowData.SheetRoadsignViewData[] viewDatas)
	{
	}

	private void CreateWindowFrameSprArray(MsgWindowData.SheetWindowFrameData[] windowFrameDatas)
	{
	}

	private void CreateWindowBGSprArray(MsgWindowData.SheetWindowBGData[] windowBGDatas)
	{
	}

	private void CreateTextureResourceArray(MsgWindowData.SheetTextureResourceData[] textureResourceData)
	{
	}

	private void CreateAssetResourceArray(MsgWindowData.SheetAssetResourceData[] assetResourceData)
	{
	}

	private void LoadAssetBundle(int dataIndex, string assetBundlePath)
	{
	}

	private void CreateSoundTagData(MsgWindowData.SheetSoundTagData[] soundTagData)
	{
	}
}
