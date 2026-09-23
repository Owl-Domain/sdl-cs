# C# bindings for SDL3

This project contains hand-written written C#/.NET bindings for
[SDL3](https://wiki.libsdl.org/SDL3/FrontPage).

These bindings will focus on being hand-written, fully documented by using the
official [SDL3 wiki](https://wiki.libsdl.org/SDL3/FrontPage) as the source,
along with links to the relevant pages, and the versioning information.

The current plan is to split the library into two parts, one for "low level"
bindings, and one for "high level" bindings that use the "low level" ones, and
still lets you use them directly if/when necessary.

> [!WARNING]
> These bindings do not come bundled with the native SDL3 binaries, this is so
> that you are free to choose whichever source you prefer for them.
> However, fret not, as we also offer the native SDL3 binaries as a separate
> NuGet package.
>
> Learn more on the [sdl-nuget](https://github.com/owl-domain/sdl-nuget)
> repository.


## Development

The development of this project happens primarily on the `dev` branch.
