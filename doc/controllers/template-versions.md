# Template Versions

```csharp
TemplateVersionsController templateVersionsController = client.TemplateVersionsController;
```

## Class Name

`TemplateVersionsController`

## Methods

* [Template Version Retrieve](../../doc/controllers/template-versions.md#template-version-retrieve)
* [Template Version Update](../../doc/controllers/template-versions.md#template-version-update)
* [Template Version Delete](../../doc/controllers/template-versions.md#template-version-delete)
* [Template Versions List](../../doc/controllers/template-versions.md#template-versions-list)
* [Create Template Version](../../doc/controllers/template-versions.md#create-template-version)


# Template Version Retrieve

Retrieves the template version with the given template and version ids.

```csharp
TemplateVersionRetrieveAsync(
    string tmplId,
    string vrsnId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `tmplId` | `string` | Template, Required | The ID of the template to which the version belongs. |
| `vrsnId` | `string` | Template, Required | id of the template_version |

## Response Type

[`Task<Models.TemplateVersion>`](../../doc/models/template-version.md)

## Example Usage

```csharp
string tmplId = "tmpl_id8";
string vrsnId = "vrsn_id2";
try
{
    TemplateVersion result = await templateVersionsController.TemplateVersionRetrieveAsync(
        tmplId,
        vrsnId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "id": "vrsn_534e339882d2282",
  "description": "Second Version",
  "html": "<html>Second HTML for {{name}}</html>",
  "date_created": "2017-11-09T04:49:38.016Z",
  "date_modified": "2017-11-09T04:49:38.016Z",
  "object": "version"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error | [`Domains0Error1Exception`](../../doc/models/domains-0-error-1-exception.md) |


# Template Version Update

Updates the template version with the given template and version ids.

```csharp
TemplateVersionUpdateAsync(
    string tmplId,
    string vrsnId,
    Models.ContentTypeEnum contentType,
    string description = null,
    FileStreamInfo engine = null,
    List<string> requiredVars = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `tmplId` | `string` | Template, Required | The ID of the template to which the version belongs. |
| `vrsnId` | `string` | Template, Required | id of the template_version |
| `contentType` | [`ContentTypeEnum`](../../doc/models/content-type-enum.md) | Header, Required | - |
| `description` | `string` | Form, Optional | An internal description that identifies this resource. Must be no longer than 255 characters. |
| `engine` | `FileStreamInfo` | Form, Optional | - |
| `requiredVars` | `List<string>` | Form, Optional | An array of required variables to be used in a template. Only available for `handlebars` templates. |

## Response Type

[`Task<Models.TemplateVersion>`](../../doc/models/template-version.md)

## Example Usage

```csharp
string tmplId = "tmpl_id8";
string vrsnId = "vrsn_id2";
ContentTypeEnum contentType = ContentTypeEnum.EnumApplicationxwwwformurlencoded;
string description = "Some description";
try
{
    TemplateVersion result = await templateVersionsController.TemplateVersionUpdateAsync(
        tmplId,
        vrsnId,
        contentType,
        description
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "id": "vrsn_534e339882d2282",
  "description": "Second Version",
  "html": "<html>Second HTML for {{name}}</html>",
  "date_created": "2017-11-09T04:49:38.016Z",
  "date_modified": "2017-11-09T04:49:38.016Z",
  "object": "version"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error | [`Domains0Error1Exception`](../../doc/models/domains-0-error-1-exception.md) |


# Template Version Delete

Permanently deletes a template version. A template's `published_version` can not be deleted.

```csharp
TemplateVersionDeleteAsync(
    string tmplId,
    string vrsnId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `tmplId` | `string` | Template, Required | The ID of the template to which the version belongs. |
| `vrsnId` | `string` | Template, Required | id of the template_version |

## Response Type

[`Task<Models.TemplatesVersionsResponse2>`](../../doc/models/templates-versions-response-2.md)

## Example Usage

```csharp
string tmplId = "tmpl_id8";
string vrsnId = "vrsn_id2";
try
{
    TemplatesVersionsResponse2 result = await templateVersionsController.TemplateVersionDeleteAsync(
        tmplId,
        vrsnId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "value": {
    "id": "vrsn_123456789",
    "deleted": true
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error | [`Domains0Error1Exception`](../../doc/models/domains-0-error-1-exception.md) |


# Template Versions List

Returns a list of template versions for the given template ID. The template versions are sorted by creation date, with the most recently created appearing first.

```csharp
TemplateVersionsListAsync(
    string tmplId,
    int? limit = 10,
    Models.Beforeafter beforeAfter = null,
    List<string> include = null,
    Dictionary<string, string> dateCreated = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `tmplId` | `string` | Template, Required | The ID of the template associated with the retrieved versions |
| `limit` | `int?` | Query, Optional | How many results to return. |
| `beforeAfter` | [`Beforeafter`](../../doc/models/beforeafter.md) | Query, Optional | `before` and `after` are both optional but only one of them can be in the query at a time. |
| `include` | `List<string>` | Query, Optional | Request that the response include the total count by specifying `include=["total_count"]`. |
| `dateCreated` | `Dictionary<string, string>` | Query, Optional | Filter by date created. Accepted formats are ISO-8601 date or datetime, e.g. `{ "gt": "2012-01-01", "lt": "2012-01-31T12:34:56Z" }` where `gt` is >, `lt` is <, `gte` is ≥, and `lte` is ≤. |

## Response Type

[`Task<Models.AllTemplateVersions>`](../../doc/models/all-template-versions.md)

## Example Usage

```csharp
string tmplId = "tmpl_id8";
int? limit = 10;
try
{
    AllTemplateVersions result = await templateVersionsController.TemplateVersionsListAsync(
        tmplId,
        limit
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "data": [
    {
      "id": "vrsn_4d6ff5d868bf630",
      "description": "Second Version",
      "html": "Second HTML for ",
      "date_created": "2017-11-09T05:09:03.665Z",
      "date_modified": "2018-05-22T22:01:10.479Z",
      "object": "version"
    },
    {
      "id": "vrsn_2a17159c1911919",
      "description": "Test Template",
      "html": "HTML for ",
      "date_created": "2017-11-09T05:08:40.004Z",
      "date_modified": "2018-05-22T22:01:11.309Z",
      "object": "version"
    }
  ],
  "object": "list",
  "count": 2
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error | [`Domains0Error1Exception`](../../doc/models/domains-0-error-1-exception.md) |


# Create Template Version

Creates a new template version attached to the specified template.

```csharp
CreateTemplateVersionAsync(
    string tmplId,
    Models.ContentTypeEnum contentType,
    string html,
    string description = null,
    FileStreamInfo engine = null,
    List<string> requiredVars = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `tmplId` | `string` | Template, Required | The ID of the template the new version will be attached to |
| `contentType` | [`ContentTypeEnum`](../../doc/models/content-type-enum.md) | Header, Required | - |
| `html` | `string` | Form, Required | An HTML string of less than 100,000 characters to be used as the `published_version` of this template. See [here](#section/HTML-Examples) for guidance on designing HTML templates. Please see endpoint specific documentation for any other product-specific HTML details:<br><br>- [Postcards](#operation/postcard_create) - `front` and `back`<br>- [Self Mailers](#operation/self_mailer_create) - `inside` and `outside`<br>- [Letters](#operation/letter_create) - `file`<br>- [Checks](#operation/check_create) - `check_bottom` and `attachment`<br>- [Cards](#operation/card_create) - `front` and `back`<br><br>If there is a syntax error with your variable names within your HTML, then an error will be thrown, e.g. using a `{{#users}}` opening tag without the corresponding closing tag `{{/users}}`. |
| `description` | `string` | Form, Optional | An internal description that identifies this resource. Must be no longer than 255 characters. |
| `engine` | `FileStreamInfo` | Form, Optional | - |
| `requiredVars` | `List<string>` | Form, Optional | An array of required variables to be used in a template. Only available for `handlebars` templates. |

## Response Type

[`Task<Models.TemplateVersion>`](../../doc/models/template-version.md)

## Example Usage

```csharp
string tmplId = "tmpl_id8";
ContentTypeEnum contentType = ContentTypeEnum.EnumApplicationxwwwformurlencoded;
string html = "<html>HTML for {{name}}</html>";
string description = "Some Description";
try
{
    TemplateVersion result = await templateVersionsController.CreateTemplateVersionAsync(
        tmplId,
        contentType,
        html,
        description
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "id": "vrsn_534e339882d2282",
  "description": "Second Version",
  "html": "<html>Second HTML for {{name}}</html>",
  "date_created": "2017-11-09T04:49:38.016Z",
  "date_modified": "2017-11-09T04:49:38.016Z",
  "object": "version"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error | [`Domains0Error1Exception`](../../doc/models/domains-0-error-1-exception.md) |

