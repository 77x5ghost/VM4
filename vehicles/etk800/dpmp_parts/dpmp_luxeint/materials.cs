singleton Material("etk800_seats.skin_interior.luxe")
{
    mapTo = "etk800_seats.skin_interior.luxe";
    normalMap[0] = "vehicles/etk800/dpmp_parts/dpmp_luxeint/etk800dpmp_seats_n.dds";
    diffuseMap[0] = "vehicles/etk800/dpmp_parts/dpmp_luxeint/etk800dpmp_seats_d_ttsport.dds";
    specularMap[0] = "vehicles/etk800/dpmp_parts/dpmp_luxeint/etk800dpmp_seats_s.dds";
    diffuseColor[0] = "1 1 1 1";
    specularPower[0] = "32";
    useAnisotropic[0] = "1";
    castShadows = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material("etk800_interior.skin_interior.luxe")
{
    mapTo = "etk800_interior.skin_interior.luxe";
    normalMap[0] = "vehicles/etk800/dpmp_parts/dpmp_luxeint/etk800dpmp_interior_n.dds";
    diffuseMap[0] = "vehicles/etk800/dpmp_parts/dpmp_luxeint/etk800dpmp_interior_d.dds";
    specularMap[0] = "vehicles/etk800/dpmp_parts/dpmp_luxeint/etk800dpmp_interior_s.dds";
    diffuseColor[0] = "1 1 1 1";
    specularPower[0] = "32";
    useAnisotropic[0] = "1";
    castShadows = "1";
    translucent = "0";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    cubemap = "global_cubemap_metalblurred";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};
