using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class ZukanCompareWeightController : MonoBehaviour
{
	private static readonly int AnimatorStateInitialize;

	private static readonly int AnimatorParamStateId;

	private static readonly int AnimatorParamSideId;

	private static readonly int AnimatorParamWeightId;

	private const int StateIdInitialize = -1;

	private const int StateIdStart = 1;

	private const int SideIdBalance = 0;

	private const int SideIdPlayer = 1;

	private const int SideIdPokemon = 2;

	private const string PlayerIconSpriteNameFormat = "dex_ico_compare_player_01_{0:D3}_{1:D2}";

	[SerializeField]
	private Animator animator;

	[SerializeField]
	private Image[] playerImages;

	[SerializeField]
	private Image pokemonIconImage;

	private ushort playerWeight;

	private ZukanInfo currentZukanInfo;

	private bool isSetupEnd;

	public bool IsLoadEnd
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

	public void Initialize(ushort playerWeight)
	{
	}

	public void Dispose()
	{
	}

	public void OnUpdate(float deltaTime)
	{
	}

	public void Setup(ZukanInfo zukanInfo)
	{
	}

	public void RequestLoadModel()
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	private void LoadPlayerIcon(int fashionId, int colorId)
	{
	}
}
