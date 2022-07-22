using FieldDoor;
using UnityEngine;

public class FieldEventDoorEntity : FieldEventEntity
{
	public StartVectol startVectol;

	public string connectionName;

	public DoorType doorType;

	public bool doorEnable;

	public CallLabel callLabel;

	public ExitLabel exitLabel;

	[HideInInspector]
	public int[] locatorArray;

	[HideInInspector]
	public int[] mdIndexArray;

	public override string entityType => null;
}
