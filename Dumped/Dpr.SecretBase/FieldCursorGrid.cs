using System.Runtime.CompilerServices;
using UnityEngine;

namespace Dpr.SecretBase;

public class FieldCursorGrid : MonoBehaviour
{
	[SerializeField]
	private Transform top;

	[SerializeField]
	private Transform bottom;

	[SerializeField]
	private Transform left;

	[SerializeField]
	private Transform right;

	public int Width
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

	public int Height
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

	public void SetSize(int width, int height)
	{
	}

	public void OnUpdate()
	{
	}
}
