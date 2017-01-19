using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Yalantis.Guillotine.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.yalantis.guillotine.interfaces']/interface[@name='GuillotineListener']"
	[Register ("com/yalantis/guillotine/interfaces/GuillotineListener", "", "Com.Yalantis.Guillotine.Interfaces.IGuillotineListenerInvoker")]
	public partial interface IGuillotineListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.yalantis.guillotine.interfaces']/interface[@name='GuillotineListener']/method[@name='onGuillotineClosed' and count(parameter)=0]"
		[Register ("onGuillotineClosed", "()V", "GetOnGuillotineClosedHandler:Com.Yalantis.Guillotine.Interfaces.IGuillotineListenerInvoker, Scratch.JarBinding")]
		void OnGuillotineClosed ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.yalantis.guillotine.interfaces']/interface[@name='GuillotineListener']/method[@name='onGuillotineOpened' and count(parameter)=0]"
		[Register ("onGuillotineOpened", "()V", "GetOnGuillotineOpenedHandler:Com.Yalantis.Guillotine.Interfaces.IGuillotineListenerInvoker, Scratch.JarBinding")]
		void OnGuillotineOpened ();

	}

	[global::Android.Runtime.Register ("com/yalantis/guillotine/interfaces/GuillotineListener", DoNotGenerateAcw=true)]
	internal class IGuillotineListenerInvoker : global::Java.Lang.Object, IGuillotineListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/yalantis/guillotine/interfaces/GuillotineListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IGuillotineListenerInvoker); }
		}

		IntPtr class_ref;

		public static IGuillotineListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IGuillotineListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.yalantis.guillotine.interfaces.GuillotineListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IGuillotineListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onGuillotineClosed;
#pragma warning disable 0169
		static Delegate GetOnGuillotineClosedHandler ()
		{
			if (cb_onGuillotineClosed == null)
				cb_onGuillotineClosed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnGuillotineClosed);
			return cb_onGuillotineClosed;
		}

		static void n_OnGuillotineClosed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Yalantis.Guillotine.Interfaces.IGuillotineListener __this = global::Java.Lang.Object.GetObject<global::Com.Yalantis.Guillotine.Interfaces.IGuillotineListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnGuillotineClosed ();
		}
#pragma warning restore 0169

		IntPtr id_onGuillotineClosed;
		public unsafe void OnGuillotineClosed ()
		{
			if (id_onGuillotineClosed == IntPtr.Zero)
				id_onGuillotineClosed = JNIEnv.GetMethodID (class_ref, "onGuillotineClosed", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onGuillotineClosed);
		}

		static Delegate cb_onGuillotineOpened;
#pragma warning disable 0169
		static Delegate GetOnGuillotineOpenedHandler ()
		{
			if (cb_onGuillotineOpened == null)
				cb_onGuillotineOpened = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnGuillotineOpened);
			return cb_onGuillotineOpened;
		}

		static void n_OnGuillotineOpened (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Yalantis.Guillotine.Interfaces.IGuillotineListener __this = global::Java.Lang.Object.GetObject<global::Com.Yalantis.Guillotine.Interfaces.IGuillotineListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnGuillotineOpened ();
		}
#pragma warning restore 0169

		IntPtr id_onGuillotineOpened;
		public unsafe void OnGuillotineOpened ()
		{
			if (id_onGuillotineOpened == IntPtr.Zero)
				id_onGuillotineOpened = JNIEnv.GetMethodID (class_ref, "onGuillotineOpened", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onGuillotineOpened);
		}

	}

	[global::Android.Runtime.Register ("mono/com/yalantis/guillotine/interfaces/GuillotineListenerImplementor")]
	internal sealed partial class IGuillotineListenerImplementor : global::Java.Lang.Object, IGuillotineListener {

		object sender;

		public IGuillotineListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/yalantis/guillotine/interfaces/GuillotineListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler OnGuillotineClosedHandler;
#pragma warning restore 0649

		public void OnGuillotineClosed ()
		{
			var __h = OnGuillotineClosedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler OnGuillotineOpenedHandler;
#pragma warning restore 0649

		public void OnGuillotineOpened ()
		{
			var __h = OnGuillotineOpenedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IGuillotineListenerImplementor value)
		{
			return value.OnGuillotineClosedHandler == null && value.OnGuillotineOpenedHandler == null;
		}
	}

}
