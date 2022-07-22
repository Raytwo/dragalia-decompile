using System;
using UnityEngine;

namespace AK.Wwise;

[Serializable]
public abstract class BaseGroupType : BaseType
{
	[HideInInspector]
	[SerializeField]
	private int groupIdInternal;

	[HideInInspector]
	[SerializeField]
	private byte[] groupGuidInternal;

	public WwiseObjectReference GroupWwiseObjectReference => null;

	public abstract WwiseObjectType WwiseObjectGroupType { get; }

	public uint GroupId => default(uint);

	[Obsolete]
	public int groupID => default(int);

	[Obsolete]
	public byte[] groupGuid => null;

	public override bool IsValid()
	{
		return default(bool);
	}
}
