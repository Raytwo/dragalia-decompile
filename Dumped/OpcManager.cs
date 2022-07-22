using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Dpr.NetworkUtils;
using SmartPoint.AssetAssistant;
using UnityEngine;
using XLSXContent;

public abstract class OpcManager
{
	[Serializable]
	public struct CharaData
	{
		public int stationIndex;

		public string assetName;

		public int colorId;

		public int avatarId;

		public int sexId;

		public int cassetVersion;
	}

	protected const int INVALID_CHARAID = -1;

	protected const string ASSET_PASS_FIELD = "persons/field/";

	[SerializeField]
	protected List<OpcController> _OpcControllers;

	[SerializeField]
	protected List<OpcController> _CopyOpcControllers;

	public Action<byte> _RequestNetDataCallback;

	[Space]
	[Space]
	[SerializeField]
	private int _CreateMaxCharacterCount;

	public UnionCharacterTable.SheetSheet1[] _DataTable
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public UnionNpcColorTable.SheetSheet1[] _ColorDataTable
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public int characterCreateCount
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public void Init()
	{
	}

	public virtual void Destroy()
	{
	}

	public void SetDataTable(UnionCharacterTable.SheetSheet1[] table)
	{
	}

	public void SetNpcColorDataTable(UnionNpcColorTable.SheetSheet1[] table)
	{
	}

	public bool IsOverCreateCount()
	{
		return default(bool);
	}

	public void SetRequestNetDataCallBack(Action<byte> RequestNetData)
	{
	}

	public virtual void SetNetData(INetData netData)
	{
	}

	protected CharaData CreateCharaData(ANetData<JoinData> netJoinData)
	{
		return default(CharaData);
	}

	public OpcController GetOpc(int id)
	{
		return null;
	}

	public int GetSexId(int id)
	{
		return default(int);
	}

	public CharaData GetCharaData(int id)
	{
		return default(CharaData);
	}

	private int GetNpcColorId(int avaterId)
	{
		return default(int);
	}

	protected IEnumerator OpLoadCharacter(string path, RequestEventCallback callback)
	{
		return null;
	}

	public abstract void CreateCharacter(INetData data);

	public virtual void RemoveCharacter(int stationIndex, bool isGameObjectDestroy = true)
	{
	}

	public void RemoveAllCharacter()
	{
	}

	public void SetCopyOpcCharaController(List<OpcController> opcCharacterControllers)
	{
	}

	public List<OpcController> GetCopyOpcCharaController()
	{
		return null;
	}

	public void ChangeOpcState(OpcState.OnlineState state)
	{
	}

	public void CreateEmoticon(NetEmotionData data)
	{
	}

	public List<OpcController> GetOpcControllerList()
	{
		return null;
	}

	public void TargetOpcTalk(int targetIndex)
	{
	}

	public void AddPosition(int index, Vector2 pos, float rotY)
	{
	}

	private int GetOpcSexId(int avaterId)
	{
		return default(int);
	}
}
