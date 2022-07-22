using System.Runtime.CompilerServices;
using DPData;
using Pml;
using Pml.PokePara;
using XLSXContent;

namespace Dpr.UI;

public class ZukanInfo
{
	public enum ModelSexType
	{
		Male,
		Female,
		Unknown,
		Both
	}

	private class ModelParam
	{
		public int UniqueID;

		public ModelSexType SexType;

		public int FormNo;

		public bool IsRare;

		public ModelParam(PokemonInfo.SheetCatalog catalog)
		{
		}

		public Sex GetSex()
		{
			return default(Sex);
		}
	}

	private const string ZukanMessageFileName = "ss_pokedex";

	private const string NameMessageFileName = "ss_monsname";

	private const string FormMessageFileName = "ss_zkn_form";

	private const string TypeMessageFileName = "ss_zkn_type";

	private const string HeightMessageFileName = "ss_zkn_height";

	private const string WeightMessageFileName = "ss_zkn_weight";

	private const string UnknownNameMessageLabel = "SS_pokedex_029";

	private const string HeightMessageLabelNameFormat = "ZKN_HEIGHT_{0:D3}_{1:D3}";

	private const string WeightMessageLabelNameFormat = "ZKN_WEIGHT_{0:D3}_{1:D3}";

	private ModelParam[] modelParams;

	private int formIndex;

	private IndexSelector modelIndexSelector;

	public MonsNo MonsNo
	{
		[CompilerGenerated]
		get
		{
			return default(MonsNo);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int ZukanNo
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public ushort Height
	{
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public ushort Weight
	{
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public string HeightText
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public string WeightText
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public PokeType Type1
	{
		[CompilerGenerated]
		get
		{
			return default(PokeType);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public PokeType Type2
	{
		[CompilerGenerated]
		get
		{
			return default(PokeType);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public GET_STATUS GetStatus
	{
		[CompilerGenerated]
		get
		{
			return default(GET_STATUS);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool ExistForm => default(bool);

	public bool CanChangeModel => default(bool);

	public bool CanShowDescription => default(bool);

	private string DescriptionMessageFileName => null;

	public ZukanInfo(MonsNo monsNo, bool isShinouZukan)
	{
	}

	public void SetFormNo(int formNo)
	{
	}

	public void Set(int formNo, Sex sex, bool isRare)
	{
	}

	public void SetupUITexts(UIText nameText, UIText classText, UIText heightText, UIText weightText, UIText descText, UIText formNameText)
	{
	}

	public ModelSexType GetCurrentModelSexType()
	{
		return default(ModelSexType);
	}

	public bool IsRareCurrentModel()
	{
		return default(bool);
	}

	public void MoveModelSelect(int value)
	{
	}

	public PokemonParam GetCurrentPokemonParam()
	{
		return null;
	}

	private void UpdateInfo()
	{
	}

	private PokemonInfo.SheetCatalog[] GetCatalogs(MonsNo monsNo, int formMax, bool isUnknownSex)
	{
		return null;
	}
}
