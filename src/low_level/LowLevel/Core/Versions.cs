namespace OwlDomain.SDL3.LowLevel;

/// <summary>
/// Represents an SDL version.
/// </summary>
public readonly struct SDLVersion
{
	#region Properties
	/// <summary>The full version number.</summary>
	public int Number { get; }

	/// <summary>The major version.</summary>
	public int Major => Number / 1_000_000;

	/// <summary>The minor version.</summary>
	public int Minor => Number / 1000 % 1000;

	/// <summary>The micro version.</summary>
	public int Micro => Number % 1000;
	#endregion

	#region Constructors
	/// <summary>Creates a new <see cref="SDLVersion"/>.</summary>
	/// <param name="number">The full version number.</param>
	public SDLVersion(int number) => Number = number;
	#endregion

	#region Operators
	/// <summary>Implicitly converts the given <see cref="SDLString"/> value to an <see langword="int"/> representing the full version number.</summary>
	/// <param name="value">The <see cref="SDLVersion"/> value to convert.</param>
	public static implicit operator int(SDLVersion value) => value.Number;

	/// <summary>Implicitly converts the given <see cref="SDLVersion"/> value to a <see cref="Version"/>.</summary>
	/// <param name="value">The <see cref="SDLVersion"/> value to convert.</param>
	public static implicit operator Version(SDLVersion value) => new(value.Major, value.Minor, value.Micro);
	#endregion
}

partial class SDL
{
	#region Functions
	[LibraryImport(LibName, EntryPoint = "SDL_GetVersion")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _GetVersion();

	/// <summary>Get the version of SDL that is linked against your program.</summary>
	/// <returns>Returns the version of the linked library.</returns>
	/// <remarks>
	/// This function is available since SDL 3.2.0 as <c>SDL_GetVersion</c>, it is thread-safe, and can be called at any time.<br/>
	/// <br/>
	/// Wiki: <seealso href="https://wiki.libsdl.org/SDL3/SDL_GetVersion"/>.
	/// </remarks>
	public static SDLVersion GetVersion()
	{
		int number = _GetVersion();
		return new(number);
	}

	/// <summary>Get the code revision of the SDL library that is linked against your program.</summary>
	/// <returns>Returns an arbitrary <see cref="SDLString"/>, uniquely identifying the exact revision of the SDL library in use.</returns>
	/// <remarks>
	/// The revision is an arbitrary string (a hash value) uniquely identifying the exact revision of the SDL library in use,
	/// and is only useful in comparing against other revisions. It is NOT an incrementing number.<br/>
	/// <br/>
	/// If SDL wasn't built from a git repository with the appropriate tools, this will return an empty string.<br/>
	/// You shouldn't use this function for anything but logging it for debugging purposes. The string is not intended to be reliable in any way.<br/>
	/// <br/>
	/// This function is available since SDL 3.2.0 as <c>SDL_GetRevision</c>, it is thread-safe, and can be called at any time.<br/>
	/// <br/>
	/// Wiki: <seealso href="https://wiki.libsdl.org/SDL3/SDL_GetRevision"/>.
	/// </remarks>
	[LibraryImport(LibName, EntryPoint = "SDL_GetRevision")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDLString GetRevision();
	#endregion
}
