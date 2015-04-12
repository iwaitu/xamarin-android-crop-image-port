using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Android.Camera.Gallery {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.android.camera.gallery']/interface[@name='IImage']"
	[Register ("com/android/camera/gallery/IImage", "", "Com.Android.Camera.Gallery.IImageInvoker")]
	public partial interface IImage : IJavaObject {

		global::Com.Android.Camera.Gallery.IImageList Container {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/interface[@name='IImage']/method[@name='getContainer' and count(parameter)=0]"
			[Register ("getContainer", "()Lcom/android/camera/gallery/IImageList;", "GetGetContainerHandler:Com.Android.Camera.Gallery.IImageInvoker, AndroidCropImageBinding")] get;
		}

		string DataPath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/interface[@name='IImage']/method[@name='getDataPath' and count(parameter)=0]"
			[Register ("getDataPath", "()Ljava/lang/String;", "GetGetDataPathHandler:Com.Android.Camera.Gallery.IImageInvoker, AndroidCropImageBinding")] get;
		}

		long DateTaken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/interface[@name='IImage']/method[@name='getDateTaken' and count(parameter)=0]"
			[Register ("getDateTaken", "()J", "GetGetDateTakenHandler:Com.Android.Camera.Gallery.IImageInvoker, AndroidCropImageBinding")] get;
		}

		int DegreesRotated {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/interface[@name='IImage']/method[@name='getDegreesRotated' and count(parameter)=0]"
			[Register ("getDegreesRotated", "()I", "GetGetDegreesRotatedHandler:Com.Android.Camera.Gallery.IImageInvoker, AndroidCropImageBinding")] get;
		}

		int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/interface[@name='IImage']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "GetGetHeightHandler:Com.Android.Camera.Gallery.IImageInvoker, AndroidCropImageBinding")] get;
		}

		bool IsDrm {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/interface[@name='IImage']/method[@name='isDrm' and count(parameter)=0]"
			[Register ("isDrm", "()Z", "GetIsDrmHandler:Com.Android.Camera.Gallery.IImageInvoker, AndroidCropImageBinding")] get;
		}

		bool IsReadonly {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/interface[@name='IImage']/method[@name='isReadonly' and count(parameter)=0]"
			[Register ("isReadonly", "()Z", "GetIsReadonlyHandler:Com.Android.Camera.Gallery.IImageInvoker, AndroidCropImageBinding")] get;
		}

		string MimeType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/interface[@name='IImage']/method[@name='getMimeType' and count(parameter)=0]"
			[Register ("getMimeType", "()Ljava/lang/String;", "GetGetMimeTypeHandler:Com.Android.Camera.Gallery.IImageInvoker, AndroidCropImageBinding")] get;
		}

		string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/interface[@name='IImage']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler:Com.Android.Camera.Gallery.IImageInvoker, AndroidCropImageBinding")] get;
		}

		int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/interface[@name='IImage']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()I", "GetGetWidthHandler:Com.Android.Camera.Gallery.IImageInvoker, AndroidCropImageBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/interface[@name='IImage']/method[@name='fullSizeBitmap' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("fullSizeBitmap", "(II)Landroid/graphics/Bitmap;", "GetFullSizeBitmap_IIHandler:Com.Android.Camera.Gallery.IImageInvoker, AndroidCropImageBinding")]
		global::Android.Graphics.Bitmap FullSizeBitmap (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/interface[@name='IImage']/method[@name='fullSizeBitmap' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean']]"
		[Register ("fullSizeBitmap", "(IIZZ)Landroid/graphics/Bitmap;", "GetFullSizeBitmap_IIZZHandler:Com.Android.Camera.Gallery.IImageInvoker, AndroidCropImageBinding")]
		global::Android.Graphics.Bitmap FullSizeBitmap (int p0, int p1, bool p2, bool p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/interface[@name='IImage']/method[@name='fullSizeImageData' and count(parameter)=0]"
		[Register ("fullSizeImageData", "()Ljava/io/InputStream;", "GetFullSizeImageDataHandler:Com.Android.Camera.Gallery.IImageInvoker, AndroidCropImageBinding")]
		global::System.IO.Stream FullSizeImageData ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/interface[@name='IImage']/method[@name='fullSizeImageUri' and count(parameter)=0]"
		[Register ("fullSizeImageUri", "()Landroid/net/Uri;", "GetFullSizeImageUriHandler:Com.Android.Camera.Gallery.IImageInvoker, AndroidCropImageBinding")]
		global::Android.Net.Uri FullSizeImageUri ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/interface[@name='IImage']/method[@name='miniThumbBitmap' and count(parameter)=0]"
		[Register ("miniThumbBitmap", "()Landroid/graphics/Bitmap;", "GetMiniThumbBitmapHandler:Com.Android.Camera.Gallery.IImageInvoker, AndroidCropImageBinding")]
		global::Android.Graphics.Bitmap MiniThumbBitmap ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/interface[@name='IImage']/method[@name='rotateImageBy' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("rotateImageBy", "(I)Z", "GetRotateImageBy_IHandler:Com.Android.Camera.Gallery.IImageInvoker, AndroidCropImageBinding")]
		bool RotateImageBy (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.camera.gallery']/interface[@name='IImage']/method[@name='thumbBitmap' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("thumbBitmap", "(Z)Landroid/graphics/Bitmap;", "GetThumbBitmap_ZHandler:Com.Android.Camera.Gallery.IImageInvoker, AndroidCropImageBinding")]
		global::Android.Graphics.Bitmap ThumbBitmap (bool p0);

	}

	[global::Android.Runtime.Register ("com/android/camera/gallery/IImage", DoNotGenerateAcw=true)]
	internal class IImageInvoker : global::Java.Lang.Object, IImage {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/android/camera/gallery/IImage");
		IntPtr class_ref;

		public static IImage GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IImage> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.android.camera.gallery.IImage"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IImageInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IImageInvoker); }
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
			global::Com.Android.Camera.Gallery.IImage __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Container);
		}
#pragma warning restore 0169

		IntPtr id_getContainer;
		public global::Com.Android.Camera.Gallery.IImageList Container {
			get {
				if (id_getContainer == IntPtr.Zero)
					id_getContainer = JNIEnv.GetMethodID (class_ref, "getContainer", "()Lcom/android/camera/gallery/IImageList;");
				return global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImageList> (JNIEnv.CallObjectMethod (Handle, id_getContainer), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Android.Camera.Gallery.IImage __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DataPath);
		}
#pragma warning restore 0169

		IntPtr id_getDataPath;
		public string DataPath {
			get {
				if (id_getDataPath == IntPtr.Zero)
					id_getDataPath = JNIEnv.GetMethodID (class_ref, "getDataPath", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getDataPath), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Android.Camera.Gallery.IImage __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DateTaken;
		}
#pragma warning restore 0169

		IntPtr id_getDateTaken;
		public long DateTaken {
			get {
				if (id_getDateTaken == IntPtr.Zero)
					id_getDateTaken = JNIEnv.GetMethodID (class_ref, "getDateTaken", "()J");
				return JNIEnv.CallLongMethod (Handle, id_getDateTaken);
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
			global::Com.Android.Camera.Gallery.IImage __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DegreesRotated;
		}
#pragma warning restore 0169

		IntPtr id_getDegreesRotated;
		public int DegreesRotated {
			get {
				if (id_getDegreesRotated == IntPtr.Zero)
					id_getDegreesRotated = JNIEnv.GetMethodID (class_ref, "getDegreesRotated", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getDegreesRotated);
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
			global::Com.Android.Camera.Gallery.IImage __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		IntPtr id_getHeight;
		public int Height {
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getHeight);
			}
		}

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
			global::Com.Android.Camera.Gallery.IImage __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrm;
		}
#pragma warning restore 0169

		IntPtr id_isDrm;
		public bool IsDrm {
			get {
				if (id_isDrm == IntPtr.Zero)
					id_isDrm = JNIEnv.GetMethodID (class_ref, "isDrm", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isDrm);
			}
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
			global::Com.Android.Camera.Gallery.IImage __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsReadonly;
		}
#pragma warning restore 0169

		IntPtr id_isReadonly;
		public bool IsReadonly {
			get {
				if (id_isReadonly == IntPtr.Zero)
					id_isReadonly = JNIEnv.GetMethodID (class_ref, "isReadonly", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isReadonly);
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
			global::Com.Android.Camera.Gallery.IImage __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MimeType);
		}
#pragma warning restore 0169

		IntPtr id_getMimeType;
		public string MimeType {
			get {
				if (id_getMimeType == IntPtr.Zero)
					id_getMimeType = JNIEnv.GetMethodID (class_ref, "getMimeType", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getMimeType), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Android.Camera.Gallery.IImage __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		IntPtr id_getTitle;
		public string Title {
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Android.Camera.Gallery.IImage __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		IntPtr id_getWidth;
		public int Width {
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getWidth);
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
			global::Com.Android.Camera.Gallery.IImage __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FullSizeBitmap (p0, p1));
		}
#pragma warning restore 0169

		IntPtr id_fullSizeBitmap_II;
		public global::Android.Graphics.Bitmap FullSizeBitmap (int p0, int p1)
		{
			if (id_fullSizeBitmap_II == IntPtr.Zero)
				id_fullSizeBitmap_II = JNIEnv.GetMethodID (class_ref, "fullSizeBitmap", "(II)Landroid/graphics/Bitmap;");
			return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (Handle, id_fullSizeBitmap_II, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Android.Camera.Gallery.IImage __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FullSizeBitmap (p0, p1, p2, p3));
		}
#pragma warning restore 0169

		IntPtr id_fullSizeBitmap_IIZZ;
		public global::Android.Graphics.Bitmap FullSizeBitmap (int p0, int p1, bool p2, bool p3)
		{
			if (id_fullSizeBitmap_IIZZ == IntPtr.Zero)
				id_fullSizeBitmap_IIZZ = JNIEnv.GetMethodID (class_ref, "fullSizeBitmap", "(IIZZ)Landroid/graphics/Bitmap;");
			return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (Handle, id_fullSizeBitmap_IIZZ, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Android.Camera.Gallery.IImage __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.FullSizeImageData ());
		}
#pragma warning restore 0169

		IntPtr id_fullSizeImageData;
		public global::System.IO.Stream FullSizeImageData ()
		{
			if (id_fullSizeImageData == IntPtr.Zero)
				id_fullSizeImageData = JNIEnv.GetMethodID (class_ref, "fullSizeImageData", "()Ljava/io/InputStream;");
			return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_fullSizeImageData), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Android.Camera.Gallery.IImage __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FullSizeImageUri ());
		}
#pragma warning restore 0169

		IntPtr id_fullSizeImageUri;
		public global::Android.Net.Uri FullSizeImageUri ()
		{
			if (id_fullSizeImageUri == IntPtr.Zero)
				id_fullSizeImageUri = JNIEnv.GetMethodID (class_ref, "fullSizeImageUri", "()Landroid/net/Uri;");
			return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod (Handle, id_fullSizeImageUri), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Android.Camera.Gallery.IImage __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MiniThumbBitmap ());
		}
#pragma warning restore 0169

		IntPtr id_miniThumbBitmap;
		public global::Android.Graphics.Bitmap MiniThumbBitmap ()
		{
			if (id_miniThumbBitmap == IntPtr.Zero)
				id_miniThumbBitmap = JNIEnv.GetMethodID (class_ref, "miniThumbBitmap", "()Landroid/graphics/Bitmap;");
			return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (Handle, id_miniThumbBitmap), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Android.Camera.Gallery.IImage __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RotateImageBy (p0);
		}
#pragma warning restore 0169

		IntPtr id_rotateImageBy_I;
		public bool RotateImageBy (int p0)
		{
			if (id_rotateImageBy_I == IntPtr.Zero)
				id_rotateImageBy_I = JNIEnv.GetMethodID (class_ref, "rotateImageBy", "(I)Z");
			return JNIEnv.CallBooleanMethod (Handle, id_rotateImageBy_I, new JValue (p0));
		}

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
			global::Com.Android.Camera.Gallery.IImage __this = global::Java.Lang.Object.GetObject<global::Com.Android.Camera.Gallery.IImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ThumbBitmap (p0));
		}
#pragma warning restore 0169

		IntPtr id_thumbBitmap_Z;
		public global::Android.Graphics.Bitmap ThumbBitmap (bool p0)
		{
			if (id_thumbBitmap_Z == IntPtr.Zero)
				id_thumbBitmap_Z = JNIEnv.GetMethodID (class_ref, "thumbBitmap", "(Z)Landroid/graphics/Bitmap;");
			return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (Handle, id_thumbBitmap_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

	}

}
