-- This Source Code Form is subject to the terms of the bCDDL, v. 1.1.
-- If a copy of the bCDDL was not distributed with this
-- file, You can obtain one at http://beamng.com/bCDDL-1.1.txt

--[[local M = {}

local timer = 0
local running = false
local failed = false
local maxTime = 160 --s
local minSpeed = 85 --km/h
local playerCar = nil

local function fail(reason)
    failed = true
    running = false
    --guihooks.trigger('ScenarioFlashMessage', {{reason, 2}} )
    scenarios.finish({failed = reason})
end

--[[local function onRaceStart()
    timer = 0    
    failed = false
    playerCar = scenetree.findObject('scenario_player1')
    playerCar:queueLuaCommand('mapmgr.enableTracking("player")')
    running = true
end

local function onRaceWaypoint(status) 
    if status.waypointName == "utewp1" then
        local vehicleData = map.objects.player

    
        if not failed and vehicleData.vel:length() < minSpeed / 3.6 then
            fail('Too slow... Drive faster!')
        end 
    end
end

local function onRaceTick(raceTickTime)
    if not running then 
        return
    end
    
  --  local vehicleData = map.objects.player
    
  --  if not vehicleData then
  --      return
  --  end

  --  timer = timer + raceTickTime

    --[[if not failed and timer > maxTime then                
        fail('Used more than '..tostring(maxTime)..' sec')        
    end --]]   
    
   --[[ if not failed and vehicleData.damage > 0 then
        fail('You damaged your car...')
    end
end

M.onRaceStart = onRaceStart
M.onRaceWaypoint = onRaceWaypoint
M.onRaceTick = onRaceTick

return M--]]
