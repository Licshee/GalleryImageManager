﻿// "Therefore those skilled at the unorthodox
// are infinite as heaven and earth,
// inexhaustible as the great rivers.
// When they come to an end,
// they bagin again,
// like the days and months;
// they die and are reborn,
// like the four seasons."
// 
// - Sun Tsu,
// "The Art of War"

// ---
//  This code was generated by Resource extnsions template for T4 C#
//
//  DO NOT CHANGE THIS FILE!
//	Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.

using System.Drawing;

namespace GalleryImage.Demo.Properties
{
	// ReSharper disable InconsistentNaming
	// ReSharper disable ResourceItemNotResolved
    
	/// <summary>
    /// Represent a cached resources class for "Resources" resources.
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.CodeDom.Compiler.GeneratedCode("CachedResources", "1.0.1.0")]
    public static class CachedResources
    {
		#region Fields and Consts

		private static Bitmap _Emoticons;
		private static Bitmap _Extensions;
		private static Icon _Icons;

		#endregion
		
		
		/// <summary>
        /// Get the cached bitmap image of "Emoticons" resource.<br/>
		/// On first call the image is cached, all subsequent calls will return the same image object.
        /// </summary>
		public static Bitmap Emoticons
		{
			get 
			{
				if(_Emoticons == null)
					_Emoticons = (Bitmap)Resources.ResourceManager.GetObject("Emoticons");
				return _Emoticons;
			}
		}
		
		/// <summary>
        /// Get the cached bitmap image of "Extensions" resource.<br/>
		/// On first call the image is cached, all subsequent calls will return the same image object.
        /// </summary>
		public static Bitmap Extensions
		{
			get 
			{
				if(_Extensions == null)
					_Extensions = (Bitmap)Resources.ResourceManager.GetObject("Extensions");
				return _Extensions;
			}
		}
		
		/// <summary>
        /// Get the cached bitmap image of "Icons" resource.<br/>
		/// On first call the image is cached, all subsequent calls will return the same image object.
        /// </summary>
		public static Icon Icons
		{
			get 
			{
				if(_Icons == null)
					_Icons = (Icon)Resources.ResourceManager.GetObject("Icons");
				return _Icons;
			}
		}

		/// <summary>
        /// Clear all cached images.
        /// </summary>
		public static void ClearCache()
		{
			var Emoticons2 = _Emoticons;
			_Emoticons = null;
			if( Emoticons2 != null)
				Emoticons2.Dispose();

			var Extensions2 = _Extensions;
			_Extensions = null;
			if( Extensions2 != null)
				Extensions2.Dispose();

			var Icons2 = _Icons;
			_Icons = null;
			if( Icons2 != null)
				Icons2.Dispose();

		}
    }

	// ReSharper restore ResourceItemNotResolved
	// ReSharper restore InconsistentNaming
}
