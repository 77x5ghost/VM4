-- This Source Code Form is subject to the terms of the bCDDL, v. 1.1.
-- If a copy of the bCDDL was not distributed with this
-- file, You can obtain one at http://beamng.com/bCDDL-1.1.txt

local M = {}

local function init()
    electrics.values.beaconSpin = 1
end

local function updateGFX(dt)
    electrics.values.beaconSpin = electrics.values.lightbar == 1 and ((electrics.values.beaconSpin + (dt * 320)) % 360) or 0
end

-- public interface
M.updateGFX      = updateGFX
M.onInit      = init
M.onReset     = init
return M