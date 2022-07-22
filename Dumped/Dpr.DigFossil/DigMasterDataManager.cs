using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using XLSXContent;

namespace Dpr.DigFossil;

public class DigMasterDataManager : MonoBehaviour
{
	public enum RatioId
	{
		Diamond,
		Diamond_Dialga,
		Diamond_Zenkoku,
		Pearl,
		Pearl_Palkia,
		Pearl_Zenkoku
	}

	public interface IDeposit
	{
		char[,] Shape { get; }

		int Width { get; }

		int Height { get; }

		short ItemId { get; }

		bool IsDeposit { get; }

		bool IsStoneBox { get; }

		bool IsOnly { get; }

		string TextureName { get; }

		int NormalWidth { get; }

		int NormalHeight { get; }

		int Turn { get; }

		bool bIsRare { get; }

		short OffsetSize { get; }

		short OffsetX { get; }

		short OffsetY { get; }

		int GetRatio(RatioId id);
	}

	public class StoneBoxData : IDeposit
	{
		public char[,] Shape
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public int Width
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		public int Height
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		public string TextureName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public int NormalWidth
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		public int NormalHeight
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		public int Turn => default(int);

		public short ItemId => default(short);

		public bool IsDeposit => default(bool);

		public bool IsStoneBox => default(bool);

		public bool IsOnly => default(bool);

		public bool bIsRare => default(bool);

		public short OffsetSize
		{
			[CompilerGenerated]
			get
			{
				return default(short);
			}
		}

		public short OffsetX
		{
			[CompilerGenerated]
			get
			{
				return default(short);
			}
		}

		public short OffsetY
		{
			[CompilerGenerated]
			get
			{
				return default(short);
			}
		}

		public StoneBoxRawData.SheetBox RawData
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public string BoxModelName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public short PokeType => default(short);

		public short Reality => default(short);

		public int GetRatio(RatioId id)
		{
			return default(int);
		}

		public StoneBoxData([In] ref StoneBoxRawData.SheetBox inRawData)
		{
		}
	}

	public class DepositItemData : IDeposit
	{
		private readonly DepositItemRawData.SheetDeposit rawData;

		public char[,] Shape
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public int Width
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		public int Height
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		public short ItemId => default(short);

		public string TextureName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public int NormalWidth
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		public int NormalHeight
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		public int Turn
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		public bool IsDeposit => default(bool);

		public bool IsStoneBox => default(bool);

		public bool IsOnly => default(bool);

		public bool bIsRare => default(bool);

		public string ResultTextureName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public short OffsetSize => default(short);

		public short OffsetX => default(short);

		public short OffsetY => default(short);

		public int LabelId => default(int);

		public int GetRatio(RatioId id)
		{
			return default(int);
		}

		public DepositItemData([In] ref DepositItemRawData.SheetDeposit inRawData)
		{
		}

		public DepositItemData([In] ref DepositItemData inDst, int turn)
		{
		}
	}

	public class HardStoneData : IDeposit
	{
		private readonly HardStoneRawData.SheetHardStone rawData;

		public char[,] Shape
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public int Width
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		public int Height
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		public short ItemId => default(short);

		public string TextureName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public int NormalWidth
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		public int NormalHeight
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		public int Turn
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		public bool IsDeposit => default(bool);

		public bool IsStoneBox => default(bool);

		public bool IsOnly => default(bool);

		public bool bIsRare => default(bool);

		public short OffsetSize
		{
			[CompilerGenerated]
			get
			{
				return default(short);
			}
		}

		public short OffsetX
		{
			[CompilerGenerated]
			get
			{
				return default(short);
			}
		}

		public short OffsetY
		{
			[CompilerGenerated]
			get
			{
				return default(short);
			}
		}

		public int GetRatio(RatioId id)
		{
			return default(int);
		}

		public HardStoneData([In] ref HardStoneRawData.SheetHardStone inRawData)
		{
		}

		public HardStoneData([In] ref HardStoneData inDst, int turn)
		{
		}
	}

	[SerializeField]
	private StoneBoxRawData boxRawData;

	[SerializeField]
	private DepositItemRawData itemRawData;

	[SerializeField]
	private HardStoneRawData hardStoneRawData;

	[SerializeField]
	private StatueEffectRawData statueEffectData;

	public const short ITEM_ID_STONE_BOX = -10;

	public const short ITEM_ID_HARD_STONE = -100;

	public List<StoneBoxData> StoneBoxDatas
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public List<DepositItemData> DepositItemDatas
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public List<HardStoneData> HardStoneDatas
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public List<StatueEffectRawData.Sheettable> StatueEffectData
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

	public void Initialize()
	{
	}

	public StatueEffectRawData.Sheettable GetStatueEffectData(short statueId)
	{
		return null;
	}

	public static T[,] ShapeRotationRight<T>([In] ref T[,] inDst)
	{
		return null;
	}

	public static T[,] ShapeRotationRight<T>([In] ref T[,] inDst, int count)
	{
		return null;
	}

	private static char[,] ToShape([In] ref string inShape)
	{
		return null;
	}
}
