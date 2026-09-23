namespace OwlDomain.SDL3.LowLevel;

partial class SDL
{
	#region Functions
	/// <summary>Retrieves a message about the last error that occurred on the current thread.</summary>
	/// <returns>
	/// Returns a message with information about the specific error that occurred, or an empty string
	/// if there hasn't been an error message set since the last call to <see cref="ClearError"/>.
	/// </returns>
	/// <remarks>
	/// It is possible for multiple errors to occur before calling <see cref="GetError"/>. Only the last error is returned.
	/// The message is only applicable when an SDL function has signaled an error. You must check the return values of SDL
	/// function calls to determine when to appropriately call <see cref="GetError"/>. You should not use the results of
	/// <see cref="GetError"/> to decide if an error has occurred! Sometimes SDL will set an error string even when reporting
	/// success.<br/>
	/// <br/>
	/// SDL will <i>not</i> clear the error string for successful API calls. You must check return values for failure cases
	/// before you can assume the error string applies.<br/>
	/// <br/>
	/// Error strings are set per-thread, so an error set in a different thread will not interfere with the current thread's operation.
	/// The returned value is a thread-local string which will remain valid until the current thread's error string is changed.
	/// The caller should make a copy if the value is needed after the next SDL API call.<br/>
	/// <br/>
	/// This function is available since SDL 3.2.0 as <c>SDL_GetError</c>, and it is thread-safe.<br/>
	/// <br/>
	/// Wiki: <seealso href="https://wiki.libsdl.org/SDL3/SDL_GetError"/>.
	/// </remarks>
	/// <seealso cref="ClearError"/>
	[LibraryImport(LibName, EntryPoint = "SDL_GetError")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDLString GetError();

	/// <summary>Clears any previous error message for this thread.</summary>
	/// <returns>Always returns <see langword="true"/>.</returns>
	/// <remarks>
	/// This function is available since SDL 3.2.0 as <c>SDL_ClearError</c>, and it is thread-safe.<br/>
	/// <br/>
	/// Wiki: <seealso href="https://wiki.libsdl.org/SDL3/SDL_ClearError"/>.
	/// </remarks>
	[LibraryImport(LibName, EntryPoint = "SDL_ClearError")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolType)]
	public static partial bool ClearError();

	/// <summary>Sets an error indicating that memory allocation failed.</summary>
	/// <returns>Always returns <see langword="false"/>.</returns>
	/// <remarks>
	/// This function is available since SDL 3.2.0 as <c>SDL_OutOfMemory</c>, and it is thread-safe.<br/>
	/// <br/>
	/// Wiki: <seealso href="https://wiki.libsdl.org/SDL3/SDL_OutOfMemory"/>.
	/// </remarks>
	[LibraryImport(LibName, EntryPoint = "SDL_OutOfMemory")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolType)]
	public static partial bool OutOfMemory();
	#endregion
}
