-- This Source Code Form is subject to the terms of the bCDDL, v. 1.1.
-- If a copy of the bCDDL was not distributed with this
-- file, You can obtain one at http://beamng.com/bCDDL-1.1.txt

--[[local M = {}

local helper = require('scenario/scenariohelper')

local scenario = nil
local running = false

local checkForSpeederCrash = false
local checkForPoliceDistance = false
local speederCrashTimeout = 0 --s
local speederCrashMaxTimeout = 4 --s

local maxPoliceDamage = 15500 --no unit
local maxPoliceDistance = 200 --m
local policeDistanceEnable = 50 --m
local speederMinimumSpeed = 1.4 --m/s

local function reset()
    checkForSpeederCrash = false
    checkForPoliceDistance = false
    speederCrashTimeout = 0
    running = false
end

local function onRaceStart()
    reset()
    running = true

    helper.setAiMode('speeder', 'flee')
    --helper.setAiAggression('speeder', 1.2)
    helper.trackVehicle('scenario_player0', 'policeCar')
    helper.trackVehicle('speeder', 'speeder')
    helper.queueLuaCommandByName('scenario_player0', 'electrics.toggle_lightbar_signal()')
end

local function onRaceWaypoint(data)
    if data.waypointName == 'pp_wp_1' then
        helper.flashUiMessage('Stop the criminal!', 2)
    end
end

local function fail(reason)
    scenarios.finish({failed = reason})
    reset()
end

local function success()
    local finalTime = scenario.timer
    local minutes = math.floor(finalTime / 60);
    local seconds = finalTime - (minutes * 60);
    local timeStr = ''
    if minutes > 0 then
        timeStr = string.format("%02.0f:%05.2f", minutes, seconds)
    else
        timeStr = string.format("%0.2f", seconds) .. 's'
    end
    local result = {msg = 'Well done, your time: '..timeStr}
    scenarios.finish(result)
    reset()
end

local function onRaceTick(raceTickTime)
    if not running then
        return
    end

    local policeData = map.objects.policeCar
    local speederData = map.objects.speeder

    if not policeData or not speederData then
        return
    end

    local distanceToSpeeder = math.abs((policeData.pos - speederData.pos):length())
    local speederSpeed = speederData.vel:length()

    --Check if we are close enough to our target to actually start the distance check
    if not checkForPoliceDistance and distanceToSpeeder < policeDistanceEnable then
        checkForPoliceDistance = true
    end

    --Check if the target has passed the minimum speed before start watching his speed
    if not checkForSpeederCrash and speederSpeed > speederMinimumSpeed then
        checkForSpeederCrash = true
    end

    if checkForPoliceDistance and distanceToSpeeder > maxPoliceDistance then
        fail('The suspect got away')
    end

    if policeData.damage > maxPoliceDamage then
        fail('You crashed your car')
    end

    --Count down the target when he's below the minimum speed
    if checkForSpeederCrash and (speederSpeed < speederMinimumSpeed) then
        speederCrashTimeout = speederCrashTimeout + raceTickTime
        if speederCrashTimeout % 1 == 0 then
            local countdown = speederCrashMaxTimeout - math.modf(speederCrashTimeout)
            if countdown > 0 then
                helper.flashUiMessage(countdown..'...', 0.5, true)
            end
        end
    else
        speederCrashTimeout = 0
    end

    if speederCrashTimeout >= speederCrashMaxTimeout then -- wait x seconds
        success()
    end
end

local function onScenarioChange(sc)
    scenario = sc
end

M.onRaceStart = onRaceStart
M.onRaceWaypoint = onRaceWaypoint
M.onRaceTick = onRaceTick
M.onScenarioChange = onScenarioChange

return M--]]