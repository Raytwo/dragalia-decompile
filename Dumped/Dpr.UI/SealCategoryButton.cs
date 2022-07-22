using System.Runtime.CompilerServices;
using UnityEngine;

namespace Dpr.UI;

public class SealCategoryButton : MonoBehaviour
{
	[SerializeField]
	private SealIconButon sealIconButon;

	public int CategoryId
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

	public bool IsEnable
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

	public bool IsNoneCategory => default(bool);

	public void Set(int categoryId)
	{
	}

	public void Set(SealCategoryButton button)
	{
	}

	public void SetNone()
	{
	}

	public void SetEnable(bool isEnable)
	{
	}

	public Vector3 GetPosition()
	{
		return default(Vector3);
	}
}
