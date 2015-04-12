using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Android.Camera.Gallery {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.android.camera.gallery']/interface[@name='IImageList']"
	[Register ("com/android/camera/gallery/IImageList", "", "Com.Android.Camera.Gallery.IImageListInvoker")]
	public partial interface IImageList : IJavaObject {

		global::System.Collections.Generic.IDictionary<string, string> BucketIds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/interface[@name='IImageList']/method[@name='getBucketIds' and count(parameter)=0]"
			[Register ("getBucketIds", "()Ljava/util/HashMap;", "GetGetBucketIdsHandler:Com.Android.Camera.Gallery.IImageListInvoker, AndroidCropImageBinding")] get;
		}

		int Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/interface[@name='IImageList']/method[@name='getCount' and count(parameter)=0]"
			[Register ("getCount", "()I", "GetGetCountHandler:Com.Android.Camera.Gallery.IImageListInvoker, AndroidCropImageBinding")] get;
		}

		bool IsEmpty {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/interface[@name='IImageList']/method[@name='isEmpty' and count(parameter)=0]"
			[Register ("isEmpty", "()Z", "GetIsEmptyHandler:Com.Android.Camera.Gallery.IImageListInvoker, AndroidCropImageBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/interface[@name='IImageList']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler:Com.Android.Camera.Gallery.IImageListInvoker, AndroidCropImageBinding")]
		void Close ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/interface[@name='IImageList']/method[@name='getImageAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getImageAt", "(I)Lcom/android/camera/gallery/IImage;", "GetGetImageAt_IHandler:Com.Android.Camera.Gallery.IImageListInvoker, AndroidCropImageBinding")]
		global::Com.Android.Camera.Gallery.IImage GetImageAt (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/interface[@name='IImageList']/method[@name='getImageForUri' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("getImageForUri", "(Landroid/net/Uri;)Lcom/android/camera/gallery/IImage;", "GetGetImageForUri_Landroid_net_Uri_Handler:Com.Android.Camera.Gallery.IImageListInvoker, AndroidCropImageBinding")]
		global::Com.Android.Camera.Gallery.IImage GetImageForUri (global::Android.Net.Uri p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/interface[@name='IImageList']/method[@name='getImageIndex' and count(parameter)=1 and parameter[1][@type='com.android.camera.gallery.IImage']]"
		[Register ("getImageIndex", "(Lcom/android/camera/gallery/IImage;)I", "GetGetImageIndex_Lcom_android_camera_gallery_IImage_Handler:Com.Android.Camera.Gallery.IImageListInvoker, AndroidCropImageBinding")]
		int GetImageIndex (global::Com.Android.Camera.Gallery.IImage p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/interface[@name='IImageList']/method[@name='removeImage' and count(parameter)=1 and parameter[1][@type='com.android.camera.gallery.IImage']]"
		[Register ("removeImage", "(Lcom/android/camera/gallery/IImage;)Z", "GetRemoveImage_Lcom_android_camera_gallery_IImage_Handler:Com.Android.Camera.Gallery.IImageListInvoker, AndroidCropImageBinding")]
		bool RemoveImage (global::Com.Android.Camera.Gallery.IImage p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/interface[@name='IImageList']/method[@name='removeImageAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removeImageAt", "(I)Z", "GetRemoveImageAt_IHandler:Com.Android.Camera.Gallery.IImageListInvoker, AndroidCropImageBinding")]
		bool RemoveImageAt (int p0);

	}

	[global::Android.Runtime.Register ("com/android/camera/gallery/IImageList", DoNotGenerateAcw=true)]
	internal class IImageListInvoker : global::Java.Lang.Object, IImageList {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/android/camera/gallery/IImageList");
		IntPtr class_ref;

		public static IImageList GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IImageList> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.android.camera.gallery.IImageList"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IImageListInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IImageListInvoker); }
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
			global::Com.Android.Camera.Gallery.IImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.BucketIds);
		}
#pragma warning restore 0169

		IntPtr id_getBucketIds;
		public global::System.Collections.Generic.IDictionary<string, string> BucketIds {
			get {
				if (id_getBucketIds == IntPtr.Zero)
					id_getBucketIds = JNIEnv.GetMethodID (class_ref, "getBucketIds", "()Ljava/util/HashMap;");
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getBucketIds), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Android.Camera.Gallery.IImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count;
		}
#pragma warning restore 0169

		IntPtr id_getCount;
		public int Count {
			get {
				if (id_getCount == IntPtr.Zero)
					id_getCount = JNIEnv.GetMethodID (class_ref, "getCount", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getCount);
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
			global::Com.Android.Camera.Gallery.IImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEmpty;
		}
#pragma warning restore 0169

		IntPtr id_isEmpty;
		public bool IsEmpty {
			get {
				if (id_isEmpty == IntPtr.Zero)
					id_isEmpty = JNIEnv.GetMethodID (class_ref, "isEmpty", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isEmpty);
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
			global::Com.Android.Camera.Gallery.IImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		IntPtr id_close;
		public void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			JNIEnv.CallVoidMethod (Handle, id_close);
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
			global::Com.Android.Camera.Gallery.IImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetImageAt (p0));
		}
#pragma warning restore 0169

		IntPtr id_getImageAt_I;
		public global::Com.Android.Camera.Gallery.IImage GetImageAt (int p0)
		{
			if (id_getImageAt_I == IntPtr.Zero)
				id_getImageAt_I = JNIEnv.GetMethodID (class_ref, "getImageAt", "(I)Lcom/android/camera/gallery/IImage;");
			return global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImage> (JNIEnv.CallObjectMethod (Handle, id_getImageAt_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Android.Camera.Gallery.IImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetImageForUri (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getImageForUri_Landroid_net_Uri_;
		public global::Com.Android.Camera.Gallery.IImage GetImageForUri (global::Android.Net.Uri p0)
		{
			if (id_getImageForUri_Landroid_net_Uri_ == IntPtr.Zero)
				id_getImageForUri_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "getImageForUri", "(Landroid/net/Uri;)Lcom/android/camera/gallery/IImage;");
			global::Com.Android.Camera.Gallery.IImage __ret = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImage> (JNIEnv.CallObjectMethod (Handle, id_getImageForUri_Landroid_net_Uri_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Android.Camera.Gallery.IImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Android.Camera.Gallery.IImage p0 = (global::Com.Android.Camera.Gallery.IImage)global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImage> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetImageIndex (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getImageIndex_Lcom_android_camera_gallery_IImage_;
		public int GetImageIndex (global::Com.Android.Camera.Gallery.IImage p0)
		{
			if (id_getImageIndex_Lcom_android_camera_gallery_IImage_ == IntPtr.Zero)
				id_getImageIndex_Lcom_android_camera_gallery_IImage_ = JNIEnv.GetMethodID (class_ref, "getImageIndex", "(Lcom/android/camera/gallery/IImage;)I");
			int __ret = JNIEnv.CallIntMethod (Handle, id_getImageIndex_Lcom_android_camera_gallery_IImage_, new JValue (p0));
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
			global::Com.Android.Camera.Gallery.IImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Android.Camera.Gallery.IImage p0 = (global::Com.Android.Camera.Gallery.IImage)global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImage> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveImage (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_removeImage_Lcom_android_camera_gallery_IImage_;
		public bool RemoveImage (global::Com.Android.Camera.Gallery.IImage p0)
		{
			if (id_removeImage_Lcom_android_camera_gallery_IImage_ == IntPtr.Zero)
				id_removeImage_Lcom_android_camera_gallery_IImage_ = JNIEnv.GetMethodID (class_ref, "removeImage", "(Lcom/android/camera/gallery/IImage;)Z");
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_removeImage_Lcom_android_camera_gallery_IImage_, new JValue (p0));
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
			global::Com.Android.Camera.Gallery.IImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RemoveImageAt (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeImageAt_I;
		public bool RemoveImageAt (int p0)
		{
			if (id_removeImageAt_I == IntPtr.Zero)
				id_removeImageAt_I = JNIEnv.GetMethodID (class_ref, "removeImageAt", "(I)Z");
			return JNIEnv.CallBooleanMethod (Handle, id_removeImageAt_I, new JValue (p0));
		}

	}

}
