using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Dpr.UI;

public class BoxParty : BoxInfinityScrollItem
{
	public class BoxPartyParam : BaseParam
	{
		public enum PartyType
		{
			Normal,
			BattleTeam
		}

		public PartyType partyType;
	}

	[SerializeField]
	private UIText _title;

	[SerializeField]
	private RectTransform _contents;

	public const int cellColumn = 6;

	public const int cellNum = 30;

	private BoxPartyParam _param;

	private List<BoxPartyItem> _items;

	private static string[] _titleLabels;

	public BoxPartyParam Param => null;

	public List<BoxPartyItem> Items => null;

	private void Awake()
	{
	}

	public override void Setup(BaseParam baseParam)
	{
	}

	public void Setup()
	{
	}

	public void SetTitle()
	{
	}

	public void Apply(List<int> hideIcons, BoxWindow.OpenParam openParam, [Optional] BoxWindow.SEARCH_DATA searchData, [Optional] List<BoxWindow.SelectedPokemon> selected)
	{
	}

	public void SetupItems()
	{
	}

	public UINavigator GetNavigator(int index)
	{
		return null;
	}

	public static string GetTeamNameID(int index)
	{
		return null;
	}
}
