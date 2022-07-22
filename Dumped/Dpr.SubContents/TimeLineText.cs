using Dpr.UI;
using Pml.PokePara;
using UnityEngine;

namespace Dpr.SubContents;

public class TimeLineText : MonoBehaviour
{
	public enum Mode
	{
		Level,
		PokeName,
		PlayerName
	}

	public Mode mode;

	private UIText text;

	private const string fileName = "dlp_halloffame_demo";

	private static readonly string[] Labels;

	private void OnEnable()
	{
	}

	private void Awake()
	{
	}

	public void UpdateText(PokemonParam param)
	{
	}
}
