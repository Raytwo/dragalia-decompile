using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class SealButton : MonoBehaviour
{
	[SerializeField]
	private SealIconButon sealIconButon;

	[SerializeField]
	private Image typeIconImage;

	[SerializeField]
	private UIText countText;

	public int SealId => default(int);

	public SealInfo Info
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool IsEnable => default(bool);

	public void Set(int sealId)
	{
	}

	public void UpdateCount()
	{
	}
}
