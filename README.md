[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=sosafacun_DemonEngine&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=sosafacun_DemonEngine)
---
# Demon Engine
---

This is an attempt to make an engine to create SMT-inspired games.

## Wanted basic features:

- CRUD elements
- CRUD resistances
- CRUD ailments
- CRUD stats (used for damage / resistance formulas)
- CRUD races (used for fusing and compendium sorting)
- CRUD skills (with elemental affinities, damage formulas and effects)
- CRUD demons with everything that was mentioned above + some other stuff (their lore, a picture, level, etc)

## Wanted gameplay features:

- Dungeon creator with an automatic minimap
- Dialog textboxes and triggers
- A somewhat nice UI.
- SMT combat system (press turn icon system, buffs and debuffs)

## If you understood nothing:

- **SMT**: Shin Megami Tensei. Atlus' biggest franchise and beloved JRPG.
- **Elements**: All attacks have elements that are crucial for the combat system in the game.
- **Press Turn Icon System**: This combat system revolves around 2 "phases" (to call them something) that reward or punish either party based on their actions in combat.
    - The first phase is the round, which determines who can act: the enemy or the player.
    - Once the round starts, each character on the team will add 1 action to the round. This is the 2nd phase.
        - If you have **four characters** in your party then you'll have **four actions** during your round. If you had 3, then you'd have 3 actions for your round.
        - If the enemy has 2 characters, then they'll have only 2 actions during their round.
        - If any character during **an opposing round** gets killed then their next round will have that many fewer actions (in the example above, if you killed 1 enemy, the next enemy round will have just 1 action).
        - Half Press Turn Icons:
            - Hitting a weakness or landing a critical hit means you'll get an extra action. This does not stack and the extra action is called "half press turn icon". You can use it as a regular press turn, but if you hit a weakness or crit **IT DOES NOT GIVE YOU THE SAME HALF PRESS TURN ICON**.
            - In the example above, a **four-character party** may have a maximum of **eight actions per round**.
            - Evading or Nullifying an attack means that **the attacking party looses 2 PTIs** (Press Turn Icons). In the example above, if a friendly character dodged an enemy attack then the enemy round would end since they would lose all of their actions.
            - If your party had 2 Half PTIs and 2 PTIs and the enemy nullified or evaded an attack then you'd lose the the 2 Half PTIs.
            - Draining or Repelling an attack instantly ends the round.
            - Missing an ailment-inducing attack **does NOT** take 2 PTIs from the casting party. However, if the targeted party nullifies the ailment, it does make the attacking party lose 2PTIs. At the same time, if the targeted party is weak to that ailment, it will grant the attacking party half PTI.
            - All these rules also apply to enemy actions.
        - Buffing and debuffing change from game to game, but I'll try to stick to SMT IV's system of -4/+4 to Attack, Defense and Hit/Evasion rate that does not decay.
- **Races**: Each demon has a race. That race usually determines the nature of the demon for the negotiation as well as their fussion. It's also used to sort them in the Compendium.
- **The Demon Compendium**: an in-game database holding all of the demons' data. Kinda like a Pokedex, but you can throw money at it to summon any registered demon.

---