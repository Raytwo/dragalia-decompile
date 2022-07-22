using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class RegisterItemButton : MonoBehaviour
{
	[SerializeField]
	private Image baseImage;

	[SerializeField]
	private Image itemIconImage;

	public ushort ItemNo
	{
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool IsSet
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

	public void Setup(ushort itemNo)
	{
	}

	public void SetBaseSprite(Sprite sprite)
	{
	}
}
