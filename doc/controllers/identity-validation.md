# Identity Validation

```csharp
IdentityValidationController identityValidationController = client.IdentityValidationController;
```

## Class Name

`IdentityValidationController`


# Identity Validation

Validates whether a given name is associated with an address.

```csharp
IdentityValidationAsync(
    object body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`object`](../../doc/models/m-object-enum.md) | Body, Required | - |

## Response Type

[`Task<IdentityValidation>`](../../doc/models/containers/identity-validation.md)

## Example Usage

```csharp
object body = ApiHelper.JsonDeserialize<object>("{\"recipient\":\"Larry Lobster\",\"primary_line\":\"210 King St.\",\"secondary_line\":\"\",\"city\":\"San Francisco\",\"state\":\"CA\",\"zip_code\":\"94107\"}");
try
{
    IdentityValidation result = await identityValidationController.IdentityValidationAsync(body);
    result.Match<VoidType>(
        recipientValidation: @case =>
        {
            Console.WriteLine(@case);
            return null;
        },
        companyValidation: @case =>
        {
            Console.WriteLine(@case);
            return null;
        });
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

