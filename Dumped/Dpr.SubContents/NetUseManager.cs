using System;
using System.Collections;
using System.Collections.Generic;
using Dpr.NetworkUtils;
using SmartPoint.AssetAssistant;
using UnityEngine;

namespace Dpr.SubContents;

public abstract class NetUseManager<T> : SingletonMonoBehaviour<T> where T : SingletonMonoBehaviour<T>
{
	[Serializable]
	public class OPCNetTestPosition
	{
		public GameObject go;

		public float radius;

		public float speed;

		private Vector3 CurrentPos;

		private Vector3 InitPos;

		public OPCNetTestPosition(Vector3 InitPos)
		{
		}

		public void SetTsetPos()
		{
		}

		public Vector3 GetPos()
		{
			return default(Vector3);
		}
	}

	protected OpcManager _OpcManager;

	[SerializeField]
	private List<INetData> netDatas;

	protected SessionManager sessionManager;

	protected OnlinePlayerCharacter myPlayer;

	protected MatchingParam matchingParam;

	private NetRequestData netRequestData;

	private ZoneID[] enableZones;

	private MapType enableMapType;

	[Space]
	[SerializeField]
	private int createCharacterID;

	[SerializeField]
	private int destroyCharacterID;

	[SerializeField]
	private Vector3 nextPos;

	[SerializeField]
	private int saveCount;

	[SerializeField]
	private int curSaveCount;

	public int Button03;

	public int Button04;

	protected virtual IEnumerator Start()
	{
		return null;
	}

	protected abstract void Init();

	protected abstract void MyUpdate(float deltaTime);

	protected virtual void SetNetData(INetData netDatas)
	{
	}

	protected abstract IEnumerator LoadAsset();

	public abstract void SetMatchingParam(MatchingParam matchingParam);

	public void SetEnableZone(ZoneID[] enableZones)
	{
	}

	public void SetEnableZone(MapType mapType)
	{
	}

	private void OnZoneChange()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	protected virtual void OnReceiveData(INetData netData)
	{
	}

	protected virtual void OnSessionEvent(SessionEventData eventData)
	{
	}

	protected void RequestNetData(byte dataID)
	{
	}

	public void Talk()
	{
	}

	public void _Debug_RemoveNetCharacter()
	{
	}

	public void _Debug_SaveCharacterPosition()
	{
	}

	private bool CheckSavePosCount()
	{
		return default(bool);
	}
}
