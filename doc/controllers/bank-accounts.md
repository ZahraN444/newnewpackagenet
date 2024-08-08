# Bank Accounts

```csharp
BankAccountsController bankAccountsController = client.BankAccountsController;
```

## Class Name

`BankAccountsController`

## Methods

* [Bank Account Verify](../../doc/controllers/bank-accounts.md#bank-account-verify)
* [Bank Account Retrieve](../../doc/controllers/bank-accounts.md#bank-account-retrieve)
* [Bank Account Delete](../../doc/controllers/bank-accounts.md#bank-account-delete)
* [Bank Accounts List](../../doc/controllers/bank-accounts.md#bank-accounts-list)
* [Bank Account Create](../../doc/controllers/bank-accounts.md#bank-account-create)


# Bank Account Verify

Verify a bank account in order to create a check.

```csharp
BankAccountVerifyAsync(
    string bankId,
    Models.ContentTypeEnum contentType,
    List<int> amounts)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `bankId` | `string` | Template, Required | id of the bank account to be verified |
| `contentType` | [`ContentTypeEnum`](../../doc/models/content-type-enum.md) | Header, Required | - |
| `amounts` | `List<int>` | Form, Required | In live mode, an array containing the two micro deposits (in cents) placed in the bank account. In test mode, no micro deposits will be placed, so any two integers between `1` and `100` will work. |

## Response Type

[`Task<Models.BankAccount>`](../../doc/models/bank-account.md)

## Example Usage

```csharp
string bankId = "bank_id2";
ContentTypeEnum contentType = ContentTypeEnum.EnumApplicationxwwwformurlencoded;
List<int> amounts = new List<int>
{
    1,
    100,
};

try
{
    BankAccount result = await bankAccountsController.BankAccountVerifyAsync(
        bankId,
        contentType,
        amounts
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
  "id": "bank_8cad8df5354d33f",
  "signature_url": "https://lob-assets.com/letters/asd_asdfghjklqwertyu.pdf?version=45&expires=1234567890&signature=a",
  "description": "Test Bank Account",
  "metadata": {},
  "routing_number": "322271627",
  "fractional_routing_number": "25-3/440",
  "check_template": "jpm",
  "account_number": "123456789",
  "account_type": "company",
  "signatory": "John Doe",
  "bank_name": "J.P. MORGAN CHASE BANK, N.A.,",
  "bank_city": "Columbus",
  "bank_state": "OH",
  "bank_zip": "43240",
  "verified": false,
  "date_created": "2015-11-06T19:24:24.440Z",
  "date_modified": "2015-11-06T19:24:24.440Z",
  "object": "bank_account"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error | [`Domains0Error1Exception`](../../doc/models/domains-0-error-1-exception.md) |


# Bank Account Retrieve

Retrieves the details of an existing bank account. You need only supply the unique bank account identifier that was returned upon bank account creation.

```csharp
BankAccountRetrieveAsync(
    string bankId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `bankId` | `string` | Template, Required | id of the bank account |

## Response Type

[`Task<Models.BankAccount>`](../../doc/models/bank-account.md)

## Example Usage

```csharp
string bankId = "bank_id2";
try
{
    BankAccount result = await bankAccountsController.BankAccountRetrieveAsync(bankId);
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
  "id": "bank_8cad8df5354d33f",
  "signature_url": "https://lob-assets.com/letters/asd_asdfghjklqwertyu.pdf?version=45&expires=1234567890&signature=a",
  "description": "Test Bank Account",
  "metadata": {},
  "routing_number": "322271627",
  "fractional_routing_number": "25-3/440",
  "check_template": "jpm",
  "account_number": "123456789",
  "account_type": "company",
  "signatory": "John Doe",
  "bank_name": "J.P. MORGAN CHASE BANK, N.A.,",
  "bank_city": "Columbus",
  "bank_state": "OH",
  "bank_zip": "43240",
  "verified": false,
  "date_created": "2015-11-06T19:24:24.440Z",
  "date_modified": "2015-11-06T19:24:24.440Z",
  "object": "bank_account"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error | [`Domains0Error1Exception`](../../doc/models/domains-0-error-1-exception.md) |


# Bank Account Delete

Permanently deletes a bank account. It cannot be undone.

```csharp
BankAccountDeleteAsync(
    string bankId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `bankId` | `string` | Template, Required | id of the bank account |

## Response Type

[`Task<Models.BankAccountsResponse1>`](../../doc/models/bank-accounts-response-1.md)

## Example Usage

```csharp
string bankId = "bank_id2";
try
{
    BankAccountsResponse1 result = await bankAccountsController.BankAccountDeleteAsync(bankId);
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
  "id": "bank_123456789",
  "deleted": true
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error | [`Domains0Error1Exception`](../../doc/models/domains-0-error-1-exception.md) |


# Bank Accounts List

Returns a list of your bank accounts. The bank accounts are returned sorted by creation date, with the most recently created bank accounts appearing first.

```csharp
BankAccountsListAsync(
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

[`Task<Models.AllBankAccounts>`](../../doc/models/all-bank-accounts.md)

## Example Usage

```csharp
int? limit = 10;
try
{
    AllBankAccounts result = await bankAccountsController.BankAccountsListAsync(limit);
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
      "id": "bank_0e3fb07eba0b35b",
      "signature_url": "https://lob-assets.com/letters/asd_asdfghjklqwertyu.pdf?version=45&expires=1234567890&signature=a",
      "description": "Example bank account",
      "metadata": {},
      "routing_number": "122100024",
      "account_number": "1234564789",
      "account_type": "company",
      "signatory": "John Doe",
      "bank_name": "JPMORGAN CHASE BANK, NA",
      "verified": true,
      "date_created": "2019-03-30T13:13:22.200Z",
      "date_modified": "2019-03-30T13:13:23.385Z",
      "object": "bank_account"
    },
    {
      "id": "bank_eba93f7de3c02d9",
      "description": "Example bank account",
      "metadata": {},
      "routing_number": "122100024",
      "account_number": "1234564789",
      "account_type": "company",
      "signatory": "John Doe",
      "bank_name": "JPMORGAN CHASE BANK, NA",
      "verified": true,
      "date_created": "2019-03-30T13:11:06.809Z",
      "date_modified": "2019-03-30T13:11:07.872Z",
      "object": "bank_account"
    }
  ],
  "object": "list",
  "next_url": "https://api.lob.com/v1/bank_accounts?limit=2&after=eyJkYXRlT2Zmc2V0IjoiMjAxOS0wMy0zMFQxMzoxMTowNi44MDlaIiwiaWRPZmZzZXQiOiJiYW5rX2ViYTkzZjdkZTNjMDJkOSJ9",
  "previous_url": null,
  "count": 2
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error | [`Domains0Error1Exception`](../../doc/models/domains-0-error-1-exception.md) |


# Bank Account Create

Creates a new bank account with the provided properties. Bank accounts created in live mode will need to be verified via micro deposits before being able to send live checks. The deposits will appear in the bank account in 2-3 business days and have the description "VERIFICATION".

```csharp
BankAccountCreateAsync(
    Models.ContentTypeEnum contentType,
    string routingNumber,
    string accountNumber,
    Models.AccountTypeEnum accountType,
    string signatory,
    string description = null,
    Models.CheckTemplateEnum? checkTemplate = null,
    string fractionalRoutingNumber = null,
    string city = null,
    string state = null,
    string zipcode = null,
    Dictionary<string, string> metadata = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `contentType` | [`ContentTypeEnum`](../../doc/models/content-type-enum.md) | Header, Required | - |
| `routingNumber` | `string` | Form, Required | Must be a <a href="https://www.frbservices.org/index.html" target="_blank">valid US routing number</a>. |
| `accountNumber` | `string` | Form, Required | - |
| `accountType` | [`AccountTypeEnum`](../../doc/models/account-type-enum.md) | Form, Required | - |
| `signatory` | `string` | Form, Required | The signatory associated with your account. This name will be printed on checks created with this bank account. If you prefer to use a custom signature image on your checks instead, please create your bank account from the <a href="https://dashboard.lob.com/#/login" target="_blank">Dashboard</a>. |
| `description` | `string` | Form, Optional | An internal description that identifies this resource. Must be no longer than 255 characters. |
| `checkTemplate` | [`CheckTemplateEnum?`](../../doc/models/check-template-enum.md) | Form, Optional | - |
| `fractionalRoutingNumber` | `string` | Form, Optional | The fractional routing number for your home bank account. Required for the `jpm` check template only. Please contact a bank representative if you do not know the fractional routing number associated with your home bank institution. |
| `city` | `string` | Form, Optional | The city associated with your home bank account. Required for the `jpm` check template only. Please contact a bank representative if you do not know the city associated with your home bank institution. |
| `state` | `string` | Form, Optional | The state associated with your home bank account. Required for the `jpm` check template only. Please contact a bank representative if you do not know the state associated with your home bank institution. |
| `zipcode` | `string` | Form, Optional | The zipcode associated with your home bank account. Required for the `jpm` check template only. Please contact a bank representative if you do not know the zipcode associated with your home bank institution. |
| `metadata` | `Dictionary<string, string>` | Form, Optional | Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters `"` and `\`. i.e. '{"customer_id" : "NEWYORK2015"}' Nested objects are not supported.  See [Metadata](#section/Metadata) for more information. |

## Response Type

[`Task<Models.BankAccount>`](../../doc/models/bank-account.md)

## Example Usage

```csharp
ContentTypeEnum contentType = ContentTypeEnum.EnumApplicationxwwwformurlencoded;
string routingNumber = "322271627";
string accountNumber = "123456789";
AccountTypeEnum accountType = AccountTypeEnum.Company;
string signatory = "Jane Doe";
string description = "Test Bank Account";
try
{
    BankAccount result = await bankAccountsController.BankAccountCreateAsync(
        contentType,
        routingNumber,
        accountNumber,
        accountType,
        signatory,
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
  "id": "bank_8cad8df5354d33f",
  "signature_url": "https://lob-assets.com/letters/asd_asdfghjklqwertyu.pdf?version=45&expires=1234567890&signature=a",
  "description": "Test Bank Account",
  "metadata": {},
  "routing_number": "322271627",
  "fractional_routing_number": "25-3/440",
  "check_template": "jpm",
  "account_number": "123456789",
  "account_type": "company",
  "signatory": "John Doe",
  "bank_name": "J.P. MORGAN CHASE BANK, N.A.,",
  "bank_city": "Columbus",
  "bank_state": "OH",
  "bank_zip": "43240",
  "verified": false,
  "date_created": "2015-11-06T19:24:24.440Z",
  "date_modified": "2015-11-06T19:24:24.440Z",
  "object": "bank_account"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error | [`Domains0Error1Exception`](../../doc/models/domains-0-error-1-exception.md) |

