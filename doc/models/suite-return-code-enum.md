
# Suite Return Code Enum

A return code that indicates whether the address was matched and corrected by
<a href="https://postalpro.usps.com/address-quality-solutions/suitelink" target="_blank">Suite<sup>Link</sup></a>.
Suite<sup>Link</sup> attempts to provide secondary information to business addresses.
Possible values are:

* `A` –– A Suite<sup>Link</sup> match was found and secondary information was added.
* `00` –– A Suite<sup>Link</sup> match could not be found and no secondary information was added.
* `''` –– Suite<sup>Link</sup> lookup was not attempted.

## Enumeration

`SuiteReturnCodeEnum`

## Fields

| Name |
|  --- |
| `A` |
| `Enum00` |

