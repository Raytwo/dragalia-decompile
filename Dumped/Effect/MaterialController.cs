using System;
using UnityEngine;

namespace Effect;

public class MaterialController : MonoBehaviour
{
	[SerializeField]
	public Vector4[] _UvScroll0;

	[SerializeField]
	public Vector4[] _UvScroll1;

	[SerializeField]
	public Vector4[] _UvRotation;

	[SerializeField]
	public Vector4[] _UvScale0;

	[SerializeField]
	public Vector4[] _UvScale1;

	[SerializeField]
	public Color _MulColor;

	private ParticleSystem _particleSystem;

	private ParticleSystemRenderer _renderer;

	private MaterialPropertyBlock _propertyBlock;

	private System.Random _random;

	private static int _id_Texture0_ST;

	private static int _id_Texture1_ST;

	private static int _id_Texture2_ST;

	private static int _id_UvScroll0;

	private static int _id_UvScroll1;

	private static int _id_UvScroll2;

	private static int _id_UvRotation0;

	private static int _id_UvRotation1;

	private static int _id_UvScale0;

	private static int _id_UvScale1;

	private static int _id_UvScale2;

	private static int _id_MulColorEnabled;

	private static int _id_MulColor;

	public ParticleSystem GetParticleSystem()
	{
		return null;
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	public void CreateRandom()
	{
	}

	public void CreateRandom(int seed)
	{
	}

	public float RandomRange(float min, float max)
	{
		return default(float);
	}

	public void SetupProperty()
	{
	}

	public void SetMultiplyColor(Color color)
	{
	}
}
