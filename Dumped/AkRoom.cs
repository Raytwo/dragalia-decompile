using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AK.Wwise;
using UnityEngine;

[DisallowMultipleComponent]
public class AkRoom : AkTriggerHandler
{
	public class PriorityList
	{
		private class CompareByPriority : IComparer<AkRoom>
		{
			public virtual int Compare(AkRoom a, AkRoom b)
			{
				return default(int);
			}
		}

		private static readonly CompareByPriority s_compareByPriority;

		private List<AkRoom> rooms;

		public int Count => default(int);

		public AkRoom this[int index] => null;

		public ulong GetHighestPriorityActiveAndEnabledRoomID()
		{
			return default(ulong);
		}

		public AkRoom GetHighestPriorityActiveAndEnabledRoom()
		{
			return null;
		}

		public void Clear()
		{
		}

		public void Add(AkRoom room)
		{
		}

		public void Remove(AkRoom room)
		{
		}

		public bool Contains(AkRoom room)
		{
			return default(bool);
		}

		public int BinarySearch(AkRoom room)
		{
			return default(int);
		}
	}

	public static ulong INVALID_ROOM_ID;

	public int priority;

	public AuxBus reverbAuxBus;

	public float reverbLevel;

	public float wallOcclusion;

	public AK.Wwise.Event roomToneEvent;

	public float roomToneAuxSend;

	private List<AkRoomAwareObject> roomAwareObjectsEntered;

	private List<AkRoomAwareObject> roomAwareObjectsDetectedWhileDisabled;

	public static int RoomCount
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static ulong GetAkRoomID(AkRoom room)
	{
		return default(ulong);
	}

	public bool TryEnter(AkRoomAwareObject roomAwareObject)
	{
		return default(bool);
	}

	public void Exit(AkRoomAwareObject roomAwareObject)
	{
	}

	public ulong GetID()
	{
		return default(ulong);
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnTriggerEnter(Collider in_other)
	{
	}

	private void OnTriggerExit(Collider in_other)
	{
	}

	public override void HandleEvent(GameObject in_gameObject)
	{
	}
}
