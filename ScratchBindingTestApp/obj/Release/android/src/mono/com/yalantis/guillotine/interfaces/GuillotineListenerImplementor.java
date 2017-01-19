package mono.com.yalantis.guillotine.interfaces;


public class GuillotineListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.yalantis.guillotine.interfaces.GuillotineListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onGuillotineClosed:()V:GetOnGuillotineClosedHandler:Com.Yalantis.Guillotine.Interfaces.IGuillotineListenerInvoker, Scratch.JarBinding\n" +
			"n_onGuillotineOpened:()V:GetOnGuillotineOpenedHandler:Com.Yalantis.Guillotine.Interfaces.IGuillotineListenerInvoker, Scratch.JarBinding\n" +
			"";
		mono.android.Runtime.register ("Com.Yalantis.Guillotine.Interfaces.IGuillotineListenerImplementor, Scratch.JarBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", GuillotineListenerImplementor.class, __md_methods);
	}


	public GuillotineListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == GuillotineListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Yalantis.Guillotine.Interfaces.IGuillotineListenerImplementor, Scratch.JarBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onGuillotineClosed ()
	{
		n_onGuillotineClosed ();
	}

	private native void n_onGuillotineClosed ();


	public void onGuillotineOpened ()
	{
		n_onGuillotineOpened ();
	}

	private native void n_onGuillotineOpened ();

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
