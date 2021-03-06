#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UPlayer
	{
		static readonly int PlayerController__Offset;
		public APlayerController PlayerController
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PlayerController__Offset); if (v == IntPtr.Zero)return null; APlayerController retValue = new APlayerController(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int CurrentNetSpeed__Offset;
		public int CurrentNetSpeed
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+CurrentNetSpeed__Offset, typeof(int));}
			
		}
		
		static readonly int ConfiguredInternetSpeed__Offset;
		public int ConfiguredInternetSpeed
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+ConfiguredInternetSpeed__Offset, typeof(int));}
			
		}
		
		static readonly int ConfiguredLanSpeed__Offset;
		public int ConfiguredLanSpeed
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+ConfiguredLanSpeed__Offset, typeof(int));}
			
		}
		
		static UPlayer()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("Player");
			PlayerController__Offset=GetPropertyOffset(NativeClassPtr,"PlayerController");
			CurrentNetSpeed__Offset=GetPropertyOffset(NativeClassPtr,"CurrentNetSpeed");
			ConfiguredInternetSpeed__Offset=GetPropertyOffset(NativeClassPtr,"ConfiguredInternetSpeed");
			ConfiguredLanSpeed__Offset=GetPropertyOffset(NativeClassPtr,"ConfiguredLanSpeed");
			
		}
		
	}
	
}
#endif
#endif
