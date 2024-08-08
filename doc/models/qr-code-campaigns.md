
# Qr Code Campaigns

Customize and place a QR code on all the postcards, letters or self mailers in a campaign. Redirect URLs can either be unique for each recipient, or a single link can be used for the whole campaign. See `redirect_url` attribute below for more details.

## Structure

`QrCodeCampaigns`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Position` | `string` | Required, Constant | Sets how a QR code is being positioned in the document. Together with this, you should provide one of 'top' or 'bottom', and one of 'left' or 'right'.<br>**Default**: `"relative"` |
| `Top` | `string` | Optional | Vertical distance (in inches) to place QR code from the top. Only allowed if "bottom" isn't provided. |
| `Right` | `string` | Optional | Horizonal distance (in inches) to place QR code from the right. Only allowed if "left" isn't provided. |
| `Left` | `string` | Optional | Horizonal distance (in inches) to place QR code from the left. Only allowed if "right" isn't provided. |
| `Bottom` | `string` | Optional | Vertical distance (in inches) to place QR code from the bottom. Only allowed if "top" isn't provided. |
| `RedirectUrl` | [`QrCodeCampaignsRedirectUrl`](../../doc/models/containers/qr-code-campaigns-redirect-url.md) | Optional | This is a container for one-of cases. |
| `Width` | `string` | Required | The size (in inches) of the QR code with a minimum of 1 inch. All QR codes are generated as a square. |
| `Pages` | `string` | Optional | Specify the pages where the QR code should be stamped in a comma separated format. Your QR code can be printed in the same position on multiple pages. For postcards, the values should either be "front", "back" (for either front or back) or "front,back" (for the QR code to be printed on both sides). For self-mailers, the values should either be "inside", "outside" (for either inside or outside) or "inside,outside" (for the QR code to be printed on both sides). For letters, the values can be specific page numbers ("1", "3"), page number ranges such as "1-3", or a comma separated combination of both ("1,3,5-7"). |

## Example (as JSON)

```json
{
  "position": "relative",
  "width": "width0",
  "top": "top8",
  "right": "right2",
  "left": "left2",
  "bottom": "bottom4",
  "redirect_url": "String9"
}
```

