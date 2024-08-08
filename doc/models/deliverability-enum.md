
# Deliverability Enum

Summarizes the deliverability of the `us_verification` object.
For full details, see the `deliverability_analysis` field. Possible values are:

* `deliverable` – The address is deliverable by the USPS.
* `deliverable_unnecessary_unit` – The address is deliverable, but the secondary unit information is unnecessary.
* `deliverable_incorrect_unit` – The address is deliverable to the building's default address but the secondary unit provided may not exist. There is a chance the mail will not reach the intended recipient.
* `deliverable_missing_unit` – The address is deliverable to the building's default address but is missing secondary unit information. There is a chance the mail will not reach the intended recipient.
* `undeliverable` – The address is not deliverable according to the USPS.

## Enumeration

`DeliverabilityEnum`

## Fields

| Name |
|  --- |
| `Deliverable` |
| `DeliverableUnnecessaryUnit` |
| `DeliverableIncorrectUnit` |
| `DeliverableMissingUnit` |
| `Undeliverable` |

