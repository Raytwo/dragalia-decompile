using System;
using UnityEngine;

namespace AK.Wwise;

[Serializable]
public abstract class BaseType
{
	[HideInInspector]
	[SerializeField]
	private int idInternal;

	[HideInInspector]
	[SerializeField]
	private byte[] valueGuidInternal;

	public abstract WwiseObjectReference ObjectReference { get; set; }

	public abstract WwiseObjectType WwiseObjectType { get; }

	public virtual string Name => null;

	public uint Id => default(uint);

	public static uint InvalidId => default(uint);

	[Obsolete]
	public int ID => default(int);

	[Obsolete]
	public byte[] valueGuid => null;

	public virtual bool IsValid()
	{
		return default(bool);
	}

	public bool Validate()
	{
		return default(bool);
	}

	protected void Verify(AKRESULT result)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
