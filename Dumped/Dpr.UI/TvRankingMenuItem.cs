using System.Collections.Generic;
using DPData;
using UnityEngine;
using XLSXContent;

namespace Dpr.UI;

public class TvRankingMenuItem : MonoBehaviour
{
	public class RankParam
	{
		public RANDOMGROUP groupId;

		public int rank;

		public uint value;

		public long timeStamp;

		public bool isMine => default(bool);
	}

	[SerializeField]
	private UIText _title;

	[SerializeField]
	private RectTransform _select;

	private UIDatabase.SheetRankingDisplay _rankingData;

	private List<RankParam> _rankParams;

	public UIDatabase.SheetRankingDisplay rankingData => null;

	public List<RankParam> rankParams => null;

	public void Setup(UIDatabase.SheetRankingDisplay rankingData, List<RankParam> rankParams)
	{
	}

	public int DeleteRankParam(int flagIndex, int rankParamIndex)
	{
		return default(int);
	}

	public void Select(bool enabled)
	{
	}
}
