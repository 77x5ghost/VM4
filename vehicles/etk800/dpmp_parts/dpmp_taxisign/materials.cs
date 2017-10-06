singleton Material(taxi)
{
    mapTo = "taxi";
    diffuseMap[1] = "vehicles/common/null.dds";
    specularPower[0] = "32";
    pixelSpecular[0] = "1";
    specularPower[1] = "128";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "0.5 0.5 0 1";
    diffuseColor[1] = "0.5 0.5 0 1";
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

singleton Material(taxi_on)
{
    mapTo = "taxi_on";
   diffuseMap[1] = "vehicles/common/null.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "0.1";
    specularPower[1] = "128";
    pixelSpecular[1] = "0.1";
    diffuseColor[0] = "0.5 0.5 0 1";
    diffuseColor[1] = "0.5 0.5 0 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    castShadows = "1";
    translucent = "1";
    emissive[1] = "1";
    emissive[2] = "1";
    glow[1] = "1";
    glow[2] = "0";
    translucentBlendOp = "None";

    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(black)
{
    mapTo = "black";
    diffuseColor[0] = "0 0 0 0";
};