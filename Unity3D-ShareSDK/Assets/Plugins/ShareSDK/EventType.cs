//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections;

namespace cn.sharesdk.unity3d
{
	/// <summary>
	/// Auth result event.
	/// </summary>
	public delegate void AuthResultEvent (ResponseState state, PlatformType type, Hashtable result);
			
	/// <summary>
	/// Get user info result event.
	/// </summary>
	public delegate void GetUserInfoResultEvent (ResponseState state, PlatformType type, Hashtable result);

	/// <summary>
	/// Share result event.
	/// </summary>
	public delegate void ShareResultEvent (ResponseState state, PlatformType type, Hashtable result);
			
	/// <summary>
	/// Get friends result event.
	/// </summary>
	public delegate void GetFriendsResultEvent (ResponseState state, PlatformType type, Hashtable error);

}

