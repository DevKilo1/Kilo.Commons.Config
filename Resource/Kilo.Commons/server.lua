function FindInTable(t, value)
    local found = false;
    local resultI = nil;
    for i,v in pairs(t) do
        if v == value then
            resultI = i;
            found = true;
        end
    end
    return found,resultI;
end

RegisterNetEvent("DevKilo.Commons::SyncEvent", function(event, targetSrc, ...)  
    TriggerClientEvent(event, targetSrc, ...)
end)