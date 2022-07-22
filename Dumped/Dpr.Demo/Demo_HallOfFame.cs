using System.Collections;
using System.Collections.Generic;
using Dpr.SubContents;
using Pml.PokePara;

namespace Dpr.Demo;

public class Demo_HallOfFame : DemoBase
{
	private TimeLineBinder timeLine;

	private uint pokeCount;

	private TimeLineText LevelText;

	private TimeLineText PokeNameText;

	private TimeLineText PlayerNameText;

	private List<PokemonParam> pokes;

	public override void Destroy()
	{
	}

	public override IEnumerator Enter()
	{
		return null;
	}

	public override IEnumerator Main()
	{
		return null;
	}

	public override IEnumerator Exit()
	{
		return null;
	}

	public void CheckPokeEnd(int num, float frame)
	{
	}

	public void UpdateText(int index)
	{
	}

	public void ToBattleScale(int index)
	{
	}

	public void ToMenuScale(int index)
	{
	}

	private void SetUpGraphicText(TimeLineBinder timeline)
	{
	}
}
