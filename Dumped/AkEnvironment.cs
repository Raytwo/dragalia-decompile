using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AK.Wwise;
using UnityEngine;

public class AkEnvironment : MonoBehaviour
{
	public class AkEnvironment_CompareByPriority : IComparer<AkEnvironment>
	{
		public virtual int Compare(AkEnvironment a, AkEnvironment b)
		{
			return default(int);
		}
	}

	public class AkEnvironment_CompareBySelectionAlgorithm : AkEnvironment_CompareByPriority
	{
		public override int Compare(AkEnvironment a, AkEnvironment b)
		{
			return default(int);
		}
	}

	public const int MAX_NB_ENVIRONMENTS = 4;

	public static AkEnvironment_CompareByPriority s_compareByPriority;

	public static AkEnvironment_CompareBySelectionAlgorithm s_compareBySelectionAlgorithm;

	public bool excludeOthers;

	public bool isDefault;

	public AuxBus data;

	public int priority;

	[HideInInspector]
	[SerializeField]
	private int auxBusIdInternal;

	[HideInInspector]
	[SerializeField]
	private byte[] valueGuidInternal;

	public Collider Collider
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	[Obsolete]
	public int m_auxBusID => default(int);

	[Obsolete]
	public byte[] valueGuid => null;

	public void Awake()
	{
	}

	[Obsolete]
	public uint GetAuxBusID()
	{
		return default(uint);
	}

	[Obsolete]
	public Collider GetCollider()
	{
		return null;
	}
}
