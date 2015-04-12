using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Android.Camera {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.android.camera']/class[@name='BitmapManager']"
	[global::Android.Runtime.Register ("com/android/camera/BitmapManager", DoNotGenerateAcw=true)]
	public partial class BitmapManager : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.android.camera']/class[@name='BitmapManager.State']"
		[global::Android.Runtime.Register ("com/android/camera/BitmapManager$State", DoNotGenerateAcw=true)]
		public sealed partial class State : global::Java.Lang.Enum {


			static IntPtr ALLOW_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='BitmapManager.State']/field[@name='ALLOW']"
			[Register ("ALLOW")]
			public static global::Com.Android.Camera.BitmapManager.State Allow {
				get {
					if (ALLOW_jfieldId == IntPtr.Zero)
						ALLOW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALLOW", "Lcom/android/camera/BitmapManager$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ALLOW_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Android.Camera.BitmapManager.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ALLOW_jfieldId == IntPtr.Zero)
						ALLOW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALLOW", "Lcom/android/camera/BitmapManager$State;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ALLOW_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr CANCEL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='BitmapManager.State']/field[@name='CANCEL']"
			[Register ("CANCEL")]
			public static global::Com.Android.Camera.BitmapManager.State Cancel {
				get {
					if (CANCEL_jfieldId == IntPtr.Zero)
						CANCEL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CANCEL", "Lcom/android/camera/BitmapManager$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CANCEL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Android.Camera.BitmapManager.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (CANCEL_jfieldId == IntPtr.Zero)
						CANCEL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CANCEL", "Lcom/android/camera/BitmapManager$State;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, CANCEL_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/android/camera/BitmapManager$State", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (State); }
			}

			internal State (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.android.camera']/class[@name='BitmapManager.ThreadStatus']"
		[global::Android.Runtime.Register ("com/android/camera/BitmapManager$ThreadStatus", DoNotGenerateAcw=true)]
		public partial class ThreadStatus : global::Java.Lang.Object {


			static IntPtr mOptions_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='BitmapManager.ThreadStatus']/field[@name='mOptions']"
			[Register ("mOptions")]
			public global::Android.Graphics.BitmapFactory.Options MOptions {
				get {
					if (mOptions_jfieldId == IntPtr.Zero)
						mOptions_jfieldId = JNIEnv.GetFieldID (class_ref, "mOptions", "Landroid/graphics/BitmapFactory$Options;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, mOptions_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.BitmapFactory.Options> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (mOptions_jfieldId == IntPtr.Zero)
						mOptions_jfieldId = JNIEnv.GetFieldID (class_ref, "mOptions", "Landroid/graphics/BitmapFactory$Options;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetField (Handle, mOptions_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr mState_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='BitmapManager.ThreadStatus']/field[@name='mState']"
			[Register ("mState")]
			public global::Com.Android.Camera.BitmapManager.State MState {
				get {
					if (mState_jfieldId == IntPtr.Zero)
						mState_jfieldId = JNIEnv.GetFieldID (class_ref, "mState", "Lcom/android/camera/BitmapManager$State;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, mState_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Android.Camera.BitmapManager.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (mState_jfieldId == IntPtr.Zero)
						mState_jfieldId = JNIEnv.GetFieldID (class_ref, "mState", "Lcom/android/camera/BitmapManager$State;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetField (Handle, mState_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr mThumbRequesting_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='BitmapManager.ThreadStatus']/field[@name='mThumbRequesting']"
			[Register ("mThumbRequesting")]
			public bool MThumbRequesting {
				get {
					if (mThumbRequesting_jfieldId == IntPtr.Zero)
						mThumbRequesting_jfieldId = JNIEnv.GetFieldID (class_ref, "mThumbRequesting", "Z");
					return JNIEnv.GetBooleanField (Handle, mThumbRequesting_jfieldId);
				}
				set {
					if (mThumbRequesting_jfieldId == IntPtr.Zero)
						mThumbRequesting_jfieldId = JNIEnv.GetFieldID (class_ref, "mThumbRequesting", "Z");
					JNIEnv.SetField (Handle, mThumbRequesting_jfieldId, value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/android/camera/BitmapManager$ThreadStatus", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ThreadStatus); }
			}

			protected ThreadStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/android/camera/BitmapManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BitmapManager); }
		}

		protected BitmapManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_allowThreadDecoding_Ljava_lang_Thread_;
#pragma warning disable 0169
		static Delegate GetAllowThreadDecoding_Ljava_lang_Thread_Handler ()
		{
			if (cb_allowThreadDecoding_Ljava_lang_Thread_ == null)
				cb_allowThreadDecoding_Ljava_lang_Thread_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AllowThreadDecoding_Ljava_lang_Thread_);
			return cb_allowThreadDecoding_Ljava_lang_Thread_;
		}

		static void n_AllowThreadDecoding_Ljava_lang_Thread_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Android.Camera.BitmapManager __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.BitmapManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Thread p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AllowThreadDecoding (p0);
		}
#pragma warning restore 0169

		static IntPtr id_allowThreadDecoding_Ljava_lang_Thread_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='BitmapManager']/method[@name='allowThreadDecoding' and count(parameter)=1 and parameter[1][@type='java.lang.Thread']]"
		[Register ("allowThreadDecoding", "(Ljava/lang/Thread;)V", "GetAllowThreadDecoding_Ljava_lang_Thread_Handler")]
		public virtual void AllowThreadDecoding (global::Java.Lang.Thread p0)
		{
			if (id_allowThreadDecoding_Ljava_lang_Thread_ == IntPtr.Zero)
				id_allowThreadDecoding_Ljava_lang_Thread_ = JNIEnv.GetMethodID (class_ref, "allowThreadDecoding", "(Ljava/lang/Thread;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_allowThreadDecoding_Ljava_lang_Thread_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "allowThreadDecoding", "(Ljava/lang/Thread;)V"), new JValue (p0));
		}

		static Delegate cb_canThreadDecoding_Ljava_lang_Thread_;
#pragma warning disable 0169
		static Delegate GetCanThreadDecoding_Ljava_lang_Thread_Handler ()
		{
			if (cb_canThreadDecoding_Ljava_lang_Thread_ == null)
				cb_canThreadDecoding_Ljava_lang_Thread_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_CanThreadDecoding_Ljava_lang_Thread_);
			return cb_canThreadDecoding_Ljava_lang_Thread_;
		}

		static bool n_CanThreadDecoding_Ljava_lang_Thread_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Android.Camera.BitmapManager __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.BitmapManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Thread p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CanThreadDecoding (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_canThreadDecoding_Ljava_lang_Thread_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='BitmapManager']/method[@name='canThreadDecoding' and count(parameter)=1 and parameter[1][@type='java.lang.Thread']]"
		[Register ("canThreadDecoding", "(Ljava/lang/Thread;)Z", "GetCanThreadDecoding_Ljava_lang_Thread_Handler")]
		public virtual bool CanThreadDecoding (global::Java.Lang.Thread p0)
		{
			if (id_canThreadDecoding_Ljava_lang_Thread_ == IntPtr.Zero)
				id_canThreadDecoding_Ljava_lang_Thread_ = JNIEnv.GetMethodID (class_ref, "canThreadDecoding", "(Ljava/lang/Thread;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_canThreadDecoding_Ljava_lang_Thread_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "canThreadDecoding", "(Ljava/lang/Thread;)Z"), new JValue (p0));
			return __ret;
		}

		static Delegate cb_cancelThreadDecoding_Ljava_lang_Thread_Landroid_content_ContentResolver_;
#pragma warning disable 0169
		static Delegate GetCancelThreadDecoding_Ljava_lang_Thread_Landroid_content_ContentResolver_Handler ()
		{
			if (cb_cancelThreadDecoding_Ljava_lang_Thread_Landroid_content_ContentResolver_ == null)
				cb_cancelThreadDecoding_Ljava_lang_Thread_Landroid_content_ContentResolver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CancelThreadDecoding_Ljava_lang_Thread_Landroid_content_ContentResolver_);
			return cb_cancelThreadDecoding_Ljava_lang_Thread_Landroid_content_ContentResolver_;
		}

		static void n_CancelThreadDecoding_Ljava_lang_Thread_Landroid_content_ContentResolver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Android.Camera.BitmapManager __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.BitmapManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Thread p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.ContentResolver p1 = global::Java.Lang.Object.GetObject<global::Android.Content.ContentResolver> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CancelThreadDecoding (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_cancelThreadDecoding_Ljava_lang_Thread_Landroid_content_ContentResolver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='BitmapManager']/method[@name='cancelThreadDecoding' and count(parameter)=2 and parameter[1][@type='java.lang.Thread'] and parameter[2][@type='android.content.ContentResolver']]"
		[Register ("cancelThreadDecoding", "(Ljava/lang/Thread;Landroid/content/ContentResolver;)V", "GetCancelThreadDecoding_Ljava_lang_Thread_Landroid_content_ContentResolver_Handler")]
		public virtual void CancelThreadDecoding (global::Java.Lang.Thread p0, global::Android.Content.ContentResolver p1)
		{
			if (id_cancelThreadDecoding_Ljava_lang_Thread_Landroid_content_ContentResolver_ == IntPtr.Zero)
				id_cancelThreadDecoding_Ljava_lang_Thread_Landroid_content_ContentResolver_ = JNIEnv.GetMethodID (class_ref, "cancelThreadDecoding", "(Ljava/lang/Thread;Landroid/content/ContentResolver;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_cancelThreadDecoding_Ljava_lang_Thread_Landroid_content_ContentResolver_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancelThreadDecoding", "(Ljava/lang/Thread;Landroid/content/ContentResolver;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_decodeFileDescriptor_Ljava_io_FileDescriptor_Landroid_graphics_BitmapFactory_Options_;
#pragma warning disable 0169
		static Delegate GetDecodeFileDescriptor_Ljava_io_FileDescriptor_Landroid_graphics_BitmapFactory_Options_Handler ()
		{
			if (cb_decodeFileDescriptor_Ljava_io_FileDescriptor_Landroid_graphics_BitmapFactory_Options_ == null)
				cb_decodeFileDescriptor_Ljava_io_FileDescriptor_Landroid_graphics_BitmapFactory_Options_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DecodeFileDescriptor_Ljava_io_FileDescriptor_Landroid_graphics_BitmapFactory_Options_);
			return cb_decodeFileDescriptor_Ljava_io_FileDescriptor_Landroid_graphics_BitmapFactory_Options_;
		}

		static IntPtr n_DecodeFileDescriptor_Ljava_io_FileDescriptor_Landroid_graphics_BitmapFactory_Options_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Android.Camera.BitmapManager __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.BitmapManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.FileDescriptor p0 = global::Java.Lang.Object.GetObject<global::Java.IO.FileDescriptor> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.BitmapFactory.Options p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.BitmapFactory.Options> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DecodeFileDescriptor (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decodeFileDescriptor_Ljava_io_FileDescriptor_Landroid_graphics_BitmapFactory_Options_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='BitmapManager']/method[@name='decodeFileDescriptor' and count(parameter)=2 and parameter[1][@type='java.io.FileDescriptor'] and parameter[2][@type='android.graphics.BitmapFactory.Options']]"
		[Register ("decodeFileDescriptor", "(Ljava/io/FileDescriptor;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;", "GetDecodeFileDescriptor_Ljava_io_FileDescriptor_Landroid_graphics_BitmapFactory_Options_Handler")]
		public virtual global::Android.Graphics.Bitmap DecodeFileDescriptor (global::Java.IO.FileDescriptor p0, global::Android.Graphics.BitmapFactory.Options p1)
		{
			if (id_decodeFileDescriptor_Ljava_io_FileDescriptor_Landroid_graphics_BitmapFactory_Options_ == IntPtr.Zero)
				id_decodeFileDescriptor_Ljava_io_FileDescriptor_Landroid_graphics_BitmapFactory_Options_ = JNIEnv.GetMethodID (class_ref, "decodeFileDescriptor", "(Ljava/io/FileDescriptor;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");

			global::Android.Graphics.Bitmap __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_decodeFileDescriptor_Ljava_io_FileDescriptor_Landroid_graphics_BitmapFactory_Options_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decodeFileDescriptor", "(Ljava/io/FileDescriptor;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;"), new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getThumbnail_Landroid_content_ContentResolver_JILandroid_graphics_BitmapFactory_Options_Z;
#pragma warning disable 0169
		static Delegate GetGetThumbnail_Landroid_content_ContentResolver_JILandroid_graphics_BitmapFactory_Options_ZHandler ()
		{
			if (cb_getThumbnail_Landroid_content_ContentResolver_JILandroid_graphics_BitmapFactory_Options_Z == null)
				cb_getThumbnail_Landroid_content_ContentResolver_JILandroid_graphics_BitmapFactory_Options_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, int, IntPtr, bool, IntPtr>) n_GetThumbnail_Landroid_content_ContentResolver_JILandroid_graphics_BitmapFactory_Options_Z);
			return cb_getThumbnail_Landroid_content_ContentResolver_JILandroid_graphics_BitmapFactory_Options_Z;
		}

		static IntPtr n_GetThumbnail_Landroid_content_ContentResolver_JILandroid_graphics_BitmapFactory_Options_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, int p2, IntPtr native_p3, bool p4)
		{
			global::Com.Android.Camera.BitmapManager __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.BitmapManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.ContentResolver p0 = global::Java.Lang.Object.GetObject<global::Android.Content.ContentResolver> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.BitmapFactory.Options p3 = global::Java.Lang.Object.GetObject<global::Android.Graphics.BitmapFactory.Options> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetThumbnail (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getThumbnail_Landroid_content_ContentResolver_JILandroid_graphics_BitmapFactory_Options_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='BitmapManager']/method[@name='getThumbnail' and count(parameter)=5 and parameter[1][@type='android.content.ContentResolver'] and parameter[2][@type='long'] and parameter[3][@type='int'] and parameter[4][@type='android.graphics.BitmapFactory.Options'] and parameter[5][@type='boolean']]"
		[Register ("getThumbnail", "(Landroid/content/ContentResolver;JILandroid/graphics/BitmapFactory$Options;Z)Landroid/graphics/Bitmap;", "GetGetThumbnail_Landroid_content_ContentResolver_JILandroid_graphics_BitmapFactory_Options_ZHandler")]
		public virtual global::Android.Graphics.Bitmap GetThumbnail (global::Android.Content.ContentResolver p0, long p1, int p2, global::Android.Graphics.BitmapFactory.Options p3, bool p4)
		{
			if (id_getThumbnail_Landroid_content_ContentResolver_JILandroid_graphics_BitmapFactory_Options_Z == IntPtr.Zero)
				id_getThumbnail_Landroid_content_ContentResolver_JILandroid_graphics_BitmapFactory_Options_Z = JNIEnv.GetMethodID (class_ref, "getThumbnail", "(Landroid/content/ContentResolver;JILandroid/graphics/BitmapFactory$Options;Z)Landroid/graphics/Bitmap;");

			global::Android.Graphics.Bitmap __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_getThumbnail_Landroid_content_ContentResolver_JILandroid_graphics_BitmapFactory_Options_Z, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getThumbnail", "(Landroid/content/ContentResolver;JILandroid/graphics/BitmapFactory$Options;Z)Landroid/graphics/Bitmap;"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_instance;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='BitmapManager']/method[@name='instance' and count(parameter)=0]"
		[Register ("instance", "()Lcom/android/camera/BitmapManager;", "")]
		public static global::Com.Android.Camera.BitmapManager Instance ()
		{
			if (id_instance == IntPtr.Zero)
				id_instance = JNIEnv.GetStaticMethodID (class_ref, "instance", "()Lcom/android/camera/BitmapManager;");
			return global::Java.Lang.Object.GetObject<global::Com.Android.Camera.BitmapManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_instance), JniHandleOwnership.TransferLocalRef);
		}

	}
}
