using System;
using System.Reflection;
using System.Text;
using System.Threading;
using Dpr.Message;
using UnityEngine.Events;
using nn.ngc;
using nn.swkbd;

namespace Dpr.UI;

public static class SoftwareKeyboard
{
	public enum Preset
	{
		Default,
		Password,
		UserName,
		DownloadCode,
		Custom,
		Max
	}

	public enum KeyboardMode
	{
		LanguageSet1 = 0,
		Numeric = 1,
		ASCII = 2,
		LanguageSet1Latin = 3,
		Alphabet = 4,
		SimplifiedChinese = 5,
		TraditionalChinese = 6,
		Korean = 7,
		LanguageSet2 = 8,
		Max = 9,
		Full = 0,
		FullLatin = 3,
		Auto = 9
	}

	[Flags]
	public enum InvalidChar
	{
		Space = 2,
		AtMark = 4,
		Percent = 8,
		Slash = 0x10,
		BackSlash = 0x20,
		Numeric = 0x40,
		OutsideOfDownloadCode = 0x80,
		OutsideOfMiiNickName = 0x100,
		Force32 = -1
	}

	public enum InitialCursorPos
	{
		First,
		Last,
		Max
	}

	public enum PasswordMode
	{
		Show,
		Hide,
		Max
	}

	public enum InputFormMode
	{
		OneLine,
		MultiLine,
		Separate,
		Max
	}

	public class Param
	{
		public Preset preset;

		public KeyboardMode keyboardMode;

		public bool isPredictionEnabled;

		public InvalidChar invalidCharFlag;

		public InitialCursorPos initialCursorPos;

		public int textMaxLength;

		public int textMinLength;

		public PasswordMode passwordMode;

		public InputFormMode inputFormMode;

		public bool isUseNewLine;

		public bool isUseBlurBackground;

		public int[] separateTextPos;

		public string text;

		public string guideText;

		public string headerText;

		public string subText;

		public string okText;

		public int disableErrorChecks;
	}

	public enum ErrorState
	{
		None,
		WhiteSpace,
		NumberCount,
		WhiteUnicode,
		NgWord
	}

	[Flags]
	public enum ErrorCheck
	{
		None = 0,
		WhiteSpace = 2,
		NumberCount = 4,
		WhiteUnicode = 8,
		NgWord = 0x10
	}

	private class ThreadParam
	{
		public Thread thread;

		public AutoResetEvent callEvent;

		public bool isActived;

		public void Create()
		{
		}

		public void Remove()
		{
		}

		public void Call()
		{
		}
	}

	public const int TextMaxLength = 500;

	public const int SeparateModeTextMaxLength = 24;

	public const int HeaderTextMaxLength = 64;

	public const int SubTextMaxLength = 128;

	public const int GuideTextMaxLength = 256;

	public const int OkTextMaxLength = 8;

	public const int UnfixedStringLengthMax = 24;

	public const int UserWordMax = 5000;

	public const int DialogTextMaxLength = 500;

	public const int SepareteTextPosMax = 8;

	public const int CustomizedDicionarySetMax = 24;

	private static bool _isInitialized;

	private static Param _param;

	private static Func<string, ErrorState, (bool, string)> _onInputCheck;

	private static UnityAction<bool, string> _onComplete;

	private static string _resultText;

	private static ErrorState _errorState;

	private static bool _isCheckResult;

	private static ShowKeyboardArg _showKeyboardArg;

	private static ProfanityFilter.PatternList _patterns;

	private const string _messageFileNameWhiteWords = "dlp_whitelist_monsname";

	private const string _messageFileName = "ss_strinput";

	private static MessageMsgFile _msgFile;

	private const int _maxNumberNum = 5;

	private static char _errorWhiteUnicode;

	private static int _disableErrorChecks;

	private static MessageEnumData.MsgLangId _checkLangId;

	private const int _errorMessageArgIndex = 18;

	private static bool _isSuspendUnityThreads;

	private static bool _isThreadCall;

	private static bool _isMainThreadBlocked;

	private static ThreadParam _threadParam;

	private static SynchronizationContext _mainContext;

	private static int _mainThreadId;

	private static MethodInfo _methodExecuteTasks;

	public static bool isInitialized => default(bool);

	public static Func<string, ErrorState, (bool, string)> onInputCheck => null;

	public static UnityAction<bool, string> onComplete => null;

	public static string resultText => null;

	public static ErrorState errorState => default(ErrorState);

	public static bool isCheckResult => default(bool);

	public static void Initialize()
	{
	}

	public static string GetMessageText(string messageLabel)
	{
		return null;
	}

	private static bool IsDisableCheck(ErrorCheck checkBit)
	{
		return default(bool);
	}

	private static bool CheckWhiteSpace(string text)
	{
		return default(bool);
	}

	private static bool CheckNumbers(string text)
	{
		return default(bool);
	}

	private static bool CheckWhiteUnicodes(string text)
	{
		return default(bool);
	}

	private static bool CheckWhiteWords(string text)
	{
		return default(bool);
	}

	public static void Terminate()
	{
	}

	public static bool Open(Param param, Func<string, ErrorState, (bool, string)> onInputCheck, UnityAction<bool, string> onComplete)
	{
		return default(bool);
	}

	private static void WakerOpen(object obj)
	{
	}

	private static void MainThreadPost(UnityAction onCallback, bool isSleep = false)
	{
	}

	private static void OpenInternal()
	{
	}

	private static KeyboardMode GetKeyboardMode()
	{
		return default(KeyboardMode);
	}

	private static KeyboardMode GetLanguageKeyboardMode()
	{
		return default(KeyboardMode);
	}

	internal static void _SetCheckResult(bool isCheckResult)
	{
	}

	internal static void _SetResult(bool isSuccess, string resultText)
	{
	}

	private static ProfanityFilter.PatternList GetLanguagePatternAll()
	{
		return default(ProfanityFilter.PatternList);
	}

	private static TextCheckResult TextCheckCallback(IntPtr textBuf, ref long length, ref nn.swkbd.String str)
	{
		return default(TextCheckResult);
	}

	internal static int _GetDisableErrorChecks()
	{
		return default(int);
	}

	private static TextCheckResult _TextCheckCallbackImpl(IntPtr textBuf, ref long length, string input, Encoding encoding)
	{
		return default(TextCheckResult);
	}

	public static ErrorState CheckNgWords(ref string resultText, int disableErrorChecks = 0, MessageEnumData.MsgLangId langId = (MessageEnumData.MsgLangId)(-1))
	{
		return default(ErrorState);
	}

	private static ErrorState _CheckNgWords(ref string resultText, int disableErrorChecks, MessageEnumData.MsgLangId langId)
	{
		return default(ErrorState);
	}

	private static bool CheckNgc(ref string resultText, bool isMaskResult = false)
	{
		return default(bool);
	}

	public static int LanguageMaxLength(int maxLength, MessageEnumData.MsgLangId langId = (MessageEnumData.MsgLangId)(-1))
	{
		return default(int);
	}

	public static (bool, string) InputCheck(string resultText, ErrorState errorState)
	{
		return default((bool, string));
	}
}
