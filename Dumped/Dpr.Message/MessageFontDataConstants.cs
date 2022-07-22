using System.Collections.Generic;
using UnityEngine;

namespace Dpr.Message;

public static class MessageFontDataConstants
{
	public static readonly Dictionary<int, MessageFontTagData> TEXT_FONT_TABLE;

	public static readonly Dictionary<int, int> FONT_FILE_TABLE;

	public static readonly string[] FONT_FILE_NAME_ARRAY;

	public static readonly Dictionary<int, MessageStyleData> FONT_STYLE_DATA_TABLE;

	public static readonly Dictionary<int, int> FONT_SIZE_TABLE;

	public static readonly Color DEFAULT_FONT_COLOR;

	public static readonly Color NETWORK_TEXT_COLOR;

	public static readonly MessageStyleColorData[] FONT_COLOR_ARRAY;

	public static readonly uint[] PROPORTIONAL_CHAR_CODES;
}
