new ActionMap(zoomMap);
$currentFov = 70;
zoomMap.bind(mouse0, "ctrl button1",toggleU);
function toggleU(%val)
{
        if (%val)
        {
            setFov((20));
        }
        else
        {
            setFov(($currentFov));
        }
}
zoomMap.push();
fogpostfx.disable();