using UnityEngine;

public class FieldEyePaintingEntity : FieldEventEntity
{
	public enum EyePaintingType
	{
		NONE,
		FRONT,
		LEFT,
		RIGHT
	}

	public EyePaintingType EyePainting;

	public GameObject Painting;

	public EyePaintingType DefaultEyePainting;

	private EyePaintingType CurrentEyePainting;

	protected override void Awake()
	{
	}

	public void ChangeEyePainting()
	{
	}

	public void SetActivePaint(EyePaintingType type)
	{
	}
}
