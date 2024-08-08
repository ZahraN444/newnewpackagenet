# Letters

The letters endpoint allows you to easily print and mail letters. The API provides endpoints for
creating letters, retrieving individual letters, canceling letters, and retrieving a list of letters.

<div class="back-to-top" ><a href="#" onclick="toTopLink()">back to top</a></div>


```csharp
LettersController lettersController = client.LettersController;
```

## Class Name

`LettersController`

## Methods

* [Letter Retrieve](../../doc/controllers/letters.md#letter-retrieve)
* [Letter Cancel](../../doc/controllers/letters.md#letter-cancel)
* [Letters List](../../doc/controllers/letters.md#letters-list)
* [Letter Create](../../doc/controllers/letters.md#letter-create)


# Letter Retrieve

Retrieves the details of an existing letter. You need only supply the unique letter identifier that was returned upon letter creation.

```csharp
LetterRetrieveAsync(
    string ltrId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ltrId` | `string` | Template, Required | id of the letter |

## Response Type

`Task<object>`

## Example Usage

```csharp
string ltrId = "ltr_id4";
try
{
    object result = await lettersController.LetterRetrieveAsync(ltrId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response

```
{
  "id": "ltr_4868c3b754655f90",
  "description": "Demo Letter",
  "metadata": {},
  "to": {
    "id": "adr_d3489cd64c791ab5",
    "description": null,
    "name": "HARRY ZHANG",
    "company": null,
    "phone": null,
    "email": null,
    "address_line1": "210 KING ST STE 6100",
    "address_line2": null,
    "address_city": "SAN FRANCISCO",
    "address_state": "CA",
    "address_zip": "94107-1741",
    "address_country": "UNITED STATES",
    "metadata": {},
    "date_created": "2017-09-05T15:54:53.264Z",
    "date_modified": "2017-09-05T15:54:53.264Z",
    "deleted": true,
    "object": "address"
  },
  "from": {
    "id": "adr_b8fb5acf3a2b55db",
    "description": null,
    "name": "LEORE AVIDAR",
    "company": null,
    "phone": null,
    "email": null,
    "address_line1": "210 KING ST STE 6100",
    "address_line2": null,
    "address_city": "SAN FRANCISCO",
    "address_state": "CA",
    "address_zip": "94107-1741",
    "address_country": "UNITED STATES",
    "metadata": {},
    "date_created": "2017-09-05T15:54:53.264Z",
    "date_modified": "2017-09-05T15:54:53.264Z",
    "deleted": true,
    "object": "address"
  },
  "color": true,
  "double_sided": true,
  "address_placement": "top_first_page",
  "return_envelope": false,
  "perforated_page": null,
  "custom_envelope": null,
  "extra_service": null,
  "mail_type": "usps_first_class",
  "url": "https://lob-assets.com/letters/ltr_4868c3b754655f90.pdf?expires=1540372221&signature=8r94fse8uam7wGWmW5baxXulU88X2CA",
  "carrier": "USPS",
  "tracking_number": null,
  "tracking_events": [],
  "thumbnails": [
    {
      "small": "https://lob-assets.com/letters/ltr_4868c3b754655f90_thumb_small_1.png?expires=1540372221&signature=a5fRBJ22ZA78Vgpg34M9UfmHWTS3eha",
      "medium": "https://lob-assets.com/letters/ltr_4868c3b754655f90_thumb_medium_1.png?expires=1540372221&signature=bAzL8sv935PY09FWSkpDpWKkyvGSWYF",
      "large": "https://lob-assets.com/letters/ltr_4868c3b754655f90_thumb_large_1.png?expires=1540372221&signature=gsKvxXgrm4v4iZD3bOibK7jApNkEMdW"
    }
  ],
  "merge_variables": {
    "name": "Harry"
  },
  "expected_delivery_date": "2017-09-12",
  "date_created": "2017-09-05T15:54:53.346Z",
  "date_modified": "2017-09-05T15:54:53.346Z",
  "send_date": "2017-09-05T15:54:53.346Z",
  "cards": [
    {
      "id": "card_c51ae96f5cebf3e",
      "account_id": "fa9ea650fc7b31a89f92",
      "description": null,
      "url": "https://lob-assets.com/cards/card_c51ae96f5cebf3e.pdf?version=v1&expires=1636910992&signature=mnsDH2DAxdkN9VibdlLMxJC86sME5WYDqkNtmvGwdNsAaUWfbnv0rJhJ1mR8Ol4uxQq61j5wYZ0r3s-lBkQfDA",
      "size": "2.125x3.375",
      "auto_reorder": false,
      "reorder_quantity": null,
      "raw_url": "https://lob-assets.com/cards/card_c51ae96f5cebf3e_raw.pdf?version=v1&expires=1636910992&signature=-bZo31FMAp2vmNaZKyXn_Qa4APqwtNinw76FrQ7uyQejFZw6VBQQYfoiQ642iXh0H2K5i2aOo8_BAkt3UJdVDw",
      "front_original_url": "https://lob-assets.com/cards/card_c51ae96f5cebf3e_raw.pdf?version=v1&expires=1636910992&signature=-bZo31FMAp2vmNaZKyXn_Qa4APqwtNinw76FrQ7uyQejFZw6VBQQYfoiQ642iXh0H2K5i2aOo8_BAkt3UJdVDw",
      "back_original_url": "https://lob-assets.com/cards/card_c51ae96f5cebf3e_raw.pdf?version=v1&expires=1636910992&signature=-bZo31FMAp2vmNaZKyXn_Qa4APqwtNinw76FrQ7uyQejFZw6VBQQYfoiQ642iXh0H2K5i2aOo8_BAkt3UJdVDw",
      "thumbnails": [
        {
          "small": "https://lob-assets.com/cards/card_c51ae96f5cebf3e_thumb_small_1.png?version=v1&expires=1636910992&signature=mrv8JDvpZK4I8WUGH0tPdtK-My5oes0Ltj_gL7BDw96SpCTTeZFHkz81SzclyFP9dQRtlsvAsjcuGcTBvCvOCg",
          "medium": "https://lob-assets.com/cards/card_c51ae96f5cebf3e_thumb_medium_1.png?version=v1&expires=1636910992&signature=VgL_2Ckm_kxKiWGgWtdNoy9HHOn8dGYSVOn7UqyCbwdbVlUtx28TRN4Bo8Iru3n0keKp9He0YhKT1ILotznMDA",
          "large": "https://lob-assets.com/cards/card_c51ae96f5cebf3e_thumb_large_1.png?version=v1&expires=1636910992&signature=FKSzymA13j-CQ0uk20cGHZTzT3vimzNBYrgp-xifLFg4mMdo1BZALR5O0aF_jVhsX614hKP35ONdYl47TQxXAw"
        },
        {
          "small": "https://lob-assets.com/cards/card_c51ae96f5cebf3e_thumb_small_2.png?version=v1&expires=1636910992&signature=IWsmPa_ULlv2yyqjX564d_YfHHY_M7i9YxDnw-WXDr2jtOFcArmRZQbnHeE9g_rYxnddJbgosuv8-c2utiu7Cg",
          "medium": "https://lob-assets.com/cards/card_c51ae96f5cebf3e_thumb_medium_2.png?version=v1&expires=1636910992&signature=zxK7VKGiTvz5Ywrkaydd0v3GcYf58R7A08J4tNfI7-aiNODDcTF3l0MqY13n9Pyc8RXSdD0XVBY-OpbA1VM-Ag",
          "large": "https://lob-assets.com/cards/card_c51ae96f5cebf3e_thumb_large_2.png?version=v1&expires=1636910992&signature=r0OFUhh315ZwN0raMZdIwJd2oCIEYsz0BABaMxIuO1PKTD0ckGWrhcGdzk2dlWQ6vSvp0CUQ5k1RXGqkIIqkDw"
        }
      ],
      "available_quantity": 10000,
      "pending_quantity": 0,
      "countries": null,
      "status": "rendered",
      "mode": "test",
      "orientation": "horizontal",
      "threshold_amount": 0,
      "date_created": "2017-08-05T15:54:53.346Z",
      "date_modified": "2017-08-05T15:54:53.346Z",
      "object": "card"
    }
  ],
  "use_type": "marketing",
  "fsc": false,
  "object": "letter"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error | [`Domains0Error1Exception`](../../doc/models/domains-0-error-1-exception.md) |


# Letter Cancel

Completely removes a letter from production. This can only be done if the letter has a `send_date` and the `send_date` has not yet passed. If the letter is successfully canceled, you will not be charged for it. Read more on [cancellation windows](#section/Cancellation-Windows) and [scheduling](#section/Scheduled-Mailings). Scheduling and cancellation is a premium feature. Upgrade to the appropriate <a href="https://dashboard.lob.com/#/settings/editions" target="_blank">Print & Mail Edition</a> to gain access.

```csharp
LetterCancelAsync(
    string ltrId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ltrId` | `string` | Template, Required | id of the letter |

## Response Type

[`Task<Models.LettersResponse>`](../../doc/models/letters-response.md)

## Example Usage

```csharp
string ltrId = "ltr_id4";
try
{
    LettersResponse result = await lettersController.LetterCancelAsync(ltrId);
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
  "id": "ltr_123456789",
  "deleted": true
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error | [`Domains0Error1Exception`](../../doc/models/domains-0-error-1-exception.md) |


# Letters List

Returns a list of your letters. The letters are returned sorted by creation date, with the most recently created letters appearing first.

```csharp
LettersListAsync(
    int? limit = 10,
    Models.Beforeafter beforeAfter = null,
    List<string> include = null,
    Dictionary<string, string> dateCreated = null,
    Dictionary<string, string> metadata = null,
    bool? color = null,
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
| `color` | `bool?` | Query, Optional | Set to `true` to return only color letters. Set to `false` to return only black & white letters. |
| `scheduled` | `bool?` | Query, Optional | * `true` - only return orders (past or future) where `send_date` is<br>  greater than `date_created`<br>* `false` - only return orders where `send_date` is equal to `date_created` |
| `sendDate` | [`object`](../../doc/models/m-object-enum.md) | Query, Optional | Filter by ISO-8601 date or datetime, e.g. `{ "gt": "2012-01-01", "lt": "2012-01-31T12:34:56Z" }` where `gt` is >, `lt` is <, `gte` is ≥, and `lte` is ≤. |
| `mailType` | [`MailTypeEnum?`](../../doc/models/mail-type-enum.md) | Query, Optional | A string designating the mail postage type: * `usps_first_class` - (default) * `usps_standard` - a <a href="https://lob.com/pricing/print-mail#compare" target="_blank">cheaper option</a> which is less predictable and takes longer to deliver. `usps_standard` cannot be used with `4x6` postcards or for any postcards sent outside of the United States. |
| `sortBy` | [`SortBy1`](../../doc/models/sort-by-1.md) | Query, Optional | Sorts items by ascending or descending dates. Use either `date_created` or `send_date`, not both. |

## Response Type

[`Task<Models.AllLetters>`](../../doc/models/all-letters.md)

## Example Usage

```csharp
int? limit = 10;
try
{
    AllLetters result = await lettersController.LettersListAsync(limit);
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
      "id": "ltr_5ba44b462c79f07c",
      "description": "Demo Letter",
      "metadata": {},
      "to": {
        "id": "adr_asdi2y3riuasasoi",
        "description": "Harry - Office",
        "name": "Harry Zhang",
        "company": "Lob",
        "phone": "5555555555",
        "email": "harry@lob.com",
        "metadata": {},
        "address_line1": "370 WATER ST",
        "address_line2": "",
        "address_city": "SUMMERSIDE",
        "address_state": "PRINCE EDWARD ISLAND",
        "address_zip": "C1N 1C4",
        "address_country": "CANADA",
        "recipient_moved": false,
        "date_created": "2019-09-20T00:14:00.361Z",
        "date_modified": "2019-09-20T00:14:00.361Z",
        "object": "address"
      },
      "from": {
        "id": "adr_210a8d4b0b76d77b",
        "description": null,
        "name": "LEORE AVIDAR",
        "company": null,
        "phone": null,
        "email": null,
        "address_line1": "210 KING ST STE 6100",
        "address_line2": null,
        "address_city": "SAN FRANCISCO",
        "address_state": "CA",
        "address_zip": "94107-1741",
        "address_country": "UNITED STATES",
        "metadata": {},
        "date_created": "2018-12-08T03:01:07.651Z",
        "date_modified": "2018-12-08T03:01:07.651Z",
        "object": "address"
      },
      "color": true,
      "double_sided": false,
      "address_placement": "top_first_page",
      "return_envelope": false,
      "perforated_page": null,
      "extra_service": "certified",
      "custom_envelope": null,
      "template_id": "tmpl_a",
      "template_version_id": "vrsn_a",
      "mail_type": "usps_first_class",
      "url": "https://lob-assets.com/letters/ltr_5ba44b462c79f07c.pdf?version=v1&expires=1568239830&signature=Ob-DUPLJLM4scWQeCDNadPJ4j33MZw16pykOxwv2us-bA7utTYi6oZ8WrEtBYDBBo09XkapR3gdJf0NEr90xAA",
      "merge_variables": null,
      "carrier": "USPS",
      "tracking_number": "92071902358909000011275538",
      "tracking_events": [
        {
          "id": "evnt_9e84094c9368cfb",
          "type": "certified",
          "name": "Delivered",
          "details": {
            "event": "delivered",
            "description": "Package has been delivered.",
            "notes": "Delivered, Front Desk/Reception/Mail Room",
            "action_required": false
          },
          "location": "33408",
          "time": "2019-10-08T19:41:00Z",
          "date_created": "2019-10-08T19:41:00Z",
          "date_modified": "2019-10-08T19:41:00Z",
          "object": "tracking_event"
        }
      ],
      "thumbnails": [
        {
          "small": "https://lob-assets.com/letters/ltr_5ba44b462c79f07c_thumb_small_1.png?version=v1&expires=1568239830&signature=xZUmE8rq8wSECHPEb9c37cUDZBzGUO3XK5LsIPZhI6dOXgm6zJEn8_7tKuZ3JWBmvNJNXdTl_ufkNu4avjQUDw",
          "medium": "https://lob-assets.com/letters/ltr_5ba44b462c79f07c_thumb_medium_1.png?version=v1&expires=1568239830&signature=H7354Qpcm9S4aXbrMsBe6QJ6lSNi9IWPgMJtLWLi4Kyx9tHF8Mp9YEc_IL9x89Jfw4-yRzKDXA410X4W0PssBQ",
          "large": "https://lob-assets.com/letters/ltr_5ba44b462c79f07c_thumb_large_1.png?version=v1&expires=1568239830&signature=54LUIDKZyItA9pnC87d1pJVAuw8bhKLCsMpNWkB3LgdVWxPxxb_c1IyIWAbSR-dyOYEOlDBCc40J4Kns-O_mAg"
        }
      ],
      "expected_delivery_date": "2019-08-16",
      "date_created": "2019-08-08T17:09:14.514Z",
      "date_modified": "2019-08-08T17:09:16.850Z",
      "send_date": "2019-08-08",
      "use_type": "marketing",
      "fsc": false,
      "object": "letter"
    },
    {
      "id": "ltr_da8267c6a6545cd6",
      "description": "Demo Letter",
      "metadata": {},
      "to": {
        "id": "adr_210a8d4b0b76d77b",
        "description": null,
        "name": "LEORE AVIDAR",
        "company": null,
        "phone": null,
        "email": null,
        "address_line1": "210 KING ST STE 6100",
        "address_line2": null,
        "address_city": "SAN FRANCISCO",
        "address_state": "CA",
        "address_zip": "94107-1741",
        "address_country": "UNITED STATES",
        "metadata": {},
        "date_created": "2018-12-08T03:01:07.651Z",
        "date_modified": "2018-12-08T03:01:07.651Z",
        "object": "address"
      },
      "from": {
        "id": "adr_210a8d4b0b76d77b",
        "description": null,
        "name": "LEORE AVIDAR",
        "company": null,
        "phone": null,
        "email": null,
        "address_line1": "210 KING ST STE 6100",
        "address_line2": null,
        "address_city": "SAN FRANCISCO",
        "address_state": "CA",
        "address_zip": "94107-1741",
        "address_country": "UNITED STATES",
        "metadata": {},
        "date_created": "2018-12-08T03:01:07.651Z",
        "date_modified": "2018-12-08T03:01:07.651Z",
        "object": "address"
      },
      "color": true,
      "double_sided": false,
      "address_placement": "top_first_page",
      "return_envelope": false,
      "perforated_page": null,
      "extra_service": null,
      "custom_envelope": null,
      "mail_type": "usps_first_class",
      "url": "https://lob-assets.com/letters/ltr_da8267c6a6545cd6.pdf?version=v1&expires=1568239830&signature=HH-5RnbD4x0eJcnEC9HhqKSvQGsbkjovzvqSKgBijUHKIXwEKQJ4CbYhKs_U2q2A1k20Xefcaw7bfdPKozuqCQ",
      "merge_variables": null,
      "carrier": "USPS",
      "tracking_number": null,
      "tracking_events": [],
      "thumbnails": [
        {
          "small": "https://lob-assets.com/letters/ltr_da8267c6a6545cd6_thumb_small_1.png?version=v1&expires=1568239830&signature=C1Rs83187HpWGhsg_pJIOhDIKlDtC_IgBBxHiocCEzJ8CncJwqrq5yHke-p97Dv7o81G_pfhFmirai589O6DCw",
          "medium": "https://lob-assets.com/letters/ltr_da8267c6a6545cd6_thumb_medium_1.png?version=v1&expires=1568239830&signature=gz63l0yi3sK_sXjYfIVdLSvkknJFr_O5TWRulo_iKIgS-PosIl6J0tDR6bx_Tv5Ab_w7DABg3qdKZ846MZ7TCw",
          "large": "https://lob-assets.com/letters/ltr_da8267c6a6545cd6_thumb_large_1.png?version=v1&expires=1568239830&signature=4Y1OIymaWkSO3aBIHCeshFAVnF-pDcF2FFqkx_jovaUFuk4FT1SI24L7_POwTRXQHlETMGlzkP_CGgqselRUAA"
        }
      ],
      "expected_delivery_date": "2019-08-16",
      "date_created": "2019-08-08T17:08:12.224Z",
      "date_modified": "2019-08-08T17:08:13.990Z",
      "send_date": "2019-08-08T17:08:12.224Z",
      "cards": null,
      "use_type": "marketing",
      "fsc": true,
      "object": "letter"
    }
  ],
  "object": "list",
  "next_url": "https://api.lob.com/v1/letters?limit=2&after=eyJkYXRlT2Zmc2V0IjoiMjAxOS0wOC0wOFQxNzowODoxMi4yMjRaIiwiaWRPZmZzZXQiOiJsdHJfZGE4MjY3YzZhNjU0NWNkNiJ9",
  "previous_url": null,
  "count": 2
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error | [`Domains0Error1Exception`](../../doc/models/domains-0-error-1-exception.md) |


# Letter Create

Creates a new letter given information

```csharp
LetterCreateAsync(
    Models.LetterEditable body,
    string idempotencyKey = null,
    string idempotencyKey2 = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`LetterEditable`](../../doc/models/letter-editable.md) | Body, Required | - |
| `idempotencyKey` | `string` | Header, Optional | A string of no longer than 256 characters that uniquely identifies this resource. For more help integrating idempotency keys, refer to our <a href="https://help.lob.com/print-and-mail/building-a-mail-strategy/managing-mail-settings#idempotent-requests-12" target="_blank">implementation guide</a>. |
| `idempotencyKey2` | `string` | Query, Optional | A string of no longer than 256 characters that uniquely identifies this resource. For more help integrating idempotency keys, refer to our <a href="https://help.lob.com/print-and-mail/building-a-mail-strategy/managing-mail-settings#idempotent-requests-12" target="_blank">implementation guide</a>. |

## Response Type

`Task<object>`

## Example Usage

```csharp
LetterEditable body = new LetterEditable
{
    To = LetterEditableTo.FromString("String1"),
    From = LetterEditableFrom.FromString("String7"),
    File = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    Color = false,
    UseType = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    DoubleSided = true,
    Fsc = false,
};

string idempotencyKey = "026e7634-24d7-486c-a0bb-4a17fd0eebc5";
string idempotencyKey2 = "026e7634-24d7-486c-a0bb-4a17fd0eebc5";
try
{
    object result = await lettersController.LetterCreateAsync(
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

## Example Response

```
{
  "id": "ltr_4868c3b754655f90",
  "description": "Demo Letter",
  "metadata": {},
  "to": {
    "id": "adr_d3489cd64c791ab5",
    "description": null,
    "name": "HARRY ZHANG",
    "company": null,
    "phone": null,
    "email": null,
    "address_line1": "210 KING ST STE 6100",
    "address_line2": null,
    "address_city": "SAN FRANCISCO",
    "address_state": "CA",
    "address_zip": "94107-1741",
    "address_country": "UNITED STATES",
    "metadata": {},
    "date_created": "2017-09-05T15:54:53.264Z",
    "date_modified": "2017-09-05T15:54:53.264Z",
    "deleted": true,
    "object": "address"
  },
  "from": {
    "id": "adr_b8fb5acf3a2b55db",
    "description": null,
    "name": "LEORE AVIDAR",
    "company": null,
    "phone": null,
    "email": null,
    "address_line1": "210 KING ST STE 6100",
    "address_line2": null,
    "address_city": "SAN FRANCISCO",
    "address_state": "CA",
    "address_zip": "94107-1741",
    "address_country": "UNITED STATES",
    "metadata": {},
    "date_created": "2017-09-05T15:54:53.264Z",
    "date_modified": "2017-09-05T15:54:53.264Z",
    "deleted": true,
    "object": "address"
  },
  "color": true,
  "double_sided": true,
  "address_placement": "top_first_page",
  "return_envelope": false,
  "perforated_page": null,
  "custom_envelope": null,
  "extra_service": null,
  "mail_type": "usps_first_class",
  "url": "https://lob-assets.com/letters/ltr_4868c3b754655f90.pdf?expires=1540372221&signature=8r94fse8uam7wGWmW5baxXulU88X2CA",
  "carrier": "USPS",
  "tracking_number": null,
  "tracking_events": [],
  "thumbnails": [
    {
      "small": "https://lob-assets.com/letters/ltr_4868c3b754655f90_thumb_small_1.png?expires=1540372221&signature=a5fRBJ22ZA78Vgpg34M9UfmHWTS3eha",
      "medium": "https://lob-assets.com/letters/ltr_4868c3b754655f90_thumb_medium_1.png?expires=1540372221&signature=bAzL8sv935PY09FWSkpDpWKkyvGSWYF",
      "large": "https://lob-assets.com/letters/ltr_4868c3b754655f90_thumb_large_1.png?expires=1540372221&signature=gsKvxXgrm4v4iZD3bOibK7jApNkEMdW"
    }
  ],
  "merge_variables": {
    "name": "Harry"
  },
  "expected_delivery_date": "2017-09-12",
  "date_created": "2017-09-05T15:54:53.346Z",
  "date_modified": "2017-09-05T15:54:53.346Z",
  "send_date": "2017-09-05T15:54:53.346Z",
  "cards": [
    {
      "id": "card_c51ae96f5cebf3e",
      "account_id": "fa9ea650fc7b31a89f92",
      "description": null,
      "url": "https://lob-assets.com/cards/card_c51ae96f5cebf3e.pdf?version=v1&expires=1636910992&signature=mnsDH2DAxdkN9VibdlLMxJC86sME5WYDqkNtmvGwdNsAaUWfbnv0rJhJ1mR8Ol4uxQq61j5wYZ0r3s-lBkQfDA",
      "size": "2.125x3.375",
      "auto_reorder": false,
      "reorder_quantity": null,
      "raw_url": "https://lob-assets.com/cards/card_c51ae96f5cebf3e_raw.pdf?version=v1&expires=1636910992&signature=-bZo31FMAp2vmNaZKyXn_Qa4APqwtNinw76FrQ7uyQejFZw6VBQQYfoiQ642iXh0H2K5i2aOo8_BAkt3UJdVDw",
      "front_original_url": "https://lob-assets.com/cards/card_c51ae96f5cebf3e_raw.pdf?version=v1&expires=1636910992&signature=-bZo31FMAp2vmNaZKyXn_Qa4APqwtNinw76FrQ7uyQejFZw6VBQQYfoiQ642iXh0H2K5i2aOo8_BAkt3UJdVDw",
      "back_original_url": "https://lob-assets.com/cards/card_c51ae96f5cebf3e_raw.pdf?version=v1&expires=1636910992&signature=-bZo31FMAp2vmNaZKyXn_Qa4APqwtNinw76FrQ7uyQejFZw6VBQQYfoiQ642iXh0H2K5i2aOo8_BAkt3UJdVDw",
      "thumbnails": [
        {
          "small": "https://lob-assets.com/cards/card_c51ae96f5cebf3e_thumb_small_1.png?version=v1&expires=1636910992&signature=mrv8JDvpZK4I8WUGH0tPdtK-My5oes0Ltj_gL7BDw96SpCTTeZFHkz81SzclyFP9dQRtlsvAsjcuGcTBvCvOCg",
          "medium": "https://lob-assets.com/cards/card_c51ae96f5cebf3e_thumb_medium_1.png?version=v1&expires=1636910992&signature=VgL_2Ckm_kxKiWGgWtdNoy9HHOn8dGYSVOn7UqyCbwdbVlUtx28TRN4Bo8Iru3n0keKp9He0YhKT1ILotznMDA",
          "large": "https://lob-assets.com/cards/card_c51ae96f5cebf3e_thumb_large_1.png?version=v1&expires=1636910992&signature=FKSzymA13j-CQ0uk20cGHZTzT3vimzNBYrgp-xifLFg4mMdo1BZALR5O0aF_jVhsX614hKP35ONdYl47TQxXAw"
        },
        {
          "small": "https://lob-assets.com/cards/card_c51ae96f5cebf3e_thumb_small_2.png?version=v1&expires=1636910992&signature=IWsmPa_ULlv2yyqjX564d_YfHHY_M7i9YxDnw-WXDr2jtOFcArmRZQbnHeE9g_rYxnddJbgosuv8-c2utiu7Cg",
          "medium": "https://lob-assets.com/cards/card_c51ae96f5cebf3e_thumb_medium_2.png?version=v1&expires=1636910992&signature=zxK7VKGiTvz5Ywrkaydd0v3GcYf58R7A08J4tNfI7-aiNODDcTF3l0MqY13n9Pyc8RXSdD0XVBY-OpbA1VM-Ag",
          "large": "https://lob-assets.com/cards/card_c51ae96f5cebf3e_thumb_large_2.png?version=v1&expires=1636910992&signature=r0OFUhh315ZwN0raMZdIwJd2oCIEYsz0BABaMxIuO1PKTD0ckGWrhcGdzk2dlWQ6vSvp0CUQ5k1RXGqkIIqkDw"
        }
      ],
      "available_quantity": 10000,
      "pending_quantity": 0,
      "countries": null,
      "status": "rendered",
      "mode": "test",
      "orientation": "horizontal",
      "threshold_amount": 0,
      "date_created": "2017-08-05T15:54:53.346Z",
      "date_modified": "2017-08-05T15:54:53.346Z",
      "object": "card"
    }
  ],
  "use_type": "marketing",
  "fsc": false,
  "object": "letter"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error | [`Domains0Error1Exception`](../../doc/models/domains-0-error-1-exception.md) |

