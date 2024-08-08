
# Dpv Vacant Enum

Indicates that an address was once deliverable, but has become vacant and is no longer receiving deliveries. Possible values are:

* `Y` –– Address is vacant.
* `N` –– Address is not vacant.
* `''` –– A DPV match is not made (`deliverability_analysis[dpv_confirmation]` is `N` or an empty string).

## Enumeration

`DpvVacantEnum`

## Fields

| Name |
|  --- |
| `Y` |
| `N` |

## Example

```
N
```

