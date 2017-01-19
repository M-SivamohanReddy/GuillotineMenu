using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Yalantis.Guillotine.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.yalantis.guillotine.util']/class[@name='GuillotineInterpolator']"
	[global::Android.Runtime.Register ("com/yalantis/guillotine/util/GuillotineInterpolator", DoNotGenerateAcw=true)]
	public partial class GuillotineInterpolator : global::Java.Lang.Object, global::Android.Animation.ITimeInterpolator {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.yalantis.guillotine.util']/class[@name='GuillotineInterpolator']/field[@name='FIRST_BOUNCE_TIME']"
		[Register ("FIRST_BOUNCE_TIME")]
		public const float FirstBounceTime = (float) 0.266660;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.yalantis.guillotine.util']/class[@name='GuillotineInterpolator']/field[@name='ROTATION_TIME']"
		[Register ("ROTATION_TIME")]
		public const float RotationTime = (float) 0.466670;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.yalantis.guillotine.util']/class[@name='GuillotineInterpolator']/field[@name='SECOND_BOUNCE_TIME']"
		[Register ("SECOND_BOUNCE_TIME")]
		public const float SecondBounceTime = (float) 0.266670;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/yalantis/guillotine/util/GuillotineInterpolator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GuillotineInterpolator); }
		}

		protected GuillotineInterpolator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.yalantis.guillotine.util']/class[@name='GuillotineInterpolator']/constructor[@name='GuillotineInterpolator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GuillotineInterpolator ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (GuillotineInterpolator)) {
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
			global::Com.Yalantis.Guillotine.Util.GuillotineInterpolator __this = global::Java.Lang.Object.GetObject<global::Com.Yalantis.Guillotine.Util.GuillotineInterpolator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetInterpolation (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getInterpolation_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.yalantis.guillotine.util']/class[@name='GuillotineInterpolator']/method[@name='getInterpolation' and count(parameter)=1 and parameter[1][@type='float']]"
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
