using System;

public class AkMIDIEvent : IDisposable
{
	public class tGen : IDisposable
	{
		private IntPtr swigCPtr;

		protected bool swigCMemOwn;

		public byte byParam1
		{
			get
			{
				return default(byte);
			}
			set
			{
			}
		}

		public byte byParam2
		{
			get
			{
				return default(byte);
			}
			set
			{
			}
		}

		internal tGen(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static IntPtr getCPtr(tGen obj)
		{
			return default(IntPtr);
		}

		internal virtual void setCPtr(IntPtr cPtr)
		{
		}

		~tGen()
		{
		}

		public virtual void Dispose()
		{
		}

		public tGen()
		{
		}
	}

	public class tNoteOnOff : IDisposable
	{
		private IntPtr swigCPtr;

		protected bool swigCMemOwn;

		public byte byNote
		{
			get
			{
				return default(byte);
			}
			set
			{
			}
		}

		public byte byVelocity
		{
			get
			{
				return default(byte);
			}
			set
			{
			}
		}

		internal tNoteOnOff(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static IntPtr getCPtr(tNoteOnOff obj)
		{
			return default(IntPtr);
		}

		internal virtual void setCPtr(IntPtr cPtr)
		{
		}

		~tNoteOnOff()
		{
		}

		public virtual void Dispose()
		{
		}

		public tNoteOnOff()
		{
		}
	}

	public class tCc : IDisposable
	{
		private IntPtr swigCPtr;

		protected bool swigCMemOwn;

		public byte byCc
		{
			get
			{
				return default(byte);
			}
			set
			{
			}
		}

		public byte byValue
		{
			get
			{
				return default(byte);
			}
			set
			{
			}
		}

		internal tCc(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static IntPtr getCPtr(tCc obj)
		{
			return default(IntPtr);
		}

		internal virtual void setCPtr(IntPtr cPtr)
		{
		}

		~tCc()
		{
		}

		public virtual void Dispose()
		{
		}

		public tCc()
		{
		}
	}

	public class tPitchBend : IDisposable
	{
		private IntPtr swigCPtr;

		protected bool swigCMemOwn;

		public byte byValueLsb
		{
			get
			{
				return default(byte);
			}
			set
			{
			}
		}

		public byte byValueMsb
		{
			get
			{
				return default(byte);
			}
			set
			{
			}
		}

		internal tPitchBend(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static IntPtr getCPtr(tPitchBend obj)
		{
			return default(IntPtr);
		}

		internal virtual void setCPtr(IntPtr cPtr)
		{
		}

		~tPitchBend()
		{
		}

		public virtual void Dispose()
		{
		}

		public tPitchBend()
		{
		}
	}

	public class tNoteAftertouch : IDisposable
	{
		private IntPtr swigCPtr;

		protected bool swigCMemOwn;

		public byte byNote
		{
			get
			{
				return default(byte);
			}
			set
			{
			}
		}

		public byte byValue
		{
			get
			{
				return default(byte);
			}
			set
			{
			}
		}

		internal tNoteAftertouch(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static IntPtr getCPtr(tNoteAftertouch obj)
		{
			return default(IntPtr);
		}

		internal virtual void setCPtr(IntPtr cPtr)
		{
		}

		~tNoteAftertouch()
		{
		}

		public virtual void Dispose()
		{
		}

		public tNoteAftertouch()
		{
		}
	}

	public class tChanAftertouch : IDisposable
	{
		private IntPtr swigCPtr;

		protected bool swigCMemOwn;

		public byte byValue
		{
			get
			{
				return default(byte);
			}
			set
			{
			}
		}

		internal tChanAftertouch(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static IntPtr getCPtr(tChanAftertouch obj)
		{
			return default(IntPtr);
		}

		internal virtual void setCPtr(IntPtr cPtr)
		{
		}

		~tChanAftertouch()
		{
		}

		public virtual void Dispose()
		{
		}

		public tChanAftertouch()
		{
		}
	}

	public class tProgramChange : IDisposable
	{
		private IntPtr swigCPtr;

		protected bool swigCMemOwn;

		public byte byProgramNum
		{
			get
			{
				return default(byte);
			}
			set
			{
			}
		}

		internal tProgramChange(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static IntPtr getCPtr(tProgramChange obj)
		{
			return default(IntPtr);
		}

		internal virtual void setCPtr(IntPtr cPtr)
		{
		}

		~tProgramChange()
		{
		}

		public virtual void Dispose()
		{
		}

		public tProgramChange()
		{
		}
	}

	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public byte byChan
	{
		get
		{
			return default(byte);
		}
		set
		{
		}
	}

	public tGen Gen
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public tCc Cc
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public tNoteOnOff NoteOnOff
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public tPitchBend PitchBend
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public tNoteAftertouch NoteAftertouch
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public tChanAftertouch ChanAftertouch
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public tProgramChange ProgramChange
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public AkMIDIEventTypes byType
	{
		get
		{
			return default(AkMIDIEventTypes);
		}
		set
		{
		}
	}

	public byte byOnOffNote
	{
		get
		{
			return default(byte);
		}
		set
		{
		}
	}

	public byte byVelocity
	{
		get
		{
			return default(byte);
		}
		set
		{
		}
	}

	public AkMIDICcTypes byCc
	{
		get
		{
			return default(AkMIDICcTypes);
		}
		set
		{
		}
	}

	public byte byCcValue
	{
		get
		{
			return default(byte);
		}
		set
		{
		}
	}

	public byte byValueLsb
	{
		get
		{
			return default(byte);
		}
		set
		{
		}
	}

	public byte byValueMsb
	{
		get
		{
			return default(byte);
		}
		set
		{
		}
	}

	public byte byAftertouchNote
	{
		get
		{
			return default(byte);
		}
		set
		{
		}
	}

	public byte byNoteAftertouchValue
	{
		get
		{
			return default(byte);
		}
		set
		{
		}
	}

	public byte byChanAftertouchValue
	{
		get
		{
			return default(byte);
		}
		set
		{
		}
	}

	public byte byProgramNum
	{
		get
		{
			return default(byte);
		}
		set
		{
		}
	}

	internal AkMIDIEvent(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static IntPtr getCPtr(AkMIDIEvent obj)
	{
		return default(IntPtr);
	}

	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	~AkMIDIEvent()
	{
	}

	public virtual void Dispose()
	{
	}

	public AkMIDIEvent()
	{
	}
}
