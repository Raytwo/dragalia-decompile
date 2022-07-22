using System.Runtime.CompilerServices;
using Pml;
using Pml.PokePara;
using UnityEngine;
using XLSXContent;

namespace Dpr.SecretBase;

public class StatueEffectData
{
	public ushort statueId => default(ushort);

	public int ugItemId => default(int);

	public MonsNo monsId => default(MonsNo);

	public byte rarity => default(byte);

	public byte width => default(byte);

	public byte height => default(byte);

	public sbyte type1Id => default(sbyte);

	public sbyte type2Id => default(sbyte);

	public short[] PokeTypeEffect
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public int MSLabelId => default(int);

	public Vector3 offset => default(Vector3);

	public float cameraDistance => default(float);

	public bool isNormal => default(bool);

	public bool isLegend => default(bool);

	public bool isShiny => default(bool);

	public byte shader => default(byte);

	public string motionId => null;

	public float motionFrame => default(float);

	public ushort formNo => default(ushort);

	public Sex sex => default(Sex);

	public bool isRarePoke => default(bool);

	public bool isRareIcon => default(bool);

	public RareType rareType => default(RareType);

	public StatueEffectRawData.Sheettable rawData
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public StatueEffectData(StatueEffectRawData.Sheettable inRawData)
	{
	}

	public PokemonInfo.SheetCatalog GetPokeCatalog()
	{
		return null;
	}
}
