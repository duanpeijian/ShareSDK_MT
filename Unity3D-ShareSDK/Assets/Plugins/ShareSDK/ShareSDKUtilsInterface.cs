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
namespace cn.sharesdk.unity3d{
	public abstract class ShareSDKUtilsInterface{
		protected AuthResultEvent authHandler;
		protected GetUserInfoResultEvent showUserHandler;
		protected ShareResultEvent shareHandler;
		protected GetFriendsResultEvent getFriendsHandler;

		/// <summary>
		/// Inits the SDK.
		/// </summary>
		public abstract void InitSDK ();

		/// <summary>
		/// Inits the SDK.
		/// </summary>
		/// <param name="appKey">Appkey.</param>
		public abstract void InitSDK (string appKey);
		
		/// <summary>
		/// Sets the platform config.
		/// </summary>
		/// <param name="platform">Platform.</param>
		/// <param name="configs">Configs.</param>
		public abstract void SetPlatformConfig (int platform, Hashtable configs);
		
		/// <summary>
		/// Authorize the specified platform.
		/// </summary>
		/// <param name="platform">Platform.</param>
		/// <param name="resultHandler">Result handler.</param>
		public abstract void Authorize (int platform, AuthResultEvent resultHandler);
		
		/// <summary>
		/// Removes the account of the specified platform.
		/// </summary>
		/// <param name="platform">Platform.</param>
		public abstract void RemoveAccount (int platform);
		
		/// <summary>
		/// Determine weather the account of the specified platform is valid.
		/// </summary>
		/// <returns><c>true</c>, if valid was ised, <c>false</c> otherwise.</returns>
		/// <param name="platform">Platform.</param>
		public abstract bool IsValid (int platform);

		/// <summary>
		/// Request the user info of the specified platform.
		/// </summary>
		/// <param name="platform">Platform.</param>
		public abstract void ShowUser (int platform, GetUserInfoResultEvent resultHandler);
		
		/// <summary>
		/// Share the content to the specified platform.
		/// </summary>
		/// <param name="platform">Platform.</param>
		/// <param name="content">Content.</param>
		/// <param name="resultHandler">Result handler.</param>
		public abstract void Share (int platform, Hashtable content, ShareResultEvent resultHandler);
		
		/// <summary>
		/// GUI share.
		/// </summary>
		/// <param name="content">Content.</param>
		/// <param name="resultHandler">Result handler.</param>
		public abstract void OnekeyShare (Hashtable content, ShareResultEvent resultHandler);
		
		/// <summary>
		/// OGUI share to the specified platform. 
		/// </summary>
		/// <param name="platform">Platform.</param>
		/// <param name="content">Content.</param>
		/// <param name="resultHandler">Result handler.</param>
		public abstract void OnekeyShare (int platform, Hashtable content, ShareResultEvent resultHandler);

		/// <summary>
		/// Gets the friend list.
		/// </summary>
		/// <param name="platform">Platform.</param>
		/// <param name="count">Count.</param>
		/// <param name="page">Page.</param>
		/// <param name="resultHandler">Result handler.</param>
		public abstract void GetFriendList (int platform, int count, int page, GetFriendsResultEvent resultHandler);

		/// <summary>
		/// Gets the auth info.
		/// </summary>
		/// <param name="platform">Platform.</param>
		public abstract Hashtable GetAuthInfo (int platform);

		/// <summary>
		/// the setting of SSO
		/// </summary>
		/// <param name="disable">If set to <c>true</c> disable.</param>
		public abstract void DisableSSOWhenAuthorize (Boolean open);

		/// <summary>
		/// Java callback.
		/// </summary>
		/// <param name="message">Message.</param>
		public abstract void OnActionCallback (string message);
		
		/// <summary>
		/// Raises the error event.
		/// </summary>
		/// <param name="platform">Platform.</param>
		/// <param name="action">Action.</param>
		/// <param name="throwable">Throwable.</param>
		public abstract void OnError (int platform, int action, Hashtable throwable);
		
		/// <summary>
		/// Raises the success event.
		/// </summary>
		/// <param name="platform">Platform.</param>
		/// <param name="action">Action.</param>
		/// <param name="res">Res.</param>
		public abstract void OnComplete (int platform, int action, Hashtable res);
		
		/// <summary>
		/// Raises the cancel event.
		/// </summary>
		/// <param name="platform">Platform.</param>
		/// <param name="action">Action.</param>
		public abstract void OnCancel (int platform, int action);

	}
}

