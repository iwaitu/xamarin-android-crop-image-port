using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Android.Camera {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.android.camera']/class[@name='RotateBitmap']"
	[global::Android.Runtime.Register ("com/android/camera/RotateBitmap", DoNotGenerateAcw=true)]
	public partial class RotateBitmap : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='RotateBitmap']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "RotateBitmap";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/android/camera/RotateBitmap", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RotateBitmap); }
		}

		protected RotateBitmap (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.android.camera']/class[@name='RotateBitmap']/constructor[@name='RotateBitmap' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register (".ctor", "(Landroid/graphics/Bitmap;)V", "")]
		public RotateBitmap (global::Android.Graphics.Bitmap p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RotateBitmap)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/graphics/Bitmap;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/graphics/Bitmap;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_ctor_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/graphics/Bitmap;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_graphics_Bitmap_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_graphics_Bitmap_, new JValue (p0));
		}

		static IntPtr id_ctor_Landroid_graphics_Bitmap_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.android.camera']/class[@name='RotateBitmap']/constructor[@name='RotateBitmap' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Landroid/graphics/Bitmap;I)V", "")]
		public RotateBitmap (global::Android.Graphics.Bitmap p0, int p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RotateBitmap)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/graphics/Bitmap;I)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/graphics/Bitmap;I)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Landroid_graphics_Bitmap_I == IntPtr.Zero)
				id_ctor_Landroid_graphics_Bitmap_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/graphics/Bitmap;I)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_graphics_Bitmap_I, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_graphics_Bitmap_I, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_getBitmap;
#pragma warning disable 0169
		static Delegate GetGetBitmapHandler ()
		{
			if (cb_getBitmap == null)
				cb_getBitmap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBitmap);
			return cb_getBitmap;
		}

		static IntPtr n_GetBitmap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Android.Camera.RotateBitmap __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.RotateBitmap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Bitmap);
		}
#pragma warning restore 0169

		static Delegate cb_setBitmap_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetSetBitmap_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_setBitmap_Landroid_graphics_Bitmap_ == null)
				cb_setBitmap_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBitmap_Landroid_graphics_Bitmap_);
			return cb_setBitmap_Landroid_graphics_Bitmap_;
		}

		static void n_SetBitmap_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Android.Camera.RotateBitmap __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.RotateBitmap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Bitmap = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBitmap;
		static IntPtr id_setBitmap_Landroid_graphics_Bitmap_;
		public virtual global::Android.Graphics.Bitmap Bitmap {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='RotateBitmap']/method[@name='getBitmap' and count(parameter)=0]"
			[Register ("getBitmap", "()Landroid/graphics/Bitmap;", "GetGetBitmapHandler")]
			get {
				if (id_getBitmap == IntPtr.Zero)
					id_getBitmap = JNIEnv.GetMethodID (class_ref, "getBitmap", "()Landroid/graphics/Bitmap;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_getBitmap), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBitmap", "()Landroid/graphics/Bitmap;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='RotateBitmap']/method[@name='setBitmap' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
			[Register ("setBitmap", "(Landroid/graphics/Bitmap;)V", "GetSetBitmap_Landroid_graphics_Bitmap_Handler")]
			set {
				if (id_setBitmap_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_setBitmap_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "setBitmap", "(Landroid/graphics/Bitmap;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setBitmap_Landroid_graphics_Bitmap_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBitmap", "(Landroid/graphics/Bitmap;)V"), new JValue (value));
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
			global::Com.Android.Camera.RotateBitmap __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.RotateBitmap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		static IntPtr id_getHeight;
		public virtual int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='RotateBitmap']/method[@name='getHeight' and count(parameter)=0]"
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

		static Delegate cb_isOrientationChanged;
#pragma warning disable 0169
		static Delegate GetIsOrientationChangedHandler ()
		{
			if (cb_isOrientationChanged == null)
				cb_isOrientationChanged = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsOrientationChanged);
			return cb_isOrientationChanged;
		}

		static bool n_IsOrientationChanged (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Android.Camera.RotateBitmap __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.RotateBitmap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOrientationChanged;
		}
#pragma warning restore 0169

		static IntPtr id_isOrientationChanged;
		public virtual bool IsOrientationChanged {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='RotateBitmap']/method[@name='isOrientationChanged' and count(parameter)=0]"
			[Register ("isOrientationChanged", "()Z", "GetIsOrientationChangedHandler")]
			get {
				if (id_isOrientationChanged == IntPtr.Zero)
					id_isOrientationChanged = JNIEnv.GetMethodID (class_ref, "isOrientationChanged", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isOrientationChanged);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isOrientationChanged", "()Z"));
			}
		}

		static Delegate cb_getRotateMatrix;
#pragma warning disable 0169
		static Delegate GetGetRotateMatrixHandler ()
		{
			if (cb_getRotateMatrix == null)
				cb_getRotateMatrix = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRotateMatrix);
			return cb_getRotateMatrix;
		}

		static IntPtr n_GetRotateMatrix (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Android.Camera.RotateBitmap __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.RotateBitmap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RotateMatrix);
		}
#pragma warning restore 0169

		static IntPtr id_getRotateMatrix;
		public virtual global::Android.Graphics.Matrix RotateMatrix {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='RotateBitmap']/method[@name='getRotateMatrix' and count(parameter)=0]"
			[Register ("getRotateMatrix", "()Landroid/graphics/Matrix;", "GetGetRotateMatrixHandler")]
			get {
				if (id_getRotateMatrix == IntPtr.Zero)
					id_getRotateMatrix = JNIEnv.GetMethodID (class_ref, "getRotateMatrix", "()Landroid/graphics/Matrix;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (JNIEnv.CallObjectMethod  (Handle, id_getRotateMatrix), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRotateMatrix", "()Landroid/graphics/Matrix;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRotation;
#pragma warning disable 0169
		static Delegate GetGetRotationHandler ()
		{
			if (cb_getRotation == null)
				cb_getRotation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRotation);
			return cb_getRotation;
		}

		static int n_GetRotation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Android.Camera.RotateBitmap __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.RotateBitmap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Rotation;
		}
#pragma warning restore 0169

		static Delegate cb_setRotation_I;
#pragma warning disable 0169
		static Delegate GetSetRotation_IHandler ()
		{
			if (cb_setRotation_I == null)
				cb_setRotation_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetRotation_I);
			return cb_setRotation_I;
		}

		static void n_SetRotation_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Android.Camera.RotateBitmap __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.RotateBitmap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Rotation = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRotation;
		static IntPtr id_setRotation_I;
		public virtual int Rotation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='RotateBitmap']/method[@name='getRotation' and count(parameter)=0]"
			[Register ("getRotation", "()I", "GetGetRotationHandler")]
			get {
				if (id_getRotation == IntPtr.Zero)
					id_getRotation = JNIEnv.GetMethodID (class_ref, "getRotation", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getRotation);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRotation", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='RotateBitmap']/method[@name='setRotation' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRotation", "(I)V", "GetSetRotation_IHandler")]
			set {
				if (id_setRotation_I == IntPtr.Zero)
					id_setRotation_I = JNIEnv.GetMethodID (class_ref, "setRotation", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setRotation_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRotation", "(I)V"), new JValue (value));
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
			global::Com.Android.Camera.RotateBitmap __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.RotateBitmap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		static IntPtr id_getWidth;
		public virtual int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='RotateBitmap']/method[@name='getWidth' and count(parameter)=0]"
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

		static Delegate cb_recycle;
#pragma warning disable 0169
		static Delegate GetRecycleHandler ()
		{
			if (cb_recycle == null)
				cb_recycle = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Recycle);
			return cb_recycle;
		}

		static void n_Recycle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Android.Camera.RotateBitmap __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.RotateBitmap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Recycle ();
		}
#pragma warning restore 0169

		static IntPtr id_recycle;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='RotateBitmap']/method[@name='recycle' and count(parameter)=0]"
		[Register ("recycle", "()V", "GetRecycleHandler")]
		public virtual void Recycle ()
		{
			if (id_recycle == IntPtr.Zero)
				id_recycle = JNIEnv.GetMethodID (class_ref, "recycle", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_recycle);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "recycle", "()V"));
		}

	}
}
