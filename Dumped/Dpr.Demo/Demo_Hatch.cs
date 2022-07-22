using System.Collections;
using Dpr.SubContents;
using Pml.PokePara;

namespace Dpr.Demo;

public class Demo_Hatch : DemoBase
{
	private TimeLineBinder timeLine;

	private PokemonParam param;

	private float waitTime;

	private float pokeRoarAnimTime;

	private bool isCloseHatchMsg;

	private bool isManafy;

	private MarkerReceiver receiver;

	public Demo_Hatch(PokemonParam param)
	{
	}

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

	private void SetMessage()
	{
	}

	private void SetIsHauchMsg()
	{
	}
}
