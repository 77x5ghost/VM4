singleton Material(sunburst_dpmpHTI)
{
    mapTo = "sunburst_dpmpHTI";
    diffuseMap[2] = "vehicles/sunburst/dpmp_parts/dpmp_HTI/sunburstdpmpHTI_c.dds";
    specularMap[2] = "vehicles/sunburst/dpmp_parts/dpmp_HTI/sunburstdpmpHTI_s.dds";
    normalMap[2] = "vehicles/sunburst/sunburst_n.dds";
    diffuseMap[1] = "vehicles/sunburst/dpmp_parts/dpmp_HTI/sunburstdpmpHTI_d.dds";
    specularMap[1] = "vehicles/sunburst/dpmp_parts/dpmp_HTI/sunburstdpmpHTI_s.dds";
    normalMap[1] = "vehicles/sunburst/sunburst_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/sunburst/sunburst_n.dds";
    specular[0] = "0.5 0.5 0.5 0.1";
    specular[1] = "0.5 0.5 0.5 0.1";
    specular[2] = "0.5 0.5 0.5 0.1";
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
    beamngDiffuseColorSlot = 2;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};


singleton Material(sunburst_engine_dpmpHTI)
{
    mapTo = "sunburst_engine_dpmpHTI";
    diffuseMap[0] = "vehicles/sunburst/dpmp_parts/dpmp_HTI/sunburst_enginedpmpHTI_d.dds";
    specularMap[0] = "vehicles/sunburst/dpmp_parts/dpmp_HTI/sunburst_enginedpmpHTI_s.dds";
    normalMap[0] = "vehicles/sunburst/sunburst_engine_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    useAnisotropic[0] = "1";
    castShadows = "1";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(sunburst_seats_dpmpHTI)
{
    mapTo = "sunburst_seats_dpmpHTI";
    normalMap[0] = "vehicles/sunburst/sunburst_seats_n.dds";
    diffuseMap[0] = "vehicles/sunburst/dpmp_parts/dpmp_HTI/sunburst_seatsdpmpHTI_d.dds";
    specularMap[0] = "vehicles/sunburst/dpmp_parts/dpmp_HTI/sunburst_seatsdpmpHTI_s.dds";
    specularPower[0] = "20";
    diffuseColor[0] = "1 1 1 1";
    specularPower[1] = "32";
    useAnisotropic[0] = "1";
    castShadows = "1";
    translucent = "0";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};