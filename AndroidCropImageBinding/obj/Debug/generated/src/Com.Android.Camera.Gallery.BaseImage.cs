using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Android.Camera.Gallery {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImage']"
	[global::Android.Runtime.Register ("com/android/camera/gallery/BaseImage", DoNotGenerateAcw=true)]
	public abstract partial class BaseImage : global::Java.Lang.Object, global::Com.Android.Camera.Gallery.IImage {


		static IntPtr mContainer_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImage']/field[@name='mContainer']"
		[Register ("mContainer")]
		protected global::Com.Android.Camera.Gallery.BaseImageList MContainer {
			get {
				if (mContainer_jfieldId == IntPtr.Zero)
					mContainer_jfieldId = JNIEnv.GetFieldID (class_ref, "mContainer", "Lcom/android/camera/gallery/BaseImageList;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mContainer_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.BaseImageList> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mContainer_jfieldId == IntPtr.Zero)
					mContainer_jfieldId = JNIEnv.GetFieldID (class_ref, "mContainer", "Lcom/android/camera/gallery/BaseImageList;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mContainer_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mContentResolver_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImage']/field[@name='mContentResolver']"
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

		static IntPtr mDataPath_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImage']/field[@name='mDataPath']"
		[Register ("mDataPath")]
		protected string MDataPath {
			get {
				if (mDataPath_jfieldId == IntPtr.Zero)
					mDataPath_jfieldId = JNIEnv.GetFieldID (class_ref, "mDataPath", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mDataPath_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mDataPath_jfieldId == IntPtr.Zero)
					mDataPath_jfieldId = JNIEnv.GetFieldID (class_ref, "mDataPath", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, mDataPath_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImage']/field[@name='mId']"
		[Register ("mId")]
		protected long MId {
			get {
				if (mId_jfieldId == IntPtr.Zero)
					mId_jfieldId = JNIEnv.GetFieldID (class_ref, "mId", "J");
				return JNIEnv.GetLongField (Handle, mId_jfieldId);
			}
			set {
				if (mId_jfieldId == IntPtr.Zero)
					mId_jfieldId = JNIEnv.GetFieldID (class_ref, "mId", "J");
				JNIEnv.SetField (Handle, mId_jfieldId, value);
			}
		}

		static IntPtr mIndex_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImage']/field[@name='mIndex']"
		[Register ("mIndex")]
		protected int MIndex {
			get {
				if (mIndex_jfieldId == IntPtr.Zero)
					mIndex_jfieldId = JNIEnv.GetFieldID (class_ref, "mIndex", "I");
				return JNIEnv.GetIntField (Handle, mIndex_jfieldId);
			}
			set {
				if (mIndex_jfieldId == IntPtr.Zero)
					mIndex_jfieldId = JNIEnv.GetFieldID (class_ref, "mIndex", "I");
				JNIEnv.SetField (Handle, mIndex_jfieldId, value);
			}
		}

		static IntPtr mMimeType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImage']/field[@name='mMimeType']"
		[Register ("mMimeType")]
		protected string MMimeType {
			get {
				if (mMimeType_jfieldId == IntPtr.Zero)
					mMimeType_jfieldId = JNIEnv.GetFieldID (class_ref, "mMimeType", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mMimeType_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMimeType_jfieldId == IntPtr.Zero)
					mMimeType_jfieldId = JNIEnv.GetFieldID (class_ref, "mMimeType", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, mMimeType_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mUri_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImage']/field[@name='mUri']"
		[Register ("mUri")]
		protected global::Android.Net.Uri MUri {
			get {
				if (mUri_jfieldId == IntPtr.Zero)
					mUri_jfieldId = JNIEnv.GetFieldID (class_ref, "mUri", "Landroid/net/Uri;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mUri_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mUri_jfieldId == IntPtr.Zero)
					mUri_jfieldId = JNIEnv.GetFieldID (class_ref, "mUri", "Landroid/net/Uri;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mUri_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/android/camera/gallery/BaseImage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseImage); }
		}

		protected BaseImage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_android_camera_gallery_BaseImageList_Landroid_content_ContentResolver_JILandroid_net_Uri_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImage']/constructor[@name='BaseImage' and count(parameter)=9 and parameter[1][@type='com.android.camera.gallery.BaseImageList'] and parameter[2][@type='android.content.ContentResolver'] and parameter[3][@type='long'] and parameter[4][@type='int'] and parameter[5][@type='android.net.Uri'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='long'] and parameter[9][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/android/camera/gallery/BaseImageList;Landroid/content/ContentResolver;JILandroid/net/Uri;Ljava/lang/String;Ljava/lang/String;JLjava/lang/String;)V", "")]
		protected BaseImage (global::Com.Android.Camera.Gallery.BaseImageList p0, global::Android.Content.ContentResolver p1, long p2, int p3, global::Android.Net.Uri p4, string p5, string p6, long p7, string p8) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p5 = JNIEnv.NewString (p5);;
			IntPtr native_p6 = JNIEnv.NewString (p6);;
			IntPtr native_p8 = JNIEnv.NewString (p8);;
			if (GetType () != typeof (BaseImage)) {
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

		static Delegate cb_getContainer;
#pragma warning disable 0169
		static Delegate GetGetContainerHandler ()
		{
			if (cb_getContainer == null)
				cb_getContainer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContainer);
			return cb_getContainer;
		}

		static IntPtr n_GetContainer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Android.Camera.Gallery.BaseImage __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.BaseImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Container);
		}
#pragma warning restore 0169

		static IntPtr id_getContainer;
		public virtual global::Com.Android.Camera.Gallery.IImageList Container {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImage']/method[@name='getContainer' and count(parameter)=0]"
			[Register ("getContainer", "()Lcom/android/camera/gallery/IImageList;", "GetGetContainerHandler")]
			get {
				if (id_getContainer == IntPtr.Zero)
					id_getContainer = JNIEnv.GetMethodID (class_ref, "getContainer", "()Lcom/android/camera/gallery/IImageList;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImageList> (JNIEnv.CallObjectMethod  (Handle, id_getContainer), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImageList> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContainer", "()Lcom/android/camera/gallery/IImageList;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDataPath;
#pragma warning disable 0169
		static Delegate GetGetDataPathHandler ()
		{
			if (cb_getDataPath == null)
				cb_getDataPath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDataPath);
			return cb_getDataPath;
		}

		static IntPtr n_GetDataPath (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Android.Camera.Gallery.BaseImage __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.BaseImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DataPath);
		}
#pragma warning restore 0169

		static IntPtr id_getDataPath;
		public virtual string DataPath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImage']/method[@name='getDataPath' and count(parameter)=0]"
			[Register ("getDataPath", "()Ljava/lang/String;", "GetGetDataPathHandler")]
			get {
				if (id_getDataPath == IntPtr.Zero)
					id_getDataPath = JNIEnv.GetMethodID (class_ref, "getDataPath", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDataPath), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDataPath", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDateTaken;
#pragma warning disable 0169
		static Delegate GetGetDateTakenHandler ()
		{
			if (cb_getDateTaken == null)
				cb_getDateTaken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetDateTaken);
			return cb_getDateTaken;
		}

		static long n_GetDateTaken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Android.Camera.Gallery.BaseImage __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.BaseImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DateTaken;
		}
#pragma warning restore 0169

		static IntPtr id_getDateTaken;
		public virtual long DateTaken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImage']/method[@name='getDateTaken' and count(parameter)=0]"
			[Register ("getDateTaken", "()J", "GetGetDateTakenHandler")]
			get {
				if (id_getDateTaken == IntPtr.Zero)
					id_getDateTaken = JNIEnv.GetMethodID (class_ref, "getDateTaken", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getDateTaken);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDateTaken", "()J"));
			}
		}

		static Delegate cb_getDegreesRotated;
#pragma warning disable 0169
		static Delegate GetGetDegreesRotatedHandler ()
		{
			if (cb_getDegreesRotated == null)
				cb_getDegreesRotated = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDegreesRotated);
			return cb_getDegreesRotated;
		}

		static int n_GetDegreesRotated (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Android.Camera.Gallery.BaseImage __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.BaseImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DegreesRotated;
		}
#pragma warning restore 0169

		static IntPtr id_getDegreesRotated;
		public virtual int DegreesRotated {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImage']/method[@name='getDegreesRotated' and count(parameter)=0]"
			[Register ("getDegreesRotated", "()I", "GetGetDegreesRotatedHandler")]
			get {
				if (id_getDegreesRotated == IntPtr.Zero)
					id_getDegreesRotated = JNIEnv.GetMethodID (class_ref, "getDegreesRotated", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getDegreesRotated);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDegreesRotated", "()I"));
			}
		}

		static Delegate cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeight);
			return cb_getHeight;
		}

		static int n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Android.Camera.Gallery.BaseImage __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.BaseImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		static IntPtr id_getHeight;
		public virtual int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImage']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "GetGetHeightHandler")]
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getHeight);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeight", "()I"));
			}
		}

		static Delegate cb_getMimeType;
#pragma warning disable 0169
		static Delegate GetGetMimeTypeHandler ()
		{
			if (cb_getMimeType == null)
				cb_getMimeType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMimeType);
			return cb_getMimeType;
		}

		static IntPtr n_GetMimeType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Android.Camera.Gallery.BaseImage __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.BaseImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MimeType);
		}
#pragma warning restore 0169

		static IntPtr id_getMimeType;
		public virtual string MimeType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImage']/method[@name='getMimeType' and count(parameter)=0]"
			[Register ("getMimeType", "()Ljava/lang/String;", "GetGetMimeTypeHandler")]
			get {
				if (id_getMimeType == IntPtr.Zero)
					id_getMimeType = JNIEnv.GetMethodID (class_ref, "getMimeType", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMimeType), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMimeType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Android.Camera.Gallery.BaseImage __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.BaseImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		static IntPtr id_getTitle;
		public virtual string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImage']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTitle", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getWidth;
#pragma warning disable 0169
		static Delegate GetGetWidthHandler ()
		{
			if (cb_getWidth == null)
				cb_getWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWidth);
			return cb_getWidth;
		}

		static int n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Android.Camera.Gallery.BaseImage __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.BaseImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		static IntPtr id_getWidth;
		public virtual int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImage']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()I", "GetGetWidthHandler")]
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getWidth);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWidth", "()I"));
			}
		}

		static Delegate cb_fullSizeBitmap_II;
#pragma warning disable 0169
		static Delegate GetFullSizeBitmap_IIHandler ()
		{
			if (cb_fullSizeBitmap_II == null)
				cb_fullSizeBitmap_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_FullSizeBitmap_II);
			return cb_fullSizeBitmap_II;
		}

		static IntPtr n_FullSizeBitmap_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Android.Camera.Gallery.BaseImage __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.BaseImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FullSizeBitmap (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_fullSizeBitmap_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImage']/method[@name='fullSizeBitmap' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("fullSizeBitmap", "(II)Landroid/graphics/Bitmap;", "GetFullSizeBitmap_IIHandler")]
		public virtual global::Android.Graphics.Bitmap FullSizeBitmap (int p0, int p1)
		{
			if (id_fullSizeBitmap_II == IntPtr.Zero)
				id_fullSizeBitmap_II = JNIEnv.GetMethodID (class_ref, "fullSizeBitmap", "(II)Landroid/graphics/Bitmap;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_fullSizeBitmap_II, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fullSizeBitmap", "(II)Landroid/graphics/Bitmap;"), new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_fullSizeBitmap_IIZZ;
#pragma warning disable 0169
		static Delegate GetFullSizeBitmap_IIZZHandler ()
		{
			if (cb_fullSizeBitmap_IIZZ == null)
				cb_fullSizeBitmap_IIZZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, bool, bool, IntPtr>) n_FullSizeBitmap_IIZZ);
			return cb_fullSizeBitmap_IIZZ;
		}

		static IntPtr n_FullSizeBitmap_IIZZ (IntPtr jnienv, IntPtr native__this, int p0, int p1, bool p2, bool p3)
		{
			global::Com.Android.Camera.Gallery.BaseImage __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.BaseImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FullSizeBitmap (p0, p1, p2, p3));
		}
#pragma warning restore 0169

		static IntPtr id_fullSizeBitmap_IIZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImage']/method[@name='fullSizeBitmap' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean']]"
		[Register ("fullSizeBitmap", "(IIZZ)Landroid/graphics/Bitmap;", "GetFullSizeBitmap_IIZZHandler")]
		public virtual global::Android.Graphics.Bitmap FullSizeBitmap (int p0, int p1, bool p2, bool p3)
		{
			if (id_fullSizeBitmap_IIZZ == IntPtr.Zero)
				id_fullSizeBitmap_IIZZ = JNIEnv.GetMethodID (class_ref, "fullSizeBitmap", "(IIZZ)Landroid/graphics/Bitmap;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_fullSizeBitmap_IIZZ, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fullSizeBitmap", "(IIZZ)Landroid/graphics/Bitmap;"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_fullSizeImageData;
#pragma warning disable 0169
		static Delegate GetFullSizeImageDataHandler ()
		{
			if (cb_fullSizeImageData == null)
				cb_fullSizeImageData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_FullSizeImageData);
			return cb_fullSizeImageData;
		}

		static IntPtr n_FullSizeImageData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Android.Camera.Gallery.BaseImage __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.BaseImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.FullSizeImageData ());
		}
#pragma warning restore 0169

		static IntPtr id_fullSizeImageData;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImage']/method[@name='fullSizeImageData' and count(parameter)=0]"
		[Register ("fullSizeImageData", "()Ljava/io/InputStream;", "GetFullSizeImageDataHandler")]
		public virtual global::System.IO.Stream FullSizeImageData ()
		{
			if (id_fullSizeImageData == IntPtr.Zero)
				id_fullSizeImageData = JNIEnv.GetMethodID (class_ref, "fullSizeImageData", "()Ljava/io/InputStream;");

			if (GetType () == ThresholdType)
				return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_fullSizeImageData), JniHandleOwnership.TransferLocalRef);
			else
				return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fullSizeImageData", "()Ljava/io/InputStream;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_fullSizeImageUri;
#pragma warning disable 0169
		static Delegate GetFullSizeImageUriHandler ()
		{
			if (cb_fullSizeImageUri == null)
				cb_fullSizeImageUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_FullSizeImageUri);
			return cb_fullSizeImageUri;
		}

		static IntPtr n_FullSizeImageUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Android.Camera.Gallery.BaseImage __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.BaseImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FullSizeImageUri ());
		}
#pragma warning restore 0169

		static IntPtr id_fullSizeImageUri;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImage']/method[@name='fullSizeImageUri' and count(parameter)=0]"
		[Register ("fullSizeImageUri", "()Landroid/net/Uri;", "GetFullSizeImageUriHandler")]
		public virtual global::Android.Net.Uri FullSizeImageUri ()
		{
			if (id_fullSizeImageUri == IntPtr.Zero)
				id_fullSizeImageUri = JNIEnv.GetMethodID (class_ref, "fullSizeImageUri", "()Landroid/net/Uri;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod  (Handle, id_fullSizeImageUri), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fullSizeImageUri", "()Landroid/net/Uri;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_miniThumbBitmap;
#pragma warning disable 0169
		static Delegate GetMiniThumbBitmapHandler ()
		{
			if (cb_miniThumbBitmap == null)
				cb_miniThumbBitmap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_MiniThumbBitmap);
			return cb_miniThumbBitmap;
		}

		static IntPtr n_MiniThumbBitmap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Android.Camera.Gallery.BaseImage __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.BaseImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MiniThumbBitmap ());
		}
#pragma warning restore 0169

		static IntPtr id_miniThumbBitmap;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImage']/method[@name='miniThumbBitmap' and count(parameter)=0]"
		[Register ("miniThumbBitmap", "()Landroid/graphics/Bitmap;", "GetMiniThumbBitmapHandler")]
		public virtual global::Android.Graphics.Bitmap MiniThumbBitmap ()
		{
			if (id_miniThumbBitmap == IntPtr.Zero)
				id_miniThumbBitmap = JNIEnv.GetMethodID (class_ref, "miniThumbBitmap", "()Landroid/graphics/Bitmap;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_miniThumbBitmap), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "miniThumbBitmap", "()Landroid/graphics/Bitmap;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_onRemove;
#pragma warning disable 0169
		static Delegate GetOnRemoveHandler ()
		{
			if (cb_onRemove == null)
				cb_onRemove = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnRemove);
			return cb_onRemove;
		}

		static void n_OnRemove (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Android.Camera.Gallery.BaseImage __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.BaseImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRemove ();
		}
#pragma warning restore 0169

		static IntPtr id_onRemove;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImage']/method[@name='onRemove' and count(parameter)=0]"
		[Register ("onRemove", "()V", "GetOnRemoveHandler")]
		protected virtual void OnRemove ()
		{
			if (id_onRemove == IntPtr.Zero)
				id_onRemove = JNIEnv.GetMethodID (class_ref, "onRemove", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onRemove);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRemove", "()V"));
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
			global::Com.Android.Camera.Gallery.BaseImage __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.BaseImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RotateImageBy (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImage']/method[@name='rotateImageBy' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("rotateImageBy", "(I)Z", "GetRotateImageBy_IHandler")]
		public abstract bool RotateImageBy (int p0);

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
			global::Com.Android.Camera.Gallery.BaseImage __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.BaseImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ThumbBitmap (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImage']/method[@name='thumbBitmap' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("thumbBitmap", "(Z)Landroid/graphics/Bitmap;", "GetThumbBitmap_ZHandler")]
		public abstract global::Android.Graphics.Bitmap ThumbBitmap (bool p0);

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
			global::Com.Android.Camera.Gallery.BaseImage __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.BaseImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrm;
		}
#pragma warning restore 0169

		public abstract bool IsDrm {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImage']/method[@name='isDrm' and count(parameter)=0]"
			[Register ("isDrm", "()Z", "GetIsDrmHandler")] get;
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
			global::Com.Android.Camera.Gallery.BaseImage __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.BaseImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsReadonly;
		}
#pragma warning restore 0169

		public abstract bool IsReadonly {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImage']/method[@name='isReadonly' and count(parameter)=0]"
			[Register ("isReadonly", "()Z", "GetIsReadonlyHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("com/android/camera/gallery/BaseImage", DoNotGenerateAcw=true)]
	internal partial class BaseImageInvoker : BaseImage {

		public BaseImageInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseImageInvoker); }
		}

		static IntPtr id_isDrm;
		public override bool IsDrm {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImage']/method[@name='isDrm' and count(parameter)=0]"
			[Register ("isDrm", "()Z", "GetIsDrmHandler")]
			get {
				if (id_isDrm == IntPtr.Zero)
					id_isDrm = JNIEnv.GetMethodID (class_ref, "isDrm", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isDrm);
			}
		}

		static IntPtr id_isReadonly;
		public override bool IsReadonly {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImage']/method[@name='isReadonly' and count(parameter)=0]"
			[Register ("isReadonly", "()Z", "GetIsReadonlyHandler")]
			get {
				if (id_isReadonly == IntPtr.Zero)
					id_isReadonly = JNIEnv.GetMethodID (class_ref, "isReadonly", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isReadonly);
			}
		}

		static IntPtr id_rotateImageBy_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImage']/method[@name='rotateImageBy' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("rotateImageBy", "(I)Z", "GetRotateImageBy_IHandler")]
		public override bool RotateImageBy (int p0)
		{
			if (id_rotateImageBy_I == IntPtr.Zero)
				id_rotateImageBy_I = JNIEnv.GetMethodID (class_ref, "rotateImageBy", "(I)Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_rotateImageBy_I, new JValue (p0));
		}

		static IntPtr id_thumbBitmap_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='BaseImage']/method[@name='thumbBitmap' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("thumbBitmap", "(Z)Landroid/graphics/Bitmap;", "GetThumbBitmap_ZHandler")]
		public override global::Android.Graphics.Bitmap ThumbBitmap (bool p0)
		{
			if (id_thumbBitmap_Z == IntPtr.Zero)
				id_thumbBitmap_Z = JNIEnv.GetMethodID (class_ref, "thumbBitmap", "(Z)Landroid/graphics/Bitmap;");
			return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_thumbBitmap_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

	}

}
