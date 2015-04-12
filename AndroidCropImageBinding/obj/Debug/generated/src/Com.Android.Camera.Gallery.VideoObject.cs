using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Android.Camera.Gallery {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='VideoObject']"
	[global::Android.Runtime.Register ("com/android/camera/gallery/VideoObject", DoNotGenerateAcw=true)]
	public partial class VideoObject : global::Com.Android.Camera.Gallery.BaseImage, global::Com.Android.Camera.Gallery.IImage {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/android/camera/gallery/VideoObject", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VideoObject); }
		}

		protected VideoObject (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_android_camera_gallery_BaseImageList_Landroid_content_ContentResolver_JILandroid_net_Uri_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='VideoObject']/constructor[@name='VideoObject' and count(parameter)=9 and parameter[1][@type='com.android.camera.gallery.BaseImageList'] and parameter[2][@type='android.content.ContentResolver'] and parameter[3][@type='long'] and parameter[4][@type='int'] and parameter[5][@type='android.net.Uri'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='long'] and parameter[9][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/android/camera/gallery/BaseImageList;Landroid/content/ContentResolver;JILandroid/net/Uri;Ljava/lang/String;Ljava/lang/String;JLjava/lang/String;)V", "")]
		protected VideoObject (global::Com.Android.Camera.Gallery.BaseImageList p0, global::Android.Content.ContentResolver p1, long p2, int p3, global::Android.Net.Uri p4, string p5, string p6, long p7, string p8) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p5 = JNIEnv.NewString (p5);;
			IntPtr native_p6 = JNIEnv.NewString (p6);;
			IntPtr native_p8 = JNIEnv.NewString (p8);;
			if (GetType () != typeof (VideoObject)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/android/camera/gallery/BaseImageList;Landroid/content/ContentResolver;JILandroid/net/Uri;Ljava/lang/String;Ljava/lang/String;JLjava/lang/String;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (native_p5), new JValue (native_p6), new JValue (p7), new JValue (native_p8)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/android/camera/gallery/BaseImageList;Landroid/content/ContentResolver;JILandroid/net/Uri;Ljava/lang/String;Ljava/lang/String;JLjava/lang/String;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (native_p5), new JValue (native_p6), new JValue (p7), new JValue (native_p8));
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p6);
				JNIEnv.DeleteLocalRef (native_p8);
				return;
			}

			if (id_ctor_Lcom_android_camera_gallery_BaseImageList_Landroid_content_ContentResolver_JILandroid_net_Uri_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_ == IntPtr.Zero)
				id_ctor_Lcom_android_camera_gallery_BaseImageList_Landroid_content_ContentResolver_JILandroid_net_Uri_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/android/camera/gallery/BaseImageList;Landroid/content/ContentResolver;JILandroid/net/Uri;Ljava/lang/String;Ljava/lang/String;JLjava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_android_camera_gallery_BaseImageList_Landroid_content_ContentResolver_JILandroid_net_Uri_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (native_p5), new JValue (native_p6), new JValue (p7), new JValue (native_p8)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_android_camera_gallery_BaseImageList_Landroid_content_ContentResolver_JILandroid_net_Uri_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (native_p5), new JValue (native_p6), new JValue (p7), new JValue (native_p8));
			JNIEnv.DeleteLocalRef (native_p5);
			JNIEnv.DeleteLocalRef (native_p6);
			JNIEnv.DeleteLocalRef (native_p8);
		}

		static Delegate cb_isDrm;
#pragma warning disable 0169
		static Delegate GetIsDrmHandler ()
		{
			if (cb_isDrm == null)
				cb_isDrm = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDrm);
			return cb_isDrm;
		}

		static bool n_IsDrm (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Android.Camera.Gallery.VideoObject __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.VideoObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrm;
		}
#pragma warning restore 0169

		static IntPtr id_isDrm;
		public override bool IsDrm {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='VideoObject']/method[@name='isDrm' and count(parameter)=0]"
			[Register ("isDrm", "()Z", "GetIsDrmHandler")]
			get {
				if (id_isDrm == IntPtr.Zero)
					id_isDrm = JNIEnv.GetMethodID (class_ref, "isDrm", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isDrm);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDrm", "()Z"));
			}
		}

		static Delegate cb_isReadonly;
#pragma warning disable 0169
		static Delegate GetIsReadonlyHandler ()
		{
			if (cb_isReadonly == null)
				cb_isReadonly = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsReadonly);
			return cb_isReadonly;
		}

		static bool n_IsReadonly (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Android.Camera.Gallery.VideoObject __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.VideoObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsReadonly;
		}
#pragma warning restore 0169

		static IntPtr id_isReadonly;
		public override bool IsReadonly {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='VideoObject']/method[@name='isReadonly' and count(parameter)=0]"
			[Register ("isReadonly", "()Z", "GetIsReadonlyHandler")]
			get {
				if (id_isReadonly == IntPtr.Zero)
					id_isReadonly = JNIEnv.GetMethodID (class_ref, "isReadonly", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isReadonly);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isReadonly", "()Z"));
			}
		}

		static Delegate cb_rotateImageBy_I;
#pragma warning disable 0169
		static Delegate GetRotateImageBy_IHandler ()
		{
			if (cb_rotateImageBy_I == null)
				cb_rotateImageBy_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_RotateImageBy_I);
			return cb_rotateImageBy_I;
		}

		static bool n_RotateImageBy_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Android.Camera.Gallery.VideoObject __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.VideoObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RotateImageBy (p0);
		}
#pragma warning restore 0169

		static IntPtr id_rotateImageBy_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='VideoObject']/method[@name='rotateImageBy' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("rotateImageBy", "(I)Z", "GetRotateImageBy_IHandler")]
		public override bool RotateImageBy (int p0)
		{
			if (id_rotateImageBy_I == IntPtr.Zero)
				id_rotateImageBy_I = JNIEnv.GetMethodID (class_ref, "rotateImageBy", "(I)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_rotateImageBy_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "rotateImageBy", "(I)Z"), new JValue (p0));
		}

		static Delegate cb_thumbBitmap_Z;
#pragma warning disable 0169
		static Delegate GetThumbBitmap_ZHandler ()
		{
			if (cb_thumbBitmap_Z == null)
				cb_thumbBitmap_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_ThumbBitmap_Z);
			return cb_thumbBitmap_Z;
		}

		static IntPtr n_ThumbBitmap_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Android.Camera.Gallery.VideoObject __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.VideoObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ThumbBitmap (p0));
		}
#pragma warning restore 0169

		static IntPtr id_thumbBitmap_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='VideoObject']/method[@name='thumbBitmap' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("thumbBitmap", "(Z)Landroid/graphics/Bitmap;", "GetThumbBitmap_ZHandler")]
		public override global::Android.Graphics.Bitmap ThumbBitmap (bool p0)
		{
			if (id_thumbBitmap_Z == IntPtr.Zero)
				id_thumbBitmap_Z = JNIEnv.GetMethodID (class_ref, "thumbBitmap", "(Z)Landroid/graphics/Bitmap;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_thumbBitmap_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "thumbBitmap", "(Z)Landroid/graphics/Bitmap;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

	}
}
