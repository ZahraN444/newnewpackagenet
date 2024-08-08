
# Lacs Indicator Enum

Indicates whether this address has been converted by
<a href="https://postalpro.usps.com/address-quality/lacslink" target="_blank">LACS<sup>Link</sup></a>.
LACS<sup>Link</sup> corrects outdated addresses into their modern counterparts.
Possible values are:

* `Y` –– New address produced with a matching record in LACS<sup>Link</sup>.
* `N` –– New address could not be produced with a matching record in LACS<sup>Link</sup>.
* `''` –– A DPV match is not made (`deliverability_analysis[dpv_confirmation]` is `N` or an empty string).

## Enumeration

`LacsIndicatorEnum`

## Fields

| Name |
|  --- |
| `Y` |
| `N` |

