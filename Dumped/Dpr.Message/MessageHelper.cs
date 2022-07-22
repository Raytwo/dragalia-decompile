using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

namespace Dpr.Message;

public static class MessageHelper
{
	private static int eggNameHash;

	public static string ExtractionLangNameByName(string fileName)
	{
		return null;
	}

	public static bool IsEFIGS(MessageEnumData.MsgLangId languageId)
	{
		return default(bool);
	}

	public static string SurroundFontTag(string word, uint languageId)
	{
		return null;
	}

	public static string SurroundFontTag(string word, MessageEnumData.MsgLangId languageId)
	{
		return null;
	}

	public static string GetFontFileName(MessageEnumData.MsgLangId languageId)
	{
		return null;
	}

	public static string[] GetLocalizeVariants()
	{
		return null;
	}

	public static string GetLanguageVariant()
	{
		return null;
	}

	public static string GetLanguageVariant(MessageEnumData.MsgLangId langID)
	{
		return null;
	}

	public static string AddVariantNameToPath(string path)
	{
		return null;
	}

	public static string AddVariantNameToPath(string path, string langVariant)
	{
		return null;
	}

	public static bool CheckExcludeCode(char c)
	{
		return default(bool);
	}

	public static bool CheckNewLineCharCode(char c)
	{
		return default(bool);
	}

	public static char ConvertUnicodeToChar(int unicode)
	{
		return default(char);
	}

	public static MessageEnumData.GenderQtyID GetGenderQtyId(MessageEnumData.GenderID genderId, MessageEnumData.QtyID qtyId)
	{
		return default(MessageEnumData.GenderQtyID);
	}

	public static MessageEnumData.QtyID CheckQtyIdByCount(int count, MessageEnumData.MsgLangId langID)
	{
		return default(MessageEnumData.QtyID);
	}

	public static bool IsVowel(char initial)
	{
		return default(bool);
	}

	public static bool IsFRVowel(char initial)
	{
		return default(bool);
	}

	public static bool IsITVowelE(char initial)
	{
		return default(bool);
	}

	private static bool ContainParam(char target, [In] ref char[] paramArray)
	{
		return default(bool);
	}

	public static bool IsDigitWordByUnicode(byte[] unicodes)
	{
		return default(bool);
	}

	public static void SetEggName(string eggName)
	{
	}

	public static bool IsEggName(string nickName)
	{
		return default(bool);
	}

	public static int GetEggNameGender(MessageEnumData.MsgLangId langID, int genderID)
	{
		return default(int);
	}

	public static int GetEggNameInitialSound(MessageEnumData.MsgLangId langID, int initialSound)
	{
		return default(int);
	}

	public static float CalcMessageWidth(MessageEnumData.MsgLangId langID, string str, float textFontScale)
	{
		return default(float);
	}

	public static float CheckMessageWidth(FontAssetInfo fontAssetInfo, string str, float textFontScale)
	{
		return default(float);
	}

	public static float CheckMessageWidth(TMP_FontAsset fontAsset, string str, float textFontScale)
	{
		return default(float);
	}

	private static bool IsSpriteFontCode(uint unicode)
	{
		return default(bool);
	}

	public static bool ExistMissingChara(MessageEnumData.MsgLangId langID, [In] ref string checkStr)
	{
		return default(bool);
	}

	public static bool ExistMissingChara(TMP_FontAsset fontAsset, [In] ref string checkStr)
	{
		return default(bool);
	}

	public static MessageEnumData.ForceGrmID CreateNotationValue(float centiSize, ref int integerValue, ref int decimalValue)
	{
		return default(MessageEnumData.ForceGrmID);
	}

	private static void SplitRealNumber(float baseValue, ref float integerValue, ref float decimalValue)
	{
	}

	public static void EmitLog(string log, LogType logType = LogType.Log)
	{
	}

	public static MessageEnumData.MsgLangId ConvertMsgId(MessageEnumData.MsgLangId langId)
	{
		return default(MessageEnumData.MsgLangId);
	}
}
