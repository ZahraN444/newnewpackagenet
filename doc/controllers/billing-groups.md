# Billing Groups

```csharp
BillingGroupsController billingGroupsController = client.BillingGroupsController;
```

## Class Name

`BillingGroupsController`

## Methods

* [Billing Group Retrieve](../../doc/controllers/billing-groups.md#billing-group-retrieve)
* [Billing Group Update](../../doc/controllers/billing-groups.md#billing-group-update)
* [Billing Groups List](../../doc/controllers/billing-groups.md#billing-groups-list)
* [Billing Group Create](../../doc/controllers/billing-groups.md#billing-group-create)


# Billing Group Retrieve

Retrieves the details of an existing billing_group. You need only supply the unique billing_group identifier that was returned upon billing_group creation.

```csharp
BillingGroupRetrieveAsync(
    string bgId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `bgId` | `string` | Template, Required | id of the billing_group |

## Response Type

[`Task<Models.BillingGroup>`](../../doc/models/billing-group.md)

## Example Usage

```csharp
string bgId = "bg_id8";
try
{
    BillingGroup result = await billingGroupsController.BillingGroupRetrieveAsync(bgId);
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
  "id": "bg_c94e83ca2cd5121",
  "name": "Marketing Dept",
  "description": "Usage group used for the Marketing Dept resource sends",
  "date_created": "2017-11-07T22:56:10.962Z",
  "date_modified": "2017-11-07T22:56:10.962Z",
  "object": "billing_group"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error | [`Domains0Error1Exception`](../../doc/models/domains-0-error-1-exception.md) |


# Billing Group Update

Updates all editable attributes of the billing_group with the given id.

```csharp
BillingGroupUpdateAsync(
    string bgId,
    Models.ContentTypeEnum contentType,
    string description = null,
    string name = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `bgId` | `string` | Template, Required | id of the billing_group |
| `contentType` | [`ContentTypeEnum`](../../doc/models/content-type-enum.md) | Header, Required | - |
| `description` | `string` | Form, Optional | Description of the billing group. |
| `name` | `string` | Form, Optional | Name of the billing group. |

## Response Type

[`Task<Models.BillingGroup>`](../../doc/models/billing-group.md)

## Example Usage

```csharp
string bgId = "bg_id8";
ContentTypeEnum contentType = ContentTypeEnum.EnumApplicationxwwwformurlencoded;
string description = "Usage group used for the Marketing Dept resource sends";
string name = "Marketing Dept";
try
{
    BillingGroup result = await billingGroupsController.BillingGroupUpdateAsync(
        bgId,
        contentType,
        description,
        name
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
  "id": "bg_c94e83ca2cd5121",
  "name": "Marketing Dept",
  "description": "Usage group used for the Marketing Dept resource sends",
  "date_created": "2017-11-07T22:56:10.962Z",
  "date_modified": "2017-11-07T22:56:10.962Z",
  "object": "billing_group"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error | [`Domains0Error1Exception`](../../doc/models/domains-0-error-1-exception.md) |


# Billing Groups List

Returns a list of your billing_groups. The billing_groups are returned sorted by creation date, with the most recently created billing_groups appearing first.

```csharp
BillingGroupsListAsync(
    int? limit = 10,
    int? offset = 0,
    List<string> include = null,
    Dictionary<string, string> dateCreated = null,
    Dictionary<string, string> dateModified = null,
    Models.SortBy sortBy = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `limit` | `int?` | Query, Optional | How many results to return. |
| `offset` | `int?` | Query, Optional | An integer that designates the offset at which to begin returning results. Defaults to 0. |
| `include` | `List<string>` | Query, Optional | Request that the response include the total count by specifying `include=["total_count"]`. |
| `dateCreated` | `Dictionary<string, string>` | Query, Optional | Filter by date created. Accepted formats are ISO-8601 date or datetime, e.g. `{ "gt": "2012-01-01", "lt": "2012-01-31T12:34:56Z" }` where `gt` is >, `lt` is <, `gte` is ≥, and `lte` is ≤. |
| `dateModified` | `Dictionary<string, string>` | Query, Optional | Filter by date modified. Accepted formats are ISO-8601 date or datetime, e.g. `{ "gt": "2012-01-01", "lt": "2012-01-31T12:34:56Z" }` where `gt` is >, `lt` is <, `gte` is ≥, and `lte` is ≤. |
| `sortBy` | [`SortBy`](../../doc/models/sort-by.md) | Query, Optional | Sorts items by ascending or descending dates. Use either `date_created` or `date_modified`, not both. |

## Response Type

[`Task<Models.BillingGroupsResponse>`](../../doc/models/billing-groups-response.md)

## Example Usage

```csharp
int? limit = 10;
int? offset = 0;
try
{
    BillingGroupsResponse result = await billingGroupsController.BillingGroupsListAsync(
        limit,
        offset
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
      "id": "bg_d5a5a89da9106f8",
      "description": "Test billing_group",
      "metadata": {},
      "date_created": "2019-07-27T23:49:01.511Z",
      "date_modified": "2019-07-27T23:49:01.511Z",
      "object": "billing_group"
    },
    {
      "id": "bg_59b2150ae120887",
      "description": "Test billing_group",
      "metadata": {},
      "date_created": "2019-03-29T10:22:34.642Z",
      "date_modified": "2019-03-29T10:22:34.642Z",
      "object": "billing_group"
    }
  ],
  "object": "list",
  "next_url": null,
  "prev_url": null,
  "count": 2
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error | [`Domains0Error1Exception`](../../doc/models/domains-0-error-1-exception.md) |


# Billing Group Create

Creates a new billing_group with the provided properties.

```csharp
BillingGroupCreateAsync(
    Models.BillingGroupEditable body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`BillingGroupEditable`](../../doc/models/billing-group-editable.md) | Body, Required | - |

## Response Type

[`Task<Models.BillingGroup>`](../../doc/models/billing-group.md)

## Example Usage

```csharp
BillingGroupEditable body = new BillingGroupEditable
{
    Name = "Marketing Dept",
    Description = "Usage group used for the Marketing Dept resource sends",
};

try
{
    BillingGroup result = await billingGroupsController.BillingGroupCreateAsync(body);
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
  "id": "bg_c94e83ca2cd5121",
  "name": "Marketing Dept",
  "description": "Usage group used for the Marketing Dept resource sends",
  "date_created": "2017-11-07T22:56:10.962Z",
  "date_modified": "2017-11-07T22:56:10.962Z",
  "object": "billing_group"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error | [`Domains0Error1Exception`](../../doc/models/domains-0-error-1-exception.md) |

