using System;
using UnityEngine;

public sealed class UVConnection : MonoBehaviour
{
	[Serializable]
	public struct Property
	{
		[SerializeField]
		public Renderer renderer;

		[SerializeField]
		public int materialIndex;

		[SerializeField]
		public Vector2 baseUV;

		[SerializeField]
		public Vector2 offsetUV;

		[SerializeField]
		public string propertyName;

		private int propertyID;

		public void Reset()
		{
		}

		public void Update(MaterialPropertyBlock propertyBlock)
		{
		}

		public void Clear()
		{
		}
	}

	private MaterialPropertyBlock propertyBlock;

	[SerializeField]
	private Property Property00;

	[SerializeField]
	private Property Property01;

	[SerializeField]
	private Property Property02;

	[SerializeField]
	private Property Property03;

	public Property this[int index]
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

	private void OnDisable()
	{
	}

	private void OnUpdate(float deltaTime)
	{
	}
}
