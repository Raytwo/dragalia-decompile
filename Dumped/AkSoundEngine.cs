using System;
using System.Collections.Generic;
using UnityEngine;

public class AkSoundEngine
{
	public delegate ulong GameObjectHashFunction(GameObject gameObject);

	private class AutoObject
	{
		private readonly GameObject gameObject;

		public AutoObject(GameObject go)
		{
		}

		~AutoObject()
		{
		}
	}

	public const int AK_SIMD_ALIGNMENT = 16;

	public const int AK_BUFFER_ALIGNMENT = 16;

	public const int AK_MAX_PATH = 260;

	public const int AK_BANK_PLATFORM_DATA_ALIGNMENT = 16;

	public const uint AK_INVALID_PLUGINID = uint.MaxValue;

	public const ulong AK_INVALID_GAME_OBJECT = ulong.MaxValue;

	public const uint AK_INVALID_UNIQUE_ID = 0u;

	public const uint AK_INVALID_RTPC_ID = 0u;

	public const uint AK_INVALID_LISTENER_INDEX = uint.MaxValue;

	public const uint AK_INVALID_PLAYING_ID = 0u;

	public const uint AK_DEFAULT_SWITCH_STATE = 0u;

	public const int AK_INVALID_POOL_ID = -1;

	public const int AK_DEFAULT_POOL_ID = -1;

	public const uint AK_INVALID_AUX_ID = 0u;

	public const uint AK_INVALID_FILE_ID = uint.MaxValue;

	public const uint AK_INVALID_DEVICE_ID = uint.MaxValue;

	public const uint AK_INVALID_BANK_ID = 0u;

	public const uint AK_FALLBACK_ARGUMENTVALUE_ID = 0u;

	public const uint AK_INVALID_CHANNELMASK = 0u;

	public const uint AK_INVALID_OUTPUT_DEVICE_ID = 0u;

	public const uint AK_MIXER_FX_SLOT = uint.MaxValue;

	public const ulong AK_DEFAULT_LISTENER_OBJ = 0uL;

	public const uint AK_DEFAULT_PRIORITY = 50u;

	public const uint AK_MIN_PRIORITY = 0u;

	public const uint AK_MAX_PRIORITY = 100u;

	public const uint AK_DEFAULT_BANK_IO_PRIORITY = 50u;

	public const double AK_DEFAULT_BANK_THROUGHPUT = 1048.576;

	public const uint AKCOMPANYID_AUDIOKINETIC = 0u;

	public const uint AK_LISTENERS_MASK_ALL = uint.MaxValue;

	public const int NULL = 0;

	public const int AKCURVEINTERPOLATION_NUM_STORAGE_BIT = 5;

	public const int AK_MAX_LANGUAGE_NAME_SIZE = 32;

	public const int AKCOMPANYID_PLUGINDEV_MIN = 64;

	public const int AKCOMPANYID_PLUGINDEV_MAX = 255;

	public const int AKCOMPANYID_AUDIOKINETIC_EXTERNAL = 1;

	public const int AKCOMPANYID_MCDSP = 256;

	public const int AKCOMPANYID_WAVEARTS = 257;

	public const int AKCOMPANYID_PHONETICARTS = 258;

	public const int AKCOMPANYID_IZOTOPE = 259;

	public const int AKCOMPANYID_CRANKCASEAUDIO = 261;

	public const int AKCOMPANYID_IOSONO = 262;

	public const int AKCOMPANYID_AUROTECHNOLOGIES = 263;

	public const int AKCOMPANYID_DOLBY = 264;

	public const int AKCOMPANYID_TWOBIGEARS = 265;

	public const int AKCOMPANYID_OCULUS = 266;

	public const int AKCOMPANYID_BLUERIPPLESOUND = 267;

	public const int AKCOMPANYID_ENZIEN = 268;

	public const int AKCOMPANYID_KROTOS = 269;

	public const int AKCOMPANYID_NURULIZE = 270;

	public const int AKCOMPANYID_SUPERPOWERED = 271;

	public const int AKCOMPANYID_GOOGLE = 272;

	public const int AKCOMPANYID_VISISONICS = 277;

	public const int AKCODECID_BANK = 0;

	public const int AKCODECID_PCM = 1;

	public const int AKCODECID_ADPCM = 2;

	public const int AKCODECID_XMA = 3;

	public const int AKCODECID_VORBIS = 4;

	public const int AKCODECID_WIIADPCM = 5;

	public const int AKCODECID_PCMEX = 7;

	public const int AKCODECID_EXTERNAL_SOURCE = 8;

	public const int AKCODECID_XWMA = 9;

	public const int AKCODECID_AAC = 10;

	public const int AKCODECID_FILE_PACKAGE = 11;

	public const int AKCODECID_ATRAC9 = 12;

	public const int AKCODECID_VAG = 13;

	public const int AKCODECID_PROFILERCAPTURE = 14;

	public const int AKCODECID_ANALYSISFILE = 15;

	public const int AKCODECID_MIDI = 16;

	public const int AKCODECID_OPUSNX = 17;

	public const int AKCODECID_CAF = 18;

	public const int AKCODECID_AKOPUS = 19;

	public const int AKCODECID_AKOPUS_WEM = 20;

	public const int AKPLUGINID_METER = 129;

	public const int AKPLUGINID_RECORDER = 132;

	public const int AKEXTENSIONID_SPATIALAUDIO = 800;

	public const int AKEXTENSIONID_INTERACTIVEMUSIC = 801;

	public const int AKEXTENSIONID_EVENTMGRTHREAD = 900;

	public const int AK_WAVE_FORMAT_VAG = 65531;

	public const int AK_WAVE_FORMAT_AT9 = 65532;

	public const int AK_WAVE_FORMAT_VORBIS = 65535;

	public const int AK_WAVE_FORMAT_AAC = 43712;

	public const int AK_WAVE_FORMAT_OPUSNX = 12345;

	public const int AK_WAVE_FORMAT_OPUS = 12352;

	public const int AK_WAVE_FORMAT_OPUS_WEM = 12353;

	public const int WAVE_FORMAT_XMA2 = 358;

	public const int AK_PANNER_NUM_STORAGE_BITS = 3;

	public const int AK_POSSOURCE_NUM_STORAGE_BITS = 3;

	public const int AK_SPAT_NUM_STORAGE_BITS = 3;

	public const int AK_MAX_BITS_METERING_FLAGS = 5;

	public const int AK_OS_STRUCT_ALIGN = 4;

	public const int AK_64B_OS_STRUCT_ALIGN = 8;

	public const bool AK_ASYNC_OPEN_DEFAULT = false;

	public const int AK_COMM_DEFAULT_DISCOVERY_PORT = 24024;

	public const int AK_MIDI_EVENT_TYPE_INVALID = 0;

	public const int AK_MIDI_EVENT_TYPE_NOTE_OFF = 128;

	public const int AK_MIDI_EVENT_TYPE_NOTE_ON = 144;

	public const int AK_MIDI_EVENT_TYPE_NOTE_AFTERTOUCH = 160;

	public const int AK_MIDI_EVENT_TYPE_CONTROLLER = 176;

	public const int AK_MIDI_EVENT_TYPE_PROGRAM_CHANGE = 192;

	public const int AK_MIDI_EVENT_TYPE_CHANNEL_AFTERTOUCH = 208;

	public const int AK_MIDI_EVENT_TYPE_PITCH_BEND = 224;

	public const int AK_MIDI_EVENT_TYPE_SYSEX = 240;

	public const int AK_MIDI_EVENT_TYPE_ESCAPE = 247;

	public const int AK_MIDI_EVENT_TYPE_META = 255;

	public const int AK_MIDI_CC_BANK_SELECT_COARSE = 0;

	public const int AK_MIDI_CC_MOD_WHEEL_COARSE = 1;

	public const int AK_MIDI_CC_BREATH_CTRL_COARSE = 2;

	public const int AK_MIDI_CC_CTRL_3_COARSE = 3;

	public const int AK_MIDI_CC_FOOT_PEDAL_COARSE = 4;

	public const int AK_MIDI_CC_PORTAMENTO_COARSE = 5;

	public const int AK_MIDI_CC_DATA_ENTRY_COARSE = 6;

	public const int AK_MIDI_CC_VOLUME_COARSE = 7;

	public const int AK_MIDI_CC_BALANCE_COARSE = 8;

	public const int AK_MIDI_CC_CTRL_9_COARSE = 9;

	public const int AK_MIDI_CC_PAN_POSITION_COARSE = 10;

	public const int AK_MIDI_CC_EXPRESSION_COARSE = 11;

	public const int AK_MIDI_CC_EFFECT_CTRL_1_COARSE = 12;

	public const int AK_MIDI_CC_EFFECT_CTRL_2_COARSE = 13;

	public const int AK_MIDI_CC_CTRL_14_COARSE = 14;

	public const int AK_MIDI_CC_CTRL_15_COARSE = 15;

	public const int AK_MIDI_CC_GEN_SLIDER_1 = 16;

	public const int AK_MIDI_CC_GEN_SLIDER_2 = 17;

	public const int AK_MIDI_CC_GEN_SLIDER_3 = 18;

	public const int AK_MIDI_CC_GEN_SLIDER_4 = 19;

	public const int AK_MIDI_CC_CTRL_20_COARSE = 20;

	public const int AK_MIDI_CC_CTRL_21_COARSE = 21;

	public const int AK_MIDI_CC_CTRL_22_COARSE = 22;

	public const int AK_MIDI_CC_CTRL_23_COARSE = 23;

	public const int AK_MIDI_CC_CTRL_24_COARSE = 24;

	public const int AK_MIDI_CC_CTRL_25_COARSE = 25;

	public const int AK_MIDI_CC_CTRL_26_COARSE = 26;

	public const int AK_MIDI_CC_CTRL_27_COARSE = 27;

	public const int AK_MIDI_CC_CTRL_28_COARSE = 28;

	public const int AK_MIDI_CC_CTRL_29_COARSE = 29;

	public const int AK_MIDI_CC_CTRL_30_COARSE = 30;

	public const int AK_MIDI_CC_CTRL_31_COARSE = 31;

	public const int AK_MIDI_CC_BANK_SELECT_FINE = 32;

	public const int AK_MIDI_CC_MOD_WHEEL_FINE = 33;

	public const int AK_MIDI_CC_BREATH_CTRL_FINE = 34;

	public const int AK_MIDI_CC_CTRL_3_FINE = 35;

	public const int AK_MIDI_CC_FOOT_PEDAL_FINE = 36;

	public const int AK_MIDI_CC_PORTAMENTO_FINE = 37;

	public const int AK_MIDI_CC_DATA_ENTRY_FINE = 38;

	public const int AK_MIDI_CC_VOLUME_FINE = 39;

	public const int AK_MIDI_CC_BALANCE_FINE = 40;

	public const int AK_MIDI_CC_CTRL_9_FINE = 41;

	public const int AK_MIDI_CC_PAN_POSITION_FINE = 42;

	public const int AK_MIDI_CC_EXPRESSION_FINE = 43;

	public const int AK_MIDI_CC_EFFECT_CTRL_1_FINE = 44;

	public const int AK_MIDI_CC_EFFECT_CTRL_2_FINE = 45;

	public const int AK_MIDI_CC_CTRL_14_FINE = 46;

	public const int AK_MIDI_CC_CTRL_15_FINE = 47;

	public const int AK_MIDI_CC_CTRL_20_FINE = 52;

	public const int AK_MIDI_CC_CTRL_21_FINE = 53;

	public const int AK_MIDI_CC_CTRL_22_FINE = 54;

	public const int AK_MIDI_CC_CTRL_23_FINE = 55;

	public const int AK_MIDI_CC_CTRL_24_FINE = 56;

	public const int AK_MIDI_CC_CTRL_25_FINE = 57;

	public const int AK_MIDI_CC_CTRL_26_FINE = 58;

	public const int AK_MIDI_CC_CTRL_27_FINE = 59;

	public const int AK_MIDI_CC_CTRL_28_FINE = 60;

	public const int AK_MIDI_CC_CTRL_29_FINE = 61;

	public const int AK_MIDI_CC_CTRL_30_FINE = 62;

	public const int AK_MIDI_CC_CTRL_31_FINE = 63;

	public const int AK_MIDI_CC_HOLD_PEDAL = 64;

	public const int AK_MIDI_CC_PORTAMENTO_ON_OFF = 65;

	public const int AK_MIDI_CC_SUSTENUTO_PEDAL = 66;

	public const int AK_MIDI_CC_SOFT_PEDAL = 67;

	public const int AK_MIDI_CC_LEGATO_PEDAL = 68;

	public const int AK_MIDI_CC_HOLD_PEDAL_2 = 69;

	public const int AK_MIDI_CC_SOUND_VARIATION = 70;

	public const int AK_MIDI_CC_SOUND_TIMBRE = 71;

	public const int AK_MIDI_CC_SOUND_RELEASE_TIME = 72;

	public const int AK_MIDI_CC_SOUND_ATTACK_TIME = 73;

	public const int AK_MIDI_CC_SOUND_BRIGHTNESS = 74;

	public const int AK_MIDI_CC_SOUND_CTRL_6 = 75;

	public const int AK_MIDI_CC_SOUND_CTRL_7 = 76;

	public const int AK_MIDI_CC_SOUND_CTRL_8 = 77;

	public const int AK_MIDI_CC_SOUND_CTRL_9 = 78;

	public const int AK_MIDI_CC_SOUND_CTRL_10 = 79;

	public const int AK_MIDI_CC_GENERAL_BUTTON_1 = 80;

	public const int AK_MIDI_CC_GENERAL_BUTTON_2 = 81;

	public const int AK_MIDI_CC_GENERAL_BUTTON_3 = 82;

	public const int AK_MIDI_CC_GENERAL_BUTTON_4 = 83;

	public const int AK_MIDI_CC_REVERB_LEVEL = 91;

	public const int AK_MIDI_CC_TREMOLO_LEVEL = 92;

	public const int AK_MIDI_CC_CHORUS_LEVEL = 93;

	public const int AK_MIDI_CC_CELESTE_LEVEL = 94;

	public const int AK_MIDI_CC_PHASER_LEVEL = 95;

	public const int AK_MIDI_CC_DATA_BUTTON_P1 = 96;

	public const int AK_MIDI_CC_DATA_BUTTON_M1 = 97;

	public const int AK_MIDI_CC_NON_REGISTER_COARSE = 98;

	public const int AK_MIDI_CC_NON_REGISTER_FINE = 99;

	public const int AK_MIDI_CC_ALL_SOUND_OFF = 120;

	public const int AK_MIDI_CC_ALL_CONTROLLERS_OFF = 121;

	public const int AK_MIDI_CC_LOCAL_KEYBOARD = 122;

	public const int AK_MIDI_CC_ALL_NOTES_OFF = 123;

	public const int AK_MIDI_CC_OMNI_MODE_OFF = 124;

	public const int AK_MIDI_CC_OMNI_MODE_ON = 125;

	public const int AK_MIDI_CC_OMNI_MONOPHONIC_ON = 126;

	public const int AK_MIDI_CC_OMNI_POLYPHONIC_ON = 127;

	public const int AK_SPEAKER_FRONT_LEFT = 1;

	public const int AK_SPEAKER_FRONT_RIGHT = 2;

	public const int AK_SPEAKER_FRONT_CENTER = 4;

	public const int AK_SPEAKER_LOW_FREQUENCY = 8;

	public const int AK_SPEAKER_BACK_LEFT = 16;

	public const int AK_SPEAKER_BACK_RIGHT = 32;

	public const int AK_SPEAKER_BACK_CENTER = 256;

	public const int AK_SPEAKER_SIDE_LEFT = 512;

	public const int AK_SPEAKER_SIDE_RIGHT = 1024;

	public const int AK_SPEAKER_TOP = 2048;

	public const int AK_SPEAKER_HEIGHT_FRONT_LEFT = 4096;

	public const int AK_SPEAKER_HEIGHT_FRONT_CENTER = 8192;

	public const int AK_SPEAKER_HEIGHT_FRONT_RIGHT = 16384;

	public const int AK_SPEAKER_HEIGHT_BACK_LEFT = 32768;

	public const int AK_SPEAKER_HEIGHT_BACK_CENTER = 65536;

	public const int AK_SPEAKER_HEIGHT_BACK_RIGHT = 131072;

	public const int AK_SPEAKER_SETUP_MONO = 4;

	public const int AK_SPEAKER_SETUP_0POINT1 = 8;

	public const int AK_SPEAKER_SETUP_1POINT1 = 12;

	public const int AK_SPEAKER_SETUP_STEREO = 3;

	public const int AK_SPEAKER_SETUP_2POINT1 = 11;

	public const int AK_SPEAKER_SETUP_3STEREO = 7;

	public const int AK_SPEAKER_SETUP_3POINT1 = 15;

	public const int AK_SPEAKER_SETUP_4 = 1539;

	public const int AK_SPEAKER_SETUP_4POINT1 = 1547;

	public const int AK_SPEAKER_SETUP_5 = 1543;

	public const int AK_SPEAKER_SETUP_5POINT1 = 1551;

	public const int AK_SPEAKER_SETUP_6 = 1587;

	public const int AK_SPEAKER_SETUP_6POINT1 = 1595;

	public const int AK_SPEAKER_SETUP_7 = 1591;

	public const int AK_SPEAKER_SETUP_7POINT1 = 1599;

	public const int AK_SPEAKER_SETUP_SURROUND = 259;

	public const int AK_SPEAKER_SETUP_DPL2 = 1539;

	public const int AK_SPEAKER_SETUP_HEIGHT_4 = 184320;

	public const int AK_SPEAKER_SETUP_HEIGHT_5 = 192512;

	public const int AK_SPEAKER_SETUP_HEIGHT_ALL = 258048;

	public const int AK_SPEAKER_SETUP_AURO_222 = 22019;

	public const int AK_SPEAKER_SETUP_AURO_8 = 185859;

	public const int AK_SPEAKER_SETUP_AURO_9 = 185863;

	public const int AK_SPEAKER_SETUP_AURO_9POINT1 = 185871;

	public const int AK_SPEAKER_SETUP_AURO_10 = 187911;

	public const int AK_SPEAKER_SETUP_AURO_10POINT1 = 187919;

	public const int AK_SPEAKER_SETUP_AURO_11 = 196103;

	public const int AK_SPEAKER_SETUP_AURO_11POINT1 = 196111;

	public const int AK_SPEAKER_SETUP_AURO_11_740 = 185911;

	public const int AK_SPEAKER_SETUP_AURO_11POINT1_740 = 185919;

	public const int AK_SPEAKER_SETUP_AURO_13_751 = 196151;

	public const int AK_SPEAKER_SETUP_AURO_13POINT1_751 = 196159;

	public const int AK_SPEAKER_SETUP_DOLBY_5_0_2 = 22023;

	public const int AK_SPEAKER_SETUP_DOLBY_5_1_2 = 22031;

	public const int AK_SPEAKER_SETUP_DOLBY_6_0_2 = 22067;

	public const int AK_SPEAKER_SETUP_DOLBY_6_1_2 = 22075;

	public const int AK_SPEAKER_SETUP_DOLBY_6_0_4 = 185907;

	public const int AK_SPEAKER_SETUP_DOLBY_6_1_4 = 185915;

	public const int AK_SPEAKER_SETUP_DOLBY_7_0_2 = 22071;

	public const int AK_SPEAKER_SETUP_DOLBY_7_1_2 = 22079;

	public const int AK_SPEAKER_SETUP_DOLBY_7_0_4 = 185911;

	public const int AK_SPEAKER_SETUP_DOLBY_7_1_4 = 185919;

	public const int AK_SPEAKER_SETUP_ALL_SPEAKERS = 261951;

	public const int AK_IDX_SETUP_FRONT_LEFT = 0;

	public const int AK_IDX_SETUP_FRONT_RIGHT = 1;

	public const int AK_IDX_SETUP_CENTER = 2;

	public const int AK_IDX_SETUP_NOCENTER_BACK_LEFT = 2;

	public const int AK_IDX_SETUP_NOCENTER_BACK_RIGHT = 3;

	public const int AK_IDX_SETUP_NOCENTER_SIDE_LEFT = 4;

	public const int AK_IDX_SETUP_NOCENTER_SIDE_RIGHT = 5;

	public const int AK_IDX_SETUP_WITHCENTER_BACK_LEFT = 3;

	public const int AK_IDX_SETUP_WITHCENTER_BACK_RIGHT = 4;

	public const int AK_IDX_SETUP_WITHCENTER_SIDE_LEFT = 5;

	public const int AK_IDX_SETUP_WITHCENTER_SIDE_RIGHT = 6;

	public const int AK_IDX_SETUP_0_LFE = 0;

	public const int AK_IDX_SETUP_1_CENTER = 0;

	public const int AK_IDX_SETUP_1_LFE = 1;

	public const int AK_IDX_SETUP_2_LEFT = 0;

	public const int AK_IDX_SETUP_2_RIGHT = 1;

	public const int AK_IDX_SETUP_2_LFE = 2;

	public const int AK_IDX_SETUP_3_LEFT = 0;

	public const int AK_IDX_SETUP_3_RIGHT = 1;

	public const int AK_IDX_SETUP_3_CENTER = 2;

	public const int AK_IDX_SETUP_3_LFE = 3;

	public const int AK_IDX_SETUP_4_FRONTLEFT = 0;

	public const int AK_IDX_SETUP_4_FRONTRIGHT = 1;

	public const int AK_IDX_SETUP_4_REARLEFT = 2;

	public const int AK_IDX_SETUP_4_REARRIGHT = 3;

	public const int AK_IDX_SETUP_4_LFE = 4;

	public const int AK_IDX_SETUP_5_FRONTLEFT = 0;

	public const int AK_IDX_SETUP_5_FRONTRIGHT = 1;

	public const int AK_IDX_SETUP_5_CENTER = 2;

	public const int AK_IDX_SETUP_5_REARLEFT = 3;

	public const int AK_IDX_SETUP_5_REARRIGHT = 4;

	public const int AK_IDX_SETUP_5_LFE = 5;

	public const int AK_IDX_SETUP_6_FRONTLEFT = 0;

	public const int AK_IDX_SETUP_6_FRONTRIGHT = 1;

	public const int AK_IDX_SETUP_6_REARLEFT = 2;

	public const int AK_IDX_SETUP_6_REARRIGHT = 3;

	public const int AK_IDX_SETUP_6_SIDELEFT = 4;

	public const int AK_IDX_SETUP_6_SIDERIGHT = 5;

	public const int AK_IDX_SETUP_6_LFE = 6;

	public const int AK_IDX_SETUP_7_FRONTLEFT = 0;

	public const int AK_IDX_SETUP_7_FRONTRIGHT = 1;

	public const int AK_IDX_SETUP_7_CENTER = 2;

	public const int AK_IDX_SETUP_7_REARLEFT = 3;

	public const int AK_IDX_SETUP_7_REARRIGHT = 4;

	public const int AK_IDX_SETUP_7_SIDELEFT = 5;

	public const int AK_IDX_SETUP_7_SIDERIGHT = 6;

	public const int AK_IDX_SETUP_7_LFE = 7;

	public const int AK_SPEAKER_SETUP_0_1 = 8;

	public const int AK_SPEAKER_SETUP_1_0_CENTER = 4;

	public const int AK_SPEAKER_SETUP_1_1_CENTER = 12;

	public const int AK_SPEAKER_SETUP_2_0 = 3;

	public const int AK_SPEAKER_SETUP_2_1 = 11;

	public const int AK_SPEAKER_SETUP_3_0 = 7;

	public const int AK_SPEAKER_SETUP_3_1 = 15;

	public const int AK_SPEAKER_SETUP_FRONT = 7;

	public const int AK_SPEAKER_SETUP_4_0 = 1539;

	public const int AK_SPEAKER_SETUP_4_1 = 1547;

	public const int AK_SPEAKER_SETUP_5_0 = 1543;

	public const int AK_SPEAKER_SETUP_5_1 = 1551;

	public const int AK_SPEAKER_SETUP_6_0 = 1587;

	public const int AK_SPEAKER_SETUP_6_1 = 1595;

	public const int AK_SPEAKER_SETUP_7_0 = 1591;

	public const int AK_SPEAKER_SETUP_7_1 = 1599;

	public const int AK_SPEAKER_SETUP_DEFAULT_PLANE = 1599;

	public const int AK_SUPPORTED_STANDARD_CHANNEL_MASK = 261951;

	public const int AK_STANDARD_MAX_NUM_CHANNELS = 8;

	public const int AK_MAX_AMBISONICS_ORDER = 5;

	public const int AK_MAX_NUM_TEXTURE = 4;

	public const int AK_MAX_REFLECT_ORDER = 4;

	public const int AK_MAX_REFLECTION_PATH_LENGTH = 8;

	public const int AK_MAX_SOUND_PROPAGATION_DEPTH = 8;

	public const double AK_DEFAULT_DIFFR_SHADOW_DEGREES = 30.0;

	public const double AK_DEFAULT_DIFFR_SHADOW_ATTEN = 1.0;

	public const double AK_DEFAULT_MOVEMENT_THRESHOLD = 1.0;

	public const int AK_DEFAULT_REFLECTIONS_ORDER = 1;

	public const double AK_SA_EPSILON = 0.001;

	public const double AK_SA_DIFFRACTION_EPSILON = 0.002;

	public const double AK_SA_PLANE_THICKNESS_RATIO = 0.005;

	private static GameObjectHashFunction gameObjectHash;

	public const string Deprecation_2018_1_2 = "This functionality is deprecated as of Wwise v2018.1.2 and will be removed in a future release.";

	public const string Deprecation_2018_1_6 = "This functionality is deprecated as of Wwise v2018.1.6 and will be removed in a future release.";

	public const string Deprecation_2019_2_0 = "This functionality is deprecated as of Wwise v2019.2.0 and will be removed in a future release.";

	public const string Deprecation_2019_2_2 = "This functionality is deprecated as of Wwise v2019.2.2 and will be removed in a future release.";

	private static readonly HashSet<ulong> RegisteredGameObjects;

	public static uint AK_SOUNDBANK_VERSION => default(uint);

	public static ushort AK_INT => default(ushort);

	public static ushort AK_FLOAT => default(ushort);

	public static byte AK_INTERLEAVED => default(byte);

	public static byte AK_NONINTERLEAVED => default(byte);

	public static uint AK_LE_NATIVE_BITSPERSAMPLE => default(uint);

	public static uint AK_LE_NATIVE_SAMPLETYPE => default(uint);

	public static uint AK_LE_NATIVE_INTERLEAVE => default(uint);

	public static byte AK_INVALID_MIDI_CHANNEL => default(byte);

	public static byte AK_INVALID_MIDI_NOTE => default(byte);

	public static float kDefaultMaxPathLength => default(float);

	public static uint kDefaultDiffractionMaxEdges => default(uint);

	public static uint kDefaultDiffractionMaxPaths => default(uint);

	public static float kMaxDiffraction => default(float);

	public static uint kDiffractionMaxEdges => default(uint);

	public static uint kDiffractionMaxPaths => default(uint);

	public static uint kPortalToPortalDiffractionMaxPaths => default(uint);

	public static GameObjectHashFunction GameObjectHash
	{
		set
		{
		}
	}

	public static string WwiseVersion => null;

	public static uint DynamicSequenceOpen(GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, AkDynamicSequenceType in_eDynamicSequenceType)
	{
		return default(uint);
	}

	public static uint DynamicSequenceOpen(GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie)
	{
		return default(uint);
	}

	public static uint DynamicSequenceOpen(GameObject in_gameObjectID)
	{
		return default(uint);
	}

	public static AKRESULT DynamicSequenceClose(uint in_playingID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT DynamicSequencePlay(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve)
	{
		return default(AKRESULT);
	}

	public static AKRESULT DynamicSequencePlay(uint in_playingID, int in_uTransitionDuration)
	{
		return default(AKRESULT);
	}

	public static AKRESULT DynamicSequencePlay(uint in_playingID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT DynamicSequencePause(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve)
	{
		return default(AKRESULT);
	}

	public static AKRESULT DynamicSequencePause(uint in_playingID, int in_uTransitionDuration)
	{
		return default(AKRESULT);
	}

	public static AKRESULT DynamicSequencePause(uint in_playingID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT DynamicSequenceResume(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve)
	{
		return default(AKRESULT);
	}

	public static AKRESULT DynamicSequenceResume(uint in_playingID, int in_uTransitionDuration)
	{
		return default(AKRESULT);
	}

	public static AKRESULT DynamicSequenceResume(uint in_playingID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT DynamicSequenceStop(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve)
	{
		return default(AKRESULT);
	}

	public static AKRESULT DynamicSequenceStop(uint in_playingID, int in_uTransitionDuration)
	{
		return default(AKRESULT);
	}

	public static AKRESULT DynamicSequenceStop(uint in_playingID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT DynamicSequenceBreak(uint in_playingID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT Seek(uint in_playingID, int in_iPosition, bool in_bSeekToNearestMarker)
	{
		return default(AKRESULT);
	}

	public static AKRESULT Seek(uint in_playingID, float in_fPercent, bool in_bSeekToNearestMarker)
	{
		return default(AKRESULT);
	}

	public static AKRESULT DynamicSequenceGetPauseTimes(uint in_playingID, out uint out_uTime, out uint out_uDuration)
	{
		return default(AKRESULT);
	}

	public static AkPlaylist DynamicSequenceLockPlaylist(uint in_playingID)
	{
		return null;
	}

	public static AKRESULT DynamicSequenceUnlockPlaylist(uint in_playingID)
	{
		return default(AKRESULT);
	}

	public static bool IsInitialized()
	{
		return default(bool);
	}

	public static AKRESULT GetAudioSettings(AkAudioSettings out_audioSettings)
	{
		return default(AKRESULT);
	}

	public static AkChannelConfig GetSpeakerConfiguration(ulong in_idOutput)
	{
		return null;
	}

	public static AkChannelConfig GetSpeakerConfiguration()
	{
		return null;
	}

	public static AKRESULT GetPanningRule(out int out_ePanningRule, ulong in_idOutput)
	{
		return default(AKRESULT);
	}

	public static AKRESULT GetPanningRule(out int out_ePanningRule)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetPanningRule(AkPanningRule in_ePanningRule, ulong in_idOutput)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetPanningRule(AkPanningRule in_ePanningRule)
	{
		return default(AKRESULT);
	}

	public static AKRESULT GetSpeakerAngles(float[] io_pfSpeakerAngles, ref uint io_uNumAngles, out float out_fHeightAngle, ulong in_idOutput)
	{
		return default(AKRESULT);
	}

	public static AKRESULT GetSpeakerAngles(float[] io_pfSpeakerAngles, ref uint io_uNumAngles, out float out_fHeightAngle)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetSpeakerAngles(float[] in_pfSpeakerAngles, uint in_uNumAngles, float in_fHeightAngle, ulong in_idOutput)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetSpeakerAngles(float[] in_pfSpeakerAngles, uint in_uNumAngles, float in_fHeightAngle)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetVolumeThreshold(float in_fVolumeThresholdDB)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetMaxNumVoicesLimit(ushort in_maxNumberVoices)
	{
		return default(AKRESULT);
	}

	public static AKRESULT RenderAudio(bool in_bAllowSyncRender)
	{
		return default(AKRESULT);
	}

	public static AKRESULT RenderAudio()
	{
		return default(AKRESULT);
	}

	public static AKRESULT RegisterPluginDLL(string in_DllName, string in_DllPath)
	{
		return default(AKRESULT);
	}

	public static AKRESULT RegisterPluginDLL(string in_DllName)
	{
		return default(AKRESULT);
	}

	public static uint GetIDFromString(string in_pszString)
	{
		return default(uint);
	}

	public static uint PostEvent(uint in_eventID, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources, uint in_PlayingID)
	{
		return default(uint);
	}

	public static uint PostEvent(uint in_eventID, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources)
	{
		return default(uint);
	}

	public static uint PostEvent(uint in_eventID, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie)
	{
		return default(uint);
	}

	public static uint PostEvent(uint in_eventID, GameObject in_gameObjectID)
	{
		return default(uint);
	}

	public static uint PostEvent(string in_pszEventName, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources, uint in_PlayingID)
	{
		return default(uint);
	}

	public static uint PostEvent(string in_pszEventName, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources)
	{
		return default(uint);
	}

	public static uint PostEvent(string in_pszEventName, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie)
	{
		return default(uint);
	}

	public static uint PostEvent(string in_pszEventName, GameObject in_gameObjectID)
	{
		return default(uint);
	}

	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve, uint in_PlayingID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve)
	{
		return default(AKRESULT);
	}

	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration)
	{
		return default(AKRESULT);
	}

	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType)
	{
		return default(AKRESULT);
	}

	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve, uint in_PlayingID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve)
	{
		return default(AKRESULT);
	}

	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration)
	{
		return default(AKRESULT);
	}

	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType)
	{
		return default(AKRESULT);
	}

	public static AKRESULT PostMIDIOnEvent(uint in_eventID, GameObject in_gameObjectID, AkMIDIPostArray in_pPosts, ushort in_uNumPosts)
	{
		return default(AKRESULT);
	}

	public static AKRESULT StopMIDIOnEvent(uint in_eventID, GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT StopMIDIOnEvent(uint in_eventID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT StopMIDIOnEvent()
	{
		return default(AKRESULT);
	}

	public static AKRESULT PinEventInStreamCache(uint in_eventID, sbyte in_uActivePriority, sbyte in_uInactivePriority)
	{
		return default(AKRESULT);
	}

	public static AKRESULT PinEventInStreamCache(string in_pszEventName, sbyte in_uActivePriority, sbyte in_uInactivePriority)
	{
		return default(AKRESULT);
	}

	public static AKRESULT UnpinEventInStreamCache(uint in_eventID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT UnpinEventInStreamCache(string in_pszEventName)
	{
		return default(AKRESULT);
	}

	public static AKRESULT GetBufferStatusForPinnedEvent(uint in_eventID, out float out_fPercentBuffered, out int out_bCachePinnedMemoryFull)
	{
		return default(AKRESULT);
	}

	public static AKRESULT GetBufferStatusForPinnedEvent(string in_pszEventName, out float out_fPercentBuffered, out int out_bCachePinnedMemoryFull)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker, uint in_PlayingID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, int in_iPosition)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker, uint in_PlayingID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, int in_iPosition)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker, uint in_PlayingID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, float in_fPercent)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker, uint in_PlayingID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, float in_fPercent)
	{
		return default(AKRESULT);
	}

	public static void CancelEventCallbackCookie(object in_pCookie)
	{
	}

	public static void CancelEventCallbackGameObject(GameObject in_gameObjectID)
	{
	}

	public static void CancelEventCallback(uint in_playingID)
	{
	}

	public static AKRESULT GetSourcePlayPosition(uint in_PlayingID, out int out_puPosition, bool in_bExtrapolate)
	{
		return default(AKRESULT);
	}

	public static AKRESULT GetSourcePlayPosition(uint in_PlayingID, out int out_puPosition)
	{
		return default(AKRESULT);
	}

	public static AKRESULT GetSourceStreamBuffering(uint in_PlayingID, out int out_buffering, out int out_bIsBuffering)
	{
		return default(AKRESULT);
	}

	public static void StopAll(GameObject in_gameObjectID)
	{
	}

	public static void StopAll()
	{
	}

	public static void StopPlayingID(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve)
	{
	}

	public static void StopPlayingID(uint in_playingID, int in_uTransitionDuration)
	{
	}

	public static void StopPlayingID(uint in_playingID)
	{
	}

	public static void ExecuteActionOnPlayingID(AkActionOnEventType in_ActionType, uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve)
	{
	}

	public static void ExecuteActionOnPlayingID(AkActionOnEventType in_ActionType, uint in_playingID, int in_uTransitionDuration)
	{
	}

	public static void ExecuteActionOnPlayingID(AkActionOnEventType in_ActionType, uint in_playingID)
	{
	}

	public static void SetRandomSeed(uint in_uSeed)
	{
	}

	public static void MuteBackgroundMusic(bool in_bMute)
	{
	}

	public static bool GetBackgroundMusicMute()
	{
		return default(bool);
	}

	public static AKRESULT SendPluginCustomGameData(uint in_busID, GameObject in_busObjectID, AkPluginType in_eType, uint in_uCompanyID, uint in_uPluginID, IntPtr in_pData, uint in_uSizeInBytes)
	{
		return default(AKRESULT);
	}

	public static AKRESULT UnregisterAllGameObj()
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetMultiplePositions(GameObject in_GameObjectID, AkPositionArray in_pPositions, ushort in_NumPositions, AkMultiPositionType in_eMultiPositionType)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetMultiplePositions(GameObject in_GameObjectID, AkPositionArray in_pPositions, ushort in_NumPositions)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetMultiplePositions(GameObject in_GameObjectID, AkChannelEmitterArray in_pPositions, ushort in_NumPositions, AkMultiPositionType in_eMultiPositionType)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetMultiplePositions(GameObject in_GameObjectID, AkChannelEmitterArray in_pPositions, ushort in_NumPositions)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetScalingFactor(GameObject in_GameObjectID, float in_fAttenuationScalingFactor)
	{
		return default(AKRESULT);
	}

	public static AKRESULT ClearBanks()
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetBankLoadIOSettings(float in_fThroughput, sbyte in_priority)
	{
		return default(AKRESULT);
	}

	public static AKRESULT LoadBank(string in_pszString, out uint out_bankID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT LoadBank(uint in_bankID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT LoadBankMemoryView(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, out uint out_bankID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT LoadBankMemoryCopy(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, out uint out_bankID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT LoadBank(string in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, out uint out_bankID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT LoadBank(uint in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie)
	{
		return default(AKRESULT);
	}

	public static AKRESULT LoadBankMemoryView(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, out uint out_bankID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT LoadBankMemoryCopy(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, out uint out_bankID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT UnloadBank(string in_pszString, IntPtr in_pInMemoryBankPtr)
	{
		return default(AKRESULT);
	}

	public static AKRESULT UnloadBank(uint in_bankID, IntPtr in_pInMemoryBankPtr)
	{
		return default(AKRESULT);
	}

	public static AKRESULT UnloadBank(string in_pszString, IntPtr in_pInMemoryBankPtr, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie)
	{
		return default(AKRESULT);
	}

	public static AKRESULT UnloadBank(uint in_bankID, IntPtr in_pInMemoryBankPtr, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie)
	{
		return default(AKRESULT);
	}

	public static void CancelBankCallbackCookie(object in_pCookie)
	{
	}

	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString, AkBankContent in_uFlags)
	{
		return default(AKRESULT);
	}

	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString)
	{
		return default(AKRESULT);
	}

	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID, AkBankContent in_uFlags)
	{
		return default(AKRESULT);
	}

	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, AkBankContent in_uFlags)
	{
		return default(AKRESULT);
	}

	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie)
	{
		return default(AKRESULT);
	}

	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, AkBankContent in_uFlags)
	{
		return default(AKRESULT);
	}

	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie)
	{
		return default(AKRESULT);
	}

	public static AKRESULT ClearPreparedEvents()
	{
		return default(AKRESULT);
	}

	public static AKRESULT PrepareEvent(AkPreparationType in_PreparationType, string[] in_ppszString, uint in_uNumEvent)
	{
		return default(AKRESULT);
	}

	public static AKRESULT PrepareEvent(AkPreparationType in_PreparationType, uint[] in_pEventID, uint in_uNumEvent)
	{
		return default(AKRESULT);
	}

	public static AKRESULT PrepareEvent(AkPreparationType in_PreparationType, string[] in_ppszString, uint in_uNumEvent, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie)
	{
		return default(AKRESULT);
	}

	public static AKRESULT PrepareEvent(AkPreparationType in_PreparationType, uint[] in_pEventID, uint in_uNumEvent, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetMedia(AkSourceSettingsArray in_pSourceSettings, uint in_uNumSourceSettings)
	{
		return default(AKRESULT);
	}

	public static AKRESULT UnsetMedia(AkSourceSettingsArray in_pSourceSettings, uint in_uNumSourceSettings)
	{
		return default(AKRESULT);
	}

	public static AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, string in_pszGroupName, string[] in_ppszGameSyncName, uint in_uNumGameSyncs)
	{
		return default(AKRESULT);
	}

	public static AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, uint in_GroupID, uint[] in_paGameSyncID, uint in_uNumGameSyncs)
	{
		return default(AKRESULT);
	}

	public static AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, string in_pszGroupName, string[] in_ppszGameSyncName, uint in_uNumGameSyncs, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie)
	{
		return default(AKRESULT);
	}

	public static AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, uint in_GroupID, uint[] in_paGameSyncID, uint in_uNumGameSyncs, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie)
	{
		return default(AKRESULT);
	}

	public static AKRESULT AddListener(GameObject in_emitterGameObj, GameObject in_listenerGameObj)
	{
		return default(AKRESULT);
	}

	public static AKRESULT RemoveListener(GameObject in_emitterGameObj, GameObject in_listenerGameObj)
	{
		return default(AKRESULT);
	}

	public static AKRESULT AddDefaultListener(GameObject in_listenerGameObj)
	{
		return default(AKRESULT);
	}

	public static AKRESULT RemoveDefaultListener(GameObject in_listenerGameObj)
	{
		return default(AKRESULT);
	}

	public static AKRESULT ResetListenersToDefault(GameObject in_emitterGameObj)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetListenerSpatialization(GameObject in_uListenerID, bool in_bSpatialized, AkChannelConfig in_channelConfig, float[] in_pVolumeOffsets)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetListenerSpatialization(GameObject in_uListenerID, bool in_bSpatialized, AkChannelConfig in_channelConfig)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetRTPCValueByPlayingID(uint in_rtpcID, float in_value, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetRTPCValueByPlayingID(uint in_rtpcID, float in_value, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetRTPCValueByPlayingID(uint in_rtpcID, float in_value, uint in_playingID, int in_uValueChangeDuration)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetRTPCValueByPlayingID(uint in_rtpcID, float in_value, uint in_playingID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetRTPCValueByPlayingID(string in_pszRtpcName, float in_value, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetRTPCValueByPlayingID(string in_pszRtpcName, float in_value, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetRTPCValueByPlayingID(string in_pszRtpcName, float in_value, uint in_playingID, int in_uValueChangeDuration)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetRTPCValueByPlayingID(string in_pszRtpcName, float in_value, uint in_playingID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT ResetRTPCValue(uint in_rtpcID, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation)
	{
		return default(AKRESULT);
	}

	public static AKRESULT ResetRTPCValue(uint in_rtpcID, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve)
	{
		return default(AKRESULT);
	}

	public static AKRESULT ResetRTPCValue(uint in_rtpcID, GameObject in_gameObjectID, int in_uValueChangeDuration)
	{
		return default(AKRESULT);
	}

	public static AKRESULT ResetRTPCValue(uint in_rtpcID, GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT ResetRTPCValue(uint in_rtpcID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation)
	{
		return default(AKRESULT);
	}

	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve)
	{
		return default(AKRESULT);
	}

	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, GameObject in_gameObjectID, int in_uValueChangeDuration)
	{
		return default(AKRESULT);
	}

	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT ResetRTPCValue(string in_pszRtpcName)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetSwitch(uint in_switchGroup, uint in_switchState, GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetSwitch(string in_pszSwitchGroup, string in_pszSwitchState, GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT PostTrigger(uint in_triggerID, GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT PostTrigger(string in_pszTrigger, GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetState(uint in_stateGroup, uint in_state)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetState(string in_pszStateGroup, string in_pszState)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetGameObjectAuxSendValues(GameObject in_gameObjectID, AkAuxSendArray in_aAuxSendValues, uint in_uNumSendValues)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetGameObjectOutputBusVolume(GameObject in_emitterObjID, GameObject in_listenerObjID, float in_fControlValue)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetActorMixerEffect(uint in_audioNodeID, uint in_uFXIndex, uint in_shareSetID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetBusEffect(uint in_audioNodeID, uint in_uFXIndex, uint in_shareSetID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetBusEffect(string in_pszBusName, uint in_uFXIndex, uint in_shareSetID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetMixer(uint in_audioNodeID, uint in_shareSetID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetMixer(string in_pszBusName, uint in_shareSetID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetBusConfig(uint in_audioNodeID, AkChannelConfig in_channelConfig)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetBusConfig(string in_pszBusName, AkChannelConfig in_channelConfig)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetObjectObstructionAndOcclusion(GameObject in_EmitterID, GameObject in_ListenerID, float in_fObstructionLevel, float in_fOcclusionLevel)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetMultipleObstructionAndOcclusion(GameObject in_EmitterID, GameObject in_uListenerID, AkObstructionOcclusionValuesArray in_fObstructionOcclusionValues, uint in_uNumOcclusionObstruction)
	{
		return default(AKRESULT);
	}

	public static AKRESULT StartOutputCapture(string in_CaptureFileName)
	{
		return default(AKRESULT);
	}

	public static AKRESULT StopOutputCapture()
	{
		return default(AKRESULT);
	}

	public static AKRESULT AddOutputCaptureMarker(string in_MarkerText)
	{
		return default(AKRESULT);
	}

	public static AKRESULT StartProfilerCapture(string in_CaptureFileName)
	{
		return default(AKRESULT);
	}

	public static AKRESULT StopProfilerCapture()
	{
		return default(AKRESULT);
	}

	public static AKRESULT RemoveOutput(ulong in_idOutput)
	{
		return default(AKRESULT);
	}

	public static AKRESULT ReplaceOutput(AkOutputSettings in_Settings, ulong in_outputDeviceId, out ulong out_pOutputDeviceId)
	{
		return default(AKRESULT);
	}

	public static AKRESULT ReplaceOutput(AkOutputSettings in_Settings, ulong in_outputDeviceId)
	{
		return default(AKRESULT);
	}

	public static ulong GetOutputID(uint in_idShareset, uint in_idDevice)
	{
		return default(ulong);
	}

	public static ulong GetOutputID(string in_szShareSet, uint in_idDevice)
	{
		return default(ulong);
	}

	public static AKRESULT SetBusDevice(uint in_idBus, uint in_idNewDevice)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetBusDevice(string in_BusName, string in_DeviceName)
	{
		return default(AKRESULT);
	}

	public static AKRESULT GetDeviceList(uint in_ulCompanyID, uint in_ulPluginID, out uint io_maxNumDevices, AkDeviceDescriptionArray out_deviceDescriptions)
	{
		return default(AKRESULT);
	}

	public static AKRESULT GetDeviceList(uint in_audioDeviceShareSetID, out uint io_maxNumDevices, AkDeviceDescriptionArray out_deviceDescriptions)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetOutputVolume(ulong in_idOutput, float in_fVolume)
	{
		return default(AKRESULT);
	}

	public static AKRESULT GetDeviceSpatialAudioSupport(uint in_idDevice)
	{
		return default(AKRESULT);
	}

	public static AKRESULT Suspend(bool in_bRenderAnyway)
	{
		return default(AKRESULT);
	}

	public static AKRESULT Suspend()
	{
		return default(AKRESULT);
	}

	public static AKRESULT WakeupFromSuspend()
	{
		return default(AKRESULT);
	}

	public static uint GetBufferTick()
	{
		return default(uint);
	}

	public static AKRESULT GetPlayingSegmentInfo(uint in_PlayingID, AkSegmentInfo out_segmentInfo, bool in_bExtrapolate)
	{
		return default(AKRESULT);
	}

	public static AKRESULT GetPlayingSegmentInfo(uint in_PlayingID, AkSegmentInfo out_segmentInfo)
	{
		return default(AKRESULT);
	}

	public static void LocalOutput(AkMonitorErrorCode in_eErrorCode, string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID)
	{
	}

	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID, uint in_audioNodeID, bool in_bIsBus)
	{
		return default(AKRESULT);
	}

	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID, uint in_audioNodeID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel)
	{
		return default(AKRESULT);
	}

	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID, uint in_audioNodeID, bool in_bIsBus)
	{
		return default(AKRESULT);
	}

	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID, uint in_audioNodeID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel)
	{
		return default(AKRESULT);
	}

	public static int GetTimeStamp()
	{
		return default(int);
	}

	public static uint GetNumNonZeroBits(uint in_uWord)
	{
		return default(uint);
	}

	public static void AkGetDefaultHighPriorityThreadProperties(AkThreadProperties out_threadProperties)
	{
	}

	public static uint ResolveDialogueEvent(uint in_eventID, uint[] in_aArgumentValues, uint in_uNumArguments, uint in_idSequence)
	{
		return default(uint);
	}

	public static uint ResolveDialogueEvent(uint in_eventID, uint[] in_aArgumentValues, uint in_uNumArguments)
	{
		return default(uint);
	}

	public static AKRESULT GetDialogueEventCustomPropertyValue(uint in_eventID, uint in_uPropID, out int out_iValue)
	{
		return default(AKRESULT);
	}

	public static AKRESULT GetDialogueEventCustomPropertyValue(uint in_eventID, uint in_uPropID, out float out_fValue)
	{
		return default(AKRESULT);
	}

	public static AKRESULT GetPosition(GameObject in_GameObjectID, AkTransform out_rPosition)
	{
		return default(AKRESULT);
	}

	public static AKRESULT GetListenerPosition(GameObject in_uIndex, AkTransform out_rPosition)
	{
		return default(AKRESULT);
	}

	public static AKRESULT GetRTPCValue(uint in_rtpcID, GameObject in_gameObjectID, uint in_playingID, out float out_rValue, ref int io_rValueType)
	{
		return default(AKRESULT);
	}

	public static AKRESULT GetRTPCValue(string in_pszRtpcName, GameObject in_gameObjectID, uint in_playingID, out float out_rValue, ref int io_rValueType)
	{
		return default(AKRESULT);
	}

	public static AKRESULT GetSwitch(uint in_switchGroup, GameObject in_gameObjectID, out uint out_rSwitchState)
	{
		return default(AKRESULT);
	}

	public static AKRESULT GetSwitch(string in_pstrSwitchGroupName, GameObject in_GameObj, out uint out_rSwitchState)
	{
		return default(AKRESULT);
	}

	public static AKRESULT GetState(uint in_stateGroup, out uint out_rState)
	{
		return default(AKRESULT);
	}

	public static AKRESULT GetState(string in_pstrStateGroupName, out uint out_rState)
	{
		return default(AKRESULT);
	}

	public static AKRESULT GetGameObjectAuxSendValues(GameObject in_gameObjectID, AkAuxSendArray out_paAuxSendValues, ref uint io_ruNumSendValues)
	{
		return default(AKRESULT);
	}

	public static AKRESULT GetGameObjectDryLevelValue(GameObject in_EmitterID, GameObject in_ListenerID, out float out_rfControlValue)
	{
		return default(AKRESULT);
	}

	public static AKRESULT GetObjectObstructionAndOcclusion(GameObject in_EmitterID, GameObject in_ListenerID, out float out_rfObstructionLevel, out float out_rfOcclusionLevel)
	{
		return default(AKRESULT);
	}

	public static AKRESULT QueryAudioObjectIDs(uint in_eventID, ref uint io_ruNumItems, AkObjectInfoArray out_aObjectInfos)
	{
		return default(AKRESULT);
	}

	public static AKRESULT QueryAudioObjectIDs(string in_pszEventName, ref uint io_ruNumItems, AkObjectInfoArray out_aObjectInfos)
	{
		return default(AKRESULT);
	}

	public static AKRESULT GetPositioningInfo(uint in_ObjectID, AkPositioningInfo out_rPositioningInfo)
	{
		return default(AKRESULT);
	}

	public static bool GetIsGameObjectActive(GameObject in_GameObjId)
	{
		return default(bool);
	}

	public static float GetMaxRadius(GameObject in_GameObjId)
	{
		return default(float);
	}

	public static uint GetEventIDFromPlayingID(uint in_playingID)
	{
		return default(uint);
	}

	public static ulong GetGameObjectFromPlayingID(uint in_playingID)
	{
		return default(ulong);
	}

	public static AKRESULT GetPlayingIDsFromGameObject(GameObject in_GameObjId, ref uint io_ruNumIDs, uint[] out_aPlayingIDs)
	{
		return default(AKRESULT);
	}

	public static AKRESULT GetCustomPropertyValue(uint in_ObjectID, uint in_uPropID, out int out_iValue)
	{
		return default(AKRESULT);
	}

	public static AKRESULT GetCustomPropertyValue(uint in_ObjectID, uint in_uPropID, out float out_fValue)
	{
		return default(AKRESULT);
	}

	public static void AK_SPEAKER_SETUP_FIX_LEFT_TO_CENTER(ref uint io_uChannelMask)
	{
	}

	public static void AK_SPEAKER_SETUP_FIX_REAR_TO_SIDE(ref uint io_uChannelMask)
	{
	}

	public static void AK_SPEAKER_SETUP_CONVERT_TO_SUPPORTED(ref uint io_uChannelMask)
	{
	}

	public static byte ChannelMaskToNumChannels(uint in_uChannelMask)
	{
		return default(byte);
	}

	public static uint ChannelMaskFromNumChannels(uint in_uNumChannels)
	{
		return default(uint);
	}

	public static byte ChannelBitToIndex(uint in_uChannelBit, uint in_uChannelMask)
	{
		return default(byte);
	}

	public static bool HasSurroundChannels(uint in_uChannelMask)
	{
		return default(bool);
	}

	public static bool HasStrictlyOnePairOfSurroundChannels(uint in_uChannelMask)
	{
		return default(bool);
	}

	public static bool HasSideAndRearChannels(uint in_uChannelMask)
	{
		return default(bool);
	}

	public static bool HasHeightChannels(uint in_uChannelMask)
	{
		return default(bool);
	}

	public static uint BackToSideChannels(uint in_uChannelMask)
	{
		return default(uint);
	}

	public static uint StdChannelIndexToDisplayIndex(AkChannelOrdering in_eOrdering, uint in_uChannelMask, uint in_uChannelIdx)
	{
		return default(uint);
	}

	public static AKRESULT SetImageSource(uint in_srcID, AkImageSourceSettings in_info, uint in_AuxBusID, ulong in_roomID, GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT RemoveImageSource(uint in_srcID, uint in_AuxBusID, GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT ClearImageSources(uint in_AuxBusID, GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT ClearImageSources(uint in_AuxBusID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT ClearImageSources()
	{
		return default(AKRESULT);
	}

	public static AKRESULT RemoveGeometry(ulong in_SetID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT QueryReflectionPaths(GameObject in_gameObjectID, ref Vector3 out_listenerPos, ref Vector3 out_emitterPos, AkReflectionPathInfoArray out_aPaths, out uint io_uArraySize)
	{
		return default(AKRESULT);
	}

	public static AKRESULT RemoveRoom(ulong in_RoomID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT RemovePortal(ulong in_PortalID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetGameObjectInRoom(GameObject in_gameObjectID, ulong in_CurrentRoomID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetReflectionsOrder(uint in_uReflectionsOrder, bool in_bUpdatePaths)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetNumberOfPrimaryRays(uint in_uNbPrimaryRays)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetEarlyReflectionsAuxSend(GameObject in_gameObjectID, uint in_auxBusID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetEarlyReflectionsVolume(GameObject in_gameObjectID, float in_fSendVolume)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetPortalObstructionAndOcclusion(ulong in_PortalID, float in_fObstruction, float in_fOcclusion)
	{
		return default(AKRESULT);
	}

	public static AKRESULT QueryWetDiffraction(ulong in_portal, out float out_wetDiffraction)
	{
		return default(AKRESULT);
	}

	public static AKRESULT QueryDiffractionPaths(GameObject in_gameObjectID, ref Vector3 out_listenerPos, ref Vector3 out_emitterPos, AkDiffractionPathInfoArray out_aPaths, out uint io_uArraySize)
	{
		return default(AKRESULT);
	}

	public static void SetErrorLogger(AkLogger.ErrorLoggerInteropDelegate logger)
	{
	}

	public static void SetErrorLogger()
	{
	}

	public static void SetAudioInputCallbacks(AkAudioInputManager.AudioSamplesInteropDelegate getAudioSamples, AkAudioInputManager.AudioFormatInteropDelegate getAudioFormat)
	{
	}

	public static AKRESULT Init(AkInitializationSettings settings)
	{
		return default(AKRESULT);
	}

	public static AKRESULT InitSpatialAudio(AkSpatialAudioInitSettings settings)
	{
		return default(AKRESULT);
	}

	public static AKRESULT InitCommunication(AkCommunicationSettings settings)
	{
		return default(AKRESULT);
	}

	public static void Term()
	{
	}

	public static AKRESULT RegisterGameObjInternal(GameObject in_GameObj)
	{
		return default(AKRESULT);
	}

	public static AKRESULT UnregisterGameObjInternal(GameObject in_GameObj)
	{
		return default(AKRESULT);
	}

	public static AKRESULT RegisterGameObjInternal_WithName(GameObject in_GameObj, string in_pszObjName)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetBasePath(string in_pszBasePath)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetCurrentLanguage(string in_pszAudioSrcPath)
	{
		return default(AKRESULT);
	}

	public static AKRESULT LoadFilePackage(string in_pszFilePackageName, out uint out_uPackageID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT AddBasePath(string in_pszBasePath)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetGameName(string in_GameName)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetDecodedBankPath(string in_DecodedPath)
	{
		return default(AKRESULT);
	}

	public static AKRESULT LoadAndDecodeBank(string in_pszString, bool in_bSaveDecodedBank, out uint out_bankID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT LoadAndDecodeBankFromMemory(IntPtr in_BankData, uint in_BankDataSize, bool in_bSaveDecodedBank, string in_DecodedBankName, bool in_bIsLanguageSpecific, out uint out_bankID)
	{
		return default(AKRESULT);
	}

	public static uint PostEventOnRoom(string in_pszEventName, ulong in_roomID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources, uint in_PlayingID)
	{
		return default(uint);
	}

	public static uint PostEventOnRoom(string in_pszEventName, ulong in_roomID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources)
	{
		return default(uint);
	}

	public static uint PostEventOnRoom(string in_pszEventName, ulong in_roomID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie)
	{
		return default(uint);
	}

	public static uint PostEventOnRoom(string in_pszEventName, ulong in_roomID)
	{
		return default(uint);
	}

	public static string GetCurrentLanguage()
	{
		return null;
	}

	public static AKRESULT UnloadFilePackage(uint in_uPackageID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT UnloadAllFilePackages()
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetObjectPosition(GameObject in_GameObjectID, Vector3 Pos, Vector3 Front, Vector3 Top)
	{
		return default(AKRESULT);
	}

	public static AKRESULT GetSourceMultiplePlayPositions(uint in_PlayingID, uint[] out_audioNodeID, uint[] out_mediaID, int[] out_msTime, ref uint io_pcPositions, bool in_bExtrapolate)
	{
		return default(AKRESULT);
	}

	public static AKRESULT GetSourceMultiplePlayPositions(uint in_PlayingID, uint[] out_audioNodeID, uint[] out_mediaID, int[] out_msTime, ref uint io_pcPositions)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetListeners(GameObject in_emitterGameObj, ulong[] in_pListenerGameObjs, uint in_uNumListeners)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetDefaultListeners(ulong[] in_pListenerObjs, uint in_uNumListeners)
	{
		return default(AKRESULT);
	}

	public static AKRESULT AddOutput(AkOutputSettings in_Settings, out ulong out_pDeviceID, ulong[] in_pListenerIDs, uint in_uNumListeners)
	{
		return default(AKRESULT);
	}

	public static AKRESULT AddOutput(AkOutputSettings in_Settings, out ulong out_pDeviceID, ulong[] in_pListenerIDs)
	{
		return default(AKRESULT);
	}

	public static AKRESULT AddOutput(AkOutputSettings in_Settings, out ulong out_pDeviceID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT AddOutput(AkOutputSettings in_Settings)
	{
		return default(AKRESULT);
	}

	public static void GetDefaultStreamSettings(AkStreamMgrSettings out_settings)
	{
	}

	public static void GetDefaultDeviceSettings(AkDeviceSettings out_settings)
	{
	}

	public static void GetDefaultMusicSettings(AkMusicSettings out_settings)
	{
	}

	public static void GetDefaultInitSettings(AkInitSettings out_settings)
	{
	}

	public static void GetDefaultPlatformInitSettings(AkPlatformInitSettings out_settings)
	{
	}

	public static uint GetMajorMinorVersion()
	{
		return default(uint);
	}

	public static uint GetSubminorBuildVersion()
	{
		return default(uint);
	}

	public static void StartResourceMonitoring()
	{
	}

	public static void StopResourceMonitoring()
	{
	}

	public static void GetResourceMonitorDataSummary(AkResourceMonitorDataSummary resourceMonitorDataSummary)
	{
	}

	public static AKRESULT SetRoomPortal(ulong in_PortalID, AkTransform Transform, Vector3 Extent, bool bEnabled, ulong FrontRoom, ulong BackRoom)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetRoom(ulong in_RoomID, AkRoomParams in_roomParams, string in_pName)
	{
		return default(AKRESULT);
	}

	public static AKRESULT RegisterSpatialAudioListener(GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT UnregisterSpatialAudioListener(GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetGeometry(ulong in_GeomSetID, AkTriangleArray Triangles, uint NumTriangles, Vector3[] Vertices, uint NumVertices, AkAcousticSurfaceArray Surfaces, uint NumSurfaces, ulong RoomID, bool EnableDiffraction, bool EnableDiffractionOnBoundaryEdges)
	{
		return default(AKRESULT);
	}

	public static uint PostEventOnRoom(uint in_eventID, ulong in_roomID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources, uint in_PlayingID)
	{
		return default(uint);
	}

	public static uint PostEventOnRoom(uint in_eventID, ulong in_roomID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources)
	{
		return default(uint);
	}

	public static uint PostEventOnRoom(uint in_eventID, ulong in_roomID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie)
	{
		return default(uint);
	}

	public static uint PostEventOnRoom(uint in_eventID, ulong in_roomID)
	{
		return default(uint);
	}

	public static string StringFromIntPtrString(IntPtr ptr)
	{
		return null;
	}

	public static string StringFromIntPtrWString(IntPtr ptr)
	{
		return null;
	}

	public static string StringFromIntPtrOSString(IntPtr ptr)
	{
		return null;
	}

	private static ulong InternalGameObjectHash(GameObject gameObject)
	{
		return default(ulong);
	}

	public static ulong GetAkGameObjectID(GameObject gameObject)
	{
		return default(ulong);
	}

	public static AKRESULT RegisterGameObj(GameObject gameObject)
	{
		return default(AKRESULT);
	}

	public static AKRESULT RegisterGameObj(GameObject gameObject, string name)
	{
		return default(AKRESULT);
	}

	public static AKRESULT UnregisterGameObj(GameObject gameObject)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetObjectPosition(GameObject gameObject, Transform transform)
	{
		return default(AKRESULT);
	}

	public static AKRESULT SetObjectPosition(GameObject gameObject, float posX, float posY, float posZ, float frontX, float frontY, float frontZ, float topX, float topY, float topZ)
	{
		return default(AKRESULT);
	}

	public static void PreGameObjectAPICall(GameObject gameObject, ulong id)
	{
	}

	private static void PreGameObjectAPICallUserHook(GameObject gameObject, ulong id)
	{
	}

	private static void PostRegisterGameObjUserHook(AKRESULT result, GameObject gameObject, ulong id)
	{
	}

	private static void PostUnregisterGameObjUserHook(AKRESULT result, GameObject gameObject, ulong id)
	{
	}

	private static void AutoRegister(GameObject gameObject, ulong id)
	{
	}

	private static bool IsInRegisteredList(ulong id)
	{
		return default(bool);
	}

	public static bool IsGameObjectRegistered(GameObject in_gameObject)
	{
		return default(bool);
	}
}
