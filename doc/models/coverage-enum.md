
# Coverage Enum

The coverage level for the country. This represents the maximum level of
accuracy an input address can be verified to.

* `SUBBUILDING` - Coverage down to unit numbers. For example, in an apartment or a large building
* `HOUSENUMBER/BUILDING` - Coverage down to house number. For example, the address where a house or building may be located
* `STREET` - Coverage down to street. This means that we can verify that an street exists in a city, state, country
* `LOCALITY` - Coverage down to city, state, or village or province. This means that we can verify that a city, village, province, or state exists in a country. Countries differ in how they define what is a province, state, city, village, etc. This attempts to group eveyrthing together.
* `SPARSE` - Some addresses for this country exist in our databases

## Enumeration

`CoverageEnum`

## Fields

| Name |
|  --- |
| `SUBBUILDING` |
| `EnumHOUSENUMBERBUILDING` |
| `STREET` |
| `LOCALITY` |
| `SPARSE` |

