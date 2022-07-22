using System;
using Pml;
using Pml.PokePara;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class WazaManageWazaStatusPanel : PokemonStatusPanel
{
	[Serializable]
	private class DetailParam
	{
		public Image category;

		public UIText power;

		public UIText hitRate;

		public UIText description;

		public RectTransform contents;

		public PokemonStatusContestWazaAppealItem prefab;
	}

	[SerializeField]
	private UIScrollView wazaScrollView;

	[SerializeField]
	private Cursor cursor;

	[SerializeField]
	private DetailParam detail;

	[SerializeField]
	private bool isContestPanel;

	private WazaNo[] detailWazaNos;

	private int selectIndex;

	private int newWazaIndex;

	private UIInputController inputController;

	public void Initialize()
	{
	}

	public void Setup(PokemonParam pokemonParam, WazaNo[] wazaNos, int newWazaIndex = -1)
	{
	}

	public void UpdateSelect(float deltaTime, bool isPlaySound = true)
	{
	}

	private void OnRequiredItemData(IUIButton button)
	{
	}

	private void OnSelectItemScrollViewItem(IUIButton button)
	{
	}

	private void OnUnSelectItemScrollViewItem(IUIButton button)
	{
	}

	public bool MoveIndex(int value)
	{
		return default(bool);
	}

	public void ResumeMoveIndex()
	{
	}

	public void SetCursorActive(bool isActive)
	{
	}

	public int GetSelectedIndex()
	{
		return default(int);
	}

	public WazaNo GetSelectedWazaNo()
	{
		return default(WazaNo);
	}

	private void SetupDetail(WazaNo wazaNo)
	{
	}
}
