using UnityEngine;

public class Snowfield : ProceduralPlane
{
	protected static readonly int ID_HEIGHT_MAP;

	protected static readonly int ID_CORNER;

	protected static readonly int ID_SNOWCOVER;

	public static Snowfield global;

	[SerializeField]
	protected float _snowCover;

	[SerializeField]
	protected Texture2D _skierFootprintTexture;

	[SerializeField]
	protected Texture2D _heightMap;

	[SerializeField]
	protected Vector3Int _corner;

	private Material transferMaterial;

	public float snowCover
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	protected override void OnEnable()
	{
	}

	protected override void OnDisable()
	{
	}

	protected override void OnUpdate()
	{
	}
}
