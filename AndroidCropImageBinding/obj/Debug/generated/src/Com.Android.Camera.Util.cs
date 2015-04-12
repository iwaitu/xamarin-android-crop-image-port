using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Android.Camera {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.android.camera']/class[@name='Util']"
	[global::Android.Runtime.Register ("com/android/camera/Util", DoNotGenerateAcw=true)]
	public partial class Util : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='Util']/field[@name='DIRECTION_DOWN']"
		[Register ("DIRECTION_DOWN")]
		public const int DirectionDown = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='Util']/field[@name='DIRECTION_LEFT']"
		[Register ("DIRECTION_LEFT")]
		public const int DirectionLeft = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='Util']/field[@name='DIRECTION_RIGHT']"
		[Register ("DIRECTION_RIGHT")]
		public const int DirectionRight = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='Util']/field[@name='DIRECTION_UP']"
		[Register ("DIRECTION_UP")]
		public const int DirectionUp = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='Util']/field[@name='NO_RECYCLE_INPUT']"
		[Register ("NO_RECYCLE_INPUT")]
		public const bool NoRecycleInput = (bool) false;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='Util']/field[@name='RECYCLE_INPUT']"
		[Register ("RECYCLE_INPUT")]
		public const bool RecycleInput = (bool) true;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.android.camera']/class[@name='Util.BackgroundJob']"
		[global::Android.Runtime.Register ("com/android/camera/Util$BackgroundJob", DoNotGenerateAcw=true)]
		public partial class BackgroundJob : global::Com.Android.Camera.MonitoredActivity.LifeCycleAdapter, global::Java.Lang.IRunnable {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/android/camera/Util$BackgroundJob", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (BackgroundJob); }
			}

			protected BackgroundJob (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_android_camera_MonitoredActivity_Ljava_lang_Runnable_Landroid_app_ProgressDialog_Landroid_os_Handler_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.android.camera']/class[@name='Util.BackgroundJob']/constructor[@name='Util.BackgroundJob' and count(parameter)=4 and parameter[1][@type='com.android.camera.MonitoredActivity'] and parameter[2][@type='java.lang.Runnable'] and parameter[3][@type='android.app.ProgressDialog'] and parameter[4][@type='android.os.Handler']]"
			[Register (".ctor", "(Lcom/android/camera/MonitoredActivity;Ljava/lang/Runnable;Landroid/app/ProgressDialog;Landroid/os/Handler;)V", "")]
			public BackgroundJob (global::Com.Android.Camera.MonitoredActivity p0, global::Java.Lang.IRunnable p1, global::Android.App.ProgressDialog p2, global::Android.OS.Handler p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (BackgroundJob)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/android/camera/MonitoredActivity;Ljava/lang/Runnable;Landroid/app/ProgressDialog;Landroid/os/Handler;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/android/camera/MonitoredActivity;Ljava/lang/Runnable;Landroid/app/ProgressDialog;Landroid/os/Handler;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
					return;
				}

				if (id_ctor_Lcom_android_camera_MonitoredActivity_Ljava_lang_Runnable_Landroid_app_ProgressDialog_Landroid_os_Handler_ == IntPtr.Zero)
					id_ctor_Lcom_android_camera_MonitoredActivity_Ljava_lang_Runnable_Landroid_app_ProgressDialog_Landroid_os_Handler_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/android/camera/MonitoredActivity;Ljava/lang/Runnable;Landroid/app/ProgressDialog;Landroid/os/Handler;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_android_camera_MonitoredActivity_Ljava_lang_Runnable_Landroid_app_ProgressDialog_Landroid_os_Handler_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_android_camera_MonitoredActivity_Ljava_lang_Runnable_Landroid_app_ProgressDialog_Landroid_os_Handler_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Android.Camera.Util.BackgroundJob __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Util.BackgroundJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='Util.BackgroundJob']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public virtual void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_run);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/android/camera/Util", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Util); }
		}

		protected Util (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getNullOnClickListener;
		public static global::Android.Views.View.IOnClickListener NullOnClickListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='Util']/method[@name='getNullOnClickListener' and count(parameter)=0]"
			[Register ("getNullOnClickListener", "()Landroid/view/View$OnClickListener;", "GetGetNullOnClickListenerHandler")]
			get {
				if (id_getNullOnClickListener == IntPtr.Zero)
					id_getNullOnClickListener = JNIEnv.GetStaticMethodID (class_ref, "getNullOnClickListener", "()Landroid/view/View$OnClickListener;");
				return global::Java.Lang.Object.GetObject<global::Android.Views.View.IOnClickListener> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getNullOnClickListener), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_Assert_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='Util']/method[@name='Assert' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("Assert", "(Z)V", "")]
		public static void Assert (bool p0)
		{
			if (id_Assert_Z == IntPtr.Zero)
				id_Assert_Z = JNIEnv.GetStaticMethodID (class_ref, "Assert", "(Z)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_Assert_Z, new JValue (p0));
		}

		static IntPtr id_closeSilently_Landroid_os_ParcelFileDescriptor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='Util']/method[@name='closeSilently' and count(parameter)=1 and parameter[1][@type='android.os.ParcelFileDescriptor']]"
		[Register ("closeSilently", "(Landroid/os/ParcelFileDescriptor;)V", "")]
		public static void CloseSilently (global::Android.OS.ParcelFileDescriptor p0)
		{
			if (id_closeSilently_Landroid_os_ParcelFileDescriptor_ == IntPtr.Zero)
				id_closeSilently_Landroid_os_ParcelFileDescriptor_ = JNIEnv.GetStaticMethodID (class_ref, "closeSilently", "(Landroid/os/ParcelFileDescriptor;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_closeSilently_Landroid_os_ParcelFileDescriptor_, new JValue (p0));
		}

		static IntPtr id_closeSilently_Ljava_io_Closeable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='Util']/method[@name='closeSilently' and count(parameter)=1 and parameter[1][@type='java.io.Closeable']]"
		[Register ("closeSilently", "(Ljava/io/Closeable;)V", "")]
		public static void CloseSilently (global::Java.IO.ICloseable p0)
		{
			if (id_closeSilently_Ljava_io_Closeable_ == IntPtr.Zero)
				id_closeSilently_Ljava_io_Closeable_ = JNIEnv.GetStaticMethodID (class_ref, "closeSilently", "(Ljava/io/Closeable;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_closeSilently_Ljava_io_Closeable_, new JValue (p0));
		}

		static IntPtr id_computeSampleSize_Landroid_graphics_BitmapFactory_Options_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='Util']/method[@name='computeSampleSize' and count(parameter)=3 and parameter[1][@type='android.graphics.BitmapFactory.Options'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("computeSampleSize", "(Landroid/graphics/BitmapFactory$Options;II)I", "")]
		public static int ComputeSampleSize (global::Android.Graphics.BitmapFactory.Options p0, int p1, int p2)
		{
			if (id_computeSampleSize_Landroid_graphics_BitmapFactory_Options_II == IntPtr.Zero)
				id_computeSampleSize_Landroid_graphics_BitmapFactory_Options_II = JNIEnv.GetStaticMethodID (class_ref, "computeSampleSize", "(Landroid/graphics/BitmapFactory$Options;II)I");
			int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_computeSampleSize_Landroid_graphics_BitmapFactory_Options_II, new JValue (p0), new JValue (p1), new JValue (p2));
			return __ret;
		}

		static IntPtr id_createNativeAllocOptions;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='Util']/method[@name='createNativeAllocOptions' and count(parameter)=0]"
		[Register ("createNativeAllocOptions", "()Landroid/graphics/BitmapFactory$Options;", "")]
		public static global::Android.Graphics.BitmapFactory.Options CreateNativeAllocOptions ()
		{
			if (id_createNativeAllocOptions == IntPtr.Zero)
				id_createNativeAllocOptions = JNIEnv.GetStaticMethodID (class_ref, "createNativeAllocOptions", "()Landroid/graphics/BitmapFactory$Options;");
			return global::Java.Lang.Object.GetObject<global::Android.Graphics.BitmapFactory.Options> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createNativeAllocOptions), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_createSetAsIntent_Lcom_android_camera_gallery_IImage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='Util']/method[@name='createSetAsIntent' and count(parameter)=1 and parameter[1][@type='com.android.camera.gallery.IImage']]"
		[Register ("createSetAsIntent", "(Lcom/android/camera/gallery/IImage;)Landroid/content/Intent;", "")]
		public static global::Android.Content.Intent CreateSetAsIntent (global::Com.Android.Camera.Gallery.IImage p0)
		{
			if (id_createSetAsIntent_Lcom_android_camera_gallery_IImage_ == IntPtr.Zero)
				id_createSetAsIntent_Lcom_android_camera_gallery_IImage_ = JNIEnv.GetStaticMethodID (class_ref, "createSetAsIntent", "(Lcom/android/camera/gallery/IImage;)Landroid/content/Intent;");
			global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createSetAsIntent_Lcom_android_camera_gallery_IImage_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_equals_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='Util']/method[@name='equals' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("equals", "(Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public static bool Equals (string p0, string p1)
		{
			if (id_equals_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_equals_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "equals", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_equals_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_indexOf_arrayLjava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='Util']/method[@name='indexOf' and count(parameter)=2 and parameter[1][@type='java.lang.Object[]'] and parameter[2][@type='java.lang.Object']]"
		[Register ("indexOf", "([Ljava/lang/Object;Ljava/lang/Object;)I", "")]
		public static int IndexOf (global::Java.Lang.Object[] p0, global::Java.Lang.Object p1)
		{
			if (id_indexOf_arrayLjava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_indexOf_arrayLjava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "indexOf", "([Ljava/lang/Object;Ljava/lang/Object;)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_indexOf_arrayLjava_lang_Object_Ljava_lang_Object_, new JValue (native_p0), new JValue (native_p1));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_makeBitmap_IILandroid_net_Uri_Landroid_content_ContentResolver_Landroid_os_ParcelFileDescriptor_Landroid_graphics_BitmapFactory_Options_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='Util']/method[@name='makeBitmap' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.net.Uri'] and parameter[4][@type='android.content.ContentResolver'] and parameter[5][@type='android.os.ParcelFileDescriptor'] and parameter[6][@type='android.graphics.BitmapFactory.Options']]"
		[Register ("makeBitmap", "(IILandroid/net/Uri;Landroid/content/ContentResolver;Landroid/os/ParcelFileDescriptor;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;", "")]
		public static global::Android.Graphics.Bitmap MakeBitmap (int p0, int p1, global::Android.Net.Uri p2, global::Android.Content.ContentResolver p3, global::Android.OS.ParcelFileDescriptor p4, global::Android.Graphics.BitmapFactory.Options p5)
		{
			if (id_makeBitmap_IILandroid_net_Uri_Landroid_content_ContentResolver_Landroid_os_ParcelFileDescriptor_Landroid_graphics_BitmapFactory_Options_ == IntPtr.Zero)
				id_makeBitmap_IILandroid_net_Uri_Landroid_content_ContentResolver_Landroid_os_ParcelFileDescriptor_Landroid_graphics_BitmapFactory_Options_ = JNIEnv.GetStaticMethodID (class_ref, "makeBitmap", "(IILandroid/net/Uri;Landroid/content/ContentResolver;Landroid/os/ParcelFileDescriptor;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");
			global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_makeBitmap_IILandroid_net_Uri_Landroid_content_ContentResolver_Landroid_os_ParcelFileDescriptor_Landroid_graphics_BitmapFactory_Options_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_makeBitmap_IILandroid_net_Uri_Landroid_content_ContentResolver_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='Util']/method[@name='makeBitmap' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.net.Uri'] and parameter[4][@type='android.content.ContentResolver'] and parameter[5][@type='boolean']]"
		[Register ("makeBitmap", "(IILandroid/net/Uri;Landroid/content/ContentResolver;Z)Landroid/graphics/Bitmap;", "")]
		public static global::Android.Graphics.Bitmap MakeBitmap (int p0, int p1, global::Android.Net.Uri p2, global::Android.Content.ContentResolver p3, bool p4)
		{
			if (id_makeBitmap_IILandroid_net_Uri_Landroid_content_ContentResolver_Z == IntPtr.Zero)
				id_makeBitmap_IILandroid_net_Uri_Landroid_content_ContentResolver_Z = JNIEnv.GetStaticMethodID (class_ref, "makeBitmap", "(IILandroid/net/Uri;Landroid/content/ContentResolver;Z)Landroid/graphics/Bitmap;");
			global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_makeBitmap_IILandroid_net_Uri_Landroid_content_ContentResolver_Z, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_makeBitmap_IILandroid_os_ParcelFileDescriptor_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='Util']/method[@name='makeBitmap' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.os.ParcelFileDescriptor'] and parameter[4][@type='boolean']]"
		[Register ("makeBitmap", "(IILandroid/os/ParcelFileDescriptor;Z)Landroid/graphics/Bitmap;", "")]
		public static global::Android.Graphics.Bitmap MakeBitmap (int p0, int p1, global::Android.OS.ParcelFileDescriptor p2, bool p3)
		{
			if (id_makeBitmap_IILandroid_os_ParcelFileDescriptor_Z == IntPtr.Zero)
				id_makeBitmap_IILandroid_os_ParcelFileDescriptor_Z = JNIEnv.GetStaticMethodID (class_ref, "makeBitmap", "(IILandroid/os/ParcelFileDescriptor;Z)Landroid/graphics/Bitmap;");
			global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_makeBitmap_IILandroid_os_ParcelFileDescriptor_Z, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_rotate_Landroid_graphics_Bitmap_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='Util']/method[@name='rotate' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='int']]"
		[Register ("rotate", "(Landroid/graphics/Bitmap;I)Landroid/graphics/Bitmap;", "")]
		public static global::Android.Graphics.Bitmap Rotate (global::Android.Graphics.Bitmap p0, int p1)
		{
			if (id_rotate_Landroid_graphics_Bitmap_I == IntPtr.Zero)
				id_rotate_Landroid_graphics_Bitmap_I = JNIEnv.GetStaticMethodID (class_ref, "rotate", "(Landroid/graphics/Bitmap;I)Landroid/graphics/Bitmap;");
			global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_rotate_Landroid_graphics_Bitmap_I, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_startBackgroundJob_Lcom_android_camera_MonitoredActivity_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Runnable_Landroid_os_Handler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='Util']/method[@name='startBackgroundJob' and count(parameter)=5 and parameter[1][@type='com.android.camera.MonitoredActivity'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Runnable'] and parameter[5][@type='android.os.Handler']]"
		[Register ("startBackgroundJob", "(Lcom/android/camera/MonitoredActivity;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Runnable;Landroid/os/Handler;)V", "")]
		public static void StartBackgroundJob (global::Com.Android.Camera.MonitoredActivity p0, string p1, string p2, global::Java.Lang.IRunnable p3, global::Android.OS.Handler p4)
		{
			if (id_startBackgroundJob_Lcom_android_camera_MonitoredActivity_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Runnable_Landroid_os_Handler_ == IntPtr.Zero)
				id_startBackgroundJob_Lcom_android_camera_MonitoredActivity_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Runnable_Landroid_os_Handler_ = JNIEnv.GetStaticMethodID (class_ref, "startBackgroundJob", "(Lcom/android/camera/MonitoredActivity;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Runnable;Landroid/os/Handler;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_startBackgroundJob_Lcom_android_camera_MonitoredActivity_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Runnable_Landroid_os_Handler_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3), new JValue (p4));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_transform_Landroid_graphics_Matrix_Landroid_graphics_Bitmap_IIZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='Util']/method[@name='transform' and count(parameter)=6 and parameter[1][@type='android.graphics.Matrix'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='boolean'] and parameter[6][@type='boolean']]"
		[Register ("transform", "(Landroid/graphics/Matrix;Landroid/graphics/Bitmap;IIZZ)Landroid/graphics/Bitmap;", "")]
		public static global::Android.Graphics.Bitmap Transform (global::Android.Graphics.Matrix p0, global::Android.Graphics.Bitmap p1, int p2, int p3, bool p4, bool p5)
		{
			if (id_transform_Landroid_graphics_Matrix_Landroid_graphics_Bitmap_IIZZ == IntPtr.Zero)
				id_transform_Landroid_graphics_Matrix_Landroid_graphics_Bitmap_IIZZ = JNIEnv.GetStaticMethodID (class_ref, "transform", "(Landroid/graphics/Matrix;Landroid/graphics/Bitmap;IIZZ)Landroid/graphics/Bitmap;");
			global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_transform_Landroid_graphics_Matrix_Landroid_graphics_Bitmap_IIZZ, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
