# Campaigns

The campaigns endpoint allows you to create and view campaigns that can be used to send multiple letters or postcards.
The API provides endpoints for creating campaigns, updating campaigns, retrieving individual campaigns, listing campaigns, and deleting
campaigns.

```csharp
CampaignsController campaignsController = client.CampaignsController;
```

## Class Name

`CampaignsController`

## Methods

* [Campaigns List](../../doc/controllers/campaigns.md#campaigns-list)
* [Campaign Create](../../doc/controllers/campaigns.md#campaign-create)
* [Campaign Retrieve](../../doc/controllers/campaigns.md#campaign-retrieve)
* [Campaign Update](../../doc/controllers/campaigns.md#campaign-update)
* [Campaign Delete](../../doc/controllers/campaigns.md#campaign-delete)
* [Campaign Send](../../doc/controllers/campaigns.md#campaign-send)


# Campaigns List

Returns a list of your campaigns. The campaigns are returned sorted by creation date, with the most recently created campaigns appearing first.

```csharp
CampaignsListAsync(
    int? limit = 10,
    List<string> include = null,
    Models.Beforeafter beforeAfter = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `limit` | `int?` | Query, Optional | How many results to return. |
| `include` | `List<string>` | Query, Optional | Request that the response include the total count by specifying `include=["total_count"]`. |
| `beforeAfter` | [`Beforeafter`](../../doc/models/beforeafter.md) | Query, Optional | `before` and `after` are both optional but only one of them can be in the query at a time. |

## Response Type

[`Task<Models.AllCampaigns>`](../../doc/models/all-campaigns.md)

## Example Usage

```csharp
int? limit = 10;
try
{
    AllCampaigns result = await campaignsController.CampaignsListAsync(limit);
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
      "id": "cmp_e05ee61ff80764b",
      "billing_group_id": "bg_fe3079dcdd80e5ae",
      "name": "My Campaign",
      "description": "My Campaign's description",
      "schedule_type": "immediate",
      "send_date": null,
      "target_delivery_date": null,
      "cancel_window_campaign_minutes": 60,
      "metadata": {},
      "use_type": "marketing",
      "is_draft": true,
      "deleted": false,
      "creatives": [],
      "uploads": [],
      "auto_cancel_if_ncoa": false,
      "date_created": "2017-09-05T17:47:53.767Z",
      "date_modified": "2017-09-05T17:47:53.767Z",
      "object": "campaign"
    }
  ],
  "object": "list",
  "previous_url": null,
  "next_url": null,
  "count": 1
}
```


# Campaign Create

Creates a new campaign with the provided properties. See how to launch your first campaign [here](https://help.lob.com/print-and-mail/building-a-mail-strategy/campaign-or-triggered-sends/launch-your-first-campaign).

```csharp
CampaignCreateAsync(
    Models.ContentTypeEnum contentType,
    string name,
    Models.CmpScheduleTypeEnum scheduleType,
    FileStreamInfo useType,
    Models.XLangOutput1Enum? xLangOutput = null,
    string billingGroupId = null,
    string description = null,
    DateTime? targetDeliveryDate = null,
    DateTime? sendDate = null,
    int? cancelWindowCampaignMinutes = null,
    Dictionary<string, string> metadata = null,
    bool? autoCancelIfNcoa = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `contentType` | [`ContentTypeEnum`](../../doc/models/content-type-enum.md) | Header, Required | - |
| `name` | `string` | Form, Required | Name of the campaign. |
| `scheduleType` | [`CmpScheduleTypeEnum`](../../doc/models/cmp-schedule-type-enum.md) | Form, Required | - |
| `useType` | `FileStreamInfo` | Form, Required | - |
| `xLangOutput` | [`XLangOutput1Enum?`](../../doc/models/x-lang-output-1-enum.md) | Header, Optional | * `native` - Translate response to the native language of the country in the request<br>* `match` - match the response to the language in the request<br><br>Default response is in English. |
| `billingGroupId` | `string` | Form, Optional | Unique identifier prefixed with `bg_`. |
| `description` | `string` | Form, Optional | An internal description that identifies this resource. Must be no longer than 255 characters. |
| `targetDeliveryDate` | `DateTime?` | Form, Optional | If `schedule_type` is `target_delivery_date`, provide a targeted delivery date for mail pieces in this campaign. |
| `sendDate` | `DateTime?` | Form, Optional | If `schedule_type` is `scheduled_send_date`, provide a date to send this campaign. |
| `cancelWindowCampaignMinutes` | `int?` | Form, Optional | A window, in minutes, within which the campaign can be canceled. |
| `metadata` | `Dictionary<string, string>` | Form, Optional | Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters `"` and `\`. i.e. '{"customer_id" : "NEWYORK2015"}' Nested objects are not supported.  See [Metadata](#section/Metadata) for more information. |
| `autoCancelIfNcoa` | `bool?` | Form, Optional | Whether or not a mail piece should be automatically canceled and not sent if the address is updated via NCOA. |

## Response Type

[`Task<Models.Campaign>`](../../doc/models/campaign.md)

## Example Usage

```csharp
ContentTypeEnum contentType = ContentTypeEnum.EnumApplicationxwwwformurlencoded;
string name = "My Demo Campaign";
CmpScheduleTypeEnum scheduleType = CmpScheduleTypeEnum.Immediate;
FileStreamInfo useType = new FileStreamInfo(new FileStream("dummy_file", FileMode.Open));
string description = "My Campaign's description";
try
{
    Campaign result = await campaignsController.CampaignCreateAsync(
        contentType,
        name,
        scheduleType,
        useType,
        null,
        null,
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
  "id": "cmp_e05ee61ff80764b",
  "billing_group_id": "bg_fe3079dcdd80e5ae",
  "name": "My Campaign",
  "description": "My Campaign's description",
  "schedule_type": "immediate",
  "cancel_window_campaign_minutes": 60,
  "metadata": {},
  "use_type": "marketing",
  "is_draft": true,
  "deleted": false,
  "creatives": [],
  "uploads": [],
  "auto_cancel_if_ncoa": false,
  "date_created": "2017-09-05T17:47:53.767Z",
  "date_modified": "2017-09-05T17:47:53.767Z",
  "object": "campaign"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error | [`Domains0Error1Exception`](../../doc/models/domains-0-error-1-exception.md) |


# Campaign Retrieve

Retrieves the details of an existing campaign. You need only supply the unique campaign identifier that was returned upon campaign creation.

```csharp
CampaignRetrieveAsync(
    string cmpId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `cmpId` | `string` | Template, Required | id of the campaign |

## Response Type

[`Task<Models.Campaign>`](../../doc/models/campaign.md)

## Example Usage

```csharp
string cmpId = "cmp_id0";
try
{
    Campaign result = await campaignsController.CampaignRetrieveAsync(cmpId);
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
  "id": "cmp_e05ee61ff80764b",
  "billing_group_id": "bg_fe3079dcdd80e5ae",
  "name": "My Campaign",
  "description": "My Campaign's description",
  "schedule_type": "immediate",
  "cancel_window_campaign_minutes": 60,
  "metadata": {},
  "use_type": "marketing",
  "is_draft": true,
  "deleted": false,
  "creatives": [],
  "uploads": [],
  "auto_cancel_if_ncoa": false,
  "date_created": "2017-09-05T17:47:53.767Z",
  "date_modified": "2017-09-05T17:47:53.767Z",
  "object": "campaign"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error | [`Domains0Error1Exception`](../../doc/models/domains-0-error-1-exception.md) |


# Campaign Update

Update the details of an existing campaign. You need only supply the unique identifier that was returned upon campaign creation.

```csharp
CampaignUpdateAsync(
    string cmpId,
    Models.ContentTypeEnum contentType,
    string name = null,
    string description = null,
    Models.CmpScheduleTypeEnum? scheduleType = null,
    DateTime? targetDeliveryDate = null,
    DateTime? sendDate = null,
    int? cancelWindowCampaignMinutes = null,
    Dictionary<string, string> metadata = null,
    bool? isDraft = null,
    FileStreamInfo useType = null,
    bool? autoCancelIfNcoa = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `cmpId` | `string` | Template, Required | id of the campaign |
| `contentType` | [`ContentTypeEnum`](../../doc/models/content-type-enum.md) | Header, Required | - |
| `name` | `string` | Form, Optional | - |
| `description` | `string` | Form, Optional | An internal description that identifies this resource. Must be no longer than 255 characters. |
| `scheduleType` | [`CmpScheduleTypeEnum?`](../../doc/models/cmp-schedule-type-enum.md) | Form, Optional | - |
| `targetDeliveryDate` | `DateTime?` | Form, Optional | If `schedule_type` is `target_delivery_date`, provide a targeted delivery date for mail pieces in this campaign. |
| `sendDate` | `DateTime?` | Form, Optional | If `schedule_type` is `scheduled_send_date`, provide a date to send this campaign. |
| `cancelWindowCampaignMinutes` | `int?` | Form, Optional | A window, in minutes, within which the campaign can be canceled. |
| `metadata` | `Dictionary<string, string>` | Form, Optional | Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters `"` and `\`. i.e. '{"customer_id" : "NEWYORK2015"}' Nested objects are not supported.  See [Metadata](#section/Metadata) for more information. |
| `isDraft` | `bool?` | Form, Optional | Whether or not the campaign is still a draft. Can either be excluded or `false`. |
| `useType` | `FileStreamInfo` | Form, Optional | - |
| `autoCancelIfNcoa` | `bool?` | Form, Optional | Whether or not a mail piece should be automatically canceled and not sent if the address is updated via NCOA. |

## Response Type

[`Task<Models.Campaign>`](../../doc/models/campaign.md)

## Example Usage

```csharp
string cmpId = "cmp_id0";
ContentTypeEnum contentType = ContentTypeEnum.EnumApplicationxwwwformurlencoded;
string description = "Test campaign";
try
{
    Campaign result = await campaignsController.CampaignUpdateAsync(
        cmpId,
        contentType,
        null,
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
  "id": "cmp_e05ee61ff80764b",
  "billing_group_id": "bg_fe3079dcdd80e5ae",
  "name": "My Campaign",
  "description": "My Campaign's description",
  "schedule_type": "immediate",
  "cancel_window_campaign_minutes": 60,
  "metadata": {},
  "use_type": "marketing",
  "is_draft": true,
  "deleted": false,
  "creatives": [],
  "uploads": [],
  "auto_cancel_if_ncoa": false,
  "date_created": "2017-09-05T17:47:53.767Z",
  "date_modified": "2017-09-05T17:47:53.767Z",
  "object": "campaign"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error | [`Domains0Error1Exception`](../../doc/models/domains-0-error-1-exception.md) |


# Campaign Delete

Delete an existing campaign. You need only supply the unique identifier that was returned upon campaign creation. Deleting a campaign also deletes any associated mail pieces that have been created but not sent. A campaign's `send_date` matches its associated mail pieces' `send_date`s.

```csharp
CampaignDeleteAsync(
    string cmpId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `cmpId` | `string` | Template, Required | id of the campaign |

## Response Type

[`Task<Models.CampaignsResponse4>`](../../doc/models/campaigns-response-4.md)

## Example Usage

```csharp
string cmpId = "cmp_id0";
try
{
    CampaignsResponse4 result = await campaignsController.CampaignDeleteAsync(cmpId);
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
  "id": "cmp_e05ee61ff80764b",
  "deleted": true
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error | [`Domains0Error1Exception`](../../doc/models/domains-0-error-1-exception.md) |


# Campaign Send

Sends a campaign. You need only supply the unique campaign identifier that was returned upon campaign creation.

```csharp
CampaignSendAsync(
    string cmpId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `cmpId` | `string` | Template, Required | id of the campaign |

## Response Type

[`Task<Models.Campaign>`](../../doc/models/campaign.md)

## Example Usage

```csharp
string cmpId = "cmp_id0";
try
{
    Campaign result = await campaignsController.CampaignSendAsync(cmpId);
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
  "id": "cmp_e05ee61ff80764b",
  "billing_group_id": "bg_fe3079dcdd80e5ae",
  "name": "My Campaign",
  "description": "My Campaign's description",
  "schedule_type": "immediate",
  "cancel_window_campaign_minutes": 60,
  "metadata": {},
  "use_type": "marketing",
  "is_draft": true,
  "deleted": false,
  "creatives": [],
  "uploads": [],
  "auto_cancel_if_ncoa": false,
  "date_created": "2017-09-05T17:47:53.767Z",
  "date_modified": "2017-09-05T17:47:53.767Z",
  "object": "campaign"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error | [`Domains0Error1Exception`](../../doc/models/domains-0-error-1-exception.md) |

