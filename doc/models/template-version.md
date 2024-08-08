
# Template Version

## Structure

`TemplateVersion`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Description` | `string` | Optional | An internal description that identifies this resource. Must be no longer than 255 characters.<br>**Constraints**: *Maximum Length*: `255` |
| `Html` | `string` | Required | An HTML string of less than 100,000 characters to be used as the `published_version` of this template. See [here](#section/HTML-Examples) for guidance on designing HTML templates. Please see endpoint specific documentation for any other product-specific HTML details:<br><br>- [Postcards](#operation/postcard_create) - `front` and `back`<br>- [Self Mailers](#operation/self_mailer_create) - `inside` and `outside`<br>- [Letters](#operation/letter_create) - `file`<br>- [Checks](#operation/check_create) - `check_bottom` and `attachment`<br>- [Cards](#operation/card_create) - `front` and `back`<br><br>If there is a syntax error with your variable names within your HTML, then an error will be thrown, e.g. using a `{{#users}}` opening tag without the corresponding closing tag `{{/users}}`.<br>**Constraints**: *Maximum Length*: `100000` |
| `Engine` | [`object`](../../doc/models/m-object-enum.md) | Optional | - |
| `RequiredVars` | `List<string>` | Optional | An array of required variables to be used in a template. Only available for `handlebars` templates. |
| `DateCreated` | `DateTime` | Required | A timestamp in ISO 8601 format of the date the resource was created. |
| `DateModified` | `DateTime` | Required | A timestamp in ISO 8601 format of the date the resource was last modified. |
| `Deleted` | `bool?` | Optional | Only returned if the resource has been successfully deleted. |
| `MObject` | `string` | Required, Constant | Value is resource type.<br>**Default**: `"version"` |
| `Id` | `string` | Required | Unique identifier prefixed with `vrsn_`.<br>**Constraints**: *Pattern*: `^vrsn_[a-zA-Z0-9]+$` |
| `SuggestJsonEditor` | `bool?` | Optional | Used by frontend, true if the template uses advanced features. |
| `MergeVariables` | [`object`](../../doc/models/m-object-enum.md) | Optional | Object representing the keys of every merge variable present in the template. It has one key named 'keys', and its value is an array of strings. |

## Example (as JSON)

```json
{
  "html": "html4",
  "date_created": "2016-03-13T12:52:32.123Z",
  "date_modified": "2016-03-13T12:52:32.123Z",
  "object": "version",
  "id": "id4",
  "description": "description4",
  "engine": {
    "key1": "val1",
    "key2": "val2"
  },
  "required_vars": [
    "required_vars7"
  ],
  "deleted": false,
  "suggest_json_editor": false
}
```

