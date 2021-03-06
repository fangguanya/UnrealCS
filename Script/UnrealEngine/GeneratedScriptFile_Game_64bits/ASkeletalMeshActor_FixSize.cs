#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ASkeletalMeshActor
	{
		static readonly int bShouldDoAnimNotifies__Offset;
		public bool bShouldDoAnimNotifies
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShouldDoAnimNotifies__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bShouldDoAnimNotifies__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bWakeOnLevelStart__Offset;
		public bool bWakeOnLevelStart
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bWakeOnLevelStart__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int SkeletalMeshComponent__Offset;
		public USkeletalMeshComponent SkeletalMeshComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SkeletalMeshComponent__Offset); if (v == IntPtr.Zero)return null; USkeletalMeshComponent retValue = new USkeletalMeshComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + SkeletalMeshComponent__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + SkeletalMeshComponent__Offset, value._this.Get()); }
			
		}
		
		static readonly int ReplicatedMesh__Offset;
		public USkeletalMesh ReplicatedMesh
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ReplicatedMesh__Offset); if (v == IntPtr.Zero)return null; USkeletalMesh retValue = new USkeletalMesh(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ReplicatedPhysAsset__Offset;
		public UPhysicsAsset ReplicatedPhysAsset
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ReplicatedPhysAsset__Offset); if (v == IntPtr.Zero)return null; UPhysicsAsset retValue = new UPhysicsAsset(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ReplicatedMaterial0__Offset;
		public UMaterialInterface ReplicatedMaterial0
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ReplicatedMaterial0__Offset); if (v == IntPtr.Zero)return null; UMaterialInterface retValue = new UMaterialInterface(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ReplicatedMaterial1__Offset;
		public UMaterialInterface ReplicatedMaterial1
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ReplicatedMaterial1__Offset); if (v == IntPtr.Zero)return null; UMaterialInterface retValue = new UMaterialInterface(); retValue._this = v; return retValue; }
			
		}
		
		static ASkeletalMeshActor()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SkeletalMeshActor");
			bShouldDoAnimNotifies__Offset=GetPropertyOffset(NativeClassPtr,"bShouldDoAnimNotifies");
			bWakeOnLevelStart__Offset=GetPropertyOffset(NativeClassPtr,"bWakeOnLevelStart");
			SkeletalMeshComponent__Offset=GetPropertyOffset(NativeClassPtr,"SkeletalMeshComponent");
			ReplicatedMesh__Offset=GetPropertyOffset(NativeClassPtr,"ReplicatedMesh");
			ReplicatedPhysAsset__Offset=GetPropertyOffset(NativeClassPtr,"ReplicatedPhysAsset");
			ReplicatedMaterial0__Offset=GetPropertyOffset(NativeClassPtr,"ReplicatedMaterial0");
			ReplicatedMaterial1__Offset=GetPropertyOffset(NativeClassPtr,"ReplicatedMaterial1");
			
		}
		
	}
	
}
#endif
#endif
