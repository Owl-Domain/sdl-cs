namespace OwlDomain.SDL3.LowLevel;

partial class SDL
{
	/// <summary>
	/// Represents a container for tha names of all of the known SDL3 hints.
	/// </summary>
	public static class KnownHints
	{
		#region Constants
		/// <summary>
		/// Specify the behavior of Alt+Tab while the keyboard is grabbed.
		/// </summary>
		/// <remarks>
		/// By default, SDL emulates Alt+Tab functionality while the keyboard is grabbed and your window is full-screen.
		/// This prevents the user from getting stuck in your application if you've enabled keyboard grab.
		/// <list type="bullet">
		/// <item><c>"0"</c> (<see langword="false"/>): SDL will not handle Alt+Tab. Your application is responsible for handling Alt+Tab while the keyboard is grabbed.</item>
		/// <item><c>"1"</c> (<see langword="true"/>): SDL will minimize your window when Alt+Tab is pressed (default).</item>
		/// </list>
		/// This hint is available since SDL 3.2.0 as <c>SDL_HINT_ALLOW_ALT_TAB_WHILE_GRABBED</c>, and it can be set anytime.<br/>
		/// <br/>
		/// Wiki: <seealso href="https://wiki.libsdl.org/SDL3/SDL_HINT_ALLOW_ALT_TAB_WHILE_GRABBED"/>.
		/// </remarks>
		public const string AllowAltTabWhileGrabbed = "SDL_ALLOW_ALT_TAB_WHILE_GRABBED";

		/// <summary>
		/// A variable setting the app ID string.
		/// </summary>
		/// <remarks>
		/// This string is used by desktop compositors to identify and group windows together, as well as match applications with associated desktop settings and icons.
		/// This hint is available since SDL 3.2.0 as <c>SDL_HINT_APP_ID</c>, and it should be set before SDL is initialized.<br/>
		/// <br/>
		/// Wiki: <seealso href="https://wiki.libsdl.org/SDL3/SDL_HINT_APP_ID"/>.
		/// </remarks>
		public const string AppId = "SDL_APP_ID";

		/// <summary>
		/// A variable setting the application name.
		/// </summary>
		/// <remarks>
		/// This hint lets you specify the application name sent to the OS when required.
		/// For example, this will often appear in volume control applets for audio streams,
		/// and in lists of applications which are inhibiting the screensaver.
		/// You should use a string that describes your program (<c>"My Game 2: The Revenge"</c>)<br/>
		/// <br/>
		/// This hint is available since SDL 3.2.0 as <c>SDL_HINT_APP_NAME</c>, and it should be set before SDL is initialized.<br/>
		/// <br/>
		/// Wiki: <seealso href="https://wiki.libsdl.org/SDL3/SDL_HINT_APP_NAME"/>.
		/// </remarks>
		public const string AppName = "SDL_APP_NAME";
		#endregion
	}
}
