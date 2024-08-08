
# Dpv Active Enum

Corresponds to the USPS field `dpv_no_stat`. Indicates that an address has been vacated in the recent past, and is no longer receiving deliveries. If it's been unoccupied for 90+ days, or temporarily vacant, this will be flagged. Possible values are:

* `Y` –– Address is active.
* `N` –– Address is not active.
* `''` –– A DPV match is not made (`deliverability_analysis[dpv_confirmation]` is `N` or an empty string).

## Enumeration

`DpvActiveEnum`

## Fields

| Name |
|  --- |
| `Y` |
| `N` |

## Example

```
Y
```

