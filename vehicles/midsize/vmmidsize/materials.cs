
singleton Material("midsize.skin.plastic")
{
    mapTo = "midsize.skin.plastic";
    diffuseMap[2] = "vehicles/midsize/vmmidsize/midsize_c_vmpl.dds";
    specularMap[2] = "vehicles/midsize/vmmidsize/midsize_s_vmpl.dds";
    normalMap[2] = "vehicles/midsize/midsize_n.dds";
    diffuseMap[1] = "vehicles/midsize/vmmidsize/midsize_d_vmpl.dds";
    specularMap[1] = "vehicles/midsize/vmmidsize/midsize_s_vmpl.dds";
    normalMap[1] = "vehicles/midsize/midsize_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/midsize/vmmidsize/midsize_s_vmpl.dds";
    normalMap[0] = "vehicles/midsize/midsize_n.dds";
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

singleton Material(midsize_lettering_vmcp)
{
    mapTo = "midsize_lettering_vmcp";
    specularMap[0] = "vehicles/midsize/vmmidsize/coupe/midsizepes_s.dds";
    normalMap[0] = "vehicles/midsize/vmmidsize/coupe/midsizepes_n.dds";
    diffuseMap[0] = "vehicles/midsize/vmmidsize/coupe/midsizepes_d.dds";
    reflectivityMap[0] = "vehicles/midsize/vmmidsize/coupe/midsizepes_s.dds";
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
