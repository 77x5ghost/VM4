singleton Material(semi_hood_dpmp)
{
    mapTo = "semi_hood_dpmp";
    diffuseMap[2] = "vehicles/semi/semi_cab_c.dds";
    specularMap[2] = "vehicles/semi/dpmp_parts/dpmp_liteparts/semi_cabdpmp_s.dds";
    normalMap[2] = "vehicles/semi/semi_cab_n.dds";
    diffuseMap[1] = "vehicles/semi/dpmp_parts/dpmp_liteparts/semi_cabdpmp_d.dds";
    specularMap[1] = "vehicles/semi/dpmp_parts/dpmp_liteparts/semi_cabdpmp_s.dds";
    normalMap[1] = "vehicles/semi/semi_cab_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/semi/semi_cab_n.dds";
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

singleton Material(semi_bumper_dpmp)
{
    mapTo = "semi_bumper_dpmp";
    diffuseMap[1] = "vehicles/semi/dpmp_parts/dpmp_liteparts/semi_framedpmp_d.dds";
    specularMap[1] = "vehicles/semi/dpmp_parts/dpmp_liteparts/semi_framedpmp_s.dds";
    normalMap[1] = "vehicles/semi/semi_frame_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/semi/semi_frame_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};
