using System;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class AkRoomPortal : AkTriggerHandler
{
	public enum State
	{
		Closed,
		Open
	}

	public const int MAX_ROOMS_PER_PORTAL = 2;

	public State initialState;

	private bool active;

	public List<int> closePortalTriggerList;

	[SerializeField]
	private AkRoom[] rooms;

	private AkRoom.PriorityList[] roomList;

	private AkTransform portalTransform;

	private BoxCollider portalCollider;

	private bool portalSet;

	public bool portalActive
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	private ulong frontRoomID => default(ulong);

	private ulong backRoomID => default(ulong);

	public AkRoom frontRoom => null;

	public AkRoom backRoom => null;

	public bool IsValid => default(bool);

	public AkRoom GetRoom(int index)
	{
		return null;
	}

	private void SetRoomPortal()
	{
	}

	public void UpdateRoomPortal()
	{
	}

	public bool Overlaps(AkRoom room)
	{
		return default(bool);
	}

	public ulong GetID()
	{
		return default(ulong);
	}

	protected override void Awake()
	{
	}

	protected override void Start()
	{
	}

	public override void HandleEvent(GameObject in_gameObject)
	{
	}

	public void ClosePortal(GameObject in_gameObject)
	{
	}

	protected override void OnDestroy()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private bool IsRoomActive(AkRoom in_room)
	{
		return default(bool);
	}

	public void Open()
	{
	}

	public void Close()
	{
	}

	public void FindOverlappingRooms(AkRoom.PriorityList[] roomList)
	{
	}

	private void FillRoomList(Vector3 position, AkRoom.PriorityList list)
	{
	}

	public void UpdateRooms()
	{
	}

	[Obsolete]
	public void SetRoom(int in_roomIndex, AkRoom in_room)
	{
	}

	[Obsolete]
	public void SetFrontRoom(AkRoom room)
	{
	}

	[Obsolete]
	public void SetBackRoom(AkRoom room)
	{
	}

	[Obsolete]
	public void UpdateSoundEngineRoomIDs()
	{
	}

	[Obsolete]
	public void UpdateOverlappingRooms()
	{
	}
}
