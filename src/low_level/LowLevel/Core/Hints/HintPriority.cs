namespace OwlDomain.SDL3.LowLevel;

/// <summary>
/// An enumeration of hint priorities.<br/>
/// </summary>
/// <remarks>
/// This <see langword="enum"/> is available since SDL 3.2.0 as <c>SDL_HintPriority</c>.<br/>
/// <br/>
/// Wiki: <seealso href="https://wiki.libsdl.org/SDL3/SDL_HintPriority"/>.
/// </remarks>
public enum HintPriority : int
{
	/// <summary>The default hint priority.</summary>
	Default = 0,

	/// <summary>The normal hint priority.</summary>
	Normal,

	/// <summary>The override hint priority.</summary>
	Override,
}
