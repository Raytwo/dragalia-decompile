using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu]
public class PetrifyData : ScriptableObject
{
	[Serializable]
	public class MaterialData
	{
		[SerializeField]
		public string name;

		[SerializeField]
		public bool forceSoftEdge;

		[SerializeField]
		public float noiseFactor;

		[SerializeField]
		public float distribution;

		[SerializeField]
		public float triPlanarScale;

		[SerializeField]
		public float edgeDectectionScale;

		[SerializeField]
		public Vector2 textureOffset;

		[SerializeField]
		public Texture2D colorMap;

		[SerializeField]
		public Texture2D specularMap;

		[SerializeField]
		public Texture2D bumpMap;

		[SerializeField]
		public Texture2D ambientMap;

		[SerializeField]
		public float colorWeight;

		[SerializeField]
		public float bumpScale;

		[SerializeField]
		public float cosinePower;

		[SerializeField]
		public float specularScale;

		[SerializeField]
		public Color reflectivity;

		[SerializeField]
		public float glossy;
	}

	public MaterialData[] materialDatas;
}
