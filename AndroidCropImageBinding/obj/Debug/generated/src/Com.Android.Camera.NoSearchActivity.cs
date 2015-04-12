using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Android.Camera {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.android.camera']/class[@name='NoSearchActivity']"
	[global::Android.Runtime.Register ("com/android/camera/NoSearchActivity", DoNotGenerateAcw=true)]
	public partial class NoSearchActivity : global::Android.App.Activity {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/android/camera/NoSearchActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NoSearchActivity); }
		}

		protected NoSearchActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.android.camera']/class[@name='NoSearchActivity']/constructor[@name='NoSearchActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public NoSearchActivity () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (NoSearchActivity)) {
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
