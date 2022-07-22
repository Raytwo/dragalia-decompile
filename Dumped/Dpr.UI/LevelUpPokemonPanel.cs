using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Pml;
using Pml.PokePara;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class LevelUpPokemonPanel : MonoBehaviour
{
	public struct LearnWazaResult
	{
		public WazaNo WazaNo;

		public WazaLearningResult Result;
	}

	private const string MessageFileName = "ss_level_up";

	private const string LevelMessageLabel = "SS_level_up_00_01";

	private const string AddExpMessageLabel = "SS_level_up_01_02";

	private const float BoostExpBarTweenDuration = 0.5f;

	[SerializeField]
	private PokemonIcon pokemonIcon;

	[SerializeField]
	private TextMeshProUGUI nameText;

	[SerializeField]
	private Image genderIconImage;

	[SerializeField]
	private TextMeshProUGUI levelText;

	[SerializeField]
	private TextMeshProUGUI addExpText;

	[SerializeField]
	private Slider expBar;

	[SerializeField]
	private CanvasGroup levelUpImageCanvasGroup;

	private bool isAnimationGauge;

	private bool isSkipAnimation;

	private bool isExpBarTweenBoost;

	private uint minExp;

	private uint maxExp;

	private float expBarTweenDuration;

	private List<LearnWazaResult> newLearnWazaResultList;

	public PokemonParam PokemonParam
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public UILevelUp.PokemonStatus CurrentPokemonStatus
	{
		[CompilerGenerated]
		get
		{
			return default(UILevelUp.PokemonStatus);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public UILevelUp.PokemonStatus BeforePokemonStatus
	{
		[CompilerGenerated]
		get
		{
			return default(UILevelUp.PokemonStatus);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public Action OnGaugeUp
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public Action OnLevelUp
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public bool IsLevelUp
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

	public bool IsLearnWaza => default(bool);

	public bool IsAnimation
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

	public void SetActive(bool isActive)
	{
	}

	public void Set(PokemonParam param)
	{
	}

	public void SkipAnimation()
	{
	}

	public bool AddExp(uint exp)
	{
		return default(bool);
	}

	public void LevelUp(int count)
	{
	}

	public float CalcExpBarTweenDuration(uint addExp)
	{
		return default(float);
	}

	public void SetExpBarTweenDuration(float duration)
	{
	}

	public void HandledLevelUp()
	{
	}

	public LearnWazaResult GetCurrentNewLearnWazaResult()
	{
		return default(LearnWazaResult);
	}

	public void HandledNewLearnWazaResult()
	{
	}

	private IEnumerator OpLoadIcon(CoreParam param, Image image)
	{
		return null;
	}

	private IEnumerator AddExpCoroutine(long exp)
	{
		return null;
	}

	private void SetupExpBar(uint min, uint max, uint current)
	{
	}

	private void SetExpBarValue(uint value)
	{
	}

	private void FadeInLevelUpImage()
	{
	}

	private string GetLevelText(CoreParam param)
	{
		return null;
	}

	private string GetAddExpText(long exp)
	{
		return null;
	}

	private uint GetLevelMinExp(MonsNo monsNo, ushort formNo, byte level)
	{
		return default(uint);
	}
}
