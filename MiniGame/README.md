## Mermaid Class Diagram VSCode

```mermaid
classDiagram
    class Character {
        -Weapon [] weapons
        -string Name
        + Fight()
    }

    class Player {
        +Player(string name)
    }

    class Enemy {
        +Enemy(string name)
    }

    class Weapon {
        -float power
    }

    class Gun {
        +Gun(float power, int ammo)
    }

    class Sword {
        +Sword(float damage, float bladeLength)
    }

    Character <|-- Player
    Character <|-- Enemy
    Weapon <|-- Gun
    Weapon <|-- Sword
    Player --> Weapon : uses
    Enemy --> Weapon : uses

