using System;
using UnityEngine;

public sealed class EmissionColorChanger : MonoBehaviour
{
	[Serializable]
	public struct Property
	{
		[SerializeField]
		public Color color;

		[SerializeField]
		public float intensity;
	}

	private static readonly int _EmissionColorID;

	private static readonly int _EmissionIntensityID;

	[SerializeField]
	public int _materialIndex;

	private Renderer _renderer;

	private MaterialPropertyBlock propertyBlock;

	[SerializeField]
	private Property _morningProp;

	[SerializeField]
	private Property _daytimeProp;

	[SerializeField]
	private Property _eveningProp;

	[SerializeField]
	private Property _nightProp;

	[SerializeField]
	private Property _midnightProp;

	public Property this[PeriodOfDay periodOfDay]
	{
		get
		{
			return default(Property);
		}
		set
		{
		}
	}

	private void OnEnable()
	{
	}

	public void Update()
	{
	}

	private void OnDisable()
	{
	}
}
