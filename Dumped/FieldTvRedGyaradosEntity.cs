using UnityEngine;

public class FieldTvRedGyaradosEntity : FieldEventEntity
{
	protected static readonly int ID_BLINKCYCLE;

	protected static readonly int ID_SCROLLSPEED;

	protected static readonly int ID_LINEALPHA;

	private Material MonitorMaterial;

	protected override void Awake()
	{
	}

	protected override void OnEnable()
	{
	}

	protected override void OnDisable()
	{
	}

	public static FieldTvRedGyaradosEntity GetTvRedGyarados()
	{
		return null;
	}

	public void SetActive(bool active)
	{
	}

	private void SetMaterialProperty(int property, float value)
	{
	}
}
