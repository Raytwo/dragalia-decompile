using System;
using System.Collections.Generic;

namespace XLSXContent;

[Serializable]
public class SheetDistributionTable
{
	public enum HabitatType
	{
		Field,
		Dungeon,
		Num
	}

	public enum TimeZoneType
	{
		Morning,
		Daytime,
		Night,
		Num
	}

	public enum SpecialType
	{
		Fishing,
		PokemonTraser,
		HoneyTree,
		Num
	}

	public int[] BeforeMorning;

	public int[] BeforeDaytime;

	public int[] BeforeNight;

	public int[] AfterMorning;

	public int[] AfterDaytime;

	public int[] AfterNight;

	public int[] Fishing;

	public int[] PokemonTraser;

	public int[] HoneyTree;

	public List<int> GetMapIds(TimeZoneType timeZone, bool isZukanZenkoku)
	{
		return null;
	}

	public List<int> GetSpecialMapIds(SpecialType type)
	{
		return null;
	}
}
