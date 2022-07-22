using System;
using UnityEngine;

public class PokemonPrefabInfo : MonoBehaviour
{
	[Serializable]
	public class AABBData
	{
		public Vector3 size;

		public Vector3 center;

		public string motionName;
	}

	[SerializeField]
	private Vector3 mStartPoint;

	[SerializeField]
	private Vector3 mEndPoint;

	[SerializeField]
	private float mModelHeight;

	public AABBData[] mAABBArray;

	public Vector3 StartPoint => default(Vector3);

	public Vector3 EndPoint => default(Vector3);

	public float ModelHeight => default(float);

	private void Start()
	{
	}

	public AABBData GetAABB(string motionName)
	{
		return null;
	}

	public AABBData GetCurrentAABB()
	{
		return null;
	}

	private void Update()
	{
	}
}
