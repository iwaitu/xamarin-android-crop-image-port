using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Android.Camera.Gallery {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImageList']"
	[global::Android.Runtime.Register ("com/android/camera/gallery/BaseImageList", DoNotGenerateAcw=true)]
	public abstract partial class BaseImageList : global::Java.Lang.Object, global::Com.Android.Camera.Gallery.IImageList {


		static IntPtr mBaseUri_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImageList']/field[@name='mBaseUri']"
		[Register ("mBaseUri")]
		protected global::Android.Net.Uri MBaseUri {
			get {
				if (mBaseUri_jfieldId == IntPtr.Zero)
					mBaseUri_jfieldId = JNIEnv.GetFieldID (class_ref, "mBaseUri", "Landroid/net/Uri;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mBaseUri_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mBaseUri_jfieldId == IntPtr.Zero)
					mBaseUri_jfieldId = JNIEnv.GetFieldID (class_ref, "mBaseUri", "Landroid/net/Uri;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mBaseUri_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mBucketId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImageList']/field[@name='mBucketId']"
		[Register ("mBucketId")]
		protected string MBucketId {
			get {
				if (mBucketId_jfieldId == IntPtr.Zero)
					mBucketId_jfieldId = JNIEnv.GetFieldID (class_ref, "mBucketId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mBucketId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mBucketId_jfieldId == IntPtr.Zero)
					mBucketId_jfieldId = JNIEnv.GetFieldID (class_ref, "mBucketId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, mBucketId_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mContentResolver_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImageList']/field[@name='mContentResolver']"
		[Register ("mContentResolver")]
		protected global::Android.Content.ContentResolver MContentResolver {
			get {
				if (mContentResolver_jfieldId == IntPtr.Zero)
					mContentResolver_jfieldId = JNIEnv.GetFieldID (class_ref, "mContentResolver", "Landroid/content/ContentResolver;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mContentResolver_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Content.ContentResolver> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mContentResolver_jfieldId == IntPtr.Zero)
					mContentResolver_jfieldId = JNIEnv.GetFieldID (class_ref, "mContentResolver", "Landroid/content/ContentResolver;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mContentResolver_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mCursor_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImageList']/field[@name='mCursor']"
		[Register ("mCursor")]
		protected global::Android.Database.ICursor MCursor {
			get {
				if (mCursor_jfieldId == IntPtr.Zero)
					mCursor_jfieldId = JNIEnv.GetFieldID (class_ref, "mCursor", "Landroid/database/Cursor;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mCursor_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCursor_jfieldId == IntPtr.Zero)
					mCursor_jfieldId = JNIEnv.GetFieldID (class_ref, "mCursor", "Landroid/database/Cursor;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mCursor_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mCursorDeactivated_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImageList']/field[@name='mCursorDeactivated']"
		[Register ("mCursorDeactivated")]
		protected bool MCursorDeactivated {
			get {
				if (mCursorDeactivated_jfieldId == IntPtr.Zero)
					mCursorDeactivated_jfieldId = JNIEnv.GetFieldID (class_ref, "mCursorDeactivated", "Z");
				return JNIEnv.GetBooleanField (Handle, mCursorDeactivated_jfieldId);
			}
			set {
				if (mCursorDeactivated_jfieldId == IntPtr.Zero)
					mCursorDeactivated_jfieldId = JNIEnv.GetFieldID (class_ref, "mCursorDeactivated", "Z");
				JNIEnv.SetField (Handle, mCursorDeactivated_jfieldId, value);
			}
		}

		static IntPtr mSort_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImageList']/field[@name='mSort']"
		[Register ("mSort")]
		protected int MSort {
			get {
				if (mSort_jfieldId == IntPtr.Zero)
					mSort_jfieldId = JNIEnv.GetFieldID (class_ref, "mSort", "I");
				return JNIEnv.GetIntField (Handle, mSort_jfieldId);
			}
			set {
				if (mSort_jfieldId == IntPtr.Zero)
					mSort_jfieldId = JNIEnv.GetFieldID (class_ref, "mSort", "I");
				JNIEnv.SetField (Handle, mSort_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/android/camera/gallery/BaseImageList", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseImageList); }
		}

		protected BaseImageList (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_ContentResolver_Landroid_net_Uri_ILjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImageList']/constructor[@name='BaseImageList' and count(parameter)=4 and parameter[1][@type='android.content.ContentResolver'] and parameter[2][@type='android.net.Uri'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/ContentResolver;Landroid/net/Uri;ILjava/lang/String;)V", "")]
		public BaseImageList (global::Android.Content.ContentResolver p0, global::Android.Net.Uri p1, int p2, string p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p3 = JNIEnv.NewString (p3);;
			if (GetType () != typeof (BaseImageList)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/ContentResolver;Landroid/net/Uri;ILjava/lang/String;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (native_p3)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/ContentResolver;Landroid/net/Uri;ILjava/lang/String;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (native_p3));
				JNIEnv.DeleteLocalRef (native_p3);
				return;
			}

			if (id_ctor_Landroid_content_ContentResolver_Landroid_net_Uri_ILjava_lang_String_ == IntPtr.Zero)
				id_ctor_Landroid_content_ContentResolver_Landroid_net_Uri_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/ContentResolver;Landroid/net/Uri;ILjava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_ContentResolver_Landroid_net_Uri_ILjava_lang_String_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (native_p3)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_ContentResolver_Landroid_net_Uri_ILjava_lang_String_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (native_p3));
			JNIEnv.DeleteLocalRef (native_p3);
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
			global::Com.Android.Camera.Gallery.BaseImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.BaseImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count;
		}
#pragma warning restore 0169

		static IntPtr id_getCount;
		public virtual int Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImageList']/method[@name='getCount' and count(parameter)=0]"
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
			global::Com.Android.Camera.Gallery.BaseImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.BaseImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEmpty;
		}
#pragma warning restore 0169

		static IntPtr id_isEmpty;
		public virtual bool IsEmpty {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImageList']/method[@name='isEmpty' and count(parameter)=0]"
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
			global::Com.Android.Camera.Gallery.BaseImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.BaseImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImageList']/method[@name='close' and count(parameter)=0]"
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

		static Delegate cb_contentUri_J;
#pragma warning disable 0169
		static Delegate GetContentUri_JHandler ()
		{
			if (cb_contentUri_J == null)
				cb_contentUri_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_ContentUri_J);
			return cb_contentUri_J;
		}

		static IntPtr n_ContentUri_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Android.Camera.Gallery.BaseImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.BaseImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ContentUri (p0));
		}
#pragma warning restore 0169

		static IntPtr id_contentUri_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImageList']/method[@name='contentUri' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("contentUri", "(J)Landroid/net/Uri;", "GetContentUri_JHandler")]
		public virtual global::Android.Net.Uri ContentUri (long p0)
		{
			if (id_contentUri_J == IntPtr.Zero)
				id_contentUri_J = JNIEnv.GetMethodID (class_ref, "contentUri", "(J)Landroid/net/Uri;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod  (Handle, id_contentUri_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "contentUri", "(J)Landroid/net/Uri;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_createCursor;
#pragma warning disable 0169
		static Delegate GetCreateCursorHandler ()
		{
			if (cb_createCursor == null)
				cb_createCursor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CreateCursor);
			return cb_createCursor;
		}

		static IntPtr n_CreateCursor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Android.Camera.Gallery.BaseImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.BaseImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateCursor ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImageList']/method[@name='createCursor' and count(parameter)=0]"
		[Register ("createCursor", "()Landroid/database/Cursor;", "GetCreateCursorHandler")]
		protected abstract global::Android.Database.ICursor CreateCursor ();

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
			global::Com.Android.Camera.Gallery.BaseImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.BaseImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetImageAt (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getImageAt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImageList']/method[@name='getImageAt' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Com.Android.Camera.Gallery.BaseImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.BaseImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetImageForUri (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getImageForUri_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImageList']/method[@name='getImageForUri' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
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

		static Delegate cb_getImageId_Landroid_database_Cursor_;
#pragma warning disable 0169
		static Delegate GetGetImageId_Landroid_database_Cursor_Handler ()
		{
			if (cb_getImageId_Landroid_database_Cursor_ == null)
				cb_getImageId_Landroid_database_Cursor_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_GetImageId_Landroid_database_Cursor_);
			return cb_getImageId_Landroid_database_Cursor_;
		}

		static long n_GetImageId_Landroid_database_Cursor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Android.Camera.Gallery.BaseImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.BaseImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.ICursor p0 = (global::Android.Database.ICursor)global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetImageId (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImageList']/method[@name='getImageId' and count(parameter)=1 and parameter[1][@type='android.database.Cursor']]"
		[Register ("getImageId", "(Landroid/database/Cursor;)J", "GetGetImageId_Landroid_database_Cursor_Handler")]
		protected abstract long GetImageId (global::Android.Database.ICursor p0);

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
			global::Com.Android.Camera.Gallery.BaseImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.BaseImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Android.Camera.Gallery.IImage p0 = (global::Com.Android.Camera.Gallery.IImage)global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImage> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetImageIndex (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getImageIndex_Lcom_android_camera_gallery_IImage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImageList']/method[@name='getImageIndex' and count(parameter)=1 and parameter[1][@type='com.android.camera.gallery.IImage']]"
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

		static Delegate cb_invalidateCache;
#pragma warning disable 0169
		static Delegate GetInvalidateCacheHandler ()
		{
			if (cb_invalidateCache == null)
				cb_invalidateCache = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InvalidateCache);
			return cb_invalidateCache;
		}

		static void n_InvalidateCache (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Android.Camera.Gallery.BaseImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.BaseImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InvalidateCache ();
		}
#pragma warning restore 0169

		static IntPtr id_invalidateCache;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImageList']/method[@name='invalidateCache' and count(parameter)=0]"
		[Register ("invalidateCache", "()V", "GetInvalidateCacheHandler")]
		protected virtual void InvalidateCache ()
		{
			if (id_invalidateCache == IntPtr.Zero)
				id_invalidateCache = JNIEnv.GetMethodID (class_ref, "invalidateCache", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_invalidateCache);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "invalidateCache", "()V"));
		}

		static Delegate cb_invalidateCursor;
#pragma warning disable 0169
		static Delegate GetInvalidateCursorHandler ()
		{
			if (cb_invalidateCursor == null)
				cb_invalidateCursor = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InvalidateCursor);
			return cb_invalidateCursor;
		}

		static void n_InvalidateCursor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Android.Camera.Gallery.BaseImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.BaseImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InvalidateCursor ();
		}
#pragma warning restore 0169

		static IntPtr id_invalidateCursor;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImageList']/method[@name='invalidateCursor' and count(parameter)=0]"
		[Register ("invalidateCursor", "()V", "GetInvalidateCursorHandler")]
		protected virtual void InvalidateCursor ()
		{
			if (id_invalidateCursor == IntPtr.Zero)
				id_invalidateCursor = JNIEnv.GetMethodID (class_ref, "invalidateCursor", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_invalidateCursor);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "invalidateCursor", "()V"));
		}

		static Delegate cb_loadImageFromCursor_Landroid_database_Cursor_;
#pragma warning disable 0169
		static Delegate GetLoadImageFromCursor_Landroid_database_Cursor_Handler ()
		{
			if (cb_loadImageFromCursor_Landroid_database_Cursor_ == null)
				cb_loadImageFromCursor_Landroid_database_Cursor_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadImageFromCursor_Landroid_database_Cursor_);
			return cb_loadImageFromCursor_Landroid_database_Cursor_;
		}

		static IntPtr n_LoadImageFromCursor_Landroid_database_Cursor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Android.Camera.Gallery.BaseImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.BaseImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.ICursor p0 = (global::Android.Database.ICursor)global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LoadImageFromCursor (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImageList']/method[@name='loadImageFromCursor' and count(parameter)=1 and parameter[1][@type='android.database.Cursor']]"
		[Register ("loadImageFromCursor", "(Landroid/database/Cursor;)Lcom/android/camera/gallery/BaseImage;", "GetLoadImageFromCursor_Landroid_database_Cursor_Handler")]
		protected abstract global::Com.Android.Camera.Gallery.BaseImage LoadImageFromCursor (global::Android.Database.ICursor p0);

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
			global::Com.Android.Camera.Gallery.BaseImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.BaseImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Android.Camera.Gallery.IImage p0 = (global::Com.Android.Camera.Gallery.IImage)global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImage> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveImage (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_removeImage_Lcom_android_camera_gallery_IImage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImageList']/method[@name='removeImage' and count(parameter)=1 and parameter[1][@type='com.android.camera.gallery.IImage']]"
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
			global::Com.Android.Camera.Gallery.BaseImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.BaseImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RemoveImageAt (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeImageAt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImageList']/method[@name='removeImageAt' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_sortOrder;
#pragma warning disable 0169
		static Delegate GetSortOrderHandler ()
		{
			if (cb_sortOrder == null)
				cb_sortOrder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SortOrder);
			return cb_sortOrder;
		}

		static IntPtr n_SortOrder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Android.Camera.Gallery.BaseImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.BaseImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SortOrder ());
		}
#pragma warning restore 0169

		static IntPtr id_sortOrder;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImageList']/method[@name='sortOrder' and count(parameter)=0]"
		[Register ("sortOrder", "()Ljava/lang/String;", "GetSortOrderHandler")]
		protected virtual string SortOrder ()
		{
			if (id_sortOrder == IntPtr.Zero)
				id_sortOrder = JNIEnv.GetMethodID (class_ref, "sortOrder", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_sortOrder), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sortOrder", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Android.Camera.Gallery.BaseImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.BaseImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.BucketIds);
		}
#pragma warning restore 0169

		public abstract global::System.Collections.Generic.IDictionary<string, string> BucketIds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImageList']/method[@name='getBucketIds' and count(parameter)=0]"
			[Register ("getBucketIds", "()Ljava/util/HashMap;", "GetGetBucketIdsHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("com/android/camera/gallery/BaseImageList", DoNotGenerateAcw=true)]
	internal partial class BaseImageListInvoker : BaseImageList {

		public BaseImageListInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseImageListInvoker); }
		}

		static IntPtr id_createCursor;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImageList']/method[@name='createCursor' and count(parameter)=0]"
		[Register ("createCursor", "()Landroid/database/Cursor;", "GetCreateCursorHandler")]
		protected override global::Android.Database.ICursor CreateCursor ()
		{
			if (id_createCursor == IntPtr.Zero)
				id_createCursor = JNIEnv.GetMethodID (class_ref, "createCursor", "()Landroid/database/Cursor;");
			return global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (JNIEnv.CallObjectMethod  (Handle, id_createCursor), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_getImageId_Landroid_database_Cursor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImageList']/method[@name='getImageId' and count(parameter)=1 and parameter[1][@type='android.database.Cursor']]"
		[Register ("getImageId", "(Landroid/database/Cursor;)J", "GetGetImageId_Landroid_database_Cursor_Handler")]
		protected override long GetImageId (global::Android.Database.ICursor p0)
		{
			if (id_getImageId_Landroid_database_Cursor_ == IntPtr.Zero)
				id_getImageId_Landroid_database_Cursor_ = JNIEnv.GetMethodID (class_ref, "getImageId", "(Landroid/database/Cursor;)J");
			long __ret = JNIEnv.CallLongMethod  (Handle, id_getImageId_Landroid_database_Cursor_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_loadImageFromCursor_Landroid_database_Cursor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImageList']/method[@name='loadImageFromCursor' and count(parameter)=1 and parameter[1][@type='android.database.Cursor']]"
		[Register ("loadImageFromCursor", "(Landroid/database/Cursor;)Lcom/android/camera/gallery/BaseImage;", "GetLoadImageFromCursor_Landroid_database_Cursor_Handler")]
		protected override global::Com.Android.Camera.Gallery.BaseImage LoadImageFromCursor (global::Android.Database.ICursor p0)
		{
			if (id_loadImageFromCursor_Landroid_database_Cursor_ == IntPtr.Zero)
				id_loadImageFromCursor_Landroid_database_Cursor_ = JNIEnv.GetMethodID (class_ref, "loadImageFromCursor", "(Landroid/database/Cursor;)Lcom/android/camera/gallery/BaseImage;");
			global::Com.Android.Camera.Gallery.BaseImage __ret = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.BaseImage> (JNIEnv.CallObjectMethod  (Handle, id_loadImageFromCursor_Landroid_database_Cursor_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getBucketIds;
		public override global::System.Collections.Generic.IDictionary<string, string> BucketIds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImageList']/method[@name='getBucketIds' and count(parameter)=0]"
			[Register ("getBucketIds", "()Ljava/util/HashMap;", "GetGetBucketIdsHandler")]
			get {
				if (id_getBucketIds == IntPtr.Zero)
					id_getBucketIds = JNIEnv.GetMethodID (class_ref, "getBucketIds", "()Ljava/util/HashMap;");
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getBucketIds), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
