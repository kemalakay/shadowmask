# Shadowmask Tutorial
Demonstrating how new Shadowmask feature works in Unity 

### Light Modes tutorial: Shadowmask

This project includes the tutorial files for Shadowmask tutorial. In Unity 5.6, new light modes are introduced for blending baked and realtime shadows. This modes include Baked Indirect, Distance Shadowmask, Shadowmask and Subtractive. This tutorial goes through the details of authoring a scene for switching between Distance Shadowmask and Shadowmask modes.

In Unity 2017.1, Shadowmask option is moved to Quality Settings so users can change the mode at runtime. This tutorial explains how to change the mode through API as well as setting up light probes, reflection probes, lighting parameters, lighting settings and light types. These concepts can be applied to a realistic use case.

The project includes two scenes. The first one provides the basic version of the scene without any lighting setup. Scene (assets, props, particles, animated character) is prepared and the tutorial explains step by step how to author the lighting and post-processing. Second scene shows the completed version of the tutorial.

Tutorial can be found [here](http://kemalakay.com/?page_id=16)

![](https://github.com/kemalakay/shadowmask/blob/master/Images/02.jpg)

### What is Shadowmask?

 In Shadowmask mode, static objects receive shadows from other static objects via the precomputed Shadowmask texture, regardless of the shadow distance. In Distance Shadowmask mode, both dynamic and static objects are using realtime shadows within the shadow distance. That is the reason why drawcall amount is higher in Distance Shadowmask. Beyond the shadow distance, static objects receive high quality shadows from other static objects via the precomputed Shadowmask.

 Unlike subtractive mode, shadowmask feature allows users to blend between baked and realtime shadows with all mixed light types (directional, point and spotlight). In old versions of Unity, this was the main constraint. It was only possible to use one mixed directional light to avoid double shadowing and overbrightness.

![](https://github.com/kemalakay/shadowmask/blob/master/Images/01.jpg)

### Credits
* [Keijiro Takahashi](https://github.com/keijiro) for sIBL HDR cubemap, camera and movement scripts
* [ThreeDScans](http://threedscans.com/) for 3D sculpture of Plato
* R&D Content Team at Unity for Standard Assets
