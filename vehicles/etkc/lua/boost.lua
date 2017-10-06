-- This Source Code Form is subject to the terms of the bCDDL, v. 1.1.
-- If a copy of the bCDDL was not distributed with this
-- file, You can obtain one at http://beamng.com/bCDDL-1.1.txt
local M = {}

local stepSize = 0
local stepCount = 6

local function onInit()
    for i = 1, stepCount, 1 do
        electrics.values['boost_'..tostring(i)] = 0
    end
	
    local engine = v.data.mainEngine
    if engine then
        stepSize = 	v.data.mainEngine.maxRPM / stepCount
    end
end

local function reset()
    onInit()
end

local function updateGFX(dt)
    local boost = electrics.values["rpm"]
    if boost then
        for i = 1, stepCount, 1 do
            electrics.values['boost_'..tostring(i)] = (boost > (i -1) * stepSize) and 1 or 0
        end
    end
end

-- public interface
M.onInit    = onInit
M.onReset   = reset
M.updateGFX = updateGFX

return M