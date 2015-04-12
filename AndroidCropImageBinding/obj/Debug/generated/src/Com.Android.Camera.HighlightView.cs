using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Android.Camera {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.android.camera']/class[@name='HighlightView']"
	[global::Android.Runtime.Register ("com/android/camera/HighlightView", DoNotGenerateAcw=true)]
	public partial class HighlightView : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='HighlightView']/field[@name='DEFAULT_OUTLINE_CIRCLE_COLOR']"
		[Register ("DEFAULT_OUTLINE_CIRCLE_COLOR")]
		public const int DefaultOutlineCircleColor = (int) -1112874;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='HighlightView']/field[@name='DEFAULT_OUTLINE_COLOR']"
		[Register ("DEFAULT_OUTLINE_COLOR")]
		public const int DefaultOutlineColor = (int) -30208;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='HighlightView']/field[@name='GROW_BOTTOM_EDGE']"
		[Register ("GROW_BOTTOM_EDGE")]
		public const int GrowBottomEdge = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='HighlightView']/field[@name='GROW_LEFT_EDGE']"
		[Register ("GROW_LEFT_EDGE")]
		public const int GrowLeftEdge = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='HighlightView']/field[@name='GROW_NONE']"
		[Register ("GROW_NONE")]
		public const int GrowNone = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='HighlightView']/field[@name='GROW_RIGHT_EDGE']"
		[Register ("GROW_RIGHT_EDGE")]
		public const int GrowRightEdge = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='HighlightView']/field[@name='GROW_TOP_EDGE']"
		[Register ("GROW_TOP_EDGE")]
		public const int GrowTopEdge = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='HighlightView']/field[@name='MOVE']"
		[Register ("MOVE")]
		public const int Move = (int) 32;

		static IntPtr mCropRect_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='HighlightView']/field[@name='mCropRect']"
		[Register ("mCropRect")]
		public global::Android.Graphics.RectF MCropRect {
			get {
				if (mCropRect_jfieldId == IntPtr.Zero)
					mCropRect_jfieldId = JNIEnv.GetFieldID (class_ref, "mCropRect", "Landroid/graphics/RectF;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mCropRect_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCropRect_jfieldId == IntPtr.Zero)
					mCropRect_jfieldId = JNIEnv.GetFieldID (class_ref, "mCropRect", "Landroid/graphics/RectF;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mCropRect_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mDrawRect_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='HighlightView']/field[@name='mDrawRect']"
		[Register ("mDrawRect")]
		public global::Android.Graphics.Rect MDrawRect {
			get {
				if (mDrawRect_jfieldId == IntPtr.Zero)
					mDrawRect_jfieldId = JNIEnv.GetFieldID (class_ref, "mDrawRect", "Landroid/graphics/Rect;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mDrawRect_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mDrawRect_jfieldId == IntPtr.Zero)
					mDrawRect_jfieldId = JNIEnv.GetFieldID (class_ref, "mDrawRect", "Landroid/graphics/Rect;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mDrawRect_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mIsFocused_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='HighlightView']/field[@name='mIsFocused']"
		[Register ("mIsFocused")]
		public bool MIsFocused {
			get {
				if (mIsFocused_jfieldId == IntPtr.Zero)
					mIsFocused_jfieldId = JNIEnv.GetFieldID (class_ref, "mIsFocused", "Z");
				return JNIEnv.GetBooleanField (Handle, mIsFocused_jfieldId);
			}
			set {
				if (mIsFocused_jfieldId == IntPtr.Zero)
					mIsFocused_jfieldId = JNIEnv.GetFieldID (class_ref, "mIsFocused", "Z");
				JNIEnv.SetField (Handle, mIsFocused_jfieldId, value);
			}
		}

		static IntPtr mMatrix_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='HighlightView']/field[@name='mMatrix']"
		[Register ("mMatrix")]
		public global::Android.Graphics.Matrix MMatrix {
			get {
				if (mMatrix_jfieldId == IntPtr.Zero)
					mMatrix_jfieldId = JNIEnv.GetFieldID (class_ref, "mMatrix", "Landroid/graphics/Matrix;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mMatrix_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMatrix_jfieldId == IntPtr.Zero)
					mMatrix_jfieldId = JNIEnv.GetFieldID (class_ref, "mMatrix", "Landroid/graphics/Matrix;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mMatrix_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mMode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='HighlightView']/field[@name='mMode']"
		[Register ("mMode")]
		public global::Com.Android.Camera.HighlightView.ModifyMode MMode {
			get {
				if (mMode_jfieldId == IntPtr.Zero)
					mMode_jfieldId = JNIEnv.GetFieldID (class_ref, "mMode", "Lcom/android/camera/HighlightView$ModifyMode;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mMode_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Android.Camera.HighlightView.ModifyMode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMode_jfieldId == IntPtr.Zero)
					mMode_jfieldId = JNIEnv.GetFieldID (class_ref, "mMode", "Lcom/android/camera/HighlightView$ModifyMode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mMode_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.android.camera']/class[@name='HighlightView.ModifyMode']"
		[global::Android.Runtime.Register ("com/android/camera/HighlightView$ModifyMode", DoNotGenerateAcw=true)]
		public sealed partial class ModifyMode : global::Java.Lang.Enum {


			static IntPtr Grow_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='HighlightView.ModifyMode']/field[@name='Grow']"
			[Register ("Grow")]
			public static global::Com.Android.Camera.HighlightView.ModifyMode Grow {
				get {
					if (Grow_jfieldId == IntPtr.Zero)
						Grow_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Grow", "Lcom/android/camera/HighlightView$ModifyMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Grow_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Android.Camera.HighlightView.ModifyMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (Grow_jfieldId == IntPtr.Zero)
						Grow_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Grow", "Lcom/android/camera/HighlightView$ModifyMode;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, Grow_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr Move_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='HighlightView.ModifyMode']/field[@name='Move']"
			[Register ("Move")]
			public static global::Com.Android.Camera.HighlightView.ModifyMode Move {
				get {
					if (Move_jfieldId == IntPtr.Zero)
						Move_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Move", "Lcom/android/camera/HighlightView$ModifyMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Move_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Android.Camera.HighlightView.ModifyMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (Move_jfieldId == IntPtr.Zero)
						Move_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Move", "Lcom/android/camera/HighlightView$ModifyMode;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, Move_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr None_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='HighlightView.ModifyMode']/field[@name='None']"
			[Register ("None")]
			public static global::Com.Android.Camera.HighlightView.ModifyMode None {
				get {
					if (None_jfieldId == IntPtr.Zero)
						None_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "None", "Lcom/android/camera/HighlightView$ModifyMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, None_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Android.Camera.HighlightView.ModifyMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (None_jfieldId == IntPtr.Zero)
						None_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "None", "Lcom/android/camera/HighlightView$ModifyMode;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, None_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/android/camera/HighlightView$ModifyMode", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ModifyMode); }
			}

			internal ModifyMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='HighlightView.ModifyMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/android/camera/HighlightView$ModifyMode;", "")]
			public static global::Com.Android.Camera.HighlightView.ModifyMode ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/android/camera/HighlightView$ModifyMode;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Android.Camera.HighlightView.ModifyMode __ret = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.HighlightView.ModifyMode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='HighlightView.ModifyMode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/android/camera/HighlightView$ModifyMode;", "")]
			public static global::Com.Android.Camera.HighlightView.ModifyMode[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/android/camera/HighlightView$ModifyMode;");
				return (global::Com.Android.Camera.HighlightView.ModifyMode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Android.Camera.HighlightView.ModifyMode));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/android/camera/HighlightView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HighlightView); }
		}

		protected HighlightView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_view_View_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.android.camera']/class[@name='HighlightView']/constructor[@name='HighlightView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register (".ctor", "(Landroid/view/View;)V", "")]
		public HighlightView (global::Android.Views.View p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (HighlightView)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/view/View;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/view/View;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_view_View_ == IntPtr.Zero)
				id_ctor_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/view/View;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_view_View_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_view_View_, new JValue (p0));
		}

		static IntPtr id_ctor_Landroid_view_View_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.android.camera']/class[@name='HighlightView']/constructor[@name='HighlightView' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/view/View;II)V", "")]
		public HighlightView (global::Android.Views.View p0, int p1, int p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (HighlightView)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/view/View;II)V", new JValue (p0), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/view/View;II)V", new JValue (p0), new JValue (p1), new JValue (p2));
				return;
			}

			if (id_ctor_Landroid_view_View_II == IntPtr.Zero)
				id_ctor_Landroid_view_View_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/view/View;II)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_view_View_II, new JValue (p0), new JValue (p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_view_View_II, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_getCropRect;
#pragma warning disable 0169
		static Delegate GetGetCropRectHandler ()
		{
			if (cb_getCropRect == null)
				cb_getCropRect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCropRect);
			return cb_getCropRect;
		}

		static IntPtr n_GetCropRect (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Android.Camera.HighlightView __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.HighlightView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CropRect);
		}
#pragma warning restore 0169

		static IntPtr id_getCropRect;
		public virtual global::Android.Graphics.Rect CropRect {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='HighlightView']/method[@name='getCropRect' and count(parameter)=0]"
			[Register ("getCropRect", "()Landroid/graphics/Rect;", "GetGetCropRectHandler")]
			get {
				if (id_getCropRect == IntPtr.Zero)
					id_getCropRect = JNIEnv.GetMethodID (class_ref, "getCropRect", "()Landroid/graphics/Rect;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (JNIEnv.CallObjectMethod  (Handle, id_getCropRect), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCropRect", "()Landroid/graphics/Rect;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_hasFocus;
#pragma warning disable 0169
		static Delegate GetHasFocusHandler ()
		{
			if (cb_hasFocus == null)
				cb_hasFocus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasFocus);
			return cb_hasFocus;
		}

		static bool n_HasFocus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Android.Camera.HighlightView __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.HighlightView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasFocus;
		}
#pragma warning restore 0169

		static IntPtr id_hasFocus;
		public virtual bool HasFocus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='HighlightView']/method[@name='hasFocus' and count(parameter)=0]"
			[Register ("hasFocus", "()Z", "GetHasFocusHandler")]
			get {
				if (id_hasFocus == IntPtr.Zero)
					id_hasFocus = JNIEnv.GetMethodID (class_ref, "hasFocus", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_hasFocus);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasFocus", "()Z"));
			}
		}

		static Delegate cb_draw_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetDraw_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_draw_Landroid_graphics_Canvas_ == null)
				cb_draw_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Draw_Landroid_graphics_Canvas_);
			return cb_draw_Landroid_graphics_Canvas_;
		}

		static void n_Draw_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Android.Camera.HighlightView __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.HighlightView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Draw (p0);
		}
#pragma warning restore 0169

		static IntPtr id_draw_Landroid_graphics_Canvas_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='HighlightView']/method[@name='draw' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("draw", "(Landroid/graphics/Canvas;)V", "GetDraw_Landroid_graphics_Canvas_Handler")]
		public virtual void Draw (global::Android.Graphics.Canvas p0)
		{
			if (id_draw_Landroid_graphics_Canvas_ == IntPtr.Zero)
				id_draw_Landroid_graphics_Canvas_ = JNIEnv.GetMethodID (class_ref, "draw", "(Landroid/graphics/Canvas;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_draw_Landroid_graphics_Canvas_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "draw", "(Landroid/graphics/Canvas;)V"), new JValue (p0));
		}

		static Delegate cb_getHit_FF;
#pragma warning disable 0169
		static Delegate GetGetHit_FFHandler ()
		{
			if (cb_getHit_FF == null)
				cb_getHit_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, int>) n_GetHit_FF);
			return cb_getHit_FF;
		}

		static int n_GetHit_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
		{
			global::Com.Android.Camera.HighlightView __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.HighlightView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetHit (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_getHit_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='HighlightView']/method[@name='getHit' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("getHit", "(FF)I", "GetGetHit_FFHandler")]
		public virtual int GetHit (float p0, float p1)
		{
			if (id_getHit_FF == IntPtr.Zero)
				id_getHit_FF = JNIEnv.GetMethodID (class_ref, "getHit", "(FF)I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_getHit_FF, new JValue (p0), new JValue (p1));
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHit", "(FF)I"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_handleMotion_IFF;
#pragma warning disable 0169
		static Delegate GetHandleMotion_IFFHandler ()
		{
			if (cb_handleMotion_IFF == null)
				cb_handleMotion_IFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, float, float>) n_HandleMotion_IFF);
			return cb_handleMotion_IFF;
		}

		static void n_HandleMotion_IFF (IntPtr jnienv, IntPtr native__this, int p0, float p1, float p2)
		{
			global::Com.Android.Camera.HighlightView __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.HighlightView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HandleMotion (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_handleMotion_IFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='HighlightView']/method[@name='handleMotion' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("handleMotion", "(IFF)V", "GetHandleMotion_IFFHandler")]
		public virtual void HandleMotion (int p0, float p1, float p2)
		{
			if (id_handleMotion_IFF == IntPtr.Zero)
				id_handleMotion_IFF = JNIEnv.GetMethodID (class_ref, "handleMotion", "(IFF)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_handleMotion_IFF, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleMotion", "(IFF)V"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_invalidate;
#pragma warning disable 0169
		static Delegate GetInvalidateHandler ()
		{
			if (cb_invalidate == null)
				cb_invalidate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Invalidate);
			return cb_invalidate;
		}

		static void n_Invalidate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Android.Camera.HighlightView __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.HighlightView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Invalidate ();
		}
#pragma warning restore 0169

		static IntPtr id_invalidate;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='HighlightView']/method[@name='invalidate' and count(parameter)=0]"
		[Register ("invalidate", "()V", "GetInvalidateHandler")]
		public virtual void Invalidate ()
		{
			if (id_invalidate == IntPtr.Zero)
				id_invalidate = JNIEnv.GetMethodID (class_ref, "invalidate", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_invalidate);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "invalidate", "()V"));
		}

		static Delegate cb_setFocus_Z;
#pragma warning disable 0169
		static Delegate GetSetFocus_ZHandler ()
		{
			if (cb_setFocus_Z == null)
				cb_setFocus_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetFocus_Z);
			return cb_setFocus_Z;
		}

		static void n_SetFocus_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Android.Camera.HighlightView __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.HighlightView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFocus (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setFocus_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='HighlightView']/method[@name='setFocus' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setFocus", "(Z)V", "GetSetFocus_ZHandler")]
		public virtual void SetFocus (bool p0)
		{
			if (id_setFocus_Z == IntPtr.Zero)
				id_setFocus_Z = JNIEnv.GetMethodID (class_ref, "setFocus", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setFocus_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFocus", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_setHidden_Z;
#pragma warning disable 0169
		static Delegate GetSetHidden_ZHandler ()
		{
			if (cb_setHidden_Z == null)
				cb_setHidden_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetHidden_Z);
			return cb_setHidden_Z;
		}

		static void n_SetHidden_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Android.Camera.HighlightView __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.HighlightView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetHidden (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setHidden_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='HighlightView']/method[@name='setHidden' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setHidden", "(Z)V", "GetSetHidden_ZHandler")]
		public virtual void SetHidden (bool p0)
		{
			if (id_setHidden_Z == IntPtr.Zero)
				id_setHidden_Z = JNIEnv.GetMethodID (class_ref, "setHidden", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setHidden_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHidden", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_setMode_Lcom_android_camera_HighlightView_ModifyMode_;
#pragma warning disable 0169
		static Delegate GetSetMode_Lcom_android_camera_HighlightView_ModifyMode_Handler ()
		{
			if (cb_setMode_Lcom_android_camera_HighlightView_ModifyMode_ == null)
				cb_setMode_Lcom_android_camera_HighlightView_ModifyMode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMode_Lcom_android_camera_HighlightView_ModifyMode_);
			return cb_setMode_Lcom_android_camera_HighlightView_ModifyMode_;
		}

		static void n_SetMode_Lcom_android_camera_HighlightView_ModifyMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Android.Camera.HighlightView __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.HighlightView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Android.Camera.HighlightView.ModifyMode p0 = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.HighlightView.ModifyMode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMode_Lcom_android_camera_HighlightView_ModifyMode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='HighlightView']/method[@name='setMode' and count(parameter)=1 and parameter[1][@type='com.android.camera.HighlightView.ModifyMode']]"
		[Register ("setMode", "(Lcom/android/camera/HighlightView$ModifyMode;)V", "GetSetMode_Lcom_android_camera_HighlightView_ModifyMode_Handler")]
		public virtual void SetMode (global::Com.Android.Camera.HighlightView.ModifyMode p0)
		{
			if (id_setMode_Lcom_android_camera_HighlightView_ModifyMode_ == IntPtr.Zero)
				id_setMode_Lcom_android_camera_HighlightView_ModifyMode_ = JNIEnv.GetMethodID (class_ref, "setMode", "(Lcom/android/camera/HighlightView$ModifyMode;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setMode_Lcom_android_camera_HighlightView_ModifyMode_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMode", "(Lcom/android/camera/HighlightView$ModifyMode;)V"), new JValue (p0));
		}

		static Delegate cb_setup_Landroid_graphics_Matrix_Landroid_graphics_Rect_Landroid_graphics_RectF_ZZ;
#pragma warning disable 0169
		static Delegate GetSetup_Landroid_graphics_Matrix_Landroid_graphics_Rect_Landroid_graphics_RectF_ZZHandler ()
		{
			if (cb_setup_Landroid_graphics_Matrix_Landroid_graphics_Rect_Landroid_graphics_RectF_ZZ == null)
				cb_setup_Landroid_graphics_Matrix_Landroid_graphics_Rect_Landroid_graphics_RectF_ZZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool, bool>) n_Setup_Landroid_graphics_Matrix_Landroid_graphics_Rect_Landroid_graphics_RectF_ZZ);
			return cb_setup_Landroid_graphics_Matrix_Landroid_graphics_Rect_Landroid_graphics_RectF_ZZ;
		}

		static void n_Setup_Landroid_graphics_Matrix_Landroid_graphics_Rect_Landroid_graphics_RectF_ZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, bool p3, bool p4)
		{
			global::Com.Android.Camera.HighlightView __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.HighlightView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Matrix p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Rect p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.RectF p2 = global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Setup (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_setup_Landroid_graphics_Matrix_Landroid_graphics_Rect_Landroid_graphics_RectF_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='HighlightView']/method[@name='setup' and count(parameter)=5 and parameter[1][@type='android.graphics.Matrix'] and parameter[2][@type='android.graphics.Rect'] and parameter[3][@type='android.graphics.RectF'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean']]"
		[Register ("setup", "(Landroid/graphics/Matrix;Landroid/graphics/Rect;Landroid/graphics/RectF;ZZ)V", "GetSetup_Landroid_graphics_Matrix_Landroid_graphics_Rect_Landroid_graphics_RectF_ZZHandler")]
		public virtual void Setup (global::Android.Graphics.Matrix p0, global::Android.Graphics.Rect p1, global::Android.Graphics.RectF p2, bool p3, bool p4)
		{
			if (id_setup_Landroid_graphics_Matrix_Landroid_graphics_Rect_Landroid_graphics_RectF_ZZ == IntPtr.Zero)
				id_setup_Landroid_graphics_Matrix_Landroid_graphics_Rect_Landroid_graphics_RectF_ZZ = JNIEnv.GetMethodID (class_ref, "setup", "(Landroid/graphics/Matrix;Landroid/graphics/Rect;Landroid/graphics/RectF;ZZ)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setup_Landroid_graphics_Matrix_Landroid_graphics_Rect_Landroid_graphics_RectF_ZZ, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setup", "(Landroid/graphics/Matrix;Landroid/graphics/Rect;Landroid/graphics/RectF;ZZ)V"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
		}

	}
}
