using Microsoft.AspNetCore.Components;

namespace TIACSmonitor.Components.Icons;

public class IconBase : ComponentBase
{
    [Parameter] public int Size { get; set; } = 28;
    [Parameter] public string Color { get; set; } = "foreground-80";

    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object> AdditionalAttributes { get; set; } = new();

    protected string Style => $"width: {Size}px; height: {Size}px;";
    protected string Fill => $"var(--{Color})";
}
