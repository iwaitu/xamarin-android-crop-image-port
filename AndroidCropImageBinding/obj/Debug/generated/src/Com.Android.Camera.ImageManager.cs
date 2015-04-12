using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Android.Camera {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager']"
	[global::Android.Runtime.Register ("com/android/camera/ImageManager", DoNotGenerateAcw=true)]
	public partial class ImageManager : global::Java.Lang.Object {


		static IntPtr CAMERA_IMAGE_BUCKET_ID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager']/field[@name='CAMERA_IMAGE_BUCKET_ID']"
		[Register ("CAMERA_IMAGE_BUCKET_ID")]
		public static string CameraImageBucketId {
			get {
				if (CAMERA_IMAGE_BUCKET_ID_jfieldId == IntPtr.Zero)
					CAMERA_IMAGE_BUCKET_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CAMERA_IMAGE_BUCKET_ID", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CAMERA_IMAGE_BUCKET_ID_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CAMERA_IMAGE_BUCKET_ID_jfieldId == IntPtr.Zero)
					CAMERA_IMAGE_BUCKET_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CAMERA_IMAGE_BUCKET_ID", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetStaticField (class_ref, CAMERA_IMAGE_BUCKET_ID_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr CAMERA_IMAGE_BUCKET_NAME_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager']/field[@name='CAMERA_IMAGE_BUCKET_NAME']"
		[Register ("CAMERA_IMAGE_BUCKET_NAME")]
		public static string CameraImageBucketName {
			get {
				if (CAMERA_IMAGE_BUCKET_NAME_jfieldId == IntPtr.Zero)
					CAMERA_IMAGE_BUCKET_NAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CAMERA_IMAGE_BUCKET_NAME", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CAMERA_IMAGE_BUCKET_NAME_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CAMERA_IMAGE_BUCKET_NAME_jfieldId == IntPtr.Zero)
					CAMERA_IMAGE_BUCKET_NAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CAMERA_IMAGE_BUCKET_NAME", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetStaticField (class_ref, CAMERA_IMAGE_BUCKET_NAME_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager']/field[@name='INCLUDE_IMAGES']"
		[Register ("INCLUDE_IMAGES")]
		public const int IncludeImages = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager']/field[@name='INCLUDE_VIDEOS']"
		[Register ("INCLUDE_VIDEOS")]
		public const int IncludeVideos = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager']/field[@name='SORT_ASCENDING']"
		[Register ("SORT_ASCENDING")]
		public const int SortAscending = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager']/field[@name='SORT_DESCENDING']"
		[Register ("SORT_DESCENDING")]
		public const int SortDescending = (int) 2;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager.DataLocation']"
		[global::Android.Runtime.Register ("com/android/camera/ImageManager$DataLocation", DoNotGenerateAcw=true)]
		public sealed partial class DataLocation : global::Java.Lang.Enum {


			static IntPtr ALL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager.DataLocation']/field[@name='ALL']"
			[Register ("ALL")]
			public static global::Com.Android.Camera.ImageManager.DataLocation All {
				get {
					if (ALL_jfieldId == IntPtr.Zero)
						ALL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALL", "Lcom/android/camera/ImageManager$DataLocation;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ALL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Android.Camera.ImageManager.DataLocation> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ALL_jfieldId == IntPtr.Zero)
						ALL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALL", "Lcom/android/camera/ImageManager$DataLocation;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ALL_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr EXTERNAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager.DataLocation']/field[@name='EXTERNAL']"
			[Register ("EXTERNAL")]
			public static global::Com.Android.Camera.ImageManager.DataLocation External {
				get {
					if (EXTERNAL_jfieldId == IntPtr.Zero)
						EXTERNAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXTERNAL", "Lcom/android/camera/ImageManager$DataLocation;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXTERNAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Android.Camera.ImageManager.DataLocation> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (EXTERNAL_jfieldId == IntPtr.Zero)
						EXTERNAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXTERNAL", "Lcom/android/camera/ImageManager$DataLocation;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, EXTERNAL_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr INTERNAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager.DataLocation']/field[@name='INTERNAL']"
			[Register ("INTERNAL")]
			public static global::Com.Android.Camera.ImageManager.DataLocation Internal {
				get {
					if (INTERNAL_jfieldId == IntPtr.Zero)
						INTERNAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INTERNAL", "Lcom/android/camera/ImageManager$DataLocation;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INTERNAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Android.Camera.ImageManager.DataLocation> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (INTERNAL_jfieldId == IntPtr.Zero)
						INTERNAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INTERNAL", "Lcom/android/camera/ImageManager$DataLocation;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, INTERNAL_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr NONE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager.DataLocation']/field[@name='NONE']"
			[Register ("NONE")]
			public static global::Com.Android.Camera.ImageManager.DataLocation None {
				get {
					if (NONE_jfieldId == IntPtr.Zero)
						NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lcom/android/camera/ImageManager$DataLocation;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NONE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Android.Camera.ImageManager.DataLocation> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (NONE_jfieldId == IntPtr.Zero)
						NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lcom/android/camera/ImageManager$DataLocation;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, NONE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/android/camera/ImageManager$DataLocation", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DataLocation); }
			}

			internal DataLocation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager.DataLocation']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/android/camera/ImageManager$DataLocation;", "")]
			public static global::Com.Android.Camera.ImageManager.DataLocation ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/android/camera/ImageManager$DataLocation;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Android.Camera.ImageManager.DataLocation __ret = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.ImageManager.DataLocation> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager.DataLocation']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/android/camera/ImageManager$DataLocation;", "")]
			public static global::Com.Android.Camera.ImageManager.DataLocation[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/android/camera/ImageManager$DataLocation;");
				return (global::Com.Android.Camera.ImageManager.DataLocation[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Android.Camera.ImageManager.DataLocation));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager.EmptyImageList']"
		[global::Android.Runtime.Register ("com/android/camera/ImageManager$EmptyImageList", DoNotGenerateAcw=true)]
		public partial class EmptyImageList : global::Java.Lang.Object, global::Com.Android.Camera.Gallery.IImageList {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/android/camera/ImageManager$EmptyImageList", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (EmptyImageList); }
			}

			protected EmptyImageList (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
				global::Com.Android.Camera.ImageManager.EmptyImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.ImageManager.EmptyImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.BucketIds);
			}
#pragma warning restore 0169

			static IntPtr id_getBucketIds;
			public virtual global::System.Collections.Generic.IDictionary<string, string> BucketIds {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager.EmptyImageList']/method[@name='getBucketIds' and count(parameter)=0]"
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
				global::Com.Android.Camera.ImageManager.EmptyImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.ImageManager.EmptyImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Count;
			}
#pragma warning restore 0169

			static IntPtr id_getCount;
			public virtual int Count {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager.EmptyImageList']/method[@name='getCount' and count(parameter)=0]"
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
				global::Com.Android.Camera.ImageManager.EmptyImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.ImageManager.EmptyImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsEmpty;
			}
#pragma warning restore 0169

			static IntPtr id_isEmpty;
			public virtual bool IsEmpty {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager.EmptyImageList']/method[@name='isEmpty' and count(parameter)=0]"
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
				global::Com.Android.Camera.ImageManager.EmptyImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.ImageManager.EmptyImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Close ();
			}
#pragma warning restore 0169

			static IntPtr id_close;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager.EmptyImageList']/method[@name='close' and count(parameter)=0]"
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
				global::Com.Android.Camera.ImageManager.EmptyImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.ImageManager.EmptyImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.GetImageAt (p0));
			}
#pragma warning restore 0169

			static IntPtr id_getImageAt_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager.EmptyImageList']/method[@name='getImageAt' and count(parameter)=1 and parameter[1][@type='int']]"
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
				global::Com.Android.Camera.ImageManager.EmptyImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.ImageManager.EmptyImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetImageForUri (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_getImageForUri_Landroid_net_Uri_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager.EmptyImageList']/method[@name='getImageForUri' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
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
				global::Com.Android.Camera.ImageManager.EmptyImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.ImageManager.EmptyImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Android.Camera.Gallery.IImage p0 = (global::Com.Android.Camera.Gallery.IImage)global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImage> (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.GetImageIndex (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_getImageIndex_Lcom_android_camera_gallery_IImage_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager.EmptyImageList']/method[@name='getImageIndex' and count(parameter)=1 and parameter[1][@type='com.android.camera.gallery.IImage']]"
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
				global::Com.Android.Camera.ImageManager.EmptyImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.ImageManager.EmptyImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Android.Camera.Gallery.IImage p0 = (global::Com.Android.Camera.Gallery.IImage)global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImage> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.RemoveImage (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_removeImage_Lcom_android_camera_gallery_IImage_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager.EmptyImageList']/method[@name='removeImage' and count(parameter)=1 and parameter[1][@type='com.android.camera.gallery.IImage']]"
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
				global::Com.Android.Camera.ImageManager.EmptyImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.ImageManager.EmptyImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.RemoveImageAt (p0);
			}
#pragma warning restore 0169

			static IntPtr id_removeImageAt_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager.EmptyImageList']/method[@name='removeImageAt' and count(parameter)=1 and parameter[1][@type='int']]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager.ImageListParam']"
		[global::Android.Runtime.Register ("com/android/camera/ImageManager$ImageListParam", DoNotGenerateAcw=true)]
		public partial class ImageListParam : global::Java.Lang.Object, global::Android.OS.IParcelable {


			static IntPtr CREATOR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager.ImageListParam']/field[@name='CREATOR']"
			[Register ("CREATOR")]
			public static global::Android.OS.IParcelableCreator Creator {
				get {
					if (CREATOR_jfieldId == IntPtr.Zero)
						CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (CREATOR_jfieldId == IntPtr.Zero)
						CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, CREATOR_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr mBucketId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager.ImageListParam']/field[@name='mBucketId']"
			[Register ("mBucketId")]
			public string MBucketId {
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

			static IntPtr mInclusion_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager.ImageListParam']/field[@name='mInclusion']"
			[Register ("mInclusion")]
			public int MInclusion {
				get {
					if (mInclusion_jfieldId == IntPtr.Zero)
						mInclusion_jfieldId = JNIEnv.GetFieldID (class_ref, "mInclusion", "I");
					return JNIEnv.GetIntField (Handle, mInclusion_jfieldId);
				}
				set {
					if (mInclusion_jfieldId == IntPtr.Zero)
						mInclusion_jfieldId = JNIEnv.GetFieldID (class_ref, "mInclusion", "I");
					JNIEnv.SetField (Handle, mInclusion_jfieldId, value);
				}
			}

			static IntPtr mIsEmptyImageList_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager.ImageListParam']/field[@name='mIsEmptyImageList']"
			[Register ("mIsEmptyImageList")]
			public bool MIsEmptyImageList {
				get {
					if (mIsEmptyImageList_jfieldId == IntPtr.Zero)
						mIsEmptyImageList_jfieldId = JNIEnv.GetFieldID (class_ref, "mIsEmptyImageList", "Z");
					return JNIEnv.GetBooleanField (Handle, mIsEmptyImageList_jfieldId);
				}
				set {
					if (mIsEmptyImageList_jfieldId == IntPtr.Zero)
						mIsEmptyImageList_jfieldId = JNIEnv.GetFieldID (class_ref, "mIsEmptyImageList", "Z");
					JNIEnv.SetField (Handle, mIsEmptyImageList_jfieldId, value);
				}
			}

			static IntPtr mLocation_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager.ImageListParam']/field[@name='mLocation']"
			[Register ("mLocation")]
			public global::Com.Android.Camera.ImageManager.DataLocation MLocation {
				get {
					if (mLocation_jfieldId == IntPtr.Zero)
						mLocation_jfieldId = JNIEnv.GetFieldID (class_ref, "mLocation", "Lcom/android/camera/ImageManager$DataLocation;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, mLocation_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Android.Camera.ImageManager.DataLocation> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (mLocation_jfieldId == IntPtr.Zero)
						mLocation_jfieldId = JNIEnv.GetFieldID (class_ref, "mLocation", "Lcom/android/camera/ImageManager$DataLocation;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetField (Handle, mLocation_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr mSingleImageUri_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager.ImageListParam']/field[@name='mSingleImageUri']"
			[Register ("mSingleImageUri")]
			public global::Android.Net.Uri MSingleImageUri {
				get {
					if (mSingleImageUri_jfieldId == IntPtr.Zero)
						mSingleImageUri_jfieldId = JNIEnv.GetFieldID (class_ref, "mSingleImageUri", "Landroid/net/Uri;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, mSingleImageUri_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (mSingleImageUri_jfieldId == IntPtr.Zero)
						mSingleImageUri_jfieldId = JNIEnv.GetFieldID (class_ref, "mSingleImageUri", "Landroid/net/Uri;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetField (Handle, mSingleImageUri_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr mSort_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager.ImageListParam']/field[@name='mSort']"
			[Register ("mSort")]
			public int MSort {
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
					return JNIEnv.FindClass ("com/android/camera/ImageManager$ImageListParam", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ImageListParam); }
			}

			protected ImageListParam (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager.ImageListParam']/constructor[@name='ImageManager.ImageListParam' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public ImageListParam () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (ImageListParam)) {
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

			static Delegate cb_describeContents;
#pragma warning disable 0169
			static Delegate GetDescribeContentsHandler ()
			{
				if (cb_describeContents == null)
					cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
				return cb_describeContents;
			}

			static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Android.Camera.ImageManager.ImageListParam __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.ImageManager.ImageListParam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.DescribeContents ();
			}
#pragma warning restore 0169

			static IntPtr id_describeContents;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager.ImageListParam']/method[@name='describeContents' and count(parameter)=0]"
			[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
			public virtual int DescribeContents ()
			{
				if (id_describeContents == IntPtr.Zero)
					id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_describeContents);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "describeContents", "()I"));
			}

			static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
			static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
			{
				if (cb_writeToParcel_Landroid_os_Parcel_I == null)
					cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
				return cb_writeToParcel_Landroid_os_Parcel_I;
			}

			static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
			{
				global::Com.Android.Camera.ImageManager.ImageListParam __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.ImageManager.ImageListParam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
				__this.WriteToParcel (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager.ImageListParam']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
			[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
			public virtual void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
			{
				if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
					id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_writeToParcel_Landroid_os_Parcel_I, new JValue (p0), new JValue ((int) p1));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToParcel", "(Landroid/os/Parcel;I)V"), new JValue (p0), new JValue ((int) p1));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/android/camera/ImageManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageManager); }
		}

		protected ImageManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager']/constructor[@name='ImageManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ImageManager () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ImageManager)) {
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

		static IntPtr id_getEmptyImageListParam;
		public static global::Com.Android.Camera.ImageManager.ImageListParam EmptyImageListParam {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager']/method[@name='getEmptyImageListParam' and count(parameter)=0]"
			[Register ("getEmptyImageListParam", "()Lcom/android/camera/ImageManager$ImageListParam;", "GetGetEmptyImageListParamHandler")]
			get {
				if (id_getEmptyImageListParam == IntPtr.Zero)
					id_getEmptyImageListParam = JNIEnv.GetStaticMethodID (class_ref, "getEmptyImageListParam", "()Lcom/android/camera/ImageManager$ImageListParam;");
				return global::Java.Lang.Object.GetObject<global::Com.Android.Camera.ImageManager.ImageListParam> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getEmptyImageListParam), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_hasStorage;
		public static bool HasStorage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager']/method[@name='hasStorage' and count(parameter)=0]"
			[Register ("hasStorage", "()Z", "GetHasStorageHandler")]
			get {
				if (id_hasStorage == IntPtr.Zero)
					id_hasStorage = JNIEnv.GetStaticMethodID (class_ref, "hasStorage", "()Z");
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_hasStorage);
			}
		}

		static IntPtr id_addImage_Landroid_content_ContentResolver_Ljava_lang_String_JLandroid_location_Location_Ljava_lang_String_Ljava_lang_String_Landroid_graphics_Bitmap_arrayBarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager']/method[@name='addImage' and count(parameter)=9 and parameter[1][@type='android.content.ContentResolver'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='android.location.Location'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='android.graphics.Bitmap'] and parameter[8][@type='byte[]'] and parameter[9][@type='int[]']]"
		[Register ("addImage", "(Landroid/content/ContentResolver;Ljava/lang/String;JLandroid/location/Location;Ljava/lang/String;Ljava/lang/String;Landroid/graphics/Bitmap;[B[I)Landroid/net/Uri;", "")]
		public static global::Android.Net.Uri AddImage (global::Android.Content.ContentResolver p0, string p1, long p2, global::Android.Locations.Location p3, string p4, string p5, global::Android.Graphics.Bitmap p6, byte[] p7, int[] p8)
		{
			if (id_addImage_Landroid_content_ContentResolver_Ljava_lang_String_JLandroid_location_Location_Ljava_lang_String_Ljava_lang_String_Landroid_graphics_Bitmap_arrayBarrayI == IntPtr.Zero)
				id_addImage_Landroid_content_ContentResolver_Ljava_lang_String_JLandroid_location_Location_Ljava_lang_String_Ljava_lang_String_Landroid_graphics_Bitmap_arrayBarrayI = JNIEnv.GetStaticMethodID (class_ref, "addImage", "(Landroid/content/ContentResolver;Ljava/lang/String;JLandroid/location/Location;Ljava/lang/String;Ljava/lang/String;Landroid/graphics/Bitmap;[B[I)Landroid/net/Uri;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p7 = JNIEnv.NewArray (p7);
			IntPtr native_p8 = JNIEnv.NewArray (p8);
			global::Android.Net.Uri __ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallStaticObjectMethod  (class_ref, id_addImage_Landroid_content_ContentResolver_Ljava_lang_String_JLandroid_location_Location_Ljava_lang_String_Ljava_lang_String_Landroid_graphics_Bitmap_arrayBarrayI, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3), new JValue (native_p4), new JValue (native_p5), new JValue (p6), new JValue (native_p7), new JValue (native_p8)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p4);
			JNIEnv.DeleteLocalRef (native_p5);
			if (p7 != null) {
				JNIEnv.CopyArray (native_p7, p7);
				JNIEnv.DeleteLocalRef (native_p7);
			}
			if (p8 != null) {
				JNIEnv.CopyArray (native_p8, p8);
				JNIEnv.DeleteLocalRef (native_p8);
			}
			return __ret;
		}

		static IntPtr id_ensureOSXCompatibleFolder;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager']/method[@name='ensureOSXCompatibleFolder' and count(parameter)=0]"
		[Register ("ensureOSXCompatibleFolder", "()V", "")]
		public static void EnsureOSXCompatibleFolder ()
		{
			if (id_ensureOSXCompatibleFolder == IntPtr.Zero)
				id_ensureOSXCompatibleFolder = JNIEnv.GetStaticMethodID (class_ref, "ensureOSXCompatibleFolder", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_ensureOSXCompatibleFolder);
		}

		static IntPtr id_getBucketId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager']/method[@name='getBucketId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBucketId", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string GetBucketId (string p0)
		{
			if (id_getBucketId_Ljava_lang_String_ == IntPtr.Zero)
				id_getBucketId_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getBucketId", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBucketId_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getExifOrientation_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager']/method[@name='getExifOrientation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getExifOrientation", "(Ljava/lang/String;)I", "")]
		public static int GetExifOrientation (string p0)
		{
			if (id_getExifOrientation_Ljava_lang_String_ == IntPtr.Zero)
				id_getExifOrientation_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getExifOrientation", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getExifOrientation_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getImageListParam_Lcom_android_camera_ImageManager_DataLocation_IILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager']/method[@name='getImageListParam' and count(parameter)=4 and parameter[1][@type='com.android.camera.ImageManager.DataLocation'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("getImageListParam", "(Lcom/android/camera/ImageManager$DataLocation;IILjava/lang/String;)Lcom/android/camera/ImageManager$ImageListParam;", "")]
		public static global::Com.Android.Camera.ImageManager.ImageListParam GetImageListParam (global::Com.Android.Camera.ImageManager.DataLocation p0, int p1, int p2, string p3)
		{
			if (id_getImageListParam_Lcom_android_camera_ImageManager_DataLocation_IILjava_lang_String_ == IntPtr.Zero)
				id_getImageListParam_Lcom_android_camera_ImageManager_DataLocation_IILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getImageListParam", "(Lcom/android/camera/ImageManager$DataLocation;IILjava/lang/String;)Lcom/android/camera/ImageManager$ImageListParam;");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			global::Com.Android.Camera.ImageManager.ImageListParam __ret = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.ImageManager.ImageListParam> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getImageListParam_Lcom_android_camera_ImageManager_DataLocation_IILjava_lang_String_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (native_p3)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p3);
			return __ret;
		}

		static IntPtr id_getSingleImageListParam_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager']/method[@name='getSingleImageListParam' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("getSingleImageListParam", "(Landroid/net/Uri;)Lcom/android/camera/ImageManager$ImageListParam;", "")]
		public static global::Com.Android.Camera.ImageManager.ImageListParam GetSingleImageListParam (global::Android.Net.Uri p0)
		{
			if (id_getSingleImageListParam_Landroid_net_Uri_ == IntPtr.Zero)
				id_getSingleImageListParam_Landroid_net_Uri_ = JNIEnv.GetStaticMethodID (class_ref, "getSingleImageListParam", "(Landroid/net/Uri;)Lcom/android/camera/ImageManager$ImageListParam;");
			global::Com.Android.Camera.ImageManager.ImageListParam __ret = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.ImageManager.ImageListParam> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSingleImageListParam_Landroid_net_Uri_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_hasStorage_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager']/method[@name='hasStorage' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("hasStorage", "(Z)Z", "")]
		public static bool InvokeHasStorage (bool p0)
		{
			if (id_hasStorage_Z == IntPtr.Zero)
				id_hasStorage_Z = JNIEnv.GetStaticMethodID (class_ref, "hasStorage", "(Z)Z");
			return JNIEnv.CallStaticBooleanMethod  (class_ref, id_hasStorage_Z, new JValue (p0));
		}

		static IntPtr id_isImage_Lcom_android_camera_gallery_IImage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager']/method[@name='isImage' and count(parameter)=1 and parameter[1][@type='com.android.camera.gallery.IImage']]"
		[Register ("isImage", "(Lcom/android/camera/gallery/IImage;)Z", "")]
		public static bool IsImage (global::Com.Android.Camera.Gallery.IImage p0)
		{
			if (id_isImage_Lcom_android_camera_gallery_IImage_ == IntPtr.Zero)
				id_isImage_Lcom_android_camera_gallery_IImage_ = JNIEnv.GetStaticMethodID (class_ref, "isImage", "(Lcom/android/camera/gallery/IImage;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isImage_Lcom_android_camera_gallery_IImage_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_isImageMimeType_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager']/method[@name='isImageMimeType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isImageMimeType", "(Ljava/lang/String;)Z", "")]
		public static bool IsImageMimeType (string p0)
		{
			if (id_isImageMimeType_Ljava_lang_String_ == IntPtr.Zero)
				id_isImageMimeType_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isImageMimeType", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isImageMimeType_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_isMediaScannerScanning_Landroid_content_ContentResolver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager']/method[@name='isMediaScannerScanning' and count(parameter)=1 and parameter[1][@type='android.content.ContentResolver']]"
		[Register ("isMediaScannerScanning", "(Landroid/content/ContentResolver;)Z", "")]
		public static bool IsMediaScannerScanning (global::Android.Content.ContentResolver p0)
		{
			if (id_isMediaScannerScanning_Landroid_content_ContentResolver_ == IntPtr.Zero)
				id_isMediaScannerScanning_Landroid_content_ContentResolver_ = JNIEnv.GetStaticMethodID (class_ref, "isMediaScannerScanning", "(Landroid/content/ContentResolver;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isMediaScannerScanning_Landroid_content_ContentResolver_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_isVideo_Lcom_android_camera_gallery_IImage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager']/method[@name='isVideo' and count(parameter)=1 and parameter[1][@type='com.android.camera.gallery.IImage']]"
		[Register ("isVideo", "(Lcom/android/camera/gallery/IImage;)Z", "")]
		public static bool IsVideo (global::Com.Android.Camera.Gallery.IImage p0)
		{
			if (id_isVideo_Lcom_android_camera_gallery_IImage_ == IntPtr.Zero)
				id_isVideo_Lcom_android_camera_gallery_IImage_ = JNIEnv.GetStaticMethodID (class_ref, "isVideo", "(Lcom/android/camera/gallery/IImage;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isVideo_Lcom_android_camera_gallery_IImage_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_makeEmptyImageList;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager']/method[@name='makeEmptyImageList' and count(parameter)=0]"
		[Register ("makeEmptyImageList", "()Lcom/android/camera/gallery/IImageList;", "")]
		public static global::Com.Android.Camera.Gallery.IImageList MakeEmptyImageList ()
		{
			if (id_makeEmptyImageList == IntPtr.Zero)
				id_makeEmptyImageList = JNIEnv.GetStaticMethodID (class_ref, "makeEmptyImageList", "()Lcom/android/camera/gallery/IImageList;");
			return global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImageList> (JNIEnv.CallStaticObjectMethod  (class_ref, id_makeEmptyImageList), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_makeImageList_Landroid_content_ContentResolver_Landroid_net_Uri_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager']/method[@name='makeImageList' and count(parameter)=3 and parameter[1][@type='android.content.ContentResolver'] and parameter[2][@type='android.net.Uri'] and parameter[3][@type='int']]"
		[Register ("makeImageList", "(Landroid/content/ContentResolver;Landroid/net/Uri;I)Lcom/android/camera/gallery/IImageList;", "")]
		public static global::Com.Android.Camera.Gallery.IImageList MakeImageList (global::Android.Content.ContentResolver p0, global::Android.Net.Uri p1, int p2)
		{
			if (id_makeImageList_Landroid_content_ContentResolver_Landroid_net_Uri_I == IntPtr.Zero)
				id_makeImageList_Landroid_content_ContentResolver_Landroid_net_Uri_I = JNIEnv.GetStaticMethodID (class_ref, "makeImageList", "(Landroid/content/ContentResolver;Landroid/net/Uri;I)Lcom/android/camera/gallery/IImageList;");
			global::Com.Android.Camera.Gallery.IImageList __ret = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImageList> (JNIEnv.CallStaticObjectMethod  (class_ref, id_makeImageList_Landroid_content_ContentResolver_Landroid_net_Uri_I, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_makeImageList_Landroid_content_ContentResolver_Lcom_android_camera_ImageManager_DataLocation_IILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager']/method[@name='makeImageList' and count(parameter)=5 and parameter[1][@type='android.content.ContentResolver'] and parameter[2][@type='com.android.camera.ImageManager.DataLocation'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.String']]"
		[Register ("makeImageList", "(Landroid/content/ContentResolver;Lcom/android/camera/ImageManager$DataLocation;IILjava/lang/String;)Lcom/android/camera/gallery/IImageList;", "")]
		public static global::Com.Android.Camera.Gallery.IImageList MakeImageList (global::Android.Content.ContentResolver p0, global::Com.Android.Camera.ImageManager.DataLocation p1, int p2, int p3, string p4)
		{
			if (id_makeImageList_Landroid_content_ContentResolver_Lcom_android_camera_ImageManager_DataLocation_IILjava_lang_String_ == IntPtr.Zero)
				id_makeImageList_Landroid_content_ContentResolver_Lcom_android_camera_ImageManager_DataLocation_IILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "makeImageList", "(Landroid/content/ContentResolver;Lcom/android/camera/ImageManager$DataLocation;IILjava/lang/String;)Lcom/android/camera/gallery/IImageList;");
			IntPtr native_p4 = JNIEnv.NewString (p4);
			global::Com.Android.Camera.Gallery.IImageList __ret = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImageList> (JNIEnv.CallStaticObjectMethod  (class_ref, id_makeImageList_Landroid_content_ContentResolver_Lcom_android_camera_ImageManager_DataLocation_IILjava_lang_String_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (native_p4)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p4);
			return __ret;
		}

		static IntPtr id_makeImageList_Landroid_content_ContentResolver_Lcom_android_camera_ImageManager_ImageListParam_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager']/method[@name='makeImageList' and count(parameter)=2 and parameter[1][@type='android.content.ContentResolver'] and parameter[2][@type='com.android.camera.ImageManager.ImageListParam']]"
		[Register ("makeImageList", "(Landroid/content/ContentResolver;Lcom/android/camera/ImageManager$ImageListParam;)Lcom/android/camera/gallery/IImageList;", "")]
		public static global::Com.Android.Camera.Gallery.IImageList MakeImageList (global::Android.Content.ContentResolver p0, global::Com.Android.Camera.ImageManager.ImageListParam p1)
		{
			if (id_makeImageList_Landroid_content_ContentResolver_Lcom_android_camera_ImageManager_ImageListParam_ == IntPtr.Zero)
				id_makeImageList_Landroid_content_ContentResolver_Lcom_android_camera_ImageManager_ImageListParam_ = JNIEnv.GetStaticMethodID (class_ref, "makeImageList", "(Landroid/content/ContentResolver;Lcom/android/camera/ImageManager$ImageListParam;)Lcom/android/camera/gallery/IImageList;");
			global::Com.Android.Camera.Gallery.IImageList __ret = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImageList> (JNIEnv.CallStaticObjectMethod  (class_ref, id_makeImageList_Landroid_content_ContentResolver_Lcom_android_camera_ImageManager_ImageListParam_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_makeSingleImageList_Landroid_content_ContentResolver_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageManager']/method[@name='makeSingleImageList' and count(parameter)=2 and parameter[1][@type='android.content.ContentResolver'] and parameter[2][@type='android.net.Uri']]"
		[Register ("makeSingleImageList", "(Landroid/content/ContentResolver;Landroid/net/Uri;)Lcom/android/camera/gallery/IImageList;", "")]
		public static global::Com.Android.Camera.Gallery.IImageList MakeSingleImageList (global::Android.Content.ContentResolver p0, global::Android.Net.Uri p1)
		{
			if (id_makeSingleImageList_Landroid_content_ContentResolver_Landroid_net_Uri_ == IntPtr.Zero)
				id_makeSingleImageList_Landroid_content_ContentResolver_Landroid_net_Uri_ = JNIEnv.GetStaticMethodID (class_ref, "makeSingleImageList", "(Landroid/content/ContentResolver;Landroid/net/Uri;)Lcom/android/camera/gallery/IImageList;");
			global::Com.Android.Camera.Gallery.IImageList __ret = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImageList> (JNIEnv.CallStaticObjectMethod  (class_ref, id_makeSingleImageList_Landroid_content_ContentResolver_Landroid_net_Uri_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
