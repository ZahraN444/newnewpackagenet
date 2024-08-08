# URL Shortener

```csharp
URLShortenerController uRLShortenerController = client.URLShortenerController;
```

## Class Name

`URLShortenerController`

## Methods

* [Domain Get](../../doc/controllers/url-shortener.md#domain-get)
* [Domain Delete](../../doc/controllers/url-shortener.md#domain-delete)
* [Domain Create](../../doc/controllers/url-shortener.md#domain-create)
* [Domain List](../../doc/controllers/url-shortener.md#domain-list)
* [Domain Delete Links](../../doc/controllers/url-shortener.md#domain-delete-links)
* [Links List](../../doc/controllers/url-shortener.md#links-list)
* [Links Get](../../doc/controllers/url-shortener.md#links-get)
* [Link Update](../../doc/controllers/url-shortener.md#link-update)
* [Links Delete](../../doc/controllers/url-shortener.md#links-delete)
* [Link Create](../../doc/controllers/url-shortener.md#link-create)
* [Link Bulk Create](../../doc/controllers/url-shortener.md#link-bulk-create)


# Domain Get

Retrieve details for a single domain.

```csharp
DomainGetAsync(
    string domainId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `domainId` | `string` | Template, Required | Unique identifier for a domain. |

## Response Type

[`Task<Models.DomainResponse>`](../../doc/models/domain-response.md)

## Example Usage

```csharp
string domainId = "domain_id2";
try
{
    DomainResponse result = await uRLShortenerController.DomainGetAsync(domainId);
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


# Domain Delete

Delete a registered domain. This operation can only be performed if all associated links with the domain are deleted.

```csharp
DomainDeleteAsync(
    string domainId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `domainId` | `string` | Template, Required | Unique identifier for a domain. |

## Response Type

[`Task<Models.DomainResponse>`](../../doc/models/domain-response.md)

## Example Usage

```csharp
string domainId = "domain_id2";
try
{
    DomainResponse result = await uRLShortenerController.DomainDeleteAsync(domainId);
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


# Domain Create

Add a new custom domain that can be used to create custom links.

```csharp
DomainCreateAsync(
    Models.ContentTypeEnum contentType,
    string domain)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `contentType` | [`ContentTypeEnum`](../../doc/models/content-type-enum.md) | Header, Required | - |
| `domain` | `string` | Form, Required | The registered domain/hostname. |

## Response Type

[`Task<Models.DomainResponse>`](../../doc/models/domain-response.md)

## Example Usage

```csharp
ContentTypeEnum contentType = ContentTypeEnum.EnumApplicationxwwwformurlencoded;
string domain = "domain6";
try
{
    DomainResponse result = await uRLShortenerController.DomainCreateAsync(
        contentType,
        domain
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


# Domain List

Retrieve a list of all created domains.

```csharp
DomainListAsync()
```

## Response Type

[`Task<Models.DomainsResponse>`](../../doc/models/domains-response.md)

## Example Usage

```csharp
try
{
    DomainsResponse result = await uRLShortenerController.DomainListAsync();
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


# Domain Delete Links

Delete all associated links for a domain

```csharp
DomainDeleteLinksAsync(
    string domainId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `domainId` | `string` | Template, Required | Unique identifier for a domain. |

## Response Type

[`Task<Models.DomainsResponse>`](../../doc/models/domains-response.md)

## Example Usage

```csharp
string domainId = "domain_id2";
try
{
    DomainsResponse result = await uRLShortenerController.DomainDeleteLinksAsync(domainId);
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
| Default | Error | [`DomainsLinks0Error1Exception`](../../doc/models/domains-links-0-error-1-exception.md) |


# Links List

Retrieves a list of shortened links. The list is sorted by  creation date, with the most recently created appearing first.

```csharp
LinksListAsync(
    int? limit = 10,
    int? offset = 0,
    List<string> include = null,
    Dictionary<string, string> dateCreated = null,
    Dictionary<string, string> metadata = null,
    string campaignId = null,
    bool? clicked = null,
    string billingGroupId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `limit` | `int?` | Query, Optional | How many results to return. |
| `offset` | `int?` | Query, Optional | An integer that designates the offset at which to begin returning results. Defaults to 0. |
| `include` | `List<string>` | Query, Optional | Request that the response include the total count by specifying `include=["total_count"]`. |
| `dateCreated` | `Dictionary<string, string>` | Query, Optional | Filter by date created. Accepted formats are ISO-8601 date or datetime, e.g. `{ "gt": "2012-01-01", "lt": "2012-01-31T12:34:56Z" }` where `gt` is >, `lt` is <, `gte` is ≥, and `lte` is ≤. |
| `metadata` | `Dictionary<string, string>` | Query, Optional | Filter by metadata key-value pair`. |
| `campaignId` | `string` | Query, Optional | Filter the links generated for a particular campaign using its campaign id. |
| `clicked` | `bool?` | Query, Optional | Retrieve the list of links that have been opened. |
| `billingGroupId` | `string` | Query, Optional | Filter the links generated for a particular billing group id. |

## Response Type

[`Task<Models.LinksResponse>`](../../doc/models/links-response.md)

## Example Usage

```csharp
int? limit = 10;
int? offset = 0;
try
{
    LinksResponse result = await uRLShortenerController.LinksListAsync(
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

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error | [`Links0Error1Exception`](../../doc/models/links-0-error-1-exception.md) |


# Links Get

Retrievs a single shortened link.

```csharp
LinksGetAsync(
    string linkId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `linkId` | `string` | Template, Required | Unique identifier for a link. |

## Response Type

[`Task<Models.LinkResponse>`](../../doc/models/link-response.md)

## Example Usage

```csharp
string linkId = "link_id0";
try
{
    LinkResponse result = await uRLShortenerController.LinksGetAsync(linkId);
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
| Default | Error | [`Links0Error1Exception`](../../doc/models/links-0-error-1-exception.md) |


# Link Update

Update any of the properties of a shortened link.

```csharp
LinkUpdateAsync(
    string linkId,
    Models.ContentTypeEnum contentType,
    string redirectLink,
    string domain = null,
    string slug = null,
    Dictionary<string, string> metadataTag = null,
    string billingGroupId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `linkId` | `string` | Template, Required | Unique identifier for a link. |
| `contentType` | [`ContentTypeEnum`](../../doc/models/content-type-enum.md) | Header, Required | - |
| `redirectLink` | `string` | Form, Required | The original target URL. |
| `domain` | `string` | Form, Optional | The registered domain to be used for the short URL. |
| `slug` | `string` | Form, Optional | The unique path for the shortened URL, if empty a unique path will be used. |
| `metadataTag` | `Dictionary<string, string>` | Form, Optional | Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters `"` and `\`. i.e. '{"customer_id" : "NEWYORK2015"}' Nested objects are not supported.  See [Metadata](#section/Metadata) for more information. |
| `billingGroupId` | `string` | Form, Optional | An optional string with the billing group ID to tag your usage with. Is used for billing purposes. Requires special activation to use. See <a href="#tag/Billing-Groups">Billing Group API</a> for more information. |

## Response Type

[`Task<Models.LinkResponse>`](../../doc/models/link-response.md)

## Example Usage

```csharp
string linkId = "link_id0";
ContentTypeEnum contentType = ContentTypeEnum.EnumApplicationxwwwformurlencoded;
string redirectLink = "redirect_link0";
try
{
    LinkResponse result = await uRLShortenerController.LinkUpdateAsync(
        linkId,
        contentType,
        redirectLink
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


# Links Delete

Delete the shortened link.

```csharp
LinksDeleteAsync(
    string linkId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `linkId` | `string` | Template, Required | Unique identifier for a link. |

## Response Type

[`Task<Models.LinkResponse>`](../../doc/models/link-response.md)

## Example Usage

```csharp
string linkId = "link_id0";
try
{
    LinkResponse result = await uRLShortenerController.LinksDeleteAsync(linkId);
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
| Default | Error | [`Links0Error1Exception`](../../doc/models/links-0-error-1-exception.md) |


# Link Create

Given a long URL, shorten your URL either by using a custom domain or Lob's own short domain.

```csharp
LinkCreateAsync(
    Models.ContentTypeEnum contentType,
    string redirectLink,
    string domain = null,
    string slug = null,
    Dictionary<string, string> metadataTag = null,
    string billingGroupId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `contentType` | [`ContentTypeEnum`](../../doc/models/content-type-enum.md) | Header, Required | - |
| `redirectLink` | `string` | Form, Required | The original target URL. |
| `domain` | `string` | Form, Optional | The registered domain to be used for the short URL. |
| `slug` | `string` | Form, Optional | The unique path for the shortened URL, if empty a unique path will be used. |
| `metadataTag` | `Dictionary<string, string>` | Form, Optional | Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters `"` and `\`. i.e. '{"customer_id" : "NEWYORK2015"}' Nested objects are not supported.  See [Metadata](#section/Metadata) for more information. |
| `billingGroupId` | `string` | Form, Optional | An optional string with the billing group ID to tag your usage with. Is used for billing purposes. Requires special activation to use. See <a href="#tag/Billing-Groups">Billing Group API</a> for more information. |

## Response Type

[`Task<Models.LinkResponse>`](../../doc/models/link-response.md)

## Example Usage

```csharp
ContentTypeEnum contentType = ContentTypeEnum.EnumApplicationxwwwformurlencoded;
string redirectLink = "redirect_link0";
try
{
    LinkResponse result = await uRLShortenerController.LinkCreateAsync(
        contentType,
        redirectLink
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


# Link Bulk Create

Shortens a list of links in a single request.

```csharp
LinkBulkCreateAsync(
    List<Models.LinkSingle> body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`List<LinkSingle>`](../../doc/models/link-single.md) | Body, Required | - |

## Response Type

[`Task<Models.LinksResponse>`](../../doc/models/links-response.md)

## Example Usage

```csharp
List<Models.LinkSingle> body = new List<Models.LinkSingle>
{
    new LinkSingle
    {
        RedirectLink = "redirect_link6",
    },
};

try
{
    LinksResponse result = await uRLShortenerController.LinkBulkCreateAsync(body);
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

