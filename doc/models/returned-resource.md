
# Returned Resource

## Structure

`ReturnedResource`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResourceType` | `string` | Required, Constant | Mailpiece type for the creative<br>**Default**: `"postcard"` |
| `Details` | [`Details5`](../../doc/models/details-5.md) | Required | - |
| `From` | [`object`](../../doc/models/m-object-enum.md) | Optional | - |
| `Description` | `string` | Optional | An internal description that identifies this resource. Must be no longer than 255 characters.<br>**Constraints**: *Maximum Length*: `255` |
| `Metadata` | `Dictionary<string, string>` | Optional | Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters `"` and `\`. i.e. '{"customer_id" : "NEWYORK2015"}' Nested objects are not supported.  See [Metadata](#section/Metadata) for more information. |

## Example (as JSON)

```json
{
  "resource_type": "postcard",
  "details": {
    "mail_type": "usps_first_class",
    "size": "6x11",
    "front_original_url": "front_original_url4",
    "back_original_url": "back_original_url6"
  },
  "from": {
    "key1": "val1",
    "key2": "val2"
  },
  "description": "description8",
  "metadata": {
    "key0": "metadata5"
  }
}
```

