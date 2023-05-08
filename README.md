# hedera
<img width=320 align=right src=https://user-images.githubusercontent.com/2285943/60907136-d0713000-a246-11e9-97a2-de9cb8ffa8cd.gif> 

- paint 3D ivy in Unity, simulate growth
- includes textures, shaders, and 5 presets for painting realistic ivy, cartoon ivy, or even ropes and cables
- curious about vert count / polycount? [download sample ivy .OBJ (right-click Save As)](https://raw.githubusercontent.com/radiatoryang/hedera/master/Example/ExampleIvyMeshExport.obj)
    - merge multiple ivy meshes to save draw calls, or just let static batching work
    - randomize vertex colors for subtle color variation, auto-unwrap ivy UV2s for lightmapping
    - store ivy meshes directly in your project, or export to .OBJ (note: OBJ file format doesn't support vertex color nor UV2)
- 25+ different ivy settings to tweak for your own presets! guide and user documentation is on the [Wiki](https://github.com/radiatoryang/hedera/wiki)
- tested on Unity 5.6.7f1 and 2019.1.8 and 2021.2.0f1 (but probably works ok on other Unity versions too)
- **no HDRP or URP shaders included** so you have to swap in your own, but everything else will still probably work OK
- [changelog](https://github.com/radiatoryang/hedera/blob/master/CHANGELOG.md)

### installation 
- (recommended) in Unity's Package Manager, add ``https://github.com/radiatoryang/hedera.git`` as a Git URL package [full instructions](https://github.com/radiatoryang/hedera/wiki#unity-package-manager-recommended)
- or manually download the latest .ZIP from [Releases](https://github.com/radiatoryang/hedera/releases) and unzip to ``/<your project folder>/Packages/com.radiatoryang.hedera/``
- or clone this Git repository as a [submodule](https://git-scm.com/book/en/v2/Git-Tools-Submodules) into ``/<your project folder>/Packages/com.radiatoryang.hedera/``

### contributors
- please post bug reports or (small) feature requests as an [Issue](https://github.com/radiatoryang/hedera/issues)
- [Pull Requests](https://github.com/radiatoryang/hedera/pulls) are welcome and encouraged

### license
**GPL2** (due to original author's use of GPL2)
- **You can use the ivy assets / generated meshes and results, with any or no license, in commercial or closed source projects.** GPL2 focuses on the code, and does not apply to program output.
- All code is editor-only and stripped upon build, which (I think) avoids GPL2's wrath. This code basically won't be in your build, which means you aren't distributing it.
- If you use this code / tool in your own tool AND distribute that tool, then your tool must use GPL2. Note that Unity Asset Store bans licenses like GPL, so no part of this tool can ever be put on the Asset Store.
- _(but I am not a lawyer, this is not legal advice, etc.)_

### acknowledgments
- based on [C++ code by Thomas Luft](http://graphics.uni-konstanz.de/~luft/ivy_generator/) from 2006 (!)
- based on [Unity C# port by Weng Xiao Yi](https://github.com/phoenixzz/IvyGenerator)
- uses [painting code](https://github.com/marmitoTH/Unity-Prefab-Placement-Editor) and [foliage shader code](https://github.com/marmitoTH/unity-enhanced-foliage) by Lucas Rodrigues
- uses [.OBJ exporter code](https://wiki.unity3d.com/index.php/ExportOBJ) by DaveA, KeliHlodversson, tgraupmann, drobe
- uses [Douglas-Peucker line simplifier code](https://github.com/rohaanhamid/simplify-csharp) by Rohaan Hamid

### press
- this got [coverage in PC Gamer](https://www.pcgamer.com/this-free-open-source-tool-can-help-game-developers-make-procedural-ivy/) for some reason

### donations
- donate to the original Ivy Generator author (Thomas Luft): http://www.loim.de/ivy_generator_donation/
- to donate to me, just go to my itch.io page and buy / tip whatever you want: https://radiatoryang.itch.io/
