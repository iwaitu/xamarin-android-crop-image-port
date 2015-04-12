using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Android.Camera {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.android.camera']/class[@name='ImageViewTouchBase']"
	[global::Android.Runtime.Register ("com/android/camera/ImageViewTouchBase", DoNotGenerateAcw=true)]
	public abstract partial class ImageViewTouchBase : global::Android.Widget.ImageView {


		static IntPtr mBaseMatrix_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='ImageViewTouchBase']/field[@name='mBaseMatrix']"
		[Register ("mBaseMatrix")]
		protected global::Android.Graphics.Matrix MBaseMatrix {
			get {
				if (mBaseMatrix_jfieldId == IntPtr.Zero)
					mBaseMatrix_jfieldId = JNIEnv.GetFieldID (class_ref, "mBaseMatrix", "Landroid/graphics/Matrix;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mBaseMatrix_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mBaseMatrix_jfieldId == IntPtr.Zero)
					mBaseMatrix_jfieldId = JNIEnv.GetFieldID (class_ref, "mBaseMatrix", "Landroid/graphics/Matrix;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mBaseMatrix_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mBitmapDisplayed_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='ImageViewTouchBase']/field[@name='mBitmapDisplayed']"
		[Register ("mBitmapDisplayed")]
		protected global::Com.Android.Camera.RotateBitmap MBitmapDisplayed {
			get {
				if (mBitmapDisplayed_jfieldId == IntPtr.Zero)
					mBitmapDisplayed_jfieldId = JNIEnv.GetFieldID (class_ref, "mBitmapDisplayed", "Lcom/android/camera/RotateBitmap;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mBitmapDisplayed_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Android.Camera.RotateBitmap> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mBitmapDisplayed_jfieldId == IntPtr.Zero)
					mBitmapDisplayed_jfieldId = JNIEnv.GetFieldID (class_ref, "mBitmapDisplayed", "Lcom/android/camera/RotateBitmap;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mBitmapDisplayed_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mHandler_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='ImageViewTouchBase']/field[@name='mHandler']"
		[Register ("mHandler")]
		protected global::Android.OS.Handler MHandler {
			get {
				if (mHandler_jfieldId == IntPtr.Zero)
					mHandler_jfieldId = JNIEnv.GetFieldID (class_ref, "mHandler", "Landroid/os/Handler;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mHandler_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mHandler_jfieldId == IntPtr.Zero)
					mHandler_jfieldId = JNIEnv.GetFieldID (class_ref, "mHandler", "Landroid/os/Handler;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mHandler_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mSuppMatrix_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='ImageViewTouchBase']/field[@name='mSuppMatrix']"
		[Register ("mSuppMatrix")]
		protected global::Android.Graphics.Matrix MSuppMatrix {
			get {
				if (mSuppMatrix_jfieldId == IntPtr.Zero)
					mSuppMatrix_jfieldId = JNIEnv.GetFieldID (class_ref, "mSuppMatrix", "Landroid/graphics/Matrix;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mSuppMatrix_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mSuppMatrix_jfieldId == IntPtr.Zero)
					mSuppMatrix_jfieldId = JNIEnv.GetFieldID (class_ref, "mSuppMatrix", "Landroid/graphics/Matrix;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mSuppMatrix_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.android.camera']/interface[@name='ImageViewTouchBase.Recycler']"
		[Register ("com/android/camera/ImageViewTouchBase$Recycler", "", "Com.Android.Camera.ImageViewTouchBase/IRecyclerInvoker")]
		public partial interface IRecycler : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/interface[@name='ImageViewTouchBase.Recycler']/method[@name='recycle' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
			[Register ("recycle", "(Landroid/graphics/Bitmap;)V", "GetRecycle_Landroid_graphics_Bitmap_Handler:Com.Android.Camera.ImageViewTouchBase/IRecyclerInvoker, AndroidCropImageBinding")]
			void Recycle (global::Android.Graphics.Bitmap p0);

		}

		[global::Android.Runtime.Register ("com/android/camera/ImageViewTouchBase$Recycler", DoNotGenerateAcw=true)]
		internal class IRecyclerInvoker : global::Java.Lang.Object, IRecycler {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/android/camera/ImageViewTouchBase$Recycler");
			IntPtr class_ref;

			public static IRecycler GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IRecycler> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.android.camera.ImageViewTouchBase.Recycler"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IRecyclerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IRecyclerInvoker); }
			}

			static Delegate cb_recycle_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
			static Delegate GetRecycle_Landroid_graphics_Bitmap_Handler ()
			{
				if (cb_recycle_Landroid_graphics_Bitmap_ == null)
					cb_recycle_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Recycle_Landroid_graphics_Bitmap_);
				return cb_recycle_Landroid_graphics_Bitmap_;
			}

			static void n_Recycle_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Android.Camera.ImageViewTouchBase.IRecycler __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.ImageViewTouchBase.IRecycler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Recycle (p0);
			}
#pragma warning restore 0169

			IntPtr id_recycle_Landroid_graphics_Bitmap_;
			public void Recycle (global::Android.Graphics.Bitmap p0)
			{
				if (id_recycle_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_recycle_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "recycle", "(Landroid/graphics/Bitmap;)V");
				JNIEnv.CallVoidMethod (Handle, id_recycle_Landroid_graphics_Bitmap_, new JValue (p0));
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/android/camera/ImageViewTouchBase", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageViewTouchBase); }
		}

		protected ImageViewTouchBase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.android.camera']/class[@name='ImageViewTouchBase']/constructor[@name='ImageViewTouchBase' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public ImageViewTouchBase (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ImageViewTouchBase)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.android.camera']/class[@name='ImageViewTouchBase']/constructor[@name='ImageViewTouchBase' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public ImageViewTouchBase (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ImageViewTouchBase)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, new JValue (p0));
		}

		static Delegate cb_getImageViewMatrix;
#pragma warning disable 0169
		static Delegate GetGetImageViewMatrixHandler ()
		{
			if (cb_getImageViewMatrix == null)
				cb_getImageViewMatrix = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageViewMatrix);
			return cb_getImageViewMatrix;
		}

		static IntPtr n_GetImageViewMatrix (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Android.Camera.ImageViewTouchBase __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.ImageViewTouchBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ImageViewMatrix);
		}
#pragma warning restore 0169

		static IntPtr id_getImageViewMatrix;
		protected virtual global::Android.Graphics.Matrix ImageViewMatrix {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageViewTouchBase']/method[@name='getImageViewMatrix' and count(parameter)=0]"
			[Register ("getImageViewMatrix", "()Landroid/graphics/Matrix;", "GetGetImageViewMatrixHandler")]
			get {
				if (id_getImageViewMatrix == IntPtr.Zero)
					id_getImageViewMatrix = JNIEnv.GetMethodID (class_ref, "getImageViewMatrix", "()Landroid/graphics/Matrix;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (JNIEnv.CallObjectMethod  (Handle, id_getImageViewMatrix), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageViewMatrix", "()Landroid/graphics/Matrix;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getScale;
#pragma warning disable 0169
		static Delegate GetGetScaleHandler ()
		{
			if (cb_getScale == null)
				cb_getScale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetScale);
			return cb_getScale;
		}

		static float n_GetScale (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Android.Camera.ImageViewTouchBase __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.ImageViewTouchBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Scale;
		}
#pragma warning restore 0169

		static IntPtr id_getScale;
		protected virtual float Scale {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageViewTouchBase']/method[@name='getScale' and count(parameter)=0]"
			[Register ("getScale", "()F", "GetGetScaleHandler")]
			get {
				if (id_getScale == IntPtr.Zero)
					id_getScale = JNIEnv.GetMethodID (class_ref, "getScale", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getScale);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScale", "()F"));
			}
		}

		static Delegate cb_center_ZZ;
#pragma warning disable 0169
		static Delegate GetCenter_ZZHandler ()
		{
			if (cb_center_ZZ == null)
				cb_center_ZZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, bool>) n_Center_ZZ);
			return cb_center_ZZ;
		}

		static void n_Center_ZZ (IntPtr jnienv, IntPtr native__this, bool p0, bool p1)
		{
			global::Com.Android.Camera.ImageViewTouchBase __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.ImageViewTouchBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Center (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_center_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageViewTouchBase']/method[@name='center' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='boolean']]"
		[Register ("center", "(ZZ)V", "GetCenter_ZZHandler")]
		public virtual void Center (bool p0, bool p1)
		{
			if (id_center_ZZ == IntPtr.Zero)
				id_center_ZZ = JNIEnv.GetMethodID (class_ref, "center", "(ZZ)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_center_ZZ, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "center", "(ZZ)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Android.Camera.ImageViewTouchBase __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.ImageViewTouchBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageViewTouchBase']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_clear);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
		}

		static Delegate cb_getScale_Landroid_graphics_Matrix_;
#pragma warning disable 0169
		static Delegate GetGetScale_Landroid_graphics_Matrix_Handler ()
		{
			if (cb_getScale_Landroid_graphics_Matrix_ == null)
				cb_getScale_Landroid_graphics_Matrix_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, float>) n_GetScale_Landroid_graphics_Matrix_);
			return cb_getScale_Landroid_graphics_Matrix_;
		}

		static float n_GetScale_Landroid_graphics_Matrix_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Android.Camera.ImageViewTouchBase __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.ImageViewTouchBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Matrix p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (native_p0, JniHandleOwnership.DoNotTransfer);
			float __ret = __this.GetScale (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getScale_Landroid_graphics_Matrix_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageViewTouchBase']/method[@name='getScale' and count(parameter)=1 and parameter[1][@type='android.graphics.Matrix']]"
		[Register ("getScale", "(Landroid/graphics/Matrix;)F", "GetGetScale_Landroid_graphics_Matrix_Handler")]
		protected virtual float GetScale (global::Android.Graphics.Matrix p0)
		{
			if (id_getScale_Landroid_graphics_Matrix_ == IntPtr.Zero)
				id_getScale_Landroid_graphics_Matrix_ = JNIEnv.GetMethodID (class_ref, "getScale", "(Landroid/graphics/Matrix;)F");

			float __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallFloatMethod  (Handle, id_getScale_Landroid_graphics_Matrix_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScale", "(Landroid/graphics/Matrix;)F"), new JValue (p0));
			return __ret;
		}

		static Delegate cb_getValue_Landroid_graphics_Matrix_I;
#pragma warning disable 0169
		static Delegate GetGetValue_Landroid_graphics_Matrix_IHandler ()
		{
			if (cb_getValue_Landroid_graphics_Matrix_I == null)
				cb_getValue_Landroid_graphics_Matrix_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, float>) n_GetValue_Landroid_graphics_Matrix_I);
			return cb_getValue_Landroid_graphics_Matrix_I;
		}

		static float n_GetValue_Landroid_graphics_Matrix_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Android.Camera.ImageViewTouchBase __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.ImageViewTouchBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Matrix p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (native_p0, JniHandleOwnership.DoNotTransfer);
			float __ret = __this.GetValue (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getValue_Landroid_graphics_Matrix_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageViewTouchBase']/method[@name='getValue' and count(parameter)=2 and parameter[1][@type='android.graphics.Matrix'] and parameter[2][@type='int']]"
		[Register ("getValue", "(Landroid/graphics/Matrix;I)F", "GetGetValue_Landroid_graphics_Matrix_IHandler")]
		protected virtual float GetValue (global::Android.Graphics.Matrix p0, int p1)
		{
			if (id_getValue_Landroid_graphics_Matrix_I == IntPtr.Zero)
				id_getValue_Landroid_graphics_Matrix_I = JNIEnv.GetMethodID (class_ref, "getValue", "(Landroid/graphics/Matrix;I)F");

			float __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallFloatMethod  (Handle, id_getValue_Landroid_graphics_Matrix_I, new JValue (p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValue", "(Landroid/graphics/Matrix;I)F"), new JValue (p0), new JValue (p1));
			return __ret;
		}

		static Delegate cb_maxZoom;
#pragma warning disable 0169
		static Delegate GetMaxZoomHandler ()
		{
			if (cb_maxZoom == null)
				cb_maxZoom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_MaxZoom);
			return cb_maxZoom;
		}

		static float n_MaxZoom (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Android.Camera.ImageViewTouchBase __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.ImageViewTouchBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxZoom ();
		}
#pragma warning restore 0169

		static IntPtr id_maxZoom;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageViewTouchBase']/method[@name='maxZoom' and count(parameter)=0]"
		[Register ("maxZoom", "()F", "GetMaxZoomHandler")]
		protected virtual float MaxZoom ()
		{
			if (id_maxZoom == IntPtr.Zero)
				id_maxZoom = JNIEnv.GetMethodID (class_ref, "maxZoom", "()F");

			if (GetType () == ThresholdType)
				return JNIEnv.CallFloatMethod  (Handle, id_maxZoom);
			else
				return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "maxZoom", "()F"));
		}

		static Delegate cb_panBy_FF;
#pragma warning disable 0169
		static Delegate GetPanBy_FFHandler ()
		{
			if (cb_panBy_FF == null)
				cb_panBy_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_PanBy_FF);
			return cb_panBy_FF;
		}

		static void n_PanBy_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
		{
			global::Com.Android.Camera.ImageViewTouchBase __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.ImageViewTouchBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PanBy (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_panBy_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageViewTouchBase']/method[@name='panBy' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("panBy", "(FF)V", "GetPanBy_FFHandler")]
		protected virtual void PanBy (float p0, float p1)
		{
			if (id_panBy_FF == IntPtr.Zero)
				id_panBy_FF = JNIEnv.GetMethodID (class_ref, "panBy", "(FF)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_panBy_FF, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "panBy", "(FF)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_postTranslate_FF;
#pragma warning disable 0169
		static Delegate GetPostTranslate_FFHandler ()
		{
			if (cb_postTranslate_FF == null)
				cb_postTranslate_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_PostTranslate_FF);
			return cb_postTranslate_FF;
		}

		static void n_PostTranslate_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
		{
			global::Com.Android.Camera.ImageViewTouchBase __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.ImageViewTouchBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PostTranslate (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_postTranslate_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageViewTouchBase']/method[@name='postTranslate' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("postTranslate", "(FF)V", "GetPostTranslate_FFHandler")]
		protected virtual void PostTranslate (float p0, float p1)
		{
			if (id_postTranslate_FF == IntPtr.Zero)
				id_postTranslate_FF = JNIEnv.GetMethodID (class_ref, "postTranslate", "(FF)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_postTranslate_FF, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "postTranslate", "(FF)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_setImageBitmapResetBase_Landroid_graphics_Bitmap_Z;
#pragma warning disable 0169
		static Delegate GetSetImageBitmapResetBase_Landroid_graphics_Bitmap_ZHandler ()
		{
			if (cb_setImageBitmapResetBase_Landroid_graphics_Bitmap_Z == null)
				cb_setImageBitmapResetBase_Landroid_graphics_Bitmap_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_SetImageBitmapResetBase_Landroid_graphics_Bitmap_Z);
			return cb_setImageBitmapResetBase_Landroid_graphics_Bitmap_Z;
		}

		static void n_SetImageBitmapResetBase_Landroid_graphics_Bitmap_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Android.Camera.ImageViewTouchBase __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.ImageViewTouchBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetImageBitmapResetBase (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setImageBitmapResetBase_Landroid_graphics_Bitmap_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageViewTouchBase']/method[@name='setImageBitmapResetBase' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='boolean']]"
		[Register ("setImageBitmapResetBase", "(Landroid/graphics/Bitmap;Z)V", "GetSetImageBitmapResetBase_Landroid_graphics_Bitmap_ZHandler")]
		public virtual void SetImageBitmapResetBase (global::Android.Graphics.Bitmap p0, bool p1)
		{
			if (id_setImageBitmapResetBase_Landroid_graphics_Bitmap_Z == IntPtr.Zero)
				id_setImageBitmapResetBase_Landroid_graphics_Bitmap_Z = JNIEnv.GetMethodID (class_ref, "setImageBitmapResetBase", "(Landroid/graphics/Bitmap;Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setImageBitmapResetBase_Landroid_graphics_Bitmap_Z, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImageBitmapResetBase", "(Landroid/graphics/Bitmap;Z)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_setImageRotateBitmapResetBase_Lcom_android_camera_RotateBitmap_Z;
#pragma warning disable 0169
		static Delegate GetSetImageRotateBitmapResetBase_Lcom_android_camera_RotateBitmap_ZHandler ()
		{
			if (cb_setImageRotateBitmapResetBase_Lcom_android_camera_RotateBitmap_Z == null)
				cb_setImageRotateBitmapResetBase_Lcom_android_camera_RotateBitmap_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_SetImageRotateBitmapResetBase_Lcom_android_camera_RotateBitmap_Z);
			return cb_setImageRotateBitmapResetBase_Lcom_android_camera_RotateBitmap_Z;
		}

		static void n_SetImageRotateBitmapResetBase_Lcom_android_camera_RotateBitmap_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Android.Camera.ImageViewTouchBase __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.ImageViewTouchBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Android.Camera.RotateBitmap p0 = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.RotateBitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetImageRotateBitmapResetBase (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setImageRotateBitmapResetBase_Lcom_android_camera_RotateBitmap_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageViewTouchBase']/method[@name='setImageRotateBitmapResetBase' and count(parameter)=2 and parameter[1][@type='com.android.camera.RotateBitmap'] and parameter[2][@type='boolean']]"
		[Register ("setImageRotateBitmapResetBase", "(Lcom/android/camera/RotateBitmap;Z)V", "GetSetImageRotateBitmapResetBase_Lcom_android_camera_RotateBitmap_ZHandler")]
		public virtual void SetImageRotateBitmapResetBase (global::Com.Android.Camera.RotateBitmap p0, bool p1)
		{
			if (id_setImageRotateBitmapResetBase_Lcom_android_camera_RotateBitmap_Z == IntPtr.Zero)
				id_setImageRotateBitmapResetBase_Lcom_android_camera_RotateBitmap_Z = JNIEnv.GetMethodID (class_ref, "setImageRotateBitmapResetBase", "(Lcom/android/camera/RotateBitmap;Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setImageRotateBitmapResetBase_Lcom_android_camera_RotateBitmap_Z, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImageRotateBitmapResetBase", "(Lcom/android/camera/RotateBitmap;Z)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_setRecycler_Lcom_android_camera_ImageViewTouchBase_Recycler_;
#pragma warning disable 0169
		static Delegate GetSetRecycler_Lcom_android_camera_ImageViewTouchBase_Recycler_Handler ()
		{
			if (cb_setRecycler_Lcom_android_camera_ImageViewTouchBase_Recycler_ == null)
				cb_setRecycler_Lcom_android_camera_ImageViewTouchBase_Recycler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRecycler_Lcom_android_camera_ImageViewTouchBase_Recycler_);
			return cb_setRecycler_Lcom_android_camera_ImageViewTouchBase_Recycler_;
		}

		static void n_SetRecycler_Lcom_android_camera_ImageViewTouchBase_Recycler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Android.Camera.ImageViewTouchBase __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.ImageViewTouchBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Android.Camera.ImageViewTouchBase.IRecycler p0 = (global::Com.Android.Camera.ImageViewTouchBase.IRecycler)global::Java.Lang.Object.GetObject<global::Com.Android.Camera.ImageViewTouchBase.IRecycler> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetRecycler (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setRecycler_Lcom_android_camera_ImageViewTouchBase_Recycler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageViewTouchBase']/method[@name='setRecycler' and count(parameter)=1 and parameter[1][@type='com.android.camera.ImageViewTouchBase.Recycler']]"
		[Register ("setRecycler", "(Lcom/android/camera/ImageViewTouchBase$Recycler;)V", "GetSetRecycler_Lcom_android_camera_ImageViewTouchBase_Recycler_Handler")]
		public virtual void SetRecycler (global::Com.Android.Camera.ImageViewTouchBase.IRecycler p0)
		{
			if (id_setRecycler_Lcom_android_camera_ImageViewTouchBase_Recycler_ == IntPtr.Zero)
				id_setRecycler_Lcom_android_camera_ImageViewTouchBase_Recycler_ = JNIEnv.GetMethodID (class_ref, "setRecycler", "(Lcom/android/camera/ImageViewTouchBase$Recycler;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setRecycler_Lcom_android_camera_ImageViewTouchBase_Recycler_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRecycler", "(Lcom/android/camera/ImageViewTouchBase$Recycler;)V"), new JValue (p0));
		}

		static Delegate cb_zoomIn;
#pragma warning disable 0169
		static Delegate GetZoomInHandler ()
		{
			if (cb_zoomIn == null)
				cb_zoomIn = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ZoomIn);
			return cb_zoomIn;
		}

		static void n_ZoomIn (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Android.Camera.ImageViewTouchBase __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.ImageViewTouchBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomIn ();
		}
#pragma warning restore 0169

		static IntPtr id_zoomIn;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageViewTouchBase']/method[@name='zoomIn' and count(parameter)=0]"
		[Register ("zoomIn", "()V", "GetZoomInHandler")]
		protected virtual void ZoomIn ()
		{
			if (id_zoomIn == IntPtr.Zero)
				id_zoomIn = JNIEnv.GetMethodID (class_ref, "zoomIn", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_zoomIn);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "zoomIn", "()V"));
		}

		static Delegate cb_zoomIn_F;
#pragma warning disable 0169
		static Delegate GetZoomIn_FHandler ()
		{
			if (cb_zoomIn_F == null)
				cb_zoomIn_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_ZoomIn_F);
			return cb_zoomIn_F;
		}

		static void n_ZoomIn_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Android.Camera.ImageViewTouchBase __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.ImageViewTouchBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomIn (p0);
		}
#pragma warning restore 0169

		static IntPtr id_zoomIn_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageViewTouchBase']/method[@name='zoomIn' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("zoomIn", "(F)V", "GetZoomIn_FHandler")]
		protected virtual void ZoomIn (float p0)
		{
			if (id_zoomIn_F == IntPtr.Zero)
				id_zoomIn_F = JNIEnv.GetMethodID (class_ref, "zoomIn", "(F)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_zoomIn_F, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "zoomIn", "(F)V"), new JValue (p0));
		}

		static Delegate cb_zoomOut;
#pragma warning disable 0169
		static Delegate GetZoomOutHandler ()
		{
			if (cb_zoomOut == null)
				cb_zoomOut = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ZoomOut);
			return cb_zoomOut;
		}

		static void n_ZoomOut (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Android.Camera.ImageViewTouchBase __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.ImageViewTouchBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomOut ();
		}
#pragma warning restore 0169

		static IntPtr id_zoomOut;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageViewTouchBase']/method[@name='zoomOut' and count(parameter)=0]"
		[Register ("zoomOut", "()V", "GetZoomOutHandler")]
		protected virtual void ZoomOut ()
		{
			if (id_zoomOut == IntPtr.Zero)
				id_zoomOut = JNIEnv.GetMethodID (class_ref, "zoomOut", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_zoomOut);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "zoomOut", "()V"));
		}

		static Delegate cb_zoomOut_F;
#pragma warning disable 0169
		static Delegate GetZoomOut_FHandler ()
		{
			if (cb_zoomOut_F == null)
				cb_zoomOut_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_ZoomOut_F);
			return cb_zoomOut_F;
		}

		static void n_ZoomOut_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Android.Camera.ImageViewTouchBase __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.ImageViewTouchBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomOut (p0);
		}
#pragma warning restore 0169

		static IntPtr id_zoomOut_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageViewTouchBase']/method[@name='zoomOut' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("zoomOut", "(F)V", "GetZoomOut_FHandler")]
		protected virtual void ZoomOut (float p0)
		{
			if (id_zoomOut_F == IntPtr.Zero)
				id_zoomOut_F = JNIEnv.GetMethodID (class_ref, "zoomOut", "(F)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_zoomOut_F, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "zoomOut", "(F)V"), new JValue (p0));
		}

		static Delegate cb_zoomTo_F;
#pragma warning disable 0169
		static Delegate GetZoomTo_FHandler ()
		{
			if (cb_zoomTo_F == null)
				cb_zoomTo_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_ZoomTo_F);
			return cb_zoomTo_F;
		}

		static void n_ZoomTo_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Android.Camera.ImageViewTouchBase __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.ImageViewTouchBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomTo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_zoomTo_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageViewTouchBase']/method[@name='zoomTo' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("zoomTo", "(F)V", "GetZoomTo_FHandler")]
		protected virtual void ZoomTo (float p0)
		{
			if (id_zoomTo_F == IntPtr.Zero)
				id_zoomTo_F = JNIEnv.GetMethodID (class_ref, "zoomTo", "(F)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_zoomTo_F, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "zoomTo", "(F)V"), new JValue (p0));
		}

		static Delegate cb_zoomTo_FFF;
#pragma warning disable 0169
		static Delegate GetZoomTo_FFFHandler ()
		{
			if (cb_zoomTo_FFF == null)
				cb_zoomTo_FFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float>) n_ZoomTo_FFF);
			return cb_zoomTo_FFF;
		}

		static void n_ZoomTo_FFF (IntPtr jnienv, IntPtr native__this, float p0, float p1, float p2)
		{
			global::Com.Android.Camera.ImageViewTouchBase __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.ImageViewTouchBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomTo (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_zoomTo_FFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageViewTouchBase']/method[@name='zoomTo' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("zoomTo", "(FFF)V", "GetZoomTo_FFFHandler")]
		protected virtual void ZoomTo (float p0, float p1, float p2)
		{
			if (id_zoomTo_FFF == IntPtr.Zero)
				id_zoomTo_FFF = JNIEnv.GetMethodID (class_ref, "zoomTo", "(FFF)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_zoomTo_FFF, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "zoomTo", "(FFF)V"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_zoomTo_FFFF;
#pragma warning disable 0169
		static Delegate GetZoomTo_FFFFHandler ()
		{
			if (cb_zoomTo_FFFF == null)
				cb_zoomTo_FFFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float, float>) n_ZoomTo_FFFF);
			return cb_zoomTo_FFFF;
		}

		static void n_ZoomTo_FFFF (IntPtr jnienv, IntPtr native__this, float p0, float p1, float p2, float p3)
		{
			global::Com.Android.Camera.ImageViewTouchBase __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.ImageViewTouchBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomTo (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_zoomTo_FFFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageViewTouchBase']/method[@name='zoomTo' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("zoomTo", "(FFFF)V", "GetZoomTo_FFFFHandler")]
		protected virtual void ZoomTo (float p0, float p1, float p2, float p3)
		{
			if (id_zoomTo_FFFF == IntPtr.Zero)
				id_zoomTo_FFFF = JNIEnv.GetMethodID (class_ref, "zoomTo", "(FFFF)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_zoomTo_FFFF, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "zoomTo", "(FFFF)V"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
		}

		static Delegate cb_zoomToPoint_FFF;
#pragma warning disable 0169
		static Delegate GetZoomToPoint_FFFHandler ()
		{
			if (cb_zoomToPoint_FFF == null)
				cb_zoomToPoint_FFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float>) n_ZoomToPoint_FFF);
			return cb_zoomToPoint_FFF;
		}

		static void n_ZoomToPoint_FFF (IntPtr jnienv, IntPtr native__this, float p0, float p1, float p2)
		{
			global::Com.Android.Camera.ImageViewTouchBase __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.ImageViewTouchBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomToPoint (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_zoomToPoint_FFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='ImageViewTouchBase']/method[@name='zoomToPoint' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("zoomToPoint", "(FFF)V", "GetZoomToPoint_FFFHandler")]
		protected virtual void ZoomToPoint (float p0, float p1, float p2)
		{
			if (id_zoomToPoint_FFF == IntPtr.Zero)
				id_zoomToPoint_FFF = JNIEnv.GetMethodID (class_ref, "zoomToPoint", "(FFF)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_zoomToPoint_FFF, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "zoomToPoint", "(FFF)V"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

	}

	[global::Android.Runtime.Register ("com/android/camera/ImageViewTouchBase", DoNotGenerateAcw=true)]
	internal partial class ImageViewTouchBaseInvoker : ImageViewTouchBase {

		public ImageViewTouchBaseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageViewTouchBaseInvoker); }
		}

	}

}
