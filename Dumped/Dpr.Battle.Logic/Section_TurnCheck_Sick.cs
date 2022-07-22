using System.Runtime.InteropServices;
using Pml.WazaData;

namespace Dpr.Battle.Logic;

public sealed class Section_TurnCheck_Sick : Section
{
	public class Description
	{
	}

	public class Result
	{
		public bool isExpGet;
	}

	private static DamageCause getDamageCause(WazaSick sick)
	{
		return default(DamageCause);
	}

	public Section_TurnCheck_Sick([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void storeFrontPokeByAgilityOrder(PokeSet pPokeSet)
	{
	}

	private void turncheckSick(BTL_POKEPARAM pPoke, WazaSick sick)
	{
	}

	private void continueSick(BTL_POKEPARAM poke, WazaSick sick)
	{
	}

	private void sickDamage(BTL_POKEPARAM poke, WazaSick sick)
	{
	}

	private bool isDamageEnable(BTL_POKEPARAM poke, uint damage, WazaSick sick)
	{
		return default(bool);
	}

	private void addDamage(BTL_POKEPARAM poke, uint damage, WazaSick sickID)
	{
	}

	private void getSickDamageMessage(StrParam strParam, BTL_POKEPARAM poke, WazaSick sick)
	{
	}

	private int getSickDamageStrID(WazaSick sick)
	{
		return default(int);
	}

	private void putEffect(BTL_POKEPARAM poke, WazaSick sick)
	{
	}

	private void cont_HorobiNoUta(BTL_POKEPARAM poke)
	{
	}

	private void putHorobiCounter(BTL_POKEPARAM poke, byte count)
	{
	}

	private void cont_Yadorigi(BTL_POKEPARAM poke)
	{
	}

	private void cont_NeWoHaru(BTL_POKEPARAM poke)
	{
	}

	private void cont_Bind(BTL_POKEPARAM poke)
	{
	}

	private void cont_AquaRing(BTL_POKEPARAM poke)
	{
	}

	private void cont_Encore(BTL_POKEPARAM poke)
	{
	}

	private void cont_Takogatame(BTL_POKEPARAM poke)
	{
	}

	private void cureSick(BTL_POKEPARAM poke, WazaSick sick, [In] ref BTL_SICKCONT oldCont)
	{
	}

	private void cure_Akubi(BTL_POKEPARAM poke, [In] ref BTL_SICKCONT sickCont)
	{
	}

	private void cure_HorobiNoUta(BTL_POKEPARAM poke, [In] ref BTL_SICKCONT sickCont)
	{
	}

	private void cure_Sasiosae(BTL_POKEPARAM poke)
	{
	}

	private void cure_KaifukuFuji(BTL_POKEPARAM bpp)
	{
	}

	private bool checkExpGet()
	{
		return default(bool);
	}
}
