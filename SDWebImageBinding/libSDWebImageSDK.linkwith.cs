using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libSDWebImageSDK.a", LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.ArmV7s, ForceLoad = true, Frameworks = "ImageIO")]
