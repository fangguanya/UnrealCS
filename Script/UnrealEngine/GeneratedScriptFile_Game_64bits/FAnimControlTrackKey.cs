#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FAnimControlTrackKey
	{
		[FieldOffset(0)]
		public float StartTime;
		[FieldOffset(16)]
		public float AnimStartOffset;
		[FieldOffset(20)]
		public float AnimEndOffset;
		[FieldOffset(24)]
		public float AnimPlayRate;
		public bool bLooping
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 28, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 28, 1, 0, 1, 1); } }}
			
		}
		public bool bReverse
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 28, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 28, 1, 0, 2, 2); } }}
			
		}
		
	}
	
}
#endif
#endif
