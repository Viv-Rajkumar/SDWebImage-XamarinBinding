// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace SDWebImageExample
{
	[Register ("TableViewController")]
	partial class TableViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIBarButtonItem ClearCacheButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ClearCacheButton != null) {
				ClearCacheButton.Dispose ();
				ClearCacheButton = null;
			}
		}
	}
}
