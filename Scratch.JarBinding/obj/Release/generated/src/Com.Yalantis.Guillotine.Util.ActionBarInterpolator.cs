using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Yalantis.Guillotine.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.yalantis.guillotine.util']/class[@name='ActionBarInterpolator']"
	[global::Android.Runtime.Register ("com/yalantis/guillotine/util/ActionBarInterpolator", DoNotGenerateAcw=true)]
	public partial class ActionBarInterpolator : global::Java.Lang.Object, global::Android.Animation.ITimeInterpolator {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/yalantis/guillotine/util/ActionBarInterpolator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ActionBarInterpolator); }
		}

		protected ActionBarInterpolator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.yalantis.guillotine.util']/class[@name='ActionBarInterpolator']/constructor[@name='ActionBarInterpolator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ActionBarInterpolator ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ActionBarInterpolator)) {
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
			} finally {
			}
		}

		static Delegate cb_getInterpolation_F;
#pragma warning disable 0169
		static Delegate GetGetInterpolation_FHandler ()
		{
			if (cb_getInterpolation_F == null)
				cb_getInterpolation_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float>) n_GetInterpolation_F);
			return cb_getInterpolation_F;
		}

		static float n_GetInterpolation_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Yalantis.Guillotine.Util.ActionBarInterpolator __this = global::Java.Lang.Object.GetObject<global::Com.Yalantis.Guillotine.Util.ActionBarInterpolator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetInterpolation (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getInterpolation_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.yalantis.guillotine.util']/class[@name='ActionBarInterpolator']/method[@name='getInterpolation' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("getInterpolation", "(F)F", "GetGetInterpolation_FHandler")]
		public virtual unsafe float GetInterpolation (float p0)
		{
			if (id_getInterpolation_F == IntPtr.Zero)
				id_getInterpolation_F = JNIEnv.GetMethodID (class_ref, "getInterpolation", "(F)F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getInterpolation_F, __args);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInterpolation", "(F)F"), __args);
			} finally {
			}
		}

	}
}
