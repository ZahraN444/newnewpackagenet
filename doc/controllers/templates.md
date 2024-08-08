# Templates

These API endpoints allow you to create, retrieve, update and delete reusable HTML templates for use with the Print & Mail API.

<div class="back-to-top" ><a href="#" onclick="toTopLink()">back to top</a></div>


```csharp
TemplatesController templatesController = client.TemplatesController;
```

## Class Name

`TemplatesController`

## Methods

* [Template Retrieve](../../doc/controllers/templates.md#template-retrieve)
* [Template Update](../../doc/controllers/templates.md#template-update)
* [Template Delete](../../doc/controllers/templates.md#template-delete)
* [Templates List](../../doc/controllers/templates.md#templates-list)
* [Create Template](../../doc/controllers/templates.md#create-template)


# Template Retrieve

Retrieves the details of an existing template. You need only supply the unique template identifier that was returned upon template creation.

```csharp
TemplateRetrieveAsync(
    string tmplId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `tmplId` | `string` | Template, Required | id of the template |

## Response Type

[`Task<Models.Template>`](../../doc/models/template.md)

## Example Usage

```csharp
string tmplId = "tmpl_id8";
try
{
    Template result = await templatesController.TemplateRetrieveAsync(tmplId);
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
  "id": "tmpl_c94e83ca2cd5121",
  "description": "Test Template",
  "versions": [
    {
      "id": "vrsn_362184d96d9b0c9",
      "suggest_json_editor": true,
      "description": "Test Template",
      "engine": "legacy",
      "html": "<html>HTML for {{name}}</html>",
      "date_created": "2017-11-07T22:56:10.962Z",
      "date_modified": "2017-11-07T22:56:10.962Z",
      "object": "version"
    }
  ],
  "published_version": {
    "id": "vrsn_362184d96d9b0c9",
    "suggest_json_editor": false,
    "description": "Test Template",
    "engine": "handlebars",
    "html": "<html>HTML for {{name}}</html>",
    "date_created": "2017-11-07T22:56:10.962Z",
    "date_modified": "2017-11-07T22:56:10.962Z",
    "object": "version"
  },
  "metadata": {},
  "date_created": "2017-11-07T22:56:10.962Z",
  "date_modified": "2017-11-07T22:56:10.962Z",
  "object": "template"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error | [`Domains0Error1Exception`](../../doc/models/domains-0-error-1-exception.md) |


# Template Update

Updates the description and/or published version of the template with the given id. To update the template's html, create a new version of the template.

```csharp
TemplateUpdateAsync(
    string tmplId,
    Models.ContentTypeEnum contentType,
    string description = null,
    string publishedVersion = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `tmplId` | `string` | Template, Required | id of the template |
| `contentType` | [`ContentTypeEnum`](../../doc/models/content-type-enum.md) | Header, Required | - |
| `description` | `string` | Form, Optional | An internal description that identifies this resource. Must be no longer than 255 characters. |
| `publishedVersion` | `string` | Form, Optional | - |

## Response Type

[`Task<Models.Template>`](../../doc/models/template.md)

## Example Usage

```csharp
string tmplId = "tmpl_id8";
ContentTypeEnum contentType = ContentTypeEnum.EnumApplicationxwwwformurlencoded;
string description = "Updated Example";
string publishedVersion = "vrsn_a";
try
{
    Template result = await templatesController.TemplateUpdateAsync(
        tmplId,
        contentType,
        description,
        publishedVersion
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
  "id": "tmpl_c94e83ca2cd5121",
  "description": "Test Template",
  "versions": [
    {
      "id": "vrsn_362184d96d9b0c9",
      "suggest_json_editor": true,
      "description": "Test Template",
      "engine": "legacy",
      "html": "<html>HTML for {{name}}</html>",
      "date_created": "2017-11-07T22:56:10.962Z",
      "date_modified": "2017-11-07T22:56:10.962Z",
      "object": "version"
    }
  ],
  "published_version": {
    "id": "vrsn_362184d96d9b0c9",
    "suggest_json_editor": false,
    "description": "Test Template",
    "engine": "handlebars",
    "html": "<html>HTML for {{name}}</html>",
    "date_created": "2017-11-07T22:56:10.962Z",
    "date_modified": "2017-11-07T22:56:10.962Z",
    "object": "version"
  },
  "metadata": {},
  "date_created": "2017-11-07T22:56:10.962Z",
  "date_modified": "2017-11-07T22:56:10.962Z",
  "object": "template"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error | [`Domains0Error1Exception`](../../doc/models/domains-0-error-1-exception.md) |


# Template Delete

Permanently deletes a template. Deleting a template also deletes its associated versions. Deleted templates can not be used to create postcard, letter, or check resources.

```csharp
TemplateDeleteAsync(
    string tmplId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `tmplId` | `string` | Template, Required | id of the template |

## Response Type

[`Task<Models.TemplatesResponse2>`](../../doc/models/templates-response-2.md)

## Example Usage

```csharp
string tmplId = "tmpl_id8";
try
{
    TemplatesResponse2 result = await templatesController.TemplateDeleteAsync(tmplId);
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
    "id": "tmpl_123456789",
    "deleted": true
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error | [`Domains0Error1Exception`](../../doc/models/domains-0-error-1-exception.md) |


# Templates List

Returns a list of your templates. The templates are returned sorted by creation date, with the most recently created templates appearing first.

```csharp
TemplatesListAsync(
    int? limit = 10,
    Models.Beforeafter beforeAfter = null,
    List<string> include = null,
    Dictionary<string, string> dateCreated = null,
    Dictionary<string, string> metadata = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `limit` | `int?` | Query, Optional | How many results to return. |
| `beforeAfter` | [`Beforeafter`](../../doc/models/beforeafter.md) | Query, Optional | `before` and `after` are both optional but only one of them can be in the query at a time. |
| `include` | `List<string>` | Query, Optional | Request that the response include the total count by specifying `include=["total_count"]`. |
| `dateCreated` | `Dictionary<string, string>` | Query, Optional | Filter by date created. Accepted formats are ISO-8601 date or datetime, e.g. `{ "gt": "2012-01-01", "lt": "2012-01-31T12:34:56Z" }` where `gt` is >, `lt` is <, `gte` is ≥, and `lte` is ≤. |
| `metadata` | `Dictionary<string, string>` | Query, Optional | Filter by metadata key-value pair`. |

## Response Type

[`Task<Models.AllTemplates>`](../../doc/models/all-templates.md)

## Example Usage

```csharp
int? limit = 10;
try
{
    AllTemplates result = await templatesController.TemplatesListAsync(limit);
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
      "id": "tmpl_d5a5a89da9106f8",
      "description": "Test Template",
      "versions": [
        {
          "id": "vrsn_232a02fb8224791",
          "suggest_json_editor": true,
          "description": "Test Template",
          "engine": "legacy",
          "html": "HTML for ",
          "date_created": "2019-07-27T23:49:01.512Z",
          "date_modified": "2019-07-27T23:49:01.512Z",
          "object": "version"
        }
      ],
      "published_version": {
        "id": "vrsn_232a02fb8224791",
        "suggest_json_editor": false,
        "description": "Test Template",
        "engine": "handlebars",
        "html": "HTML for ",
        "date_created": "2019-07-27T23:49:01.512Z",
        "date_modified": "2019-07-27T23:49:01.512Z",
        "object": "version"
      },
      "metadata": {},
      "date_created": "2019-07-27T23:49:01.511Z",
      "date_modified": "2019-07-27T23:49:01.511Z",
      "object": "template"
    },
    {
      "id": "tmpl_59b2150ae120887",
      "description": "Test Template",
      "versions": [
        {
          "id": "vrsn_2a7eb63ccb795b9",
          "description": "Test Template",
          "html": "HTML for ",
          "date_created": "2019-03-29T10:22:34.643Z",
          "date_modified": "2019-03-29T10:22:34.643Z",
          "object": "version"
        }
      ],
      "published_version": {
        "id": "vrsn_2a7eb63ccb795b9",
        "description": "Test Template",
        "html": "HTML for ",
        "date_created": "2019-03-29T10:22:34.643Z",
        "date_modified": "2019-03-29T10:22:34.643Z",
        "object": "version"
      },
      "metadata": {},
      "date_created": "2019-03-29T10:22:34.642Z",
      "date_modified": "2019-03-29T10:22:34.642Z",
      "object": "template"
    }
  ],
  "object": "list",
  "previous_url": null,
  "next_url": "https://api.lob.com/v1/templates?limit=2&after=eyJkYXRlT2Zmc2V0IjoiMjAxOS0wMy0yOVQxMDoyMjozNC42NDJaIiwiaWRPZmZzZXQiOiJ0bXBsXzU5YjIxNTBhZTEyMDg4NyJ9",
  "count": 2
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error | [`Domains0Error1Exception`](../../doc/models/domains-0-error-1-exception.md) |


# Create Template

Creates a new template for use with the Print & Mail API. In Live mode, you can only have as many non-deleted templates as allotted in your current <a href="https://dashboard.lob.com/#/settings/editions" target="_blank">Print & Mail Edition</a>. If you attempt to create a template past your limit, you will receive a `403` error. There is no limit in Test mode.

```csharp
CreateTemplateAsync(
    Models.ContentTypeEnum contentType,
    string html,
    string description = null,
    Dictionary<string, string> metadata = null,
    FileStreamInfo engine = null,
    List<string> requiredVars = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `contentType` | [`ContentTypeEnum`](../../doc/models/content-type-enum.md) | Header, Required | - |
| `html` | `string` | Form, Required | An HTML string of less than 100,000 characters to be used as the `published_version` of this template. See [here](#section/HTML-Examples) for guidance on designing HTML templates. Please see endpoint specific documentation for any other product-specific HTML details:<br><br>- [Postcards](#operation/postcard_create) - `front` and `back`<br>- [Self Mailers](#operation/self_mailer_create) - `inside` and `outside`<br>- [Letters](#operation/letter_create) - `file`<br>- [Checks](#operation/check_create) - `check_bottom` and `attachment`<br>- [Cards](#operation/card_create) - `front` and `back`<br><br>If there is a syntax error with your variable names within your HTML, then an error will be thrown, e.g. using a `{{#users}}` opening tag without the corresponding closing tag `{{/users}}`. |
| `description` | `string` | Form, Optional | An internal description that identifies this resource. Must be no longer than 255 characters. |
| `metadata` | `Dictionary<string, string>` | Form, Optional | Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters `"` and `\`. i.e. '{"customer_id" : "NEWYORK2015"}' Nested objects are not supported.  See [Metadata](#section/Metadata) for more information. |
| `engine` | `FileStreamInfo` | Form, Optional | - |
| `requiredVars` | `List<string>` | Form, Optional | An array of required variables to be used in a template. Only available for `handlebars` templates. |

## Response Type

[`Task<Models.Template>`](../../doc/models/template.md)

## Example Usage

```csharp
ContentTypeEnum contentType = ContentTypeEnum.EnumApplicationxwwwformurlencoded;
string html = "<html>HTML for {{name}}</html>";
string description = "demo";
try
{
    Template result = await templatesController.CreateTemplateAsync(
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
  "id": "tmpl_c94e83ca2cd5121",
  "description": "Test Template",
  "versions": [
    {
      "id": "vrsn_362184d96d9b0c9",
      "suggest_json_editor": true,
      "description": "Test Template",
      "engine": "legacy",
      "html": "<html>HTML for {{name}}</html>",
      "date_created": "2017-11-07T22:56:10.962Z",
      "date_modified": "2017-11-07T22:56:10.962Z",
      "object": "version"
    }
  ],
  "published_version": {
    "id": "vrsn_362184d96d9b0c9",
    "suggest_json_editor": false,
    "description": "Test Template",
    "engine": "handlebars",
    "html": "<html>HTML for {{name}}</html>",
    "date_created": "2017-11-07T22:56:10.962Z",
    "date_modified": "2017-11-07T22:56:10.962Z",
    "object": "version"
  },
  "metadata": {},
  "date_created": "2017-11-07T22:56:10.962Z",
  "date_modified": "2017-11-07T22:56:10.962Z",
  "object": "template"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error | [`Domains0Error1Exception`](../../doc/models/domains-0-error-1-exception.md) |

