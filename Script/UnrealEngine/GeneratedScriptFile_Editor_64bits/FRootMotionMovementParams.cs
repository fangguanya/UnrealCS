#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Utility struct to accumulate root motion.</summary>
	[StructLayout(LayoutKind.Explicit,Size=64)]
	public partial struct FRootMotionMovementParams
	{
		public bool bHasRootMotion
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(4)]
		public float BlendWeight;
		[FieldOffset(16)]
		public FTransform RootMotionTransform;
		
	}
	
}
#endif
#endif
