using System;
using AK.Wwise;
using UnityEngine;

[DefaultExecutionOrder(/*Could not decode attribute arguments.*/)]
public class AkSwitch : AkDragDropTriggerHandler
{
	public Switch data;

	[HideInInspector]
	[SerializeField]
	private int valueIdInternal;

	[HideInInspector]
	[SerializeField]
	private int groupIdInternal;

	[HideInInspector]
	[SerializeField]
	private byte[] valueGuidInternal;

	[HideInInspector]
	[SerializeField]
	private byte[] groupGuidInternal;

	protected override BaseType WwiseType => null;

	[Obsolete]
	public int valueID => default(int);

	[Obsolete]
	public int groupID => default(int);

	[Obsolete]
	public byte[] valueGuid => null;

	[Obsolete]
	public byte[] groupGuid => null;

	public override void HandleEvent(GameObject in_gameObject)
	{
	}
}
