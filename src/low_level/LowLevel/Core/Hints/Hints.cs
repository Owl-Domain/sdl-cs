using System.Globalization;

namespace OwlDomain.SDL3.LowLevel;

unsafe partial class SDL
{
	#region GetHint functions
	/// <summary>
	/// Get the value of a hint.
	/// </summary>
	/// <param name="name">The hint to query.</param>
	/// <returns>Returns the string value of a hint or <see langword="null"/> if the hint isn't set.</returns>
	/// <remarks>
	/// This function is available since SDL 3.2.0 as <c>SDL_GetHint</c>, and it is thread-safe.<br/>
	/// <br/>
	/// Wiki: <seealso href="https://wiki.libsdl.org/SDL3/SDL_GetHint"/>.
	/// </remarks>
	[LibraryImport(LibName, EntryPoint = "SDL_GetHint")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDLString GetHint(byte* name);

	/// <summary>
	/// Get the value of a hint.
	/// </summary>
	/// <param name="name">The hint to query.</param>
	/// <returns>Returns the string value of a hint or <see langword="null"/> if the hint isn't set.</returns>
	/// <remarks>
	/// This function is available since SDL 3.2.0 as <c>SDL_GetHint</c>, and it is thread-safe.<br/>
	/// <br/>
	/// Wiki: <seealso href="https://wiki.libsdl.org/SDL3/SDL_GetHint"/>.
	/// </remarks>
	[LibraryImport(LibName, EntryPoint = "SDL_GetHint", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDLString GetHint(string name);
	#endregion

	#region GetHintBoolean functions
	/// <summary>
	/// Get the <see langword="bool"/> value of a hint variable.
	/// </summary>
	/// <param name="name">The hint to query.</param>
	/// <param name="defaultValue">The value to return if the hint does not exist.</param>
	/// <returns>Returns the <see langword="bool"/> value of a hint or the provided <paramref name="defaultValue"/> if the hint does not exist.</returns>
	/// <remarks>
	/// This function is available since SDL 3.2.0 as <c>SDL_GetHintBoolean</c>, and it is thread-safe.<br/>
	/// <br/>
	/// Wiki: <seealso href="https://wiki.libsdl.org/SDL3/SDL_GetHintBoolean"/>.
	/// </remarks>
	[LibraryImport(LibName, EntryPoint = "SDL_GetHintBoolean")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolType)]
	public static partial bool GetHintBoolean(byte* name, [MarshalAs(BoolType)] bool defaultValue);

	/// <summary>
	/// Get the <see langword="bool"/> value of a hint variable.
	/// </summary>
	/// <param name="name">The hint to query.</param>
	/// <param name="defaultValue">The value to return if the hint does not exist.</param>
	/// <returns>Returns the <see langword="bool"/> value of a hint or the provided <paramref name="defaultValue"/> if the hint does not exist.</returns>
	/// <remarks>
	/// This function is available since SDL 3.2.0 as <c>SDL_GetHintBoolean</c>, and it is thread-safe.<br/>
	/// <br/>
	/// Wiki: <seealso href="https://wiki.libsdl.org/SDL3/SDL_GetHintBoolean"/>.
	/// </remarks>
	[LibraryImport(LibName, EntryPoint = "SDL_GetHintBoolean", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolType)]
	public static partial bool GetHintBoolean(string name, [MarshalAs(BoolType)] bool defaultValue);

	/// <summary>
	/// Get the <see langword="bool"/> value of a hint variable.
	/// </summary>
	/// <param name="name">The hint to query.</param>
	/// <param name="defaultValue">The value to return if the hint does not exist.</param>
	/// <returns>Returns the <see langword="bool"/> value of a hint or the provided <paramref name="defaultValue"/> if the hint does not exist.</returns>
	/// <remarks>
	/// This is an alias for the <see cref="GetHintBoolean(byte*, bool)"/> function.<br/>
	/// This function is available since SDL 3.2.0 as <c>SDL_GetHintBoolean</c>, and it is thread-safe.<br/>
	/// <br/>
	/// Wiki: <seealso href="https://wiki.libsdl.org/SDL3/SDL_GetHintBoolean"/>.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool GetHint(byte* name, [MarshalAs(BoolType)] bool defaultValue) => GetHintBoolean(name, defaultValue);

	/// <summary>
	/// Get the <see langword="bool"/> value of a hint variable.
	/// </summary>
	/// <param name="name">The hint to query.</param>
	/// <param name="defaultValue">The value to return if the hint does not exist.</param>
	/// <returns>Returns the <see langword="bool"/> value of a hint or the provided <paramref name="defaultValue"/> if the hint does not exist.</returns>
	/// <remarks>
	/// This is an alias for the <see cref="GetHintBoolean(string, bool)"/> function.<br/>
	/// This function is available since SDL 3.2.0 as <c>SDL_GetHintBoolean</c>, and it is thread-safe.<br/>
	/// <br/>
	/// Wiki: <seealso href="https://wiki.libsdl.org/SDL3/SDL_GetHintBoolean"/>.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool GetHint(string name, [MarshalAs(BoolType)] bool defaultValue) => GetHintBoolean(name, defaultValue);
	#endregion

	#region ResetHint functions
	/// <summary>
	/// Reset a hint to the default value.
	/// </summary>
	/// <param name="name">The hint to set.</param>
	/// <returns>Returns <see langword="true"/> on success or <see langword="false"/> on failure; call <see cref="GetError"/> for more information.</returns>
	/// <remarks>
	/// This will reset a hint to the value of the environment variable, or
	/// <see langword="null"/> if the environment isn't set.
	/// Callbacks will be called normally with this change.<br/>
	/// <br/>
	/// This function is available since SDL 3.2.0 as <c>SDL_ResetHint</c>, and it is thread-safe.<br/>
	/// <br/>
	/// Wiki: <seealso href="https://wiki.libsdl.org/SDL3/SDL_ResetHint"/>.
	/// </remarks>
	[LibraryImport(LibName, EntryPoint = "SDL_ResetHint")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolType)]
	public static partial bool ResetHint(byte* name);

	/// <summary>
	/// Reset a hint to the default value.
	/// </summary>
	/// <param name="name">The hint to set.</param>
	/// <returns>Returns <see langword="true"/> on success or <see langword="false"/> on failure; call <see cref="GetError"/> for more information.</returns>
	/// <remarks>
	/// This will reset a hint to the value of the environment variable, or
	/// <see langword="null"/> if the environment isn't set.
	/// Callbacks will be called normally with this change.<br/>
	/// <br/>
	/// This function is available since SDL 3.2.0 as <c>SDL_ResetHint</c>, and it is thread-safe.<br/>
	/// <br/>
	/// Wiki: <seealso href="https://wiki.libsdl.org/SDL3/SDL_ResetHint"/>.
	/// </remarks>
	[LibraryImport(LibName, EntryPoint = "SDL_ResetHint", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolType)]
	public static partial bool ResetHint(string name);
	#endregion

	#region ResetHints functions
	/// <summary>
	/// Reset all hints to the default values.
	/// </summary>
	/// <remarks>
	/// This will reset all hints to the value of the associated environment variable, or
	/// <see langword="null"/> if the environment isn't set.
	/// Callbacks will be called normally with this change.<br/>
	/// <br/>
	/// This function is available since SDL 3.2.0 as <c>SDL_ResetHints</c>, and it is thread-safe.<br/>
	/// <br/>
	/// Wiki: <seealso href="https://wiki.libsdl.org/SDL3/SDL_ResetHints"/>.
	/// </remarks>
	[LibraryImport(LibName, EntryPoint = "SDL_ResetHints")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void ResetHints();
	#endregion

	#region SetHint functions
	/// <summary>
	/// Set a hint with <see cref="HintPriority.Normal"/>.
	/// </summary>
	/// <param name="name">The hint to set.</param>
	/// <param name="value">The value of the hint variable.</param>
	/// <returns>Returns <see langword="true"/> on success or <see langword="false"/> on failure; call <see cref="GetError"/> for more information.</returns>
	/// <remarks>
	/// Hints will not be set if there is an existing <see cref="HintPriority.Override"/> hint or environment variable that takes precedence.
	/// You can use <see cref="SetHintWithPriority(byte*, byte*, HintPriority)"/> to set the hint with <see cref="HintPriority.Override"/> instead.
	/// <br/>
	/// This function is available since SDL 3.2.0 as <c>SDL_SetHint</c>, and it is thread-safe.<br/>
	/// <br/>
	/// Wiki: <seealso href="https://wiki.libsdl.org/SDL3/SDL_SetHint"/>.
	/// </remarks>
	[LibraryImport(LibName, EntryPoint = "SDL_SetHint")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolType)]
	public static partial bool SetHint(byte* name, byte* value);

	/// <summary>
	/// Set a hint with <see cref="HintPriority.Normal"/>.
	/// </summary>
	/// <param name="name">The hint to set.</param>
	/// <param name="value">The value of the hint variable.</param>
	/// <returns>Returns <see langword="true"/> on success or <see langword="false"/> on failure; call <see cref="GetError"/> for more information.</returns>
	/// <remarks>
	/// Hints will not be set if there is an existing <see cref="HintPriority.Override"/> hint or environment variable that takes precedence.
	/// You can use <see cref="SetHintWithPriority(string, byte*, HintPriority)"/> to set the hint with <see cref="HintPriority.Override"/> instead.
	/// <br/>
	/// This function is available since SDL 3.2.0 as <c>SDL_SetHint</c>, and it is thread-safe.<br/>
	/// <br/>
	/// Wiki: <seealso href="https://wiki.libsdl.org/SDL3/SDL_SetHint"/>.
	/// </remarks>
	[LibraryImport(LibName, EntryPoint = "SDL_SetHint", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolType)]
	public static partial bool SetHint(string name, byte* value);

	/// <summary>
	/// Set a hint with <see cref="HintPriority.Normal"/>.
	/// </summary>
	/// <param name="name">The hint to set.</param>
	/// <param name="value">The value of the hint variable.</param>
	/// <returns>Returns <see langword="true"/> on success or <see langword="false"/> on failure; call <see cref="GetError"/> for more information.</returns>
	/// <remarks>
	/// Hints will not be set if there is an existing <see cref="HintPriority.Override"/> hint or environment variable that takes precedence.
	/// You can use <see cref="SetHintWithPriority(byte*, string, HintPriority)"/> to set the hint with <see cref="HintPriority.Override"/> instead.
	/// <br/>
	/// This function is available since SDL 3.2.0 as <c>SDL_SetHint</c>, and it is thread-safe.<br/>
	/// <br/>
	/// Wiki: <seealso href="https://wiki.libsdl.org/SDL3/SDL_SetHint"/>.
	/// </remarks>
	[LibraryImport(LibName, EntryPoint = "SDL_SetHint", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolType)]
	public static partial bool SetHint(byte* name, string? value);

	/// <summary>
	/// Set a hint with <see cref="HintPriority.Normal"/>.
	/// </summary>
	/// <param name="name">The hint to set.</param>
	/// <param name="value">The value of the hint variable.</param>
	/// <returns>Returns <see langword="true"/> on success or <see langword="false"/> on failure; call <see cref="GetError"/> for more information.</returns>
	/// <remarks>
	/// Hints will not be set if there is an existing <see cref="HintPriority.Override"/> hint or environment variable that takes precedence.
	/// You can use <see cref="SetHintWithPriority(string, string, HintPriority)"/> to set the hint with <see cref="HintPriority.Override"/> instead.
	/// <br/>
	/// This function is available since SDL 3.2.0 as <c>SDL_SetHint</c>, and it is thread-safe.<br/>
	/// <br/>
	/// Wiki: <seealso href="https://wiki.libsdl.org/SDL3/SDL_SetHint"/>.
	/// </remarks>
	[LibraryImport(LibName, EntryPoint = "SDL_SetHint", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolType)]
	public static partial bool SetHint(string name, string? value);
	#endregion

	#region SetHintWithPriority functions
	/// <summary>
	/// Set a hint with a specific priority.
	/// </summary>
	/// <param name="name">The hint to set.</param>
	/// <param name="value">The value of the hint variable.</param>
	/// <param name="priority">The priority level for the hint.</param>
	/// <returns>Returns <see langword="true"/> on success or <see langword="false"/> on failure; call <see cref="GetError"/> for more information.</returns>
	/// <remarks>
	/// The priority controls the behavior when setting a hint that already has a value.
	/// Hints will replace existing hints of their priority and lower.
	/// Environment variables are considered to have <see cref="HintPriority.Override"/> priority.<br/>
	/// <br/>
	/// This function is available since SDL 3.2.0 as <c>SDL_SetHintWithPriority</c>, and it is thread-safe.<br/>
	/// <br/>
	/// Wiki: <seealso href="https://wiki.libsdl.org/SDL3/SDL_SetHintWithPriority"/>.
	/// </remarks>
	[LibraryImport(LibName, EntryPoint = "SDL_SetHintWithPriority")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolType)]
	public static partial bool SetHintWithPriority(byte* name, byte* value, HintPriority priority);

	/// <summary>
	/// Set a hint with a specific priority.
	/// </summary>
	/// <param name="name">The hint to set.</param>
	/// <param name="value">The value of the hint variable.</param>
	/// <param name="priority">The priority level for the hint.</param>
	/// <returns>Returns <see langword="true"/> on success or <see langword="false"/> on failure; call <see cref="GetError"/> for more information.</returns>
	/// <remarks>
	/// The priority controls the behavior when setting a hint that already has a value.
	/// Hints will replace existing hints of their priority and lower.
	/// Environment variables are considered to have <see cref="HintPriority.Override"/> priority.<br/>
	/// <br/>
	/// This is an alias for the <see cref="SetHintWithPriority(byte*, byte*, HintPriority)"/> function.<br/>
	/// This function is available since SDL 3.2.0 as <c>SDL_SetHintWithPriority</c>, and it is thread-safe.<br/>
	/// <br/>
	/// Wiki: <seealso href="https://wiki.libsdl.org/SDL3/SDL_SetHintWithPriority"/>.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool SetHint(byte* name, byte* value, HintPriority priority) => SetHint(name, value, priority);

	/// <summary>
	/// Set a hint with a specific priority.
	/// </summary>
	/// <param name="name">The hint to set.</param>
	/// <param name="value">The value of the hint variable.</param>
	/// <param name="priority">The priority level for the hint.</param>
	/// <returns>Returns <see langword="true"/> on success or <see langword="false"/> on failure; call <see cref="GetError"/> for more information.</returns>
	/// <remarks>
	/// The priority controls the behavior when setting a hint that already has a value.
	/// Hints will replace existing hints of their priority and lower.
	/// Environment variables are considered to have <see cref="HintPriority.Override"/> priority.<br/>
	/// <br/>
	/// This function is available since SDL 3.2.0 as <c>SDL_SetHintWithPriority</c>, and it is thread-safe.<br/>
	/// <br/>
	/// Wiki: <seealso href="https://wiki.libsdl.org/SDL3/SDL_SetHintWithPriority"/>.
	/// </remarks>
	[LibraryImport(LibName, EntryPoint = "SDL_SetHintWithPriority", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolType)]
	public static partial bool SetHintWithPriority(string name, byte* value, HintPriority priority);

	/// <summary>
	/// Set a hint with a specific priority.
	/// </summary>
	/// <param name="name">The hint to set.</param>
	/// <param name="value">The value of the hint variable.</param>
	/// <param name="priority">The priority level for the hint.</param>
	/// <returns>Returns <see langword="true"/> on success or <see langword="false"/> on failure; call <see cref="GetError"/> for more information.</returns>
	/// <remarks>
	/// The priority controls the behavior when setting a hint that already has a value.
	/// Hints will replace existing hints of their priority and lower.
	/// Environment variables are considered to have <see cref="HintPriority.Override"/> priority.<br/>
	/// <br/>
	/// This is an alias for the <see cref="SetHintWithPriority(string, byte*, HintPriority)"/> function.<br/>
	/// This function is available since SDL 3.2.0 as <c>SDL_SetHintWithPriority</c>, and it is thread-safe.<br/>
	/// <br/>
	/// Wiki: <seealso href="https://wiki.libsdl.org/SDL3/SDL_SetHintWithPriority"/>.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool SetHint(string name, byte* value, HintPriority priority) => SetHint(name, value, priority);

	/// <summary>
	/// Set a hint with a specific priority.
	/// </summary>
	/// <param name="name">The hint to set.</param>
	/// <param name="value">The value of the hint variable.</param>
	/// <param name="priority">The priority level for the hint.</param>
	/// <returns>Returns <see langword="true"/> on success or <see langword="false"/> on failure; call <see cref="GetError"/> for more information.</returns>
	/// <remarks>
	/// The priority controls the behavior when setting a hint that already has a value.
	/// Hints will replace existing hints of their priority and lower.
	/// Environment variables are considered to have <see cref="HintPriority.Override"/> priority.<br/>
	/// <br/>
	/// This function is available since SDL 3.2.0 as <c>SDL_SetHintWithPriority</c>, and it is thread-safe.<br/>
	/// <br/>
	/// Wiki: <seealso href="https://wiki.libsdl.org/SDL3/SDL_SetHintWithPriority"/>.
	/// </remarks>
	[LibraryImport(LibName, EntryPoint = "SDL_SetHintWithPriority", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolType)]
	public static partial bool SetHintWithPriority(byte* name, string? value, HintPriority priority);

	/// <summary>
	/// Set a hint with a specific priority.
	/// </summary>
	/// <param name="name">The hint to set.</param>
	/// <param name="value">The value of the hint variable.</param>
	/// <param name="priority">The priority level for the hint.</param>
	/// <returns>Returns <see langword="true"/> on success or <see langword="false"/> on failure; call <see cref="GetError"/> for more information.</returns>
	/// <remarks>
	/// The priority controls the behavior when setting a hint that already has a value.
	/// Hints will replace existing hints of their priority and lower.
	/// Environment variables are considered to have <see cref="HintPriority.Override"/> priority.<br/>
	/// <br/>
	/// This is an alias for the <see cref="SetHintWithPriority(byte*, string, HintPriority)"/> function.<br/>
	/// This function is available since SDL 3.2.0 as <c>SDL_SetHintWithPriority</c>, and it is thread-safe.<br/>
	/// <br/>
	/// Wiki: <seealso href="https://wiki.libsdl.org/SDL3/SDL_SetHintWithPriority"/>.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool SetHint(byte* name, string? value, HintPriority priority) => SetHint(name, value, priority);

	/// <summary>
	/// Set a hint with a specific priority.
	/// </summary>
	/// <param name="name">The hint to set.</param>
	/// <param name="value">The value of the hint variable.</param>
	/// <param name="priority">The priority level for the hint.</param>
	/// <returns>Returns <see langword="true"/> on success or <see langword="false"/> on failure; call <see cref="GetError"/> for more information.</returns>
	/// <remarks>
	/// The priority controls the behavior when setting a hint that already has a value.
	/// Hints will replace existing hints of their priority and lower.
	/// Environment variables are considered to have <see cref="HintPriority.Override"/> priority.<br/>
	/// <br/>
	/// This function is available since SDL 3.2.0 as <c>SDL_SetHintWithPriority</c>, and it is thread-safe.<br/>
	/// <br/>
	/// Wiki: <seealso href="https://wiki.libsdl.org/SDL3/SDL_SetHintWithPriority"/>.
	/// </remarks>
	[LibraryImport(LibName, EntryPoint = "SDL_SetHintWithPriority", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolType)]
	public static partial bool SetHintWithPriority(string name, string? value, HintPriority priority);

	/// <summary>
	/// Set a hint with a specific priority.
	/// </summary>
	/// <param name="name">The hint to set.</param>
	/// <param name="value">The value of the hint variable.</param>
	/// <param name="priority">The priority level for the hint.</param>
	/// <returns>Returns <see langword="true"/> on success or <see langword="false"/> on failure; call <see cref="GetError"/> for more information.</returns>
	/// <remarks>
	/// The priority controls the behavior when setting a hint that already has a value.
	/// Hints will replace existing hints of their priority and lower.
	/// Environment variables are considered to have <see cref="HintPriority.Override"/> priority.<br/>
	/// <br/>
	/// This is an alias for the <see cref="SetHintWithPriority(string, string, HintPriority)"/> function.<br/>
	/// This function is available since SDL 3.2.0 as <c>SDL_SetHintWithPriority</c>, and it is thread-safe.<br/>
	/// <br/>
	/// Wiki: <seealso href="https://wiki.libsdl.org/SDL3/SDL_SetHintWithPriority"/>.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool SetHint(string name, string? value, HintPriority priority) => SetHint(name, value, priority);
	#endregion

	#region SetHint helpers
	/// <summary>
	/// Set a hint with a specific priority.
	/// </summary>
	/// <param name="name">The hint to set.</param>
	/// <param name="value">The value of the hint variable.</param>
	/// <param name="priority">The priority level for the hint.</param>
	/// <returns>Returns <see langword="true"/> on success or <see langword="false"/> on failure; call <see cref="GetError"/> for more information.</returns>
	/// <remarks>
	/// The priority controls the behavior when setting a hint that already has a value.
	/// Hints will replace existing hints of their priority and lower.
	/// Environment variables are considered to have <see cref="HintPriority.Override"/> priority.<br/>
	/// <br/>
	/// This is a helper for the <see cref="SetHintWithPriority(byte*, string, HintPriority)"/> function.<br/>
	/// This function is available since SDL 3.2.0 as <c>SDL_SetHintWithPriority</c>, and it is thread-safe.<br/>
	/// <br/>
	/// Wiki: <seealso href="https://wiki.libsdl.org/SDL3/SDL_SetHintWithPriority"/>.
	/// </remarks>
	public static bool SetHint(byte* name, bool value, HintPriority priority = HintPriority.Normal) => SetHint(name, value ? "1" : "0", priority);

	/// <summary>
	/// Set a hint with a specific priority.
	/// </summary>
	/// <param name="name">The hint to set.</param>
	/// <param name="value">The value of the hint variable.</param>
	/// <param name="priority">The priority level for the hint.</param>
	/// <returns>Returns <see langword="true"/> on success or <see langword="false"/> on failure; call <see cref="GetError"/> for more information.</returns>
	/// <remarks>
	/// The priority controls the behavior when setting a hint that already has a value.
	/// Hints will replace existing hints of their priority and lower.
	/// Environment variables are considered to have <see cref="HintPriority.Override"/> priority.<br/>
	/// <br/>
	/// This is a helper for the <see cref="SetHintWithPriority(string, string, HintPriority)"/> function.<br/>
	/// This function is available since SDL 3.2.0 as <c>SDL_SetHintWithPriority</c>, and it is thread-safe.<br/>
	/// <br/>
	/// Wiki: <seealso href="https://wiki.libsdl.org/SDL3/SDL_SetHintWithPriority"/>.
	/// </remarks>
	public static bool SetHint(string name, bool value, HintPriority priority = HintPriority.Normal) => SetHint(name, value ? "1" : "0", priority);

	/// <summary>
	/// Set a hint with a specific priority.
	/// </summary>
	/// <param name="name">The hint to set.</param>
	/// <param name="value">The value of the hint variable.</param>
	/// <param name="priority">The priority level for the hint.</param>
	/// <returns>Returns <see langword="true"/> on success or <see langword="false"/> on failure; call <see cref="GetError"/> for more information.</returns>
	/// <remarks>
	/// The priority controls the behavior when setting a hint that already has a value.
	/// Hints will replace existing hints of their priority and lower.
	/// Environment variables are considered to have <see cref="HintPriority.Override"/> priority.<br/>
	/// <br/>
	/// This is a helper for the <see cref="SetHintWithPriority(byte*, string, HintPriority)"/> function.<br/>
	/// This function is available since SDL 3.2.0 as <c>SDL_SetHintWithPriority</c>, and it is thread-safe.<br/>
	/// <br/>
	/// Wiki: <seealso href="https://wiki.libsdl.org/SDL3/SDL_SetHintWithPriority"/>.
	/// </remarks>
	public static bool SetHint(byte* name, int value, HintPriority priority = HintPriority.Normal) => SetHint(name, value.ToString("D", CultureInfo.InvariantCulture), priority);

	/// <summary>
	/// Set a hint with a specific priority.
	/// </summary>
	/// <param name="name">The hint to set.</param>
	/// <param name="value">The value of the hint variable.</param>
	/// <param name="priority">The priority level for the hint.</param>
	/// <returns>Returns <see langword="true"/> on success or <see langword="false"/> on failure; call <see cref="GetError"/> for more information.</returns>
	/// <remarks>
	/// The priority controls the behavior when setting a hint that already has a value.
	/// Hints will replace existing hints of their priority and lower.
	/// Environment variables are considered to have <see cref="HintPriority.Override"/> priority.<br/>
	/// <br/>
	/// This is a helper for the <see cref="SetHintWithPriority(string, string, HintPriority)"/> function.<br/>
	/// This function is available since SDL 3.2.0 as <c>SDL_SetHintWithPriority</c>, and it is thread-safe.<br/>
	/// <br/>
	/// Wiki: <seealso href="https://wiki.libsdl.org/SDL3/SDL_SetHintWithPriority"/>.
	/// </remarks>
	public static bool SetHint(string name, int value, HintPriority priority = HintPriority.Normal) => SetHint(name, value.ToString("D", CultureInfo.InvariantCulture), priority);
	#endregion
}
