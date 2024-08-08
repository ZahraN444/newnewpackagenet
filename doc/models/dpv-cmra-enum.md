
# Dpv Cmra Enum

Indicates whether or not the address is <a href="https://en.wikipedia.org/wiki/Commercial_mail_receiving_agency" target="_blank">CMRA-authorized</a>. Possible values are:

* `Y` –– Address is CMRA-authorized.
* `N` –– Address is not CMRA-authorized.
* `''` –– A DPV match is not made (`deliverability_analysis[dpv_confirmation]` is `N` or an empty string).

## Enumeration

`DpvCmraEnum`

## Fields

| Name |
|  --- |
| `Y` |
| `N` |

## Example

```
N
```

