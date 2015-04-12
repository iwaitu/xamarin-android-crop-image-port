using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Android.Camera {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.android.camera']/class[@name='CropImageIntentBuilder']"
	[global::Android.Runtime.Register ("com/android/camera/CropImageIntentBuilder", DoNotGenerateAcw=true)]
	public partial class CropImageIntentBuilder : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/android/camera/CropImageIntentBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CropImageIntentBuilder); }
		}

		protected CropImageIntentBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IILandroid_net_Uri_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.android.camera']/class[@name='CropImageIntentBuilder']/constructor[@name='CropImageIntentBuilder' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.net.Uri']]"
		[Register (".ctor", "(IILandroid/net/Uri;)V", "")]
		public CropImageIntentBuilder (int p0, int p1, global::Android.Net.Uri p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CropImageIntentBuilder)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IILandroid/net/Uri;)V", new JValue (p0), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(IILandroid/net/Uri;)V", new JValue (p0), new JValue (p1), new JValue (p2));
				return;
			}

			if (id_ctor_IILandroid_net_Uri_ == IntPtr.Zero)
				id_ctor_IILandroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "<init>", "(IILandroid/net/Uri;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IILandroid_net_Uri_, new JValue (p0), new JValue (p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IILandroid_net_Uri_, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_ctor_IIIILandroid_net_Uri_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.android.camera']/class[@name='CropImageIntentBuilder']/constructor[@name='CropImageIntentBuilder' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='android.net.Uri']]"
		[Register (".ctor", "(IIIILandroid/net/Uri;)V", "")]
		public CropImageIntentBuilder (int p0, int p1, int p2, int p3, global::Android.Net.Uri p4) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CropImageIntentBuilder)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IIIILandroid/net/Uri;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(IIIILandroid/net/Uri;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
				return;
			}

			if (id_ctor_IIIILandroid_net_Uri_ == IntPtr.Zero)
				id_ctor_IIIILandroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "<init>", "(IIIILandroid/net/Uri;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIIILandroid_net_Uri_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IIIILandroid_net_Uri_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
		}

		static Delegate cb_getIntent_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetIntent_Landroid_content_Context_Handler ()
		{
			if (cb_getIntent_Landroid_content_Context_ == null)
				cb_getIntent_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetIntent_Landroid_content_Context_);
			return cb_getIntent_Landroid_content_Context_;
		}

		static IntPtr n_GetIntent_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Android.Camera.CropImageIntentBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.CropImageIntentBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetIntent (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getIntent_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='CropImageIntentBuilder']/method[@name='getIntent' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getIntent", "(Landroid/content/Context;)Landroid/content/Intent;", "GetGetIntent_Landroid_content_Context_Handler")]
		public virtual global::Android.Content.Intent GetIntent (global::Android.Content.Context p0)
		{
			if (id_getIntent_Landroid_content_Context_ == IntPtr.Zero)
				id_getIntent_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getIntent", "(Landroid/content/Context;)Landroid/content/Intent;");

			global::Android.Content.Intent __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallObjectMethod  (Handle, id_getIntent_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIntent", "(Landroid/content/Context;)Landroid/content/Intent;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setBitmap_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetSetBitmap_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_setBitmap_Landroid_graphics_Bitmap_ == null)
				cb_setBitmap_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetBitmap_Landroid_graphics_Bitmap_);
			return cb_setBitmap_Landroid_graphics_Bitmap_;
		}

		static IntPtr n_SetBitmap_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Android.Camera.CropImageIntentBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.CropImageIntentBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetBitmap (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setBitmap_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='CropImageIntentBuilder']/method[@name='setBitmap' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("setBitmap", "(Landroid/graphics/Bitmap;)Lcom/android/camera/CropImageIntentBuilder;", "GetSetBitmap_Landroid_graphics_Bitmap_Handler")]
		public virtual global::Com.Android.Camera.CropImageIntentBuilder SetBitmap (global::Android.Graphics.Bitmap p0)
		{
			if (id_setBitmap_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_setBitmap_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "setBitmap", "(Landroid/graphics/Bitmap;)Lcom/android/camera/CropImageIntentBuilder;");

			global::Com.Android.Camera.CropImageIntentBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.CropImageIntentBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setBitmap_Landroid_graphics_Bitmap_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.CropImageIntentBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBitmap", "(Landroid/graphics/Bitmap;)Lcom/android/camera/CropImageIntentBuilder;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setCircleCrop_Z;
#pragma warning disable 0169
		static Delegate GetSetCircleCrop_ZHandler ()
		{
			if (cb_setCircleCrop_Z == null)
				cb_setCircleCrop_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetCircleCrop_Z);
			return cb_setCircleCrop_Z;
		}

		static IntPtr n_SetCircleCrop_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Android.Camera.CropImageIntentBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.CropImageIntentBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetCircleCrop (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setCircleCrop_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='CropImageIntentBuilder']/method[@name='setCircleCrop' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setCircleCrop", "(Z)Lcom/android/camera/CropImageIntentBuilder;", "GetSetCircleCrop_ZHandler")]
		public virtual global::Com.Android.Camera.CropImageIntentBuilder SetCircleCrop (bool p0)
		{
			if (id_setCircleCrop_Z == IntPtr.Zero)
				id_setCircleCrop_Z = JNIEnv.GetMethodID (class_ref, "setCircleCrop", "(Z)Lcom/android/camera/CropImageIntentBuilder;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Android.Camera.CropImageIntentBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setCircleCrop_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Android.Camera.CropImageIntentBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCircleCrop", "(Z)Lcom/android/camera/CropImageIntentBuilder;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setDoFaceDetection_Z;
#pragma warning disable 0169
		static Delegate GetSetDoFaceDetection_ZHandler ()
		{
			if (cb_setDoFaceDetection_Z == null)
				cb_setDoFaceDetection_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetDoFaceDetection_Z);
			return cb_setDoFaceDetection_Z;
		}

		static IntPtr n_SetDoFaceDetection_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Android.Camera.CropImageIntentBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.CropImageIntentBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDoFaceDetection (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setDoFaceDetection_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='CropImageIntentBuilder']/method[@name='setDoFaceDetection' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDoFaceDetection", "(Z)Lcom/android/camera/CropImageIntentBuilder;", "GetSetDoFaceDetection_ZHandler")]
		public virtual global::Com.Android.Camera.CropImageIntentBuilder SetDoFaceDetection (bool p0)
		{
			if (id_setDoFaceDetection_Z == IntPtr.Zero)
				id_setDoFaceDetection_Z = JNIEnv.GetMethodID (class_ref, "setDoFaceDetection", "(Z)Lcom/android/camera/CropImageIntentBuilder;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Android.Camera.CropImageIntentBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setDoFaceDetection_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Android.Camera.CropImageIntentBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDoFaceDetection", "(Z)Lcom/android/camera/CropImageIntentBuilder;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setOutlineCircleColor_I;
#pragma warning disable 0169
		static Delegate GetSetOutlineCircleColor_IHandler ()
		{
			if (cb_setOutlineCircleColor_I == null)
				cb_setOutlineCircleColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetOutlineCircleColor_I);
			return cb_setOutlineCircleColor_I;
		}

		static IntPtr n_SetOutlineCircleColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Android.Camera.CropImageIntentBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.CropImageIntentBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetOutlineCircleColor (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setOutlineCircleColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='CropImageIntentBuilder']/method[@name='setOutlineCircleColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setOutlineCircleColor", "(I)Lcom/android/camera/CropImageIntentBuilder;", "GetSetOutlineCircleColor_IHandler")]
		public virtual global::Com.Android.Camera.CropImageIntentBuilder SetOutlineCircleColor (int p0)
		{
			if (id_setOutlineCircleColor_I == IntPtr.Zero)
				id_setOutlineCircleColor_I = JNIEnv.GetMethodID (class_ref, "setOutlineCircleColor", "(I)Lcom/android/camera/CropImageIntentBuilder;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Android.Camera.CropImageIntentBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setOutlineCircleColor_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Android.Camera.CropImageIntentBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOutlineCircleColor", "(I)Lcom/android/camera/CropImageIntentBuilder;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setOutlineColor_I;
#pragma warning disable 0169
		static Delegate GetSetOutlineColor_IHandler ()
		{
			if (cb_setOutlineColor_I == null)
				cb_setOutlineColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetOutlineColor_I);
			return cb_setOutlineColor_I;
		}

		static IntPtr n_SetOutlineColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Android.Camera.CropImageIntentBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.CropImageIntentBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetOutlineColor (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setOutlineColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='CropImageIntentBuilder']/method[@name='setOutlineColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setOutlineColor", "(I)Lcom/android/camera/CropImageIntentBuilder;", "GetSetOutlineColor_IHandler")]
		public virtual global::Com.Android.Camera.CropImageIntentBuilder SetOutlineColor (int p0)
		{
			if (id_setOutlineColor_I == IntPtr.Zero)
				id_setOutlineColor_I = JNIEnv.GetMethodID (class_ref, "setOutlineColor", "(I)Lcom/android/camera/CropImageIntentBuilder;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Android.Camera.CropImageIntentBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setOutlineColor_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Android.Camera.CropImageIntentBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOutlineColor", "(I)Lcom/android/camera/CropImageIntentBuilder;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setOutputFormat_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetOutputFormat_Ljava_lang_String_Handler ()
		{
			if (cb_setOutputFormat_Ljava_lang_String_ == null)
				cb_setOutputFormat_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetOutputFormat_Ljava_lang_String_);
			return cb_setOutputFormat_Ljava_lang_String_;
		}

		static IntPtr n_SetOutputFormat_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Android.Camera.CropImageIntentBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.CropImageIntentBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOutputFormat (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setOutputFormat_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='CropImageIntentBuilder']/method[@name='setOutputFormat' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setOutputFormat", "(Ljava/lang/String;)Lcom/android/camera/CropImageIntentBuilder;", "GetSetOutputFormat_Ljava_lang_String_Handler")]
		public virtual global::Com.Android.Camera.CropImageIntentBuilder SetOutputFormat (string p0)
		{
			if (id_setOutputFormat_Ljava_lang_String_ == IntPtr.Zero)
				id_setOutputFormat_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setOutputFormat", "(Ljava/lang/String;)Lcom/android/camera/CropImageIntentBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Android.Camera.CropImageIntentBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.CropImageIntentBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setOutputFormat_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.CropImageIntentBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOutputFormat", "(Ljava/lang/String;)Lcom/android/camera/CropImageIntentBuilder;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setOutputQuality_I;
#pragma warning disable 0169
		static Delegate GetSetOutputQuality_IHandler ()
		{
			if (cb_setOutputQuality_I == null)
				cb_setOutputQuality_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetOutputQuality_I);
			return cb_setOutputQuality_I;
		}

		static IntPtr n_SetOutputQuality_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Android.Camera.CropImageIntentBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.CropImageIntentBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetOutputQuality (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setOutputQuality_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='CropImageIntentBuilder']/method[@name='setOutputQuality' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setOutputQuality", "(I)Lcom/android/camera/CropImageIntentBuilder;", "GetSetOutputQuality_IHandler")]
		public virtual global::Com.Android.Camera.CropImageIntentBuilder SetOutputQuality (int p0)
		{
			if (id_setOutputQuality_I == IntPtr.Zero)
				id_setOutputQuality_I = JNIEnv.GetMethodID (class_ref, "setOutputQuality", "(I)Lcom/android/camera/CropImageIntentBuilder;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Android.Camera.CropImageIntentBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setOutputQuality_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Android.Camera.CropImageIntentBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOutputQuality", "(I)Lcom/android/camera/CropImageIntentBuilder;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setScale_Z;
#pragma warning disable 0169
		static Delegate GetSetScale_ZHandler ()
		{
			if (cb_setScale_Z == null)
				cb_setScale_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetScale_Z);
			return cb_setScale_Z;
		}

		static IntPtr n_SetScale_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Android.Camera.CropImageIntentBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.CropImageIntentBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetScale (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setScale_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='CropImageIntentBuilder']/method[@name='setScale' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setScale", "(Z)Lcom/android/camera/CropImageIntentBuilder;", "GetSetScale_ZHandler")]
		public virtual global::Com.Android.Camera.CropImageIntentBuilder SetScale (bool p0)
		{
			if (id_setScale_Z == IntPtr.Zero)
				id_setScale_Z = JNIEnv.GetMethodID (class_ref, "setScale", "(Z)Lcom/android/camera/CropImageIntentBuilder;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Android.Camera.CropImageIntentBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setScale_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Android.Camera.CropImageIntentBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScale", "(Z)Lcom/android/camera/CropImageIntentBuilder;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setScaleUpIfNeeded_Z;
#pragma warning disable 0169
		static Delegate GetSetScaleUpIfNeeded_ZHandler ()
		{
			if (cb_setScaleUpIfNeeded_Z == null)
				cb_setScaleUpIfNeeded_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetScaleUpIfNeeded_Z);
			return cb_setScaleUpIfNeeded_Z;
		}

		static IntPtr n_SetScaleUpIfNeeded_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Android.Camera.CropImageIntentBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.CropImageIntentBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetScaleUpIfNeeded (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setScaleUpIfNeeded_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='CropImageIntentBuilder']/method[@name='setScaleUpIfNeeded' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setScaleUpIfNeeded", "(Z)Lcom/android/camera/CropImageIntentBuilder;", "GetSetScaleUpIfNeeded_ZHandler")]
		public virtual global::Com.Android.Camera.CropImageIntentBuilder SetScaleUpIfNeeded (bool p0)
		{
			if (id_setScaleUpIfNeeded_Z == IntPtr.Zero)
				id_setScaleUpIfNeeded_Z = JNIEnv.GetMethodID (class_ref, "setScaleUpIfNeeded", "(Z)Lcom/android/camera/CropImageIntentBuilder;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Android.Camera.CropImageIntentBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setScaleUpIfNeeded_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Android.Camera.CropImageIntentBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScaleUpIfNeeded", "(Z)Lcom/android/camera/CropImageIntentBuilder;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setSourceImage_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetSetSourceImage_Landroid_net_Uri_Handler ()
		{
			if (cb_setSourceImage_Landroid_net_Uri_ == null)
				cb_setSourceImage_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetSourceImage_Landroid_net_Uri_);
			return cb_setSourceImage_Landroid_net_Uri_;
		}

		static IntPtr n_SetSourceImage_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Android.Camera.CropImageIntentBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.CropImageIntentBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetSourceImage (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setSourceImage_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='CropImageIntentBuilder']/method[@name='setSourceImage' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("setSourceImage", "(Landroid/net/Uri;)Lcom/android/camera/CropImageIntentBuilder;", "GetSetSourceImage_Landroid_net_Uri_Handler")]
		public virtual global::Com.Android.Camera.CropImageIntentBuilder SetSourceImage (global::Android.Net.Uri p0)
		{
			if (id_setSourceImage_Landroid_net_Uri_ == IntPtr.Zero)
				id_setSourceImage_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "setSourceImage", "(Landroid/net/Uri;)Lcom/android/camera/CropImageIntentBuilder;");

			global::Com.Android.Camera.CropImageIntentBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.CropImageIntentBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setSourceImage_Landroid_net_Uri_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.CropImageIntentBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSourceImage", "(Landroid/net/Uri;)Lcom/android/camera/CropImageIntentBuilder;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
