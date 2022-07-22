using UnityEngine;
using XLSXContent;

public class WaterInteraction : ProceduralPlane
{
	public enum CentroidType
	{
		Player,
		EyeRay
	}

	protected static readonly int ID_WATERCOLOR;

	protected static readonly int ID_WATERATTENUATION;

	protected static readonly int ID_WATERUPSCALE;

	protected static readonly int ID_WATERMAXDENSITY;

	protected static readonly int ID_REFLECTIVITY;

	protected static readonly int ID_FRESNELPOWER;

	protected static readonly int ID_SPECULARPOWER;

	protected static readonly int ID_SPECULARINTENSITY;

	protected static readonly int ID_;

	[SerializeField]
	private bool useWaterSettings;

	[SerializeField]
	protected Color _waterColor;

	[SerializeField]
	protected float _waterUpScale;

	[SerializeField]
	protected float _waterAttenuation;

	[SerializeField]
	protected float _waterMaxDensity;

	[SerializeField]
	protected float _reflectivity;

	[SerializeField]
	protected float _fresnelPower;

	[SerializeField]
	protected float _specularIntensity;

	[SerializeField]
	protected float _specularCosinePower;

	[SerializeField]
	protected int _randomDropCount;

	[SerializeField]
	protected float _randomDropDepthMin;

	[SerializeField]
	protected float _randomDropDepthMax;

	[SerializeField]
	protected CentroidType _centroidType;

	[SerializeField]
	protected Texture2D _initialWater;

	private bool _isInitialized;

	public static WaterSettings.SheetSettings waterSettings;

	public static WaterInteraction global;

	public Color waterColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public float waterUpScale
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public float waterAttenuation
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public float waterMaxDensity
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public CentroidType centroidType
	{
		get
		{
			return default(CentroidType);
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

	private Vector2Int IntersectPlaneXZ(Vector3 point, Vector3 direction)
	{
		return default(Vector2Int);
	}

	protected override void OnUpdate()
	{
	}
}
