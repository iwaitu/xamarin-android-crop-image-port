using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Android.Camera {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.android.camera']/class[@name='CropImageView']"
	[global::Android.Runtime.Register ("com/android/camera/CropImageView", DoNotGenerateAcw=true)]
	public partial class CropImageView : global::Com.Android.Camera.ImageViewTouchBase {


		static IntPtr mHighlightViews_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='CropImageView']/field[@name='mHighlightViews']"
		[Register ("mHighlightViews")]
		public global::System.Collections.IList MHighlightViews {
			get {
				if (mHighlightViews_jfieldId == IntPtr.Zero)
					mHighlightViews_jfieldId = JNIEnv.GetFieldID (class_ref, "mHighlightViews", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mHighlightViews_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mHighlightViews_jfieldId == IntPtr.Zero)
					mHighlightViews_jfieldId = JNIEnv.GetFieldID (class_ref, "mHighlightViews", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mHighlightViews_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mMotionHighlightView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.camera']/class[@name='CropImageView']/field[@name='mMotionHighlightView']"
		[Register ("mMotionHighlightView")]
		public global::Com.Android.Camera.HighlightView MMotionHighlightView {
			get {
				if (mMotionHighlightView_jfieldId == IntPtr.Zero)
					mMotionHighlightView_jfieldId = JNIEnv.GetFieldID (class_ref, "mMotionHighlightView", "Lcom/android/camera/HighlightView;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mMotionHighlightView_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Android.Camera.HighlightView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMotionHighlightView_jfieldId == IntPtr.Zero)
					mMotionHighlightView_jfieldId = JNIEnv.GetFieldID (class_ref, "mMotionHighlightView", "Lcom/android/camera/HighlightView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mMotionHighlightView_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/android/camera/CropImageView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CropImageView); }
		}

		protected CropImageView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.android.camera']/class[@name='CropImageView']/constructor[@name='CropImageView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public CropImageView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CropImageView)) {
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

		static Delegate cb_add_Lcom_android_camera_HighlightView_;
#pragma warning disable 0169
		static Delegate GetAdd_Lcom_android_camera_HighlightView_Handler ()
		{
			if (cb_add_Lcom_android_camera_HighlightView_ == null)
				cb_add_Lcom_android_camera_HighlightView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Add_Lcom_android_camera_HighlightView_);
			return cb_add_Lcom_android_camera_HighlightView_;
		}

		static void n_Add_Lcom_android_camera_HighlightView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Android.Camera.CropImageView __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Android.Camera.HighlightView p0 = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.HighlightView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0);
		}
#pragma warning restore 0169

		static IntPtr id_add_Lcom_android_camera_HighlightView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='CropImageView']/method[@name='add' and count(parameter)=1 and parameter[1][@type='com.android.camera.HighlightView']]"
		[Register ("add", "(Lcom/android/camera/HighlightView;)V", "GetAdd_Lcom_android_camera_HighlightView_Handler")]
		public virtual void Add (global::Com.Android.Camera.HighlightView p0)
		{
			if (id_add_Lcom_android_camera_HighlightView_ == IntPtr.Zero)
				id_add_Lcom_android_camera_HighlightView_ = JNIEnv.GetMethodID (class_ref, "add", "(Lcom/android/camera/HighlightView;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_add_Lcom_android_camera_HighlightView_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Lcom/android/camera/HighlightView;)V"), new JValue (p0));
		}

	}
}
