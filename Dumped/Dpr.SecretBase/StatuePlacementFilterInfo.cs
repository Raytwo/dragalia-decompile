using System.Collections.Generic;
using Dpr.UI;
using UnityEngine;

namespace Dpr.SecretBase;

public class StatuePlacementFilterInfo : MonoBehaviour
{
	private static readonly string MESSAGE_FILE_NAME;

	private static Dictionary<int, (string, string)> MESSAGE_DIC;

	[SerializeField]
	private UIText mainText;

	[SerializeField]
	private GameObject subTextRoot;

	[SerializeField]
	private UIText subText;

	private int currentIndex;

	public void Initialize()
	{
	}

	public void Apply(int value)
	{
	}
}
