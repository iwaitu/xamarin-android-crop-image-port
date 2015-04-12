using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Android.Camera.Gallery {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='SingleImageList']"
	[global::Android.Runtime.Register ("com/android/camera/gallery/SingleImageList", DoNotGenerateAcw=true)]
	public partial class SingleImageList : global::Java.Lang.Object, global::Com.Android.Camera.Gallery.IImageList {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/android/camera/gallery/SingleImageList", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SingleImageList); }
		}

		protected SingleImageList (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_ContentResolver_Landroid_net_Uri_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='SingleImageList']/constructor[@name='SingleImageList' and count(parameter)=2 and parameter[1][@type='android.content.ContentResolver'] and parameter[2][@type='android.net.Uri']]"
		[Register (".ctor", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V", "")]
		public SingleImageList (global::Android.Content.ContentResolver p0, global::Android.Net.Uri p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SingleImageList)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/ContentResolver;Landroid/net/Uri;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/ContentResolver;Landroid/net/Uri;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Landroid_content_ContentResolver_Landroid_net_Uri_ == IntPtr.Zero)
				id_ctor_Landroid_content_ContentResolver_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_ContentResolver_Landroid_net_Uri_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_ContentResolver_Landroid_net_Uri_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_getBucketIds;
#pragma warning disable 0169
		static Delegate GetGetBucketIdsHandler ()
		{
			if (cb_getBucketIds == null)
				cb_getBucketIds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBucketIds);
			return cb_getBucketIds;
		}

		static IntPtr n_GetBucketIds (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Android.Camera.Gallery.SingleImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.SingleImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.BucketIds);
		}
#pragma warning restore 0169

		static IntPtr id_getBucketIds;
		public virtual global::System.Collections.Generic.IDictionary<string, string> BucketIds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='SingleImageList']/method[@name='getBucketIds' and count(parameter)=0]"
			[Register ("getBucketIds", "()Ljava/util/HashMap;", "GetGetBucketIdsHandler")]
			get {
				if (id_getBucketIds == IntPtr.Zero)
					id_getBucketIds = JNIEnv.GetMethodID (class_ref, "getBucketIds", "()Ljava/util/HashMap;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getBucketIds), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBucketIds", "()Ljava/util/HashMap;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCount;
#pragma warning disable 0169
		static Delegate GetGetCountHandler ()
		{
			if (cb_getCount == null)
				cb_getCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCount);
			return cb_getCount;
		}

		static int n_GetCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Android.Camera.Gallery.SingleImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.SingleImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count;
		}
#pragma warning restore 0169

		static IntPtr id_getCount;
		public virtual int Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='SingleImageList']/method[@name='getCount' and count(parameter)=0]"
			[Register ("getCount", "()I", "GetGetCountHandler")]
			get {
				if (id_getCount == IntPtr.Zero)
					id_getCount = JNIEnv.GetMethodID (class_ref, "getCount", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getCount);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCount", "()I"));
			}
		}

		static Delegate cb_isEmpty;
#pragma warning disable 0169
		static Delegate GetIsEmptyHandler ()
		{
			if (cb_isEmpty == null)
				cb_isEmpty = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEmpty);
			return cb_isEmpty;
		}

		static bool n_IsEmpty (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Android.Camera.Gallery.SingleImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.SingleImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEmpty;
		}
#pragma warning restore 0169

		static IntPtr id_isEmpty;
		public virtual bool IsEmpty {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='SingleImageList']/method[@name='isEmpty' and count(parameter)=0]"
			[Register ("isEmpty", "()Z", "GetIsEmptyHandler")]
			get {
				if (id_isEmpty == IntPtr.Zero)
					id_isEmpty = JNIEnv.GetMethodID (class_ref, "isEmpty", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isEmpty);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEmpty", "()Z"));
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Android.Camera.Gallery.SingleImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.SingleImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='SingleImageList']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_close);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
		}

		static Delegate cb_getImageAt_I;
#pragma warning disable 0169
		static Delegate GetGetImageAt_IHandler ()
		{
			if (cb_getImageAt_I == null)
				cb_getImageAt_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetImageAt_I);
			return cb_getImageAt_I;
		}

		static IntPtr n_GetImageAt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Android.Camera.Gallery.SingleImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.SingleImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetImageAt (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getImageAt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='SingleImageList']/method[@name='getImageAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getImageAt", "(I)Lcom/android/camera/gallery/IImage;", "GetGetImageAt_IHandler")]
		public virtual global::Com.Android.Camera.Gallery.IImage GetImageAt (int p0)
		{
			if (id_getImageAt_I == IntPtr.Zero)
				id_getImageAt_I = JNIEnv.GetMethodID (class_ref, "getImageAt", "(I)Lcom/android/camera/gallery/IImage;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImage> (JNIEnv.CallObjectMethod  (Handle, id_getImageAt_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImage> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageAt", "(I)Lcom/android/camera/gallery/IImage;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getImageForUri_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetGetImageForUri_Landroid_net_Uri_Handler ()
		{
			if (cb_getImageForUri_Landroid_net_Uri_ == null)
				cb_getImageForUri_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetImageForUri_Landroid_net_Uri_);
			return cb_getImageForUri_Landroid_net_Uri_;
		}

		static IntPtr n_GetImageForUri_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Android.Camera.Gallery.SingleImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.SingleImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetImageForUri (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getImageForUri_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='SingleImageList']/method[@name='getImageForUri' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("getImageForUri", "(Landroid/net/Uri;)Lcom/android/camera/gallery/IImage;", "GetGetImageForUri_Landroid_net_Uri_Handler")]
		public virtual global::Com.Android.Camera.Gallery.IImage GetImageForUri (global::Android.Net.Uri p0)
		{
			if (id_getImageForUri_Landroid_net_Uri_ == IntPtr.Zero)
				id_getImageForUri_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "getImageForUri", "(Landroid/net/Uri;)Lcom/android/camera/gallery/IImage;");

			global::Com.Android.Camera.Gallery.IImage __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImage> (JNIEnv.CallObjectMethod  (Handle, id_getImageForUri_Landroid_net_Uri_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImage> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageForUri", "(Landroid/net/Uri;)Lcom/android/camera/gallery/IImage;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getImageIndex_Lcom_android_camera_gallery_IImage_;
#pragma warning disable 0169
		static Delegate GetGetImageIndex_Lcom_android_camera_gallery_IImage_Handler ()
		{
			if (cb_getImageIndex_Lcom_android_camera_gallery_IImage_ == null)
				cb_getImageIndex_Lcom_android_camera_gallery_IImage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetImageIndex_Lcom_android_camera_gallery_IImage_);
			return cb_getImageIndex_Lcom_android_camera_gallery_IImage_;
		}

		static int n_GetImageIndex_Lcom_android_camera_gallery_IImage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Android.Camera.Gallery.SingleImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.SingleImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Android.Camera.Gallery.IImage p0 = (global::Com.Android.Camera.Gallery.IImage)global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImage> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetImageIndex (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getImageIndex_Lcom_android_camera_gallery_IImage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='SingleImageList']/method[@name='getImageIndex' and count(parameter)=1 and parameter[1][@type='com.android.camera.gallery.IImage']]"
		[Register ("getImageIndex", "(Lcom/android/camera/gallery/IImage;)I", "GetGetImageIndex_Lcom_android_camera_gallery_IImage_Handler")]
		public virtual int GetImageIndex (global::Com.Android.Camera.Gallery.IImage p0)
		{
			if (id_getImageIndex_Lcom_android_camera_gallery_IImage_ == IntPtr.Zero)
				id_getImageIndex_Lcom_android_camera_gallery_IImage_ = JNIEnv.GetMethodID (class_ref, "getImageIndex", "(Lcom/android/camera/gallery/IImage;)I");

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_getImageIndex_Lcom_android_camera_gallery_IImage_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageIndex", "(Lcom/android/camera/gallery/IImage;)I"), new JValue (p0));
			return __ret;
		}

		static Delegate cb_removeImage_Lcom_android_camera_gallery_IImage_;
#pragma warning disable 0169
		static Delegate GetRemoveImage_Lcom_android_camera_gallery_IImage_Handler ()
		{
			if (cb_removeImage_Lcom_android_camera_gallery_IImage_ == null)
				cb_removeImage_Lcom_android_camera_gallery_IImage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveImage_Lcom_android_camera_gallery_IImage_);
			return cb_removeImage_Lcom_android_camera_gallery_IImage_;
		}

		static bool n_RemoveImage_Lcom_android_camera_gallery_IImage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Android.Camera.Gallery.SingleImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.SingleImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Android.Camera.Gallery.IImage p0 = (global::Com.Android.Camera.Gallery.IImage)global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImage> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveImage (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_removeImage_Lcom_android_camera_gallery_IImage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='SingleImageList']/method[@name='removeImage' and count(parameter)=1 and parameter[1][@type='com.android.camera.gallery.IImage']]"
		[Register ("removeImage", "(Lcom/android/camera/gallery/IImage;)Z", "GetRemoveImage_Lcom_android_camera_gallery_IImage_Handler")]
		public virtual bool RemoveImage (global::Com.Android.Camera.Gallery.IImage p0)
		{
			if (id_removeImage_Lcom_android_camera_gallery_IImage_ == IntPtr.Zero)
				id_removeImage_Lcom_android_camera_gallery_IImage_ = JNIEnv.GetMethodID (class_ref, "removeImage", "(Lcom/android/camera/gallery/IImage;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_removeImage_Lcom_android_camera_gallery_IImage_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeImage", "(Lcom/android/camera/gallery/IImage;)Z"), new JValue (p0));
			return __ret;
		}

		static Delegate cb_removeImageAt_I;
#pragma warning disable 0169
		static Delegate GetRemoveImageAt_IHandler ()
		{
			if (cb_removeImageAt_I == null)
				cb_removeImageAt_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_RemoveImageAt_I);
			return cb_removeImageAt_I;
		}

		static bool n_RemoveImageAt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Android.Camera.Gallery.SingleImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.SingleImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RemoveImageAt (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeImageAt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='SingleImageList']/method[@name='removeImageAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removeImageAt", "(I)Z", "GetRemoveImageAt_IHandler")]
		public virtual bool RemoveImageAt (int p0)
		{
			if (id_removeImageAt_I == IntPtr.Zero)
				id_removeImageAt_I = JNIEnv.GetMethodID (class_ref, "removeImageAt", "(I)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_removeImageAt_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeImageAt", "(I)Z"), new JValue (p0));
		}

	}
}
