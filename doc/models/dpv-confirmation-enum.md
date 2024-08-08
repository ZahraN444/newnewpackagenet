
# Dpv Confirmation Enum

Result of Delivery Point Validation (DPV), which determines whether or not the address is deliverable by the USPS. Possible values are:

* `Y` –– The address is deliverable by the USPS.
* `S` –– The address is deliverable by removing the provided secondary unit designator. This information may be incorrect or unnecessary.
* `D` –– The address is deliverable to the building's default address but is missing a secondary unit designator and/or number.
  There is a chance the mail will not reach the intended recipient.
* `N` –– The address is not deliverable according to the USPS, but parts of the address are valid (such as the street and ZIP code).
* `''` –– This address is not deliverable. No matching street could be found within the city or ZIP code.

## Enumeration

`DpvConfirmationEnum`

## Fields

| Name |
|  --- |
| `Y` |
| `S` |
| `D` |
| `N` |

## Example

```
Y
```

