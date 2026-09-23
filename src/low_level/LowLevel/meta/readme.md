# SDL3 Bindings (Low-level)

This package contains hand-written bindings for
[SDL3](https://wiki.libsdl.org/SDL3/FrontPage). These bindings are meant to be
a low-level version of the bindings, providing direct access to the SDL3
functionality.

There will be some changes, but they will be minimal in order to make things
more C# centric, such as unshortening parameter names `w` -> `width`. And adding
extra functions as overloads, instead of suffixing the function names
*(however those will still be available).*
