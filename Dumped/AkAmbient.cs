using System.Collections.Generic;
using UnityEngine;

public class AkAmbient : AkEvent
{
	public static Dictionary<uint, AkMultiPosEvent> multiPosEventTree;

	public AkMultiPositionType MultiPositionType;

	public MultiPositionTypeLabel multiPositionTypeLabel;

	public AkAmbientLargeModePositioner[] LargeModePositions;

	[HideInInspector]
	[SerializeField]
	public List<Vector3> multiPositionArray;

	private void OnEnable()
	{
	}

	protected override void Start()
	{
	}

	private void OnDisable()
	{
	}

	public override void HandleEvent(GameObject in_gameObject)
	{
	}

	public void OnDrawGizmosSelected()
	{
	}

	public AkPositionArray BuildMultiDirectionArray(AkMultiPosEvent eventPosList)
	{
		return null;
	}

	private AkPositionArray BuildAkPositionArray()
	{
		return null;
	}
}
