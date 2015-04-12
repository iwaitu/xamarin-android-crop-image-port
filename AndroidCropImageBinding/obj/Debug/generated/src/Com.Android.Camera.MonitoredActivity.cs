using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Android.Camera {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.android.camera']/class[@name='MonitoredActivity']"
	[global::Android.Runtime.Register ("com/android/camera/MonitoredActivity", DoNotGenerateAcw=true)]
	public partial class MonitoredActivity : global::Com.Android.Camera.NoSearchActivity {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.android.camera']/class[@name='MonitoredActivity.LifeCycleAdapter']"
		[global::Android.Runtime.Register ("com/android/camera/MonitoredActivity$LifeCycleAdapter", DoNotGenerateAcw=true)]
		public partial class LifeCycleAdapter : global::Java.Lang.Object, global::Com.Android.Camera.MonitoredActivity.ILifeCycleListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/android/camera/MonitoredActivity$LifeCycleAdapter", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LifeCycleAdapter); }
			}

			protected LifeCycleAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.android.camera']/class[@name='MonitoredActivity.LifeCycleAdapter']/constructor[@name='MonitoredActivity.LifeCycleAdapter' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public LifeCycleAdapter () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (LifeCycleAdapter)) {
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

			static Delegate cb_onActivityCreated_Lcom_android_camera_MonitoredActivity_;
#pragma warning disable 0169
			static Delegate GetOnActivityCreated_Lcom_android_camera_MonitoredActivity_Handler ()
			{
				if (cb_onActivityCreated_Lcom_android_camera_MonitoredActivity_ == null)
					cb_onActivityCreated_Lcom_android_camera_MonitoredActivity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityCreated_Lcom_android_camera_MonitoredActivity_);
				return cb_onActivityCreated_Lcom_android_camera_MonitoredActivity_;
			}

			static void n_OnActivityCreated_Lcom_android_camera_MonitoredActivity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Android.Camera.MonitoredActivity.LifeCycleAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.MonitoredActivity.LifeCycleAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Android.Camera.MonitoredActivity p0 = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.MonitoredActivity> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnActivityCreated (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onActivityCreated_Lcom_android_camera_MonitoredActivity_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='MonitoredActivity.LifeCycleAdapter']/method[@name='onActivityCreated' and count(parameter)=1 and parameter[1][@type='com.android.camera.MonitoredActivity']]"
			[Register ("onActivityCreated", "(Lcom/android/camera/MonitoredActivity;)V", "GetOnActivityCreated_Lcom_android_camera_MonitoredActivity_Handler")]
			public virtual void OnActivityCreated (global::Com.Android.Camera.MonitoredActivity p0)
			{
				if (id_onActivityCreated_Lcom_android_camera_MonitoredActivity_ == IntPtr.Zero)
					id_onActivityCreated_Lcom_android_camera_MonitoredActivity_ = JNIEnv.GetMethodID (class_ref, "onActivityCreated", "(Lcom/android/camera/MonitoredActivity;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onActivityCreated_Lcom_android_camera_MonitoredActivity_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivityCreated", "(Lcom/android/camera/MonitoredActivity;)V"), new JValue (p0));
			}

			static Delegate cb_onActivityDestroyed_Lcom_android_camera_MonitoredActivity_;
#pragma warning disable 0169
			static Delegate GetOnActivityDestroyed_Lcom_android_camera_MonitoredActivity_Handler ()
			{
				if (cb_onActivityDestroyed_Lcom_android_camera_MonitoredActivity_ == null)
					cb_onActivityDestroyed_Lcom_android_camera_MonitoredActivity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityDestroyed_Lcom_android_camera_MonitoredActivity_);
				return cb_onActivityDestroyed_Lcom_android_camera_MonitoredActivity_;
			}

			static void n_OnActivityDestroyed_Lcom_android_camera_MonitoredActivity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Android.Camera.MonitoredActivity.LifeCycleAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.MonitoredActivity.LifeCycleAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Android.Camera.MonitoredActivity p0 = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.MonitoredActivity> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnActivityDestroyed (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onActivityDestroyed_Lcom_android_camera_MonitoredActivity_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='MonitoredActivity.LifeCycleAdapter']/method[@name='onActivityDestroyed' and count(parameter)=1 and parameter[1][@type='com.android.camera.MonitoredActivity']]"
			[Register ("onActivityDestroyed", "(Lcom/android/camera/MonitoredActivity;)V", "GetOnActivityDestroyed_Lcom_android_camera_MonitoredActivity_Handler")]
			public virtual void OnActivityDestroyed (global::Com.Android.Camera.MonitoredActivity p0)
			{
				if (id_onActivityDestroyed_Lcom_android_camera_MonitoredActivity_ == IntPtr.Zero)
					id_onActivityDestroyed_Lcom_android_camera_MonitoredActivity_ = JNIEnv.GetMethodID (class_ref, "onActivityDestroyed", "(Lcom/android/camera/MonitoredActivity;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onActivityDestroyed_Lcom_android_camera_MonitoredActivity_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivityDestroyed", "(Lcom/android/camera/MonitoredActivity;)V"), new JValue (p0));
			}

			static Delegate cb_onActivityStarted_Lcom_android_camera_MonitoredActivity_;
#pragma warning disable 0169
			static Delegate GetOnActivityStarted_Lcom_android_camera_MonitoredActivity_Handler ()
			{
				if (cb_onActivityStarted_Lcom_android_camera_MonitoredActivity_ == null)
					cb_onActivityStarted_Lcom_android_camera_MonitoredActivity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityStarted_Lcom_android_camera_MonitoredActivity_);
				return cb_onActivityStarted_Lcom_android_camera_MonitoredActivity_;
			}

			static void n_OnActivityStarted_Lcom_android_camera_MonitoredActivity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Android.Camera.MonitoredActivity.LifeCycleAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.MonitoredActivity.LifeCycleAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Android.Camera.MonitoredActivity p0 = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.MonitoredActivity> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnActivityStarted (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onActivityStarted_Lcom_android_camera_MonitoredActivity_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='MonitoredActivity.LifeCycleAdapter']/method[@name='onActivityStarted' and count(parameter)=1 and parameter[1][@type='com.android.camera.MonitoredActivity']]"
			[Register ("onActivityStarted", "(Lcom/android/camera/MonitoredActivity;)V", "GetOnActivityStarted_Lcom_android_camera_MonitoredActivity_Handler")]
			public virtual void OnActivityStarted (global::Com.Android.Camera.MonitoredActivity p0)
			{
				if (id_onActivityStarted_Lcom_android_camera_MonitoredActivity_ == IntPtr.Zero)
					id_onActivityStarted_Lcom_android_camera_MonitoredActivity_ = JNIEnv.GetMethodID (class_ref, "onActivityStarted", "(Lcom/android/camera/MonitoredActivity;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onActivityStarted_Lcom_android_camera_MonitoredActivity_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivityStarted", "(Lcom/android/camera/MonitoredActivity;)V"), new JValue (p0));
			}

			static Delegate cb_onActivityStopped_Lcom_android_camera_MonitoredActivity_;
#pragma warning disable 0169
			static Delegate GetOnActivityStopped_Lcom_android_camera_MonitoredActivity_Handler ()
			{
				if (cb_onActivityStopped_Lcom_android_camera_MonitoredActivity_ == null)
					cb_onActivityStopped_Lcom_android_camera_MonitoredActivity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityStopped_Lcom_android_camera_MonitoredActivity_);
				return cb_onActivityStopped_Lcom_android_camera_MonitoredActivity_;
			}

			static void n_OnActivityStopped_Lcom_android_camera_MonitoredActivity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Android.Camera.MonitoredActivity.LifeCycleAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.MonitoredActivity.LifeCycleAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Android.Camera.MonitoredActivity p0 = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.MonitoredActivity> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnActivityStopped (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onActivityStopped_Lcom_android_camera_MonitoredActivity_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='MonitoredActivity.LifeCycleAdapter']/method[@name='onActivityStopped' and count(parameter)=1 and parameter[1][@type='com.android.camera.MonitoredActivity']]"
			[Register ("onActivityStopped", "(Lcom/android/camera/MonitoredActivity;)V", "GetOnActivityStopped_Lcom_android_camera_MonitoredActivity_Handler")]
			public virtual void OnActivityStopped (global::Com.Android.Camera.MonitoredActivity p0)
			{
				if (id_onActivityStopped_Lcom_android_camera_MonitoredActivity_ == IntPtr.Zero)
					id_onActivityStopped_Lcom_android_camera_MonitoredActivity_ = JNIEnv.GetMethodID (class_ref, "onActivityStopped", "(Lcom/android/camera/MonitoredActivity;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onActivityStopped_Lcom_android_camera_MonitoredActivity_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivityStopped", "(Lcom/android/camera/MonitoredActivity;)V"), new JValue (p0));
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.android.camera']/interface[@name='MonitoredActivity.LifeCycleListener']"
		[Register ("com/android/camera/MonitoredActivity$LifeCycleListener", "", "Com.Android.Camera.MonitoredActivity/ILifeCycleListenerInvoker")]
		public partial interface ILifeCycleListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/interface[@name='MonitoredActivity.LifeCycleListener']/method[@name='onActivityCreated' and count(parameter)=1 and parameter[1][@type='com.android.camera.MonitoredActivity']]"
			[Register ("onActivityCreated", "(Lcom/android/camera/MonitoredActivity;)V", "GetOnActivityCreated_Lcom_android_camera_MonitoredActivity_Handler:Com.Android.Camera.MonitoredActivity/ILifeCycleListenerInvoker, AndroidCropImageBinding")]
			void OnActivityCreated (global::Com.Android.Camera.MonitoredActivity p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/interface[@name='MonitoredActivity.LifeCycleListener']/method[@name='onActivityDestroyed' and count(parameter)=1 and parameter[1][@type='com.android.camera.MonitoredActivity']]"
			[Register ("onActivityDestroyed", "(Lcom/android/camera/MonitoredActivity;)V", "GetOnActivityDestroyed_Lcom_android_camera_MonitoredActivity_Handler:Com.Android.Camera.MonitoredActivity/ILifeCycleListenerInvoker, AndroidCropImageBinding")]
			void OnActivityDestroyed (global::Com.Android.Camera.MonitoredActivity p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/interface[@name='MonitoredActivity.LifeCycleListener']/method[@name='onActivityStarted' and count(parameter)=1 and parameter[1][@type='com.android.camera.MonitoredActivity']]"
			[Register ("onActivityStarted", "(Lcom/android/camera/MonitoredActivity;)V", "GetOnActivityStarted_Lcom_android_camera_MonitoredActivity_Handler:Com.Android.Camera.MonitoredActivity/ILifeCycleListenerInvoker, AndroidCropImageBinding")]
			void OnActivityStarted (global::Com.Android.Camera.MonitoredActivity p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/interface[@name='MonitoredActivity.LifeCycleListener']/method[@name='onActivityStopped' and count(parameter)=1 and parameter[1][@type='com.android.camera.MonitoredActivity']]"
			[Register ("onActivityStopped", "(Lcom/android/camera/MonitoredActivity;)V", "GetOnActivityStopped_Lcom_android_camera_MonitoredActivity_Handler:Com.Android.Camera.MonitoredActivity/ILifeCycleListenerInvoker, AndroidCropImageBinding")]
			void OnActivityStopped (global::Com.Android.Camera.MonitoredActivity p0);

		}

		[global::Android.Runtime.Register ("com/android/camera/MonitoredActivity$LifeCycleListener", DoNotGenerateAcw=true)]
		internal class ILifeCycleListenerInvoker : global::Java.Lang.Object, ILifeCycleListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/android/camera/MonitoredActivity$LifeCycleListener");
			IntPtr class_ref;

			public static ILifeCycleListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ILifeCycleListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.android.camera.MonitoredActivity.LifeCycleListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ILifeCycleListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (ILifeCycleListenerInvoker); }
			}

			static Delegate cb_onActivityCreated_Lcom_android_camera_MonitoredActivity_;
#pragma warning disable 0169
			static Delegate GetOnActivityCreated_Lcom_android_camera_MonitoredActivity_Handler ()
			{
				if (cb_onActivityCreated_Lcom_android_camera_MonitoredActivity_ == null)
					cb_onActivityCreated_Lcom_android_camera_MonitoredActivity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityCreated_Lcom_android_camera_MonitoredActivity_);
				return cb_onActivityCreated_Lcom_android_camera_MonitoredActivity_;
			}

			static void n_OnActivityCreated_Lcom_android_camera_MonitoredActivity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Android.Camera.MonitoredActivity.ILifeCycleListener __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.MonitoredActivity.ILifeCycleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Android.Camera.MonitoredActivity p0 = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.MonitoredActivity> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnActivityCreated (p0);
			}
#pragma warning restore 0169

			IntPtr id_onActivityCreated_Lcom_android_camera_MonitoredActivity_;
			public void OnActivityCreated (global::Com.Android.Camera.MonitoredActivity p0)
			{
				if (id_onActivityCreated_Lcom_android_camera_MonitoredActivity_ == IntPtr.Zero)
					id_onActivityCreated_Lcom_android_camera_MonitoredActivity_ = JNIEnv.GetMethodID (class_ref, "onActivityCreated", "(Lcom/android/camera/MonitoredActivity;)V");
				JNIEnv.CallVoidMethod (Handle, id_onActivityCreated_Lcom_android_camera_MonitoredActivity_, new JValue (p0));
			}

			static Delegate cb_onActivityDestroyed_Lcom_android_camera_MonitoredActivity_;
#pragma warning disable 0169
			static Delegate GetOnActivityDestroyed_Lcom_android_camera_MonitoredActivity_Handler ()
			{
				if (cb_onActivityDestroyed_Lcom_android_camera_MonitoredActivity_ == null)
					cb_onActivityDestroyed_Lcom_android_camera_MonitoredActivity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityDestroyed_Lcom_android_camera_MonitoredActivity_);
				return cb_onActivityDestroyed_Lcom_android_camera_MonitoredActivity_;
			}

			static void n_OnActivityDestroyed_Lcom_android_camera_MonitoredActivity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Android.Camera.MonitoredActivity.ILifeCycleListener __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.MonitoredActivity.ILifeCycleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Android.Camera.MonitoredActivity p0 = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.MonitoredActivity> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnActivityDestroyed (p0);
			}
#pragma warning restore 0169

			IntPtr id_onActivityDestroyed_Lcom_android_camera_MonitoredActivity_;
			public void OnActivityDestroyed (global::Com.Android.Camera.MonitoredActivity p0)
			{
				if (id_onActivityDestroyed_Lcom_android_camera_MonitoredActivity_ == IntPtr.Zero)
					id_onActivityDestroyed_Lcom_android_camera_MonitoredActivity_ = JNIEnv.GetMethodID (class_ref, "onActivityDestroyed", "(Lcom/android/camera/MonitoredActivity;)V");
				JNIEnv.CallVoidMethod (Handle, id_onActivityDestroyed_Lcom_android_camera_MonitoredActivity_, new JValue (p0));
			}

			static Delegate cb_onActivityStarted_Lcom_android_camera_MonitoredActivity_;
#pragma warning disable 0169
			static Delegate GetOnActivityStarted_Lcom_android_camera_MonitoredActivity_Handler ()
			{
				if (cb_onActivityStarted_Lcom_android_camera_MonitoredActivity_ == null)
					cb_onActivityStarted_Lcom_android_camera_MonitoredActivity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityStarted_Lcom_android_camera_MonitoredActivity_);
				return cb_onActivityStarted_Lcom_android_camera_MonitoredActivity_;
			}

			static void n_OnActivityStarted_Lcom_android_camera_MonitoredActivity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Android.Camera.MonitoredActivity.ILifeCycleListener __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.MonitoredActivity.ILifeCycleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Android.Camera.MonitoredActivity p0 = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.MonitoredActivity> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnActivityStarted (p0);
			}
#pragma warning restore 0169

			IntPtr id_onActivityStarted_Lcom_android_camera_MonitoredActivity_;
			public void OnActivityStarted (global::Com.Android.Camera.MonitoredActivity p0)
			{
				if (id_onActivityStarted_Lcom_android_camera_MonitoredActivity_ == IntPtr.Zero)
					id_onActivityStarted_Lcom_android_camera_MonitoredActivity_ = JNIEnv.GetMethodID (class_ref, "onActivityStarted", "(Lcom/android/camera/MonitoredActivity;)V");
				JNIEnv.CallVoidMethod (Handle, id_onActivityStarted_Lcom_android_camera_MonitoredActivity_, new JValue (p0));
			}

			static Delegate cb_onActivityStopped_Lcom_android_camera_MonitoredActivity_;
#pragma warning disable 0169
			static Delegate GetOnActivityStopped_Lcom_android_camera_MonitoredActivity_Handler ()
			{
				if (cb_onActivityStopped_Lcom_android_camera_MonitoredActivity_ == null)
					cb_onActivityStopped_Lcom_android_camera_MonitoredActivity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityStopped_Lcom_android_camera_MonitoredActivity_);
				return cb_onActivityStopped_Lcom_android_camera_MonitoredActivity_;
			}

			static void n_OnActivityStopped_Lcom_android_camera_MonitoredActivity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Android.Camera.MonitoredActivity.ILifeCycleListener __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.MonitoredActivity.ILifeCycleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Android.Camera.MonitoredActivity p0 = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.MonitoredActivity> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnActivityStopped (p0);
			}
#pragma warning restore 0169

			IntPtr id_onActivityStopped_Lcom_android_camera_MonitoredActivity_;
			public void OnActivityStopped (global::Com.Android.Camera.MonitoredActivity p0)
			{
				if (id_onActivityStopped_Lcom_android_camera_MonitoredActivity_ == IntPtr.Zero)
					id_onActivityStopped_Lcom_android_camera_MonitoredActivity_ = JNIEnv.GetMethodID (class_ref, "onActivityStopped", "(Lcom/android/camera/MonitoredActivity;)V");
				JNIEnv.CallVoidMethod (Handle, id_onActivityStopped_Lcom_android_camera_MonitoredActivity_, new JValue (p0));
			}

		}

		public partial class ActivityCreatedEventArgs : global::System.EventArgs {

			public ActivityCreatedEventArgs (global::Com.Android.Camera.MonitoredActivity p0)
			{
				this.p0 = p0;
			}

			global::Com.Android.Camera.MonitoredActivity p0;
			public global::Com.Android.Camera.MonitoredActivity P0 {
				get { return p0; }
			}
		}

		public partial class ActivityDestroyedEventArgs : global::System.EventArgs {

			public ActivityDestroyedEventArgs (global::Com.Android.Camera.MonitoredActivity p0)
			{
				this.p0 = p0;
			}

			global::Com.Android.Camera.MonitoredActivity p0;
			public global::Com.Android.Camera.MonitoredActivity P0 {
				get { return p0; }
			}
		}

		public partial class ActivityStartedEventArgs : global::System.EventArgs {

			public ActivityStartedEventArgs (global::Com.Android.Camera.MonitoredActivity p0)
			{
				this.p0 = p0;
			}

			global::Com.Android.Camera.MonitoredActivity p0;
			public global::Com.Android.Camera.MonitoredActivity P0 {
				get { return p0; }
			}
		}

		public partial class ActivityStoppedEventArgs : global::System.EventArgs {

			public ActivityStoppedEventArgs (global::Com.Android.Camera.MonitoredActivity p0)
			{
				this.p0 = p0;
			}

			global::Com.Android.Camera.MonitoredActivity p0;
			public global::Com.Android.Camera.MonitoredActivity P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/android/camera/MonitoredActivity_LifeCycleListenerImplementor")]
		internal sealed class ILifeCycleListenerImplementor : global::Java.Lang.Object, ILifeCycleListener {

			object sender;

			public ILifeCycleListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/android/camera/MonitoredActivity_LifeCycleListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ActivityCreatedEventArgs> OnActivityCreatedHandler;
#pragma warning restore 0649

			public void OnActivityCreated (global::Com.Android.Camera.MonitoredActivity p0)
			{
				var __h = OnActivityCreatedHandler;
				if (__h != null)
					__h (sender, new ActivityCreatedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<ActivityDestroyedEventArgs> OnActivityDestroyedHandler;
#pragma warning restore 0649

			public void OnActivityDestroyed (global::Com.Android.Camera.MonitoredActivity p0)
			{
				var __h = OnActivityDestroyedHandler;
				if (__h != null)
					__h (sender, new ActivityDestroyedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<ActivityStartedEventArgs> OnActivityStartedHandler;
#pragma warning restore 0649

			public void OnActivityStarted (global::Com.Android.Camera.MonitoredActivity p0)
			{
				var __h = OnActivityStartedHandler;
				if (__h != null)
					__h (sender, new ActivityStartedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<ActivityStoppedEventArgs> OnActivityStoppedHandler;
#pragma warning restore 0649

			public void OnActivityStopped (global::Com.Android.Camera.MonitoredActivity p0)
			{
				var __h = OnActivityStoppedHandler;
				if (__h != null)
					__h (sender, new ActivityStoppedEventArgs (p0));
			}

			internal static bool __IsEmpty (ILifeCycleListenerImplementor value)
			{
				return value.OnActivityCreatedHandler == null && value.OnActivityDestroyedHandler == null && value.OnActivityStartedHandler == null && value.OnActivityStoppedHandler == null;
			}
		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/android/camera/MonitoredActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MonitoredActivity); }
		}

		protected MonitoredActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.android.camera']/class[@name='MonitoredActivity']/constructor[@name='MonitoredActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public MonitoredActivity () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MonitoredActivity)) {
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

		static Delegate cb_addLifeCycleListener_Lcom_android_camera_MonitoredActivity_LifeCycleListener_;
#pragma warning disable 0169
		static Delegate GetAddLifeCycleListener_Lcom_android_camera_MonitoredActivity_LifeCycleListener_Handler ()
		{
			if (cb_addLifeCycleListener_Lcom_android_camera_MonitoredActivity_LifeCycleListener_ == null)
				cb_addLifeCycleListener_Lcom_android_camera_MonitoredActivity_LifeCycleListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddLifeCycleListener_Lcom_android_camera_MonitoredActivity_LifeCycleListener_);
			return cb_addLifeCycleListener_Lcom_android_camera_MonitoredActivity_LifeCycleListener_;
		}

		static void n_AddLifeCycleListener_Lcom_android_camera_MonitoredActivity_LifeCycleListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Android.Camera.MonitoredActivity __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.MonitoredActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Android.Camera.MonitoredActivity.ILifeCycleListener p0 = (global::Com.Android.Camera.MonitoredActivity.ILifeCycleListener)global::Java.Lang.Object.GetObject<global::Com.Android.Camera.MonitoredActivity.ILifeCycleListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddLifeCycleListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addLifeCycleListener_Lcom_android_camera_MonitoredActivity_LifeCycleListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='MonitoredActivity']/method[@name='addLifeCycleListener' and count(parameter)=1 and parameter[1][@type='com.android.camera.MonitoredActivity.LifeCycleListener']]"
		[Register ("addLifeCycleListener", "(Lcom/android/camera/MonitoredActivity$LifeCycleListener;)V", "GetAddLifeCycleListener_Lcom_android_camera_MonitoredActivity_LifeCycleListener_Handler")]
		public virtual void AddLifeCycleListener (global::Com.Android.Camera.MonitoredActivity.ILifeCycleListener p0)
		{
			if (id_addLifeCycleListener_Lcom_android_camera_MonitoredActivity_LifeCycleListener_ == IntPtr.Zero)
				id_addLifeCycleListener_Lcom_android_camera_MonitoredActivity_LifeCycleListener_ = JNIEnv.GetMethodID (class_ref, "addLifeCycleListener", "(Lcom/android/camera/MonitoredActivity$LifeCycleListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addLifeCycleListener_Lcom_android_camera_MonitoredActivity_LifeCycleListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addLifeCycleListener", "(Lcom/android/camera/MonitoredActivity$LifeCycleListener;)V"), new JValue (p0));
		}

		static Delegate cb_removeLifeCycleListener_Lcom_android_camera_MonitoredActivity_LifeCycleListener_;
#pragma warning disable 0169
		static Delegate GetRemoveLifeCycleListener_Lcom_android_camera_MonitoredActivity_LifeCycleListener_Handler ()
		{
			if (cb_removeLifeCycleListener_Lcom_android_camera_MonitoredActivity_LifeCycleListener_ == null)
				cb_removeLifeCycleListener_Lcom_android_camera_MonitoredActivity_LifeCycleListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveLifeCycleListener_Lcom_android_camera_MonitoredActivity_LifeCycleListener_);
			return cb_removeLifeCycleListener_Lcom_android_camera_MonitoredActivity_LifeCycleListener_;
		}

		static void n_RemoveLifeCycleListener_Lcom_android_camera_MonitoredActivity_LifeCycleListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Android.Camera.MonitoredActivity __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.MonitoredActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Android.Camera.MonitoredActivity.ILifeCycleListener p0 = (global::Com.Android.Camera.MonitoredActivity.ILifeCycleListener)global::Java.Lang.Object.GetObject<global::Com.Android.Camera.MonitoredActivity.ILifeCycleListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveLifeCycleListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeLifeCycleListener_Lcom_android_camera_MonitoredActivity_LifeCycleListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera']/class[@name='MonitoredActivity']/method[@name='removeLifeCycleListener' and count(parameter)=1 and parameter[1][@type='com.android.camera.MonitoredActivity.LifeCycleListener']]"
		[Register ("removeLifeCycleListener", "(Lcom/android/camera/MonitoredActivity$LifeCycleListener;)V", "GetRemoveLifeCycleListener_Lcom_android_camera_MonitoredActivity_LifeCycleListener_Handler")]
		public virtual void RemoveLifeCycleListener (global::Com.Android.Camera.MonitoredActivity.ILifeCycleListener p0)
		{
			if (id_removeLifeCycleListener_Lcom_android_camera_MonitoredActivity_LifeCycleListener_ == IntPtr.Zero)
				id_removeLifeCycleListener_Lcom_android_camera_MonitoredActivity_LifeCycleListener_ = JNIEnv.GetMethodID (class_ref, "removeLifeCycleListener", "(Lcom/android/camera/MonitoredActivity$LifeCycleListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeLifeCycleListener_Lcom_android_camera_MonitoredActivity_LifeCycleListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeLifeCycleListener", "(Lcom/android/camera/MonitoredActivity$LifeCycleListener;)V"), new JValue (p0));
		}

#region "Event implementation for Com.Android.Camera.MonitoredActivity.ILifeCycleListener"
		public event EventHandler<global::Com.Android.Camera.MonitoredActivity.ActivityCreatedEventArgs> ActivityCreated {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Android.Camera.MonitoredActivity.ILifeCycleListener, global::Com.Android.Camera.MonitoredActivity.ILifeCycleListenerImplementor>(
						ref weak_implementor_AddLifeCycleListener,
						__CreateILifeCycleListenerImplementor,
						AddLifeCycleListener,
						__h => __h.OnActivityCreatedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Android.Camera.MonitoredActivity.ILifeCycleListener, global::Com.Android.Camera.MonitoredActivity.ILifeCycleListenerImplementor>(
						ref weak_implementor_AddLifeCycleListener,
						global::Com.Android.Camera.MonitoredActivity.ILifeCycleListenerImplementor.__IsEmpty,
						RemoveLifeCycleListener,
						__h => __h.OnActivityCreatedHandler -= value);
			}
		}

		public event EventHandler<global::Com.Android.Camera.MonitoredActivity.ActivityDestroyedEventArgs> ActivityDestroyed {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Android.Camera.MonitoredActivity.ILifeCycleListener, global::Com.Android.Camera.MonitoredActivity.ILifeCycleListenerImplementor>(
						ref weak_implementor_AddLifeCycleListener,
						__CreateILifeCycleListenerImplementor,
						AddLifeCycleListener,
						__h => __h.OnActivityDestroyedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Android.Camera.MonitoredActivity.ILifeCycleListener, global::Com.Android.Camera.MonitoredActivity.ILifeCycleListenerImplementor>(
						ref weak_implementor_AddLifeCycleListener,
						global::Com.Android.Camera.MonitoredActivity.ILifeCycleListenerImplementor.__IsEmpty,
						RemoveLifeCycleListener,
						__h => __h.OnActivityDestroyedHandler -= value);
			}
		}

		public event EventHandler<global::Com.Android.Camera.MonitoredActivity.ActivityStartedEventArgs> ActivityStarted {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Android.Camera.MonitoredActivity.ILifeCycleListener, global::Com.Android.Camera.MonitoredActivity.ILifeCycleListenerImplementor>(
						ref weak_implementor_AddLifeCycleListener,
						__CreateILifeCycleListenerImplementor,
						AddLifeCycleListener,
						__h => __h.OnActivityStartedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Android.Camera.MonitoredActivity.ILifeCycleListener, global::Com.Android.Camera.MonitoredActivity.ILifeCycleListenerImplementor>(
						ref weak_implementor_AddLifeCycleListener,
						global::Com.Android.Camera.MonitoredActivity.ILifeCycleListenerImplementor.__IsEmpty,
						RemoveLifeCycleListener,
						__h => __h.OnActivityStartedHandler -= value);
			}
		}

		public event EventHandler<global::Com.Android.Camera.MonitoredActivity.ActivityStoppedEventArgs> ActivityStopped {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Android.Camera.MonitoredActivity.ILifeCycleListener, global::Com.Android.Camera.MonitoredActivity.ILifeCycleListenerImplementor>(
						ref weak_implementor_AddLifeCycleListener,
						__CreateILifeCycleListenerImplementor,
						AddLifeCycleListener,
						__h => __h.OnActivityStoppedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Android.Camera.MonitoredActivity.ILifeCycleListener, global::Com.Android.Camera.MonitoredActivity.ILifeCycleListenerImplementor>(
						ref weak_implementor_AddLifeCycleListener,
						global::Com.Android.Camera.MonitoredActivity.ILifeCycleListenerImplementor.__IsEmpty,
						RemoveLifeCycleListener,
						__h => __h.OnActivityStoppedHandler -= value);
			}
		}

		WeakReference weak_implementor_AddLifeCycleListener;

		global::Com.Android.Camera.MonitoredActivity.ILifeCycleListenerImplementor __CreateILifeCycleListenerImplementor ()
		{
			return new global::Com.Android.Camera.MonitoredActivity.ILifeCycleListenerImplementor (this);
		}
#endregion
	}
}
