singleton Material(etkc_glassvm)
{
    mapTo = "etkc_glassvm";
    reflectivityMap[0] = "vehicles/common/glass_base.dds";
    diffuseMap[0] = "vehicles/etkc/vmetkc/etkc_glass_dvm.dds";
    opacityMap[0] = "vehicles/etkc/vmetkc/etkc_glass_dvm.dds";
    diffuseMap[1] = "vehicles/etkc/vmetkc/etkc_glass_davm.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/common/null_n.dds";
    diffuseColor[1] = "0.5 0.5 0.5 0.75";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    diffuseColor[0] = "1 1 1 1";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(etkc_glass_dmgvm)
{
    mapTo = "etkc_glass_dmgvm";
    diffuseMap[0] = "vehicles/etkc/vmetkc/etkc_glass_dmg_dvm.dds";
    opacityMap[0] = "vehicles/etkc/vmetkc/etkc_glass_dmg_dvm.dds";
    specularMap[0] = "vehicles/common/glass_dmg_s.dds";
    normalMap[0] = "vehicles/common/glass_dmg_n.dds";
    diffuseMap[1] = "vehicles/etkc/vmetkc/etkc_glass_dmg_dvm.dds";
    specularMap[1] = "vehicles/common/glass_dmg_s.dds";
    normalMap[1] = "vehicles/common/glass_dmg_n.dds";
    specularPower[0] = "128";
    specularPower[1] = "128";
    diffuseColor[0] = "1 1 1 1.5";
    diffuseColor[1] = "1 1 1 0.75";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material("etkc.skin.vpackvm")
{
   mapTo = "etkc.skin.vpackvm";
    diffuseMap[2] = "vehicles/etkc/vmetkc/etkc_cvm.dds";
    specularMap[2] = "vehicles/etkc/etkc_s.dds";
    normalMap[2] = "vehicles/etkc/etkc_n.dds";
    diffuseMap[1] = "vehicles/etkc/vmetkc/etkc_dvm.dds";
    specularMap[1] = "vehicles/etkc/etkc_s.dds";
    normalMap[1] = "vehicles/etkc/etkc_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/etkc/etkc_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    specularPower[2] = "128";
    pixelSpecular[2] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 1";
    diffuseColor[2] = "1 1 1 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    useAnisotropic[2] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    instanceDiffuse[2] = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(etkcvm_carbonfibre)
{
    mapTo = "etkcvm_carbonfibre";
    detailMap[2] = "vehicles/common/carbonfibre.dds";
    diffuseMap[1] = "vehicles/common/carbonfibre_d.dds";
    specularMap[1] = "vehicles/etkc/etkc_s.dds";
    normalMap[1] = "vehicles/etkc/etkc_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/etkc/etkc_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    specularPower[2] = "128";
    pixelSpecular[2] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 1";
    diffuseColor[2] = "1 1 1 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    useAnisotropic[2] = "1";
	  detailScale[2] = 15;
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";

};

singleton Material(etkc_vmgtsbadge)
{
    mapTo = "etkc_vmgtsbadge";
    specularMap[0] = "vehicles/etkc/vmetkc/vmgtsbadge_s.dds";
    normalMap[0] = "vehicles/etkc/vmetkc/vmgtsbadge_n.dds";
    diffuseMap[0] = "vehicles/etkc/vmetkc/vmgtsbadge_d.dds";
    reflectivityMap[0] = "vehicles/etkc/vmetkc/vmgtsbadge_s.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    diffuseColor[0] = "1 1 1 1";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    //translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle"; materialTag2 = "decal";
    //translucentZWrite = "1";
};