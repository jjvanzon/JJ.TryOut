package android.dialog;


public class CheckboxElement
	extends android.dialog.Element
	implements
		mono.android.IGCUserPeer,
		android.widget.CompoundButton.OnCheckedChangeListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCheckedChanged:(Landroid/widget/CompoundButton;Z)V:GetOnCheckedChanged_Landroid_widget_CompoundButton_ZHandler:Android.Widget.CompoundButton/IOnCheckedChangeListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("Android.Dialog.CheckboxElement, Android.Dialog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", CheckboxElement.class, __md_methods);
	}


	public CheckboxElement ()
	{
		super ();
		if (getClass () == CheckboxElement.class)
			mono.android.TypeManager.Activate ("Android.Dialog.CheckboxElement, Android.Dialog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public CheckboxElement (java.lang.String p0)
	{
		super ();
		if (getClass () == CheckboxElement.class)
			mono.android.TypeManager.Activate ("Android.Dialog.CheckboxElement, Android.Dialog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "System.String, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0 });
	}

	public CheckboxElement (java.lang.String p0, int p1)
	{
		super ();
		if (getClass () == CheckboxElement.class)
			mono.android.TypeManager.Activate ("Android.Dialog.CheckboxElement, Android.Dialog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "System.String, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1 });
	}


	public void onCheckedChanged (android.widget.CompoundButton p0, boolean p1)
	{
		n_onCheckedChanged (p0, p1);
	}

	private native void n_onCheckedChanged (android.widget.CompoundButton p0, boolean p1);

	java.util.ArrayList refList;
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
