#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=12)]
	public partial struct FParticleEditorPromotionSettings
	{
		[FieldOffset(0)]
		public FFilePath DefaultParticleAsset;
		
	}
	
}
#endif
#endif
