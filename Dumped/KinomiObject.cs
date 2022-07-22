using UnityEngine;

public class KinomiObject
{
	public enum ObjectType
	{
		Soil,
		Seeding,
		Wet,
		Growed,
		GrowedMiki,
		GrowedHana,
		GrowedMi,
		Max
	}

	public Transform Parent;

	public int TagNo;

	private GameObject[] Objects;

	private static readonly string[] GrowedObjectName;

	private KinomiResources KinomiResources => null;

	public void SetGrowPhase(KinomiWork.GrowPhase grouPhase, bool isWet)
	{
	}

	public void Invisible()
	{
	}

	public void Visible(ObjectType type)
	{
	}

	public void Destroy()
	{
	}

	public void Setup(ObjectType type)
	{
	}

	private void SetParent(GameObject gameObject)
	{
	}
}
