using System.IO;
using System.Text.Json;

namespace OwlDomain.SDL3.LowLevel.Tests.Info;

internal sealed class SDLNameInfo
{
	#region Fields
	private static readonly Lazy<SDLNameInfo> _names = new(Load);
	#endregion

	#region Properties
	public static SDLNameInfo Names => _names.Value;

	[JsonPropertyName("functions")]
	public required Dictionary<string, SDLFunctionInfo> Functions { get; init; }
	#endregion

	#region Functions
	public static SDLNameInfo Load()
	{
		const string relativePath = "../../../../Info/sdl_names.json";
		string path = Path.GetFullPath(relativePath);

		string json = File.ReadAllText(path);
		SDLNameInfo? names = JsonSerializer.Deserialize<SDLNameInfo>(json) ?? throw new InvalidOperationException($"Failed to load the SDL names from the '{path}' json file.");

		return names;
	}
	#endregion
}

internal sealed class SDLFunctionInfo { }
