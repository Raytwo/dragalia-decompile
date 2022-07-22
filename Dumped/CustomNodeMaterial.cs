using System;
using UnityEngine;

[Serializable]
public class CustomNodeMaterial
{
	private static readonly int _FixMultiplierColor;

	private static readonly int _BillboardScale;

	private const bool useMaterialBlock = true;

	private static MaterialPropertyBlock materialPropertyBlock;

	public MaterialParam mp;

	public string shaderName;

	[SerializeField]
	private CustomNodeProperty[] cnProperties;

	[ColorUsage(false, true)]
	public Color fixMultiplyColor;

	public CustomNodeProperty[] CnProperties
	{
		set
		{
		}
	}

	public CustomNodeMaterial(Material mat)
	{
	}

	public void SetUp(Renderer[] renderers)
	{
	}

	public void Start()
	{
	}

	public void Update(float lossyScale)
	{
	}
}
