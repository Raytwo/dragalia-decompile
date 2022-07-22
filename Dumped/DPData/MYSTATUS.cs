using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace DPData;

[Serializable]
[StructLayout(0, CharSet = CharSet.Unicode, Pack = 4, Size = 80)]
public struct MYSTATUS
{
	public const int BADGE_MAX = 8;

	public const int TRAINER_RANK_MAX = 5;

	public string name;

	public uint id;

	public int gold;

	public bool sex;

	public byte region_code;

	public byte badge;

	public byte trainer_view;

	public byte rom_code;

	public bool dp_clear;

	public byte body_type;

	public byte fashion;

	public DefaultPokeType defaultPokeType;

	public bool dsPlayerFlag;

	public int turewalkMemberIndex;

	public Vector2Int grid;

	public float height;

	public float rotation;
}
