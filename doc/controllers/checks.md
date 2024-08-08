# Checks

Checks allow you to send payments via physical checks. The API provides endpoints
for creating checks, retrieving individual checks, canceling checks, and retrieving a list of checks.

<div class="back-to-top" ><a href="#" onclick="toTopLink()">back to top</a></div>


```csharp
ChecksController checksController = client.ChecksController;
```

## Class Name

`ChecksController`

## Methods

* [Checks List](../../doc/controllers/checks.md#checks-list)
* [Check Create](../../doc/controllers/checks.md#check-create)
* [Check Retrieve](../../doc/controllers/checks.md#check-retrieve)
* [Check Cancel](../../doc/controllers/checks.md#check-cancel)


# Checks List

Returns a list of your checks. The checks are returned sorted by creation date, with the most recently created checks appearing first.

```csharp
ChecksListAsync(
    int? limit = 10,
    Models.Beforeafter beforeAfter = null,
    List<string> include = null,
    Dictionary<string, string> dateCreated = null,
    Dictionary<string, string> metadata = null,
    bool? scheduled = null,
    object sendDate = null,
    Models.MailTypeEnum? mailType = null,
    Models.SortBy1 sortBy = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `limit` | `int?` | Query, Optional | How many results to return. |
| `beforeAfter` | [`Beforeafter`](../../doc/models/beforeafter.md) | Query, Optional | `before` and `after` are both optional but only one of them can be in the query at a time. |
| `include` | `List<string>` | Query, Optional | Request that the response include the total count by specifying `include=["total_count"]`. |
| `dateCreated` | `Dictionary<string, string>` | Query, Optional | Filter by date created. Accepted formats are ISO-8601 date or datetime, e.g. `{ "gt": "2012-01-01", "lt": "2012-01-31T12:34:56Z" }` where `gt` is >, `lt` is <, `gte` is ≥, and `lte` is ≤. |
| `metadata` | `Dictionary<string, string>` | Query, Optional | Filter by metadata key-value pair`. |
| `scheduled` | `bool?` | Query, Optional | * `true` - only return orders (past or future) where `send_date` is<br>  greater than `date_created`<br>* `false` - only return orders where `send_date` is equal to `date_created` |
| `sendDate` | [`object`](../../doc/models/m-object-enum.md) | Query, Optional | Filter by ISO-8601 date or datetime, e.g. `{ "gt": "2012-01-01", "lt": "2012-01-31T12:34:56Z" }` where `gt` is >, `lt` is <, `gte` is ≥, and `lte` is ≤. |
| `mailType` | [`MailTypeEnum?`](../../doc/models/mail-type-enum.md) | Query, Optional | A string designating the mail postage type: * `usps_first_class` - (default) * `usps_standard` - a <a href="https://lob.com/pricing/print-mail#compare" target="_blank">cheaper option</a> which is less predictable and takes longer to deliver. `usps_standard` cannot be used with `4x6` postcards or for any postcards sent outside of the United States. |
| `sortBy` | [`SortBy1`](../../doc/models/sort-by-1.md) | Query, Optional | Sorts items by ascending or descending dates. Use either `date_created` or `send_date`, not both. |

## Response Type

[`Task<Models.AllChecks>`](../../doc/models/all-checks.md)

## Example Usage

```csharp
int? limit = 10;
try
{
    AllChecks result = await checksController.ChecksListAsync(limit);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error | [`Domains0Error1Exception`](../../doc/models/domains-0-error-1-exception.md) |


# Check Create

Creates a new check with the provided properties.

```csharp
CheckCreateAsync(
    object body,
    string idempotencyKey = null,
    string idempotencyKey2 = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`object`](../../doc/models/m-object-enum.md) | Body, Required | - |
| `idempotencyKey` | `string` | Header, Optional | A string of no longer than 256 characters that uniquely identifies this resource. For more help integrating idempotency keys, refer to our <a href="https://help.lob.com/print-and-mail/building-a-mail-strategy/managing-mail-settings#idempotent-requests-12" target="_blank">implementation guide</a>. |
| `idempotencyKey2` | `string` | Query, Optional | A string of no longer than 256 characters that uniquely identifies this resource. For more help integrating idempotency keys, refer to our <a href="https://help.lob.com/print-and-mail/building-a-mail-strategy/managing-mail-settings#idempotent-requests-12" target="_blank">implementation guide</a>. |

## Response Type

[`Task<Models.Check>`](../../doc/models/check.md)

## Example Usage

```csharp
object body = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}");
string idempotencyKey = "026e7634-24d7-486c-a0bb-4a17fd0eebc5";
string idempotencyKey2 = "026e7634-24d7-486c-a0bb-4a17fd0eebc5";
try
{
    Check result = await checksController.CheckCreateAsync(
        body,
        idempotencyKey,
        idempotencyKey2
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error | [`Domains0Error1Exception`](../../doc/models/domains-0-error-1-exception.md) |


# Check Retrieve

Retrieves the details of an existing check. You need only supply the unique check identifier that was returned upon check creation.

```csharp
CheckRetrieveAsync(
    string chkId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `chkId` | `string` | Template, Required | id of the check |

## Response Type

[`Task<Models.Check>`](../../doc/models/check.md)

## Example Usage

```csharp
string chkId = "chk_id8";
try
{
    Check result = await checksController.CheckRetrieveAsync(chkId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error | [`Domains0Error1Exception`](../../doc/models/domains-0-error-1-exception.md) |


# Check Cancel

Completely removes a check from production. This can only be done if the check has a `send_date` and the `send_date` has not yet passed. If the check is successfully canceled, you will not be charged for it. Read more on [cancellation windows](#section/Cancellation-Windows) and [scheduling](#section/Scheduled-Mailings). Scheduling and cancellation is a premium feature. Upgrade to the appropriate <a href="https://dashboard.lob.com/#/settings/editions" target="_blank">Print & Mail Edition</a> to gain access.

```csharp
CheckCancelAsync(
    string chkId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `chkId` | `string` | Template, Required | id of the check |

## Response Type

[`Task<Models.ChecksResponse>`](../../doc/models/checks-response.md)

## Example Usage

```csharp
string chkId = "chk_id8";
try
{
    ChecksResponse result = await checksController.CheckCancelAsync(chkId);
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
  "id": "chk_123456789",
  "deleted": true
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error | [`Domains0Error1Exception`](../../doc/models/domains-0-error-1-exception.md) |

