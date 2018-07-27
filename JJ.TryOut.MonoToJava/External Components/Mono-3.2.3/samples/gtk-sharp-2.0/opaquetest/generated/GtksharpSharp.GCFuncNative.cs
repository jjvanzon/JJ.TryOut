// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtksharpSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.CDeclCallback]
	internal delegate void GCFuncNative();

	internal class GCFuncInvoker {

		GCFuncNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~GCFuncInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal GCFuncInvoker (GCFuncNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal GCFuncInvoker (GCFuncNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal GCFuncInvoker (GCFuncNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gtksharp.GCFunc Handler {
			get {
				return new Gtksharp.GCFunc(InvokeNative);
			}
		}

		void InvokeNative ()
		{
			native_cb ();
		}
	}

	internal class GCFuncWrapper {

		public void NativeCallback ()
		{
			try {
				managed ();
				if (release_on_call)
					gch.Free ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal GCFuncNative NativeDelegate;
		Gtksharp.GCFunc managed;

		public GCFuncWrapper (Gtksharp.GCFunc managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new GCFuncNative (NativeCallback);
		}

		public static Gtksharp.GCFunc GetManagedDelegate (GCFuncNative native)
		{
			if (native == null)
				return null;
			GCFuncWrapper wrapper = (GCFuncWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
