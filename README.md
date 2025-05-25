# Icon Component Package

## Installation

1. **Copy Files**
   * Add all files to the Blazor project, for example under `/Components/`
2. **Register Namespace**
   * Add the following to the  `_Imports.razor`:
     ```csharp
     @using Namespace.Components
     @using Namespace.Components.Icons
     @using Namespace.Components.Indications
     ```
3. **Include Styles**
   * Add `styles.css` to the `wwwroot/css/` folder
   * Reference it in `wwwroot/index.html` (WASM) or `_Layout.cshtml` (Server)
     ```csharp
     <link href="css/styles.css" rel="stylesheet" />
     ```

## Usage Examples

```csharp
<Icon Name="home" />
<Icon Name="alarm" Size="24" Color="warning" />
<BadgeIcon IconName="fishing" Active="true" />
<Indication Name="danger" />
```

## Adding New Icons (for icon designer):

### From Figma

1. **Export icon to SVG**
2. **Clean up the SVG**
   * Replace `width` and `height` with:
     ```csharp
     style="@Style"
     ```
   * Replace `fill` and `fill-opacity` with:
     ```csharp
     fill="@Fill"
     ```
3. **Save as **`.razor`** file** and move it to the `Icons` folder in the project.

### Register in Dictionary

Add an entry in the dictionary in `Icon.razor`, and replace tha name for using the icon and the name for selecting component:

**Icon:** `"name-of-icon"`  
**Component:** `Icons.NameOfIcon`

```csharp
["name-of-icon"] = (size, color) => new RenderFragment(builder =>
{
    builder.OpenComponent(0, typeof(Icons.NameOfIcon));
    if (size.HasValue) builder.AddAttribute(1, "Size", size.Value);
    if (!string.IsNullOrEmpty(color)) builder.AddAttribute(2, "Color", color);
    builder.CloseComponent();
}),
```

## Notes

* `Size` defaults to `28` if not specified.
* `Color` defaults to `foreground-80` if not specified.

---
