# StrugglePlugin
This plugin, created by davilone32, allows the user who is handcuffed to struggle with the cuffs to free themselves. The plugin has a cooldown and a usage percentage, meaning you can't always be freed.


# Config
```YAML
  is_enabled: true
  debug: false
  # This variable raises or lowers the chances that the user can remove the handcuffs.
  chanze: 80
  # The message that appears when you have failed to remove the handcuffs
  message_failed: 'Failed...'
  # The message he plays when the handcuffs have been removed
  message_works: '¡Manos liberadas! A disfrutar máquina.'
  # The waiting time it takes for the player to release the handcuffs again
  waiting_time: 30
  # Waiting message when the cooldown is set. CAUTION: Do not delete {Main.Instance.Config.WaitingTime} to set the waiting seconds
  messsage_message_waiting: 'You have to wait to be able to remove the handcuffs'
  player_dont_have_cuffed_hands: 'Your hands are not cuffed'
```
