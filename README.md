# View Variants for Sitecore Experience Accelerator
This library allows you to define Variants as cshtml views. It passes the variant bound item as the Model.

A sample view that can be used for the Promo Component is included in this package. The contents of the cshtml view are as follows:

```csharp
@model Sitecore.Data.Items.Item

<p>I am in a cshtml view</p>

<p>The name of the item is @Model.Name</p>

<p>Text:</p>
<div>@Html.Sitecore().Field("PromoText", Model)</div>
<p>Link: @Html.Sitecore().Field("PromoLink", Model)</p>
```

The current item in context is passed to the view. 

Note that current release/nuget package has been tested on Sitecore 9.1 only with SXA 1.8
