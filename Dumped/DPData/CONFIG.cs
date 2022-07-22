using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 64)]
public struct CONFIG
{
	public MSGSPEED msg_speed;

	public int msg_lang_id;

	public bool is_kanji;

	public WINTYPE window_type;

	public WAZAEFF_MODE wazaeff_mode;

	public BATTLERULE battle_rule;

	public PARTYANDBOXMODE party_and_box;

	public bool regist_nickname;

	public bool gyrosensor;

	public bool camerashake_of_fossil;

	public CAMERAINPUTMODE camera_updown;

	public CAMERAINPUTMODE camera_leftright;

	public bool autoreport;

	public INPUTMODE input_mode;

	public bool show_nickname;

	public byte bgm_volume;

	public byte se_volume;

	public byte voice_volume;

	public int GetValue(ConfigID configId)
	{
		return default(int);
	}

	public void SetValue(ConfigID configId, int value)
	{
	}

	public bool IsEqualValue(ConfigID configId, ref CONFIG t)
	{
		return default(bool);
	}

	public bool IsEqual(ref CONFIG t)
	{
		return default(bool);
	}
}
