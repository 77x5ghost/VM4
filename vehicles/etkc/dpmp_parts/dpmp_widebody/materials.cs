singleton Material(coupe)
{
    mapTo = "coupe";
    diffuseMap[2] = "vehicles/coupe/coupe_c.dds";
    specularMap[2] = "vehicles/coupe/coupe_s.dds";
    normalMap[2] = "vehicles/coupe/coupe_n.dds";
    diffuseMap[1] = "vehicles/coupe/coupe_d.dds";
    specularMap[1] = "vehicles/coupe/coupe_s.dds";
    normalMap[1] = "vehicles/coupe/coupe_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/coupe/coupe_n.dds";
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
singleton Material(sunburst_gauges)
{
    mapTo = "sunburst_gauges";
    diffuseMap[0] = "vehicles/sunburst/sunburst_gauges_d.dds";
    specularMap[0] = "vehicles/sunburst/sunburst_gauges_s.dds";
    normalMap[0] = "vehicles/sunburst/sunburst_gauges_n.dds";
    specularPower[0] = "64";
    pixelSpecular[0] = "1";
    useAnisotropic[0] = "1";
    cubemap = "global_cubemap_metalblurred";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    diffuseColor[0] = "1 1 1 1";
};
singleton Material(etkc_gauges_race)
{
    mapTo = "etkc_gauges_race";
    diffuseMap[0] = "vehicles/etkc/dpmp_parts/dpmp_widebody/etkc_gauges_race_d.png";
    specularMap[0] = "vehicles/etkc/dpmp_parts/dpmp_widebody/etkc_gauges_race_s.png";
//    normalMap[0] = "vehicles/sunburst/sunburst_gauges_n.dds";
    specularPower[0] = "64";
    pixelSpecular[0] = "1";
    useAnisotropic[0] = "1";
//    cubemap = "global_cubemap_metalblurred";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    diffuseColor[0] = "1 1 1 1";
};
singleton Material(etkc_gauges_race_on)
{
    mapTo = "etkc_gauges_race_on";
    diffuseMap[1] = "vehicles/etkc/dpmp_parts/dpmp_widebody/etkc_gauges_race_g.png";
    diffuseMap[0] = "vehicles/etkc/dpmp_parts/dpmp_widebody/etkc_gauges_race_d.png";
    specularMap[0] = "vehicles/etkc/dpmp_parts/dpmp_widebody/etkc_gauges_race_s.png";
//    normalMap[0] = "vehicles/sunburst/sunburst_gauges_n.dds";
    specularPower[0] = "64";
    emissive[1] = "1";
    pixelSpecular[0] = "1";
    useAnisotropic[0] = "1";
//    cubemap = "global_cubemap_metalblurred";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    diffuseColor[0] = "1 1 1 1";
};
singleton Material(sunburst_gauges_on)
{
    mapTo = "sunburst_gauges_on";
    diffuseMap[1] = "vehicles/sunburst/sunburst_gauges_g.dds";
    specularMap[1] = "vehicles/sunburst/sunburst_gauges_s.dds";
    normalMap[1] = "vehicles/sunburst/sunburst_gauges_n.dds";
    diffuseMap[0] = "vehicles/sunburst/sunburst_gauges_d.dds";
    specularMap[0] = "vehicles/sunburst/sunburst_gauges_s.dds";
    normalMap[0] = "vehicles/sunburst/sunburst_gauges_n.dds";
    specularPower[0] = "64";
    pixelSpecular[0] = "1";
    emissive[1] = "1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    cubemap = "global_cubemap_metalblurred";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 0.65";
};

singleton Material(sunburst_widebody)
{
    mapTo = "sunburst_widebody";
    diffuseMap[2] = "vehicles/sunburst/sunburst_widebody_c.dds";
    specularMap[2] = "vehicles/sunburst/sunburst_widebody_s.dds";
    normalMap[2] = "vehicles/sunburst/sunburst_widebody_n.dds";
    diffuseMap[1] = "vehicles/sunburst/sunburst_widebody_d.dds";
    specularMap[1] = "vehicles/sunburst/sunburst_widebody_s.dds";
    normalMap[1] = "vehicles/sunburst/sunburst_widebody_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/sunburst/sunburst_widebody_n.dds";
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

singleton Material(sunburst_carbonfibre)
{
    mapTo = "sunburst_carbonfibre";
    detailMap[2] = "vehicles/common/carbonfibre.dds";
    diffuseMap[1] = "vehicles/common/carbonfibre_d.dds";
    normalMap[1] = "vehicles/sunburst/sunburst_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/sunburst/sunburst_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    specularPower[2] = "128";
    pixelSpecular[2] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 1";
    diffuseColor[2] = "0.7 0.7 0.7 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    useAnisotropic[2] = "1";
    detailScale[2] = 35;
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};
singleton Material(sunburst_display)
{
    mapTo = "sunburst_display";
    diffuseMap[0] = "vehicles/sunburst/sunburst_display.dds";
    diffuseColor[0] = "1 1 1 1";
    specularPower[0] = "64";
    specularPower[1] = "32";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "0";
    translucentBlendOp = "None";
    alphaTest = "1";
    alphaRef = "20";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};
singleton Material(etki_gauges_on)
{
    mapTo = "etki_gauges_on";
    diffuseMap[1] = "vehicles/etki/etki_gauges_g.dds";
    specularMap[1] = "vehicles/etki/etki_gauges_s.dds";
    normalMap[1] = "vehicles/etki/etki_gauges_n.dds";
    diffuseMap[0] = "vehicles/etki/etki_gauges_d.dds";
    specularMap[0] = "vehicles/etki/etki_gauges_s.dds";
    normalMap[0] = "vehicles/etki/etki_gauges_n.dds";
    diffuseColor[0] = "0 0 0 1";
    specularPower[0] = "32";
    specularPower[1] = "32";
    pixelSpecular[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    //cubemap = "global_cubemap_metalblurred";
    emissive[1] = "1";
    diffuseColor[1] = "0 0 0 0";
    useAnisotropic[1] = "1";
};
singleton Material(etki_boost_1)
{
    mapTo = "etki_boost_1";
};

singleton Material(etki_boost_2)
{
    mapTo = "etki_boost_2";
};

singleton Material(etki_boost_3)
{
    mapTo = "etki_boost_3";
};

singleton Material(etki_boost_4)
{
    mapTo = "etki_boost_4";
};

singleton Material(etki_boost_5)
{
    mapTo = "etki_boost_5";
};

singleton Material(etki_boost_6)
{
    mapTo = "etki_boost_6";
};

singleton Material(etki_boost_7)
{
    mapTo = "etki_boost_7";
};

singleton Material(etki_boost_8)
{
    mapTo = "etki_boost_8";
};

singleton Material(etki_boost_9)
{
    mapTo = "etki_boost_9";
};

singleton Material(etki_boost_10)
{
    mapTo = "etki_boost_10";
};

singleton Material(etki_boost_11)
{
    mapTo = "etki_boost_11";
};
