# Icon Component Package

## Installation

1. **Copy Files**
   * Add all files to the Blazor project, for example under `/Components/Icons/`
2. **Register Namespace**
   * Add the following to the  `_Imports.razor`:
     ```
     @using Namespace.Components.Icons
     ```
3. **Include Styles**
   * Add `styles.css` to the `wwwroot/css/` folder
   * Reference it in `wwwroot/index.html` (WASM) or `_Layout.cshtml` (Server)
     ```
     <link href="css/styles.css" rel="stylesheet" />
     ```

## Usage Examples

```
<Icon Name="Home" />
<Icon Name="Alarm" Size="24" Color="warning" />
```

## Adding New Icons (for icon designer):

### From Figma

1. **Export icon to SVG**
2. **Clean up the SVG**
   * Replace `width` and `height` with:
     ```
     style="@Style"
     ```
   * Replace `fill` and `fill-opacity` with:
     ```
     fill="@Fill"
     ```
3. **Save as **`.razor`** file** and move it to the `Icons` folder in the project.

### Register in Dictionary

Add an entry in the dictionary in `Icon.razor`, for example:

```
["NAME_OF_ICON"] = (size, color) => new RenderFragment(builder =>
{
    builder.OpenComponent(0, typeof(Icons.NAME_OF_ICON));
    if (size.HasValue) builder.AddAttribute(1, "Size", size.Value);
    if (!string.IsNullOrEmpty(color)) builder.AddAttribute(2, "Color", color);
    builder.CloseComponent();
}),
```

## Notes

* `Size` defaults to `28` if not specified.
* `Color` defaults to `foreground-80` if not specified.

---
