
# Deliverability 1 Enum

Summarizes the deliverability of the `intl_verification` object. Possible values are:

* `deliverable` — The address is deliverable.
* `deliverable_missing_info` — The address is missing some information, but is most likely deliverable.
* `undeliverable` — The address is most likely not deliverable. Some components of the address (such as city or postal code) may have been found.
* `no_match` — This address is not deliverable. No matching street could be found within the city or postal code.

## Enumeration

`Deliverability1Enum`

## Fields

| Name |
|  --- |
| `Deliverable` |
| `DeliverableMissingInfo` |
| `Undeliverable` |
| `NoMatch` |

