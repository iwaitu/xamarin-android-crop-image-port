using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Android.Camera.Gallery {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='ImageList']"
	[global::Android.Runtime.Register ("com/android/camera/gallery/ImageList", DoNotGenerateAcw=true)]
	public partial class ImageList : global::Com.Android.Camera.Gallery.BaseImageList, global::Com.Android.Camera.Gallery.IImageList {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/android/camera/gallery/ImageList", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageList); }
		}

		protected ImageList (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_ContentResolver_Landroid_net_Uri_ILjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='ImageList']/constructor[@name='ImageList' and count(parameter)=4 and parameter[1][@type='android.content.ContentResolver'] and parameter[2][@type='android.net.Uri'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/ContentResolver;Landroid/net/Uri;ILjava/lang/String;)V", "")]
		public ImageList (global::Android.Content.ContentResolver p0, global::Android.Net.Uri p1, int p2, string p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p3 = JNIEnv.NewString (p3);;
			if (GetType () != typeof (ImageList)) {
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
			global::Com.Android.Camera.Gallery.ImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.ImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.BucketIds);
		}
#pragma warning restore 0169

		static IntPtr id_getBucketIds;
		public override global::System.Collections.Generic.IDictionary<string, string> BucketIds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='ImageList']/method[@name='getBucketIds' and count(parameter)=0]"
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
			global::Com.Android.Camera.Gallery.ImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.ImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateCursor ());
		}
#pragma warning restore 0169

		static IntPtr id_createCursor;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='ImageList']/method[@name='createCursor' and count(parameter)=0]"
		[Register ("createCursor", "()Landroid/database/Cursor;", "GetCreateCursorHandler")]
		protected override global::Android.Database.ICursor CreateCursor ()
		{
			if (id_createCursor == IntPtr.Zero)
				id_createCursor = JNIEnv.GetMethodID (class_ref, "createCursor", "()Landroid/database/Cursor;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (JNIEnv.CallObjectMethod  (Handle, id_createCursor), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createCursor", "()Landroid/database/Cursor;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Android.Camera.Gallery.ImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.ImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.ICursor p0 = (global::Android.Database.ICursor)global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetImageId (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getImageId_Landroid_database_Cursor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='ImageList']/method[@name='getImageId' and count(parameter)=1 and parameter[1][@type='android.database.Cursor']]"
		[Register ("getImageId", "(Landroid/database/Cursor;)J", "GetGetImageId_Landroid_database_Cursor_Handler")]
		protected override long GetImageId (global::Android.Database.ICursor p0)
		{
			if (id_getImageId_Landroid_database_Cursor_ == IntPtr.Zero)
				id_getImageId_Landroid_database_Cursor_ = JNIEnv.GetMethodID (class_ref, "getImageId", "(Landroid/database/Cursor;)J");

			long __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallLongMethod  (Handle, id_getImageId_Landroid_database_Cursor_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageId", "(Landroid/database/Cursor;)J"), new JValue (p0));
			return __ret;
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
			global::Com.Android.Camera.Gallery.ImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.ImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.ICursor p0 = (global::Android.Database.ICursor)global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LoadImageFromCursor (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_loadImageFromCursor_Landroid_database_Cursor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='ImageList']/method[@name='loadImageFromCursor' and count(parameter)=1 and parameter[1][@type='android.database.Cursor']]"
		[Register ("loadImageFromCursor", "(Landroid/database/Cursor;)Lcom/android/camera/gallery/BaseImage;", "GetLoadImageFromCursor_Landroid_database_Cursor_Handler")]
		protected override global::Com.Android.Camera.Gallery.BaseImage LoadImageFromCursor (global::Android.Database.ICursor p0)
		{
			if (id_loadImageFromCursor_Landroid_database_Cursor_ == IntPtr.Zero)
				id_loadImageFromCursor_Landroid_database_Cursor_ = JNIEnv.GetMethodID (class_ref, "loadImageFromCursor", "(Landroid/database/Cursor;)Lcom/android/camera/gallery/BaseImage;");

			global::Com.Android.Camera.Gallery.BaseImage __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.BaseImage> (JNIEnv.CallObjectMethod  (Handle, id_loadImageFromCursor_Landroid_database_Cursor_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.BaseImage> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadImageFromCursor", "(Landroid/database/Cursor;)Lcom/android/camera/gallery/BaseImage;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_whereClause;
#pragma warning disable 0169
		static Delegate GetWhereClauseHandler ()
		{
			if (cb_whereClause == null)
				cb_whereClause = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_WhereClause);
			return cb_whereClause;
		}

		static IntPtr n_WhereClause (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Android.Camera.Gallery.ImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.ImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.WhereClause ());
		}
#pragma warning restore 0169

		static IntPtr id_whereClause;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='ImageList']/method[@name='whereClause' and count(parameter)=0]"
		[Register ("whereClause", "()Ljava/lang/String;", "GetWhereClauseHandler")]
		protected virtual string WhereClause ()
		{
			if (id_whereClause == IntPtr.Zero)
				id_whereClause = JNIEnv.GetMethodID (class_ref, "whereClause", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_whereClause), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "whereClause", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_whereClauseArgs;
#pragma warning disable 0169
		static Delegate GetWhereClauseArgsHandler ()
		{
			if (cb_whereClauseArgs == null)
				cb_whereClauseArgs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_WhereClauseArgs);
			return cb_whereClauseArgs;
		}

		static IntPtr n_WhereClauseArgs (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Android.Camera.Gallery.ImageList __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.ImageList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.WhereClauseArgs ());
		}
#pragma warning restore 0169

		static IntPtr id_whereClauseArgs;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/class[@name='ImageList']/method[@name='whereClauseArgs' and count(parameter)=0]"
		[Register ("whereClauseArgs", "()[Ljava/lang/String;", "GetWhereClauseArgsHandler")]
		protected virtual string[] WhereClauseArgs ()
		{
			if (id_whereClauseArgs == IntPtr.Zero)
				id_whereClauseArgs = JNIEnv.GetMethodID (class_ref, "whereClauseArgs", "()[Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_whereClauseArgs), JniHandleOwnership.TransferLocalRef, typeof (string));
			else
				return (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "whereClauseArgs", "()[Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef, typeof (string));
		}

	}
}
