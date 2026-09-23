namespace OwlDomain.SDL3.LowLevel;

/// <summary>
/// Contains the low-level bindings for <see href="https://wiki.libsdl.org/SDL3/FrontPage">SDL3</see>.
/// </summary>
public static partial class SDL
{
	#region Constants
	/// <summary>The name of the native library.</summary>
	public const string LibName = "SDL3";
	private const UnmanagedType BoolType = UnmanagedType.U1;
	#endregion
}
