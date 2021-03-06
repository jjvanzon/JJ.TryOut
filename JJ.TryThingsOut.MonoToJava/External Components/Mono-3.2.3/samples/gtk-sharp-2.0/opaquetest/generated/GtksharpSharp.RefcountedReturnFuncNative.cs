// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtksharpSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.CDeclCallback]
	internal delegate IntPtr RefcountedReturnFuncNative();

	internal class RefcountedReturnFuncInvoker {

		RefcountedReturnFuncNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~RefcountedReturnFuncInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal RefcountedReturnFuncInvoker (RefcountedReturnFuncNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal RefcountedReturnFuncInvoker (RefcountedReturnFuncNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal RefcountedReturnFuncInvoker (RefcountedReturnFuncNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gtksharp.RefcountedReturnFunc Handler {
			get {
				return new Gtksharp.RefcountedReturnFunc(InvokeNative);
			}
		}

		Gtksharp.Refcounted InvokeNative ()
		{
			Gtksharp.Refcounted result = native_cb () == IntPtr.Zero ? null : (Gtksharp.Refcounted) GLib.Opaque.GetOpaque (native_cb (), typeof (Gtksharp.Refcounted), false);
			return result;
		}
	}

	internal class RefcountedReturnFuncWrapper {

		public IntPtr NativeCallback ()
		{
			try {
				Gtksharp.Refcounted __ret = managed ();
				if (release_on_call)
					gch.Free ();
				return __ret == null ? IntPtr.Zero : __ret.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: Above call does not return.
				throw e;
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal RefcountedReturnFuncNative NativeDelegate;
		Gtksharp.RefcountedReturnFunc managed;

		public RefcountedReturnFuncWrapper (Gtksharp.RefcountedReturnFunc managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new RefcountedReturnFuncNative (NativeCallback);
		}

		public static Gtksharp.RefcountedReturnFunc GetManagedDelegate (RefcountedReturnFuncNative native)
		{
			if (native == null)
				return null;
			RefcountedReturnFuncWrapper wrapper = (RefcountedReturnFuncWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
