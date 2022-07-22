using System.Runtime.CompilerServices;
using UnityEngine;

namespace Dpr.UI;

public class Seal3DObject : MonoBehaviour
{
	private Transform rootTransform;

	private Material sealMaterial;

	private Collider sealCollider;

	private Vector3 sealPosition;

	public int SealId
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int AffixSealId
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool IsActive
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool IsSetSeal
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public void Initialize(Vector3 sealScale, float offsetPositionZ)
	{
	}

	public void SetActive(bool isActive)
	{
	}

	public void SetSeal(int sealId, Sprite sprite, int affixSealId = -1)
	{
	}

	public void SetPositionAndRotation(Vector3 position, Vector3 up)
	{
	}

	public Vector3 GetPosition()
	{
		return default(Vector3);
	}

	public Vector3 GetSealPosition()
	{
		return default(Vector3);
	}

	public void Clear()
	{
	}

	public bool EqualCollider(Collider collider)
	{
		return default(bool);
	}
}
