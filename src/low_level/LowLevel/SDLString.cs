namespace OwlDomain.SDL3.LowLevel;

/// <summary>
/// 	Represents a raw UTF-8 <see langword="string"/> that is owned by SDL3.
/// </summary>
[NativeMarshalling(typeof(SDLStringMarshaller))]
public readonly unsafe struct SDLString
{
	#region Properties
	/// <summary>The raw pointer to the UTF-8 string.</summary>
	public readonly byte* Pointer { get; }

	/// <summary>The marshalled <see langword="string"/> value.</summary>
	/// <remarks>This will convert the <see cref="Pointer"/> to the <see langword="string"/> with each access, if necessary you should save the returned value.</remarks>
	public readonly string? String => Marshal.PtrToStringUTF8((nint)Pointer);
	#endregion

	#region Constructors
	/// <summary>Creates a new <see cref="LowLevel.SDLString"/> value.</summary>
	/// <param name="pointer">The raw pointer to the UTF-8 string, this pointer should be owned by SDL3.</param>
	public SDLString(byte* pointer) => Pointer = pointer;
	#endregion

	#region Methods
	/// <summary>Returns the <see cref="String"/> value.</summary>
	/// <returns>The <see cref="String"/> value.</returns>
	public override string? ToString() => String;
	#endregion

	#region Operators
	/// <summary>Implicitly converts the given <see cref="SDLString"/> value to a <see langword="byte"/> pointer.</summary>
	/// <param name="value">The <see cref="SDLString"/> value to convert.</param>
	public static implicit operator byte*(SDLString value) => value.Pointer;

	/// <summary>Implicitly converts the given <see cref="SDLString"/> value to a .NET <see langword="string"/>.</summary>
	/// <param name="value">The <see cref="SDLString"/> value to convert.</param>
	public static implicit operator string?(SDLString value) => value.String;
	#endregion
}

[CustomMarshaller(typeof(SDLString), MarshalMode.Default, typeof(SDLStringMarshaller))]
internal static unsafe class SDLStringMarshaller
{
	#region Functions
	public static byte* ConvertToUnmanaged(SDLString managed) => throw new NotSupportedException($"Only strings owned by SDL3 should be converted.");
	public static SDLString ConvertToManaged(byte* pointer) => new(pointer);
	public static void Free(byte* _) { /* The string is owned by SDL3, .NET should not free it. */ }
	#endregion
}
