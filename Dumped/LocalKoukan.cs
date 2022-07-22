using Dpr.Message;
using Pml;
using Pml.PokePara;
using XLSXContent;

public class LocalKoukan
{
	public class Operation
	{
		public bool IsTemotiMode;

		public int TrayNo;

		public int Pos;

		public PokemonParam from;

		public PokemonParam other;

		public void Apply()
		{
		}
	}

	public static LocalKoukanData.Sheetdata GetTargetData(int npcindex, MessageEnumData.MsgLangId lang)
	{
		return null;
	}

	public static MonsNo GetTargetMonsNo(int npcindex, MessageEnumData.MsgLangId lang)
	{
		return default(MonsNo);
	}

	public static Operation CreateOperation(PokemonParam myparam, int npcindex, MessageEnumData.MsgLangId lang, bool istemoti, int trayno, int pos)
	{
		return null;
	}

	public static Operation CreateOperation(PokemonParam from, PokemonParam other, bool istemoti, int trayno, int pos)
	{
		return null;
	}

	private static int GetIndex(int npcindex, MessageEnumData.MsgLangId lang)
	{
		return default(int);
	}

	private static PokemonParam CreateTradePokeParam(LocalKoukanData.Sheetdata data)
	{
		return null;
	}
}
