using System;
using UnityEngine;

public sealed class ColorVariation : MonoBehaviour
{
	[Serializable]
	public struct Property
	{
		[Serializable]
		public struct MaskColor
		{
			[SerializeField]
			public int materialIndex;

			[SerializeField]
			public int channel;

			[SerializeField]
			public Color color;
		}

		[SerializeField]
		public Renderer renderer;

		[SerializeField]
		public MaskColor[] colors;

		public void Update(MaterialPropertyBlock propertyBlock)
		{
		}
	}

	public static readonly int _SkinColorID;

	public static readonly int _PrimaryColorID;

	public static readonly int _SecondaryColorID;

	public int ColorIndex;

	private MaterialPropertyBlock propertyBlock;

	[SerializeField]
	private Property[] Property00;

	[SerializeField]
	private Property[] Property01;

	[SerializeField]
	private Property[] Property02;

	[SerializeField]
	private Property[] Property03;

	public Property[] this[int index]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void OnEnable()
	{
	}

	public void LateUpdate()
	{
	}

	private void OnDisable()
	{
	}
}
