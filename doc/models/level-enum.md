
# Level Enum

Indicates the likelihood that the address is a valid, mail-receiving address. Possible values are:

- `high` — Over 70% of mailpieces Lob has sent to this address were delivered successfully and recent mailings were also successful.
- `medium` — Between 40% and 70% of mailpieces Lob has sent to this address were delivered successfully.
- `low` — Less than 40% of mailpieces Lob has sent to this address were delivered successfully and recent mailings weren't successful.
- `""` — No tracking data exists for this address or lob deliverability was unable to find a corresponding level of mail success.

## Enumeration

`LevelEnum`

## Fields

| Name |
|  --- |
| `High` |
| `Medium` |
| `Low` |

