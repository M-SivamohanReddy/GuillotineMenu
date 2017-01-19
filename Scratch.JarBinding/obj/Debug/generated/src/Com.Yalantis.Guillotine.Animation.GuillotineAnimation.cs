using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Yalantis.Guillotine.Animation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.yalantis.guillotine.animation']/class[@name='GuillotineAnimation']"
	[global::Android.Runtime.Register ("com/yalantis/guillotine/animation/GuillotineAnimation", DoNotGenerateAcw=true)]
	public partial class GuillotineAnimation : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.yalantis.guillotine.animation']/class[@name='GuillotineAnimation.GuillotineBuilder']"
		[global::Android.Runtime.Register ("com/yalantis/guillotine/animation/GuillotineAnimation$GuillotineBuilder", DoNotGenerateAcw=true)]
		public partial class GuillotineBuilder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/yalantis/guillotine/animation/GuillotineAnimation$GuillotineBuilder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (GuillotineBuilder); }
			}

			protected GuillotineBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_view_View_Landroid_view_View_Landroid_view_View_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.yalantis.guillotine.animation']/class[@name='GuillotineAnimation.GuillotineBuilder']/constructor[@name='GuillotineAnimation.GuillotineBuilder' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.view.View']]"
			[Register (".ctor", "(Landroid/view/View;Landroid/view/View;Landroid/view/View;)V", "")]
			public unsafe GuillotineBuilder (global::Android.Views.View view, global::Android.Views.View contentValues, global::Android.Views.View content)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (view);
					__args [1] = new JValue (contentValues);
					__args [2] = new JValue (content);
					if (GetType () != typeof (GuillotineBuilder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/view/View;Landroid/view/View;Landroid/view/View;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/view/View;Landroid/view/View;Landroid/view/View;)V", __args);
						return;
					}

					if (id_ctor_Landroid_view_View_Landroid_view_View_Landroid_view_View_ == IntPtr.Zero)
						id_ctor_Landroid_view_View_Landroid_view_View_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/view/View;Landroid/view/View;Landroid/view/View;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_view_View_Landroid_view_View_Landroid_view_View_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_view_View_Landroid_view_View_Landroid_view_View_, __args);
				} finally {
				}
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation.GuillotineBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation.GuillotineBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.yalantis.guillotine.animation']/class[@name='GuillotineAnimation.GuillotineBuilder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/yalantis/guillotine/animation/GuillotineAnimation;", "GetBuildHandler")]
			public virtual unsafe global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/yalantis/guillotine/animation/GuillotineAnimation;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lcom/yalantis/guillotine/animation/GuillotineAnimation;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setActionBarViewForAnimation_Landroid_view_View_;
#pragma warning disable 0169
			static Delegate GetSetActionBarViewForAnimation_Landroid_view_View_Handler ()
			{
				if (cb_setActionBarViewForAnimation_Landroid_view_View_ == null)
					cb_setActionBarViewForAnimation_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetActionBarViewForAnimation_Landroid_view_View_);
				return cb_setActionBarViewForAnimation_Landroid_view_View_;
			}

			static IntPtr n_SetActionBarViewForAnimation_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_actionBarViewForAnimation)
			{
				global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation.GuillotineBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation.GuillotineBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View actionBarViewForAnimation = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_actionBarViewForAnimation, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetActionBarViewForAnimation (actionBarViewForAnimation));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setActionBarViewForAnimation_Landroid_view_View_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.yalantis.guillotine.animation']/class[@name='GuillotineAnimation.GuillotineBuilder']/method[@name='setActionBarViewForAnimation' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("setActionBarViewForAnimation", "(Landroid/view/View;)Lcom/yalantis/guillotine/animation/GuillotineAnimation$GuillotineBuilder;", "GetSetActionBarViewForAnimation_Landroid_view_View_Handler")]
			public virtual unsafe global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation.GuillotineBuilder SetActionBarViewForAnimation (global::Android.Views.View actionBarViewForAnimation)
			{
				if (id_setActionBarViewForAnimation_Landroid_view_View_ == IntPtr.Zero)
					id_setActionBarViewForAnimation_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setActionBarViewForAnimation", "(Landroid/view/View;)Lcom/yalantis/guillotine/animation/GuillotineAnimation$GuillotineBuilder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (actionBarViewForAnimation);

					global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation.GuillotineBuilder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation.GuillotineBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setActionBarViewForAnimation_Landroid_view_View_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation.GuillotineBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setActionBarViewForAnimation", "(Landroid/view/View;)Lcom/yalantis/guillotine/animation/GuillotineAnimation$GuillotineBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setClosedOnStart_Z;
#pragma warning disable 0169
			static Delegate GetSetClosedOnStart_ZHandler ()
			{
				if (cb_setClosedOnStart_Z == null)
					cb_setClosedOnStart_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetClosedOnStart_Z);
				return cb_setClosedOnStart_Z;
			}

			static IntPtr n_SetClosedOnStart_Z (IntPtr jnienv, IntPtr native__this, bool closedOnStart)
			{
				global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation.GuillotineBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation.GuillotineBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetClosedOnStart (closedOnStart));
			}
#pragma warning restore 0169

			static IntPtr id_setClosedOnStart_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.yalantis.guillotine.animation']/class[@name='GuillotineAnimation.GuillotineBuilder']/method[@name='setClosedOnStart' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setClosedOnStart", "(Z)Lcom/yalantis/guillotine/animation/GuillotineAnimation$GuillotineBuilder;", "GetSetClosedOnStart_ZHandler")]
			public virtual unsafe global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation.GuillotineBuilder SetClosedOnStart (bool closedOnStart)
			{
				if (id_setClosedOnStart_Z == IntPtr.Zero)
					id_setClosedOnStart_Z = JNIEnv.GetMethodID (class_ref, "setClosedOnStart", "(Z)Lcom/yalantis/guillotine/animation/GuillotineAnimation$GuillotineBuilder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (closedOnStart);

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation.GuillotineBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setClosedOnStart_Z, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation.GuillotineBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setClosedOnStart", "(Z)Lcom/yalantis/guillotine/animation/GuillotineAnimation$GuillotineBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setDuration_J;
#pragma warning disable 0169
			static Delegate GetSetDuration_JHandler ()
			{
				if (cb_setDuration_J == null)
					cb_setDuration_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_SetDuration_J);
				return cb_setDuration_J;
			}

			static IntPtr n_SetDuration_J (IntPtr jnienv, IntPtr native__this, long duration)
			{
				global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation.GuillotineBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation.GuillotineBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetDuration (duration));
			}
#pragma warning restore 0169

			static IntPtr id_setDuration_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.yalantis.guillotine.animation']/class[@name='GuillotineAnimation.GuillotineBuilder']/method[@name='setDuration' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setDuration", "(J)Lcom/yalantis/guillotine/animation/GuillotineAnimation$GuillotineBuilder;", "GetSetDuration_JHandler")]
			public virtual unsafe global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation.GuillotineBuilder SetDuration (long duration)
			{
				if (id_setDuration_J == IntPtr.Zero)
					id_setDuration_J = JNIEnv.GetMethodID (class_ref, "setDuration", "(J)Lcom/yalantis/guillotine/animation/GuillotineAnimation$GuillotineBuilder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (duration);

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation.GuillotineBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setDuration_J, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation.GuillotineBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDuration", "(J)Lcom/yalantis/guillotine/animation/GuillotineAnimation$GuillotineBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setGuillotineListener_Lcom_yalantis_guillotine_interfaces_GuillotineListener_;
#pragma warning disable 0169
			static Delegate GetSetGuillotineListener_Lcom_yalantis_guillotine_interfaces_GuillotineListener_Handler ()
			{
				if (cb_setGuillotineListener_Lcom_yalantis_guillotine_interfaces_GuillotineListener_ == null)
					cb_setGuillotineListener_Lcom_yalantis_guillotine_interfaces_GuillotineListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetGuillotineListener_Lcom_yalantis_guillotine_interfaces_GuillotineListener_);
				return cb_setGuillotineListener_Lcom_yalantis_guillotine_interfaces_GuillotineListener_;
			}

			static IntPtr n_SetGuillotineListener_Lcom_yalantis_guillotine_interfaces_GuillotineListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation.GuillotineBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation.GuillotineBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Yalantis.Guillotine.Interfaces.IGuillotineListener p0 = (global::Com.Yalantis.Guillotine.Interfaces.IGuillotineListener)global::Java.Lang.Object.GetObject<global::Com.Yalantis.Guillotine.Interfaces.IGuillotineListener> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetGuillotineListener (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setGuillotineListener_Lcom_yalantis_guillotine_interfaces_GuillotineListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.yalantis.guillotine.animation']/class[@name='GuillotineAnimation.GuillotineBuilder']/method[@name='setGuillotineListener' and count(parameter)=1 and parameter[1][@type='com.yalantis.guillotine.interfaces.GuillotineListener']]"
			[Register ("setGuillotineListener", "(Lcom/yalantis/guillotine/interfaces/GuillotineListener;)Lcom/yalantis/guillotine/animation/GuillotineAnimation$GuillotineBuilder;", "GetSetGuillotineListener_Lcom_yalantis_guillotine_interfaces_GuillotineListener_Handler")]
			public virtual unsafe global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation.GuillotineBuilder SetGuillotineListener (global::Com.Yalantis.Guillotine.Interfaces.IGuillotineListener p0)
			{
				if (id_setGuillotineListener_Lcom_yalantis_guillotine_interfaces_GuillotineListener_ == IntPtr.Zero)
					id_setGuillotineListener_Lcom_yalantis_guillotine_interfaces_GuillotineListener_ = JNIEnv.GetMethodID (class_ref, "setGuillotineListener", "(Lcom/yalantis/guillotine/interfaces/GuillotineListener;)Lcom/yalantis/guillotine/animation/GuillotineAnimation$GuillotineBuilder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation.GuillotineBuilder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation.GuillotineBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setGuillotineListener_Lcom_yalantis_guillotine_interfaces_GuillotineListener_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation.GuillotineBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGuillotineListener", "(Lcom/yalantis/guillotine/interfaces/GuillotineListener;)Lcom/yalantis/guillotine/animation/GuillotineAnimation$GuillotineBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setInterpolator_Landroid_animation_TimeInterpolator_;
#pragma warning disable 0169
			static Delegate GetSetInterpolator_Landroid_animation_TimeInterpolator_Handler ()
			{
				if (cb_setInterpolator_Landroid_animation_TimeInterpolator_ == null)
					cb_setInterpolator_Landroid_animation_TimeInterpolator_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetInterpolator_Landroid_animation_TimeInterpolator_);
				return cb_setInterpolator_Landroid_animation_TimeInterpolator_;
			}

			static IntPtr n_SetInterpolator_Landroid_animation_TimeInterpolator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation.GuillotineBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation.GuillotineBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Animation.ITimeInterpolator p0 = (global::Android.Animation.ITimeInterpolator)global::Java.Lang.Object.GetObject<global::Android.Animation.ITimeInterpolator> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetInterpolator (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setInterpolator_Landroid_animation_TimeInterpolator_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.yalantis.guillotine.animation']/class[@name='GuillotineAnimation.GuillotineBuilder']/method[@name='setInterpolator' and count(parameter)=1 and parameter[1][@type='android.animation.TimeInterpolator']]"
			[Register ("setInterpolator", "(Landroid/animation/TimeInterpolator;)Lcom/yalantis/guillotine/animation/GuillotineAnimation$GuillotineBuilder;", "GetSetInterpolator_Landroid_animation_TimeInterpolator_Handler")]
			public virtual unsafe global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation.GuillotineBuilder SetInterpolator (global::Android.Animation.ITimeInterpolator p0)
			{
				if (id_setInterpolator_Landroid_animation_TimeInterpolator_ == IntPtr.Zero)
					id_setInterpolator_Landroid_animation_TimeInterpolator_ = JNIEnv.GetMethodID (class_ref, "setInterpolator", "(Landroid/animation/TimeInterpolator;)Lcom/yalantis/guillotine/animation/GuillotineAnimation$GuillotineBuilder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation.GuillotineBuilder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation.GuillotineBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setInterpolator_Landroid_animation_TimeInterpolator_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation.GuillotineBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInterpolator", "(Landroid/animation/TimeInterpolator;)Lcom/yalantis/guillotine/animation/GuillotineAnimation$GuillotineBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setRightToLeftLayout_Z;
#pragma warning disable 0169
			static Delegate GetSetRightToLeftLayout_ZHandler ()
			{
				if (cb_setRightToLeftLayout_Z == null)
					cb_setRightToLeftLayout_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetRightToLeftLayout_Z);
				return cb_setRightToLeftLayout_Z;
			}

			static IntPtr n_SetRightToLeftLayout_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation.GuillotineBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation.GuillotineBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetRightToLeftLayout (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setRightToLeftLayout_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.yalantis.guillotine.animation']/class[@name='GuillotineAnimation.GuillotineBuilder']/method[@name='setRightToLeftLayout' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setRightToLeftLayout", "(Z)Lcom/yalantis/guillotine/animation/GuillotineAnimation$GuillotineBuilder;", "GetSetRightToLeftLayout_ZHandler")]
			public virtual unsafe global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation.GuillotineBuilder SetRightToLeftLayout (bool p0)
			{
				if (id_setRightToLeftLayout_Z == IntPtr.Zero)
					id_setRightToLeftLayout_Z = JNIEnv.GetMethodID (class_ref, "setRightToLeftLayout", "(Z)Lcom/yalantis/guillotine/animation/GuillotineAnimation$GuillotineBuilder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation.GuillotineBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setRightToLeftLayout_Z, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation.GuillotineBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRightToLeftLayout", "(Z)Lcom/yalantis/guillotine/animation/GuillotineAnimation$GuillotineBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setStartDelay_J;
#pragma warning disable 0169
			static Delegate GetSetStartDelay_JHandler ()
			{
				if (cb_setStartDelay_J == null)
					cb_setStartDelay_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_SetStartDelay_J);
				return cb_setStartDelay_J;
			}

			static IntPtr n_SetStartDelay_J (IntPtr jnienv, IntPtr native__this, long startDelay)
			{
				global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation.GuillotineBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation.GuillotineBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetStartDelay (startDelay));
			}
#pragma warning restore 0169

			static IntPtr id_setStartDelay_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.yalantis.guillotine.animation']/class[@name='GuillotineAnimation.GuillotineBuilder']/method[@name='setStartDelay' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setStartDelay", "(J)Lcom/yalantis/guillotine/animation/GuillotineAnimation$GuillotineBuilder;", "GetSetStartDelay_JHandler")]
			public virtual unsafe global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation.GuillotineBuilder SetStartDelay (long startDelay)
			{
				if (id_setStartDelay_J == IntPtr.Zero)
					id_setStartDelay_J = JNIEnv.GetMethodID (class_ref, "setStartDelay", "(J)Lcom/yalantis/guillotine/animation/GuillotineAnimation$GuillotineBuilder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (startDelay);

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation.GuillotineBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setStartDelay_J, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation.GuillotineBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStartDelay", "(J)Lcom/yalantis/guillotine/animation/GuillotineAnimation$GuillotineBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/yalantis/guillotine/animation/GuillotineAnimation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GuillotineAnimation); }
		}

		protected GuillotineAnimation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation __this = global::Java.Lang.Object.GetObject<global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.yalantis.guillotine.animation']/class[@name='GuillotineAnimation']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_close);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
			} finally {
			}
		}

		static Delegate cb_open;
#pragma warning disable 0169
		static Delegate GetOpenHandler ()
		{
			if (cb_open == null)
				cb_open = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Open);
			return cb_open;
		}

		static void n_Open (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation __this = global::Java.Lang.Object.GetObject<global::Com.Yalantis.Guillotine.Animation.GuillotineAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Open ();
		}
#pragma warning restore 0169

		static IntPtr id_open;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.yalantis.guillotine.animation']/class[@name='GuillotineAnimation']/method[@name='open' and count(parameter)=0]"
		[Register ("open", "()V", "GetOpenHandler")]
		public virtual unsafe void Open ()
		{
			if (id_open == IntPtr.Zero)
				id_open = JNIEnv.GetMethodID (class_ref, "open", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_open);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "open", "()V"));
			} finally {
			}
		}

	}
}
