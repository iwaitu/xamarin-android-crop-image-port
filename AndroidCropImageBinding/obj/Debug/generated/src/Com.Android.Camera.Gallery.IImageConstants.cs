using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Android.Camera.Gallery {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='IImageConstants']"
	[global::Android.Runtime.Register ("com/android/camera/gallery/IImageConstants", DoNotGenerateAcw=true)]
	public partial class IImageConstants : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='IImageConstants']/field[@name='MINI_THUMB_MAX_NUM_PIXELS']"
		[Register ("MINI_THUMB_MAX_NUM_PIXELS")]
		public const int MiniThumbMaxNumPixels = (int) 16384;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='IImageConstants']/field[@name='MINI_THUMB_TARGET_SIZE']"
		[Register ("MINI_THUMB_TARGET_SIZE")]
		public const int MiniThumbTargetSize = (int) 96;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='IImageConstants']/field[@name='NO_NATIVE']"
		[Register ("NO_NATIVE")]
		public const bool NoNative = (bool) false;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='IImageConstants']/field[@name='NO_ROTATE']"
		[Register ("NO_ROTATE")]
		public const bool NoRotate = (bool) false;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='IImageConstants']/field[@name='ROTATE_AS_NEEDED']"
		[Register ("ROTATE_AS_NEEDED")]
		public const bool RotateAsNeeded = (bool) true;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='IImageConstants']/field[@name='THUMBNAIL_MAX_NUM_PIXELS']"
		[Register ("THUMBNAIL_MAX_NUM_PIXELS")]
		public const int ThumbnailMaxNumPixels = (int) 196608;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='IImageConstants']/field[@name='THUMBNAIL_TARGET_SIZE']"
		[Register ("THUMBNAIL_TARGET_SIZE")]
		public const int ThumbnailTargetSize = (int) 320;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='IImageConstants']/field[@name='UNCONSTRAINED']"
		[Register ("UNCONSTRAINED")]
		public const int Unconstrained = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='IImageConstants']/field[@name='USE_NATIVE']"
		[Register ("USE_NATIVE")]
		public const bool UseNative = (bool) true;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/android/camera/gallery/IImageConstants", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IImageConstants); }
		}

		protected IImageConstants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='IImageConstants']/constructor[@name='IImageConstants' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public IImageConstants () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (IImageConstants)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

	}
}
