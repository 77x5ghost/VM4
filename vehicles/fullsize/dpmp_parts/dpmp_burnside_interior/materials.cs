
singleton Material("fullsize_interior.skin_interior.burnside")
{
    mapTo = "fullsize_interior.skin_interior.burnside";
    reflectivityMap[1] = "vehicles/fullsize/dpmp_parts/dpmp_burnside_interior/fullsize_interiordpmpb_s.dds";
    diffuseMap[1] = "vehicles/fullsize/dpmp_parts/dpmp_burnside_interior/fullsize_interiordpmpb_d.dds";
    specularMap[1] = "vehicles/fullsize/dpmp_parts/dpmp_burnside_interior/fullsize_interiordpmpb_s.dds";
    normalMap[1] = "vehicles/fullsize/dpmp_parts/dpmp_burnside_interior/fullsize_interiordpmpb_n.dds";
    reflectivityMap[0] = "vehicles/fullsize/dpmp_parts/dpmp_burnside_interior/fullsize_interiordpmpb_s.dds";
    diffuseMap[0] = "vehicles/fullsize/dpmp_parts/dpmp_burnside_interior/fullsize_interiordpmpb_d.dds";
    specularMap[0] = "vehicles/fullsize/dpmp_parts/dpmp_burnside_interior/fullsize_interiordpmpb_s.dds";
    normalMap[0] = "vehicles/fullsize/dpmp_parts/dpmp_burnside_interior/fullsize_interiordpmpb_n.dds";
     diffuseColor[1] = "0.3 0.3 0.3 1";
    specularPower[1] = "32";
    useAnisotropic[1] = "1";
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

singleton Material("fullsize_intcarpet.skin_interior.burnside")
{
    mapTo = "fullsize_intcarpet.skin_interior.burnside";
    diffuseMap[0] = "vehicles/fullsize/fullsize_intcarpet_d.dds";
    diffuseColor[0] = "0.3 0.3 0.3 1";
    useAnisotropic[0] = "1";
    castShadows = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};
