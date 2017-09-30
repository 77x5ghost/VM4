//eur_lightbar
singleton Material(eurlightbarvm)
{
    mapTo = "eurlightbarvm";
    diffuseMap[0] = "vehicles/common/vmlightbars/eurlightbar_dvm.dds";
    specularMap[0] = "vehicles/common/lightbars/eurlightbar_s.dds";
    normalMap[0] = "vehicles/common/lightbars/eurlightbar_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 1";
    useAnisotropic[0] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(eurlightbar_glassvm)
{
    mapTo = "eurlightbar_glassvm";
    diffuseMap[0] = "vehicles/common/vmlightbars/eurlightbar_dvm.dds";
    specularMap[0] = "vehicles/common/lightbars/eurlightbar_s.dds";
    normalMap[0] = "vehicles/common/lightbars/eurlightbar_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 1";
    useAnisotropic[0] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "LerpAlpha";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(eurlightbarBvm)
{
    mapTo = "eurlightbarBvm";
    diffuseMap[1] = "vehicles/common/vmlightbars/eurlightbar_dvm.dds";
    specularMap[1] = "vehicles/common/lightbars/eurlightbar_s.dds";
    normalMap[1] = "vehicles/common/lightbars/eurlightbar_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/common/lightbars/eurlightbar_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "0.6 0.6 0.6 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    castShadows = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    glow[0] = "0";
    glow[1] = "0";
    emissive[0] = "0";
    emissive[1] = "0";
};

singleton Material(eurlightbarB2vm)
{
    mapTo = "eurlightbarB2vm";
    diffuseMap[1] = "vehicles/common/vmlightbars/eurlightbar_dvm.dds";
    specularMap[1] = "vehicles/common/lightbars/eurlightbar_s.dds";
    normalMap[1] = "vehicles/common/lightbars/eurlightbar_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/common/lightbars/eurlightbar_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "0.6 0.6 0.6 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    castShadows = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    glow[0] = "0";
    glow[1] = "0";
    emissive[0] = "0";
    emissive[1] = "0";
};

//B_on

singleton Material(eurlightbarB_onvm)
{
    mapTo = "eurlightbarB_onvm";
    diffuseMap[2] = "vehicles/common/vmlightbars/eurlightbar_gvm.dds";
    specularMap[2] = "vehicles/common/lightbars/eurlightbar_s.dds";
    normalMap[2] = "vehicles/common/lightbars/eurlightbar_n.dds";
    diffuseMap[1] = "vehicles/common/vmlightbars/eurlightbar_dvm.dds";
    specularMap[1] = "vehicles/common/lightbars/eurlightbar_s.dds";
    normalMap[1] = "vehicles/common/lightbars/eurlightbar_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/common/lightbars/eurlightbar_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1.5 1.5 1.5 1";
    diffuseColor[2] = "1.5 1.5 1.5 0.12";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    useAnisotropic[2] = "1";
    castShadows = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    glow[0] = "0";
    glow[1] = "0";
    glow[2] = "1";
    emissive[0] = "0";
    emissive[1] = "0";
    emissive[2] = "1";
   waveAmp[2] = "0.190";
   animFlags[2] = "0x00000005";
   scrollDir[2] = "0 1";
   waveType[2] = "Square";
   waveFreq[2] = "1.85";
};

singleton Material(eurlightbarB2_onvm)
{
    mapTo = "eurlightbarB2_onvm";
    diffuseMap[2] = "vehicles/common/vmlightbars/eurlightbar_gvm.dds";
    specularMap[2] = "vehicles/common/lightbars/eurlightbar_s.dds";
    normalMap[2] = "vehicles/common/lightbars/eurlightbar_n.dds";
    diffuseMap[1] = "vehicles/common/vmlightbars/eurlightbar_dvm.dds";
    specularMap[1] = "vehicles/common/lightbars/eurlightbar_s.dds";
    normalMap[1] = "vehicles/common/lightbars/eurlightbar_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/common/lightbars/eurlightbar_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1.5 1.5 1.5 1";
    diffuseColor[2] = "1.5 1.5 1.5 0.12";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    useAnisotropic[2] = "1";
    castShadows = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    glow[0] = "0";
    glow[1] = "0";
    glow[2] = "1";
    emissive[0] = "0";
    emissive[1] = "0";
    emissive[2] = "1";
   waveAmp[2] = "0.190";
   animFlags[2] = "0x00000005";
   scrollDir[2] = "0 1";
   waveType[2] = "Square";
   waveFreq[2] = "1.85";
};

//ledsign
singleton Material(eurlightbar_signvm)
{
    mapTo = "eurlightbar_signvm";
    diffuseMap[1] = "vehicles/common/vmlightbars/eurlightbar_dvm.dds";
    specularMap[1] = "vehicles/common/lightbars/eurlightbar_s.dds";
    normalMap[1] = "vehicles/common/lightbars/eurlightbar_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/common/lightbars/eurlightbar_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1.5 1.5 1.5 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    castShadows = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    glow[0] = ".";
    glow[1] = "0";
    emissive[0] = "1";
    emissive[1] = "1";
};

singleton Material(eurlightbar_sign_onvm)
{
    mapTo = "eurlightbar_sign_onvm";
    diffuseMap[1] = "vehicles/common/vmlightbars/eurlightbar_gvm.dds";
    specularMap[1] = "vehicles/common/lightbars/eurlightbar_s.dds";
    normalMap[1] = "vehicles/common/lightbars/eurlightbar_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/common/lightbars/eurlightbar_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1.5 1.5 1.5 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    castShadows = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    glow[0] = ".";
    glow[1] = "0";
    emissive[0] = "1";
    emissive[1] = "1";
   waveAmp[1] = "0.098";
   animFlags[1] = "0x00000005";
   scrollDir[1] = "-1 0";
   waveType[1] = "Square";
   waveFreq[1] = "0.5";
};

singleton Material(lightbarvm)
{
    mapTo = "lightbarvm";
    diffuseMap[0] = "vehicles/common/vmlightbars/lightbar_dvm.dds";
    specularMap[0] = "vehicles/common/lightbars/lightbar_s.dds";
    normalMap[0] = "vehicles/common/lightbars/lightbar_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 1";
    useAnisotropic[0] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(lightbarglassRvm)
{
    mapTo = "lightbarglassRvm";
    diffuseMap[1] = "vehicles/common/vmlightbars/lightbar_dvm.dds";
    specularMap[1] = "vehicles/common/lightbars/lightbar_s.dds";
    normalMap[1] = "vehicles/common/lightbars/lightbar_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/common/lightbars/lightbar_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1.5 1.5 1.5 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    castShadows = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    glow[0] = "0";
    glow[1] = "0";
    emissive[0] = "0";
    emissive[1] = "0";
    specularStrength[0] = "0";
};


singleton Material(lightbarglassBvm)
{
    mapTo = "lightbarglassBvm";
    diffuseMap[1] = "vehicles/common/vmlightbars/lightbar_dvm.dds";
    specularMap[1] = "vehicles/common/lightbars/lightbar_s.dds";
    normalMap[1] = "vehicles/common/lightbars/lightbar_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/common/lightbars/lightbar_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1.5 1.5 1.5 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    castShadows = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    glow[0] = "0";
    glow[1] = "0";
    emissive[0] = "0";
    emissive[1] = "0";
    specularStrength[0] = "0";
};

//RB_on
singleton Material(lightbarglassR_onvm)
{
    mapTo = "lightbarglassR_onvm";
    diffuseMap[2] = "vehicles/common/vmlightbars/lightbar_gvm.dds";
    specularMap[2] = "vehicles/common/lightbars/lightbar_s.dds";
    normalMap[2] = "vehicles/common/lightbars/lightbar_n.dds";
    diffuseMap[1] = "vehicles/common/vmlightbars/lightbar_dvm.dds";
    specularMap[1] = "vehicles/common/lightbars/lightbar_s.dds";
    normalMap[1] = "vehicles/common/lightbars/lightbar_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/common/lightbars/lightbar_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1.5 1.5 1.5 1";
    diffuseColor[2] = "1.5 1.5 1.5 0.12";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    useAnisotropic[2] = "1";
    castShadows = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    glow[0] = "0";
    glow[1] = "0";
    glow[2] = "1";
    emissive[0] = "0";
    emissive[1] = "0";
    emissive[2] = "1";
    animFlags[2] = "0x00000005";
    scrollDir[2] = "0 0.21";
    waveType[2] = "Square";
    waveFreq[2] = "1.8";
    waveAmp[2] = "1";
    specularStrength[0] = "0";
};

singleton Material(lightbarglassB_onvm)
{
    mapTo = "lightbarglassB_onvm";
    diffuseMap[2] = "vehicles/common/vmlightbars/lightbar_gvm.dds";
    specularMap[2] = "vehicles/common/lightbars/lightbar_s.dds";
    normalMap[2] = "vehicles/common/lightbars/lightbar_n.dds";
    diffuseMap[1] = "vehicles/common/vmlightbars/lightbar_dvm.dds";
    specularMap[1] = "vehicles/common/lightbars/lightbar_s.dds";
    normalMap[1] = "vehicles/common/lightbars/lightbar_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/common/lightbars/lightbar_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1.5 1.5 1.5 1";
    diffuseColor[2] = "1.5 1.5 1.5 0.12";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    useAnisotropic[2] = "1";
    castShadows = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    glow[0] = "0";
    glow[1] = "0";
    glow[2] = "1";
    emissive[0] = "0";
    emissive[1] = "0";
    emissive[2] = "1";
    animFlags[2] = "0x00000005";
    scrollDir[2] = "0 0.21";
    waveType[2] = "Square";
    waveFreq[2] = "2";
    waveAmp[2] = "1";
    specularStrength[0] = "0";
};

singleton Material(lightbarglassB2vm)
{
    mapTo = "lightbarglassB2vm";
    diffuseMap[1] = "vehicles/common/vmlightbars/lightbar_dvm.dds";
    specularMap[1] = "vehicles/common/lightbars/lightbar_s.dds";
    normalMap[1] = "vehicles/common/lightbars/lightbar_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/common/lightbars/lightbar_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1.5 1.5 1.5 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    castShadows = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    glow[0] = "0";
    glow[1] = "0";
    emissive[0] = "0";
    emissive[1] = "0";
    specularStrength[0] = "0";
};

singleton Material(lightbarglassR2vm)
{
    mapTo = "lightbarglassR2vm";
    diffuseMap[1] = "vehicles/common/vmlightbars/lightbar_dvm.dds";
    specularMap[1] = "vehicles/common/lightbars/lightbar_s.dds";
    normalMap[1] = "vehicles/common/lightbars/lightbar_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/common/lightbars/lightbar_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1.5 1.5 1.5 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    castShadows = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    glow[0] = "0";
    glow[1] = "0";
    emissive[0] = "0";
    emissive[1] = "0";
    specularStrength[0] = "0";
};

//B2R2_on
singleton Material(lightbarglassB2_onvm)
{
    mapTo = "lightbarglassB2_onvm";
    diffuseMap[2] = "vehicles/common/vmlightbars/lightbar_gvm.dds";
    specularMap[2] = "vehicles/common/lightbars/lightbar_s.dds";
    normalMap[2] = "vehicles/common/lightbars/lightbar_n.dds";
    diffuseMap[1] = "vehicles/common/vmlightbars/lightbar_dvm.dds";
    specularMap[1] = "vehicles/common/lightbars/lightbar_s.dds";
    normalMap[1] = "vehicles/common/lightbars/lightbar_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/common/lightbars/lightbar_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1.5 1.5 1.5 1";
    diffuseColor[2] = "1.5 1.5 1.5 0.12";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    useAnisotropic[2] = "1";
    castShadows = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    glow[0] = "0";
    glow[1] = "0";
    glow[2] = "1";
    emissive[0] = "0";
    emissive[1] = "0";
    emissive[2] = "1";
    animFlags[2] = "0x00000005";
    scrollDir[2] = "0 -0.21";
    waveType[2] = "Square";
    waveFreq[2] = "2";
    waveAmp[2] = "1";
    specularStrength[0] = "0";
};

singleton Material(lightbarglassR2_onvm)
{
    mapTo = "lightbarglassR2_onvm";
    diffuseMap[2] = "vehicles/common/vmlightbars/lightbar_gvm.dds";
    specularMap[2] = "vehicles/common/lightbars/lightbar_s.dds";
    normalMap[2] = "vehicles/common/lightbars/lightbar_n.dds";
    diffuseMap[1] = "vehicles/common/lightbars/lightbar_dvm.dds";
    specularMap[1] = "vehicles/common/lightbars/lightbar_s.dds";
    normalMap[1] = "vehicles/common/lightbars/lightbar_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/common/lightbars/lightbar_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1.5 1.5 1.5 1";
    diffuseColor[2] = "1.5 1.5 1.5 0.12";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    useAnisotropic[2] = "1";
    castShadows = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    glow[0] = "0";
    glow[1] = "0";
    glow[2] = "1";
    emissive[0] = "0";
    emissive[1] = "0";
    emissive[2] = "1";
    animFlags[2] = "0x00000005";
    scrollDir[2] = "0 -0.21";
    waveType[2] = "Square";
    waveFreq[2] = "1.8";
    waveAmp[2] = "1";
    specularStrength[0] = "0";
};