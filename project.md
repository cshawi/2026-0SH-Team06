
<p align="center"><img src="./_bin/logo.svg" alt="drawing" width="100"/></p>
<h4 align="center">0SH - Gestion de projet (2026)</h4>
<<<<<<< HEAD

# 1. Calendrier du projet
| Date | Matière en classe | Projet  |
|----------:|:---------:|:---------:|
| 02-20         | Création d'un projet GitHub | Planification |
| 02-27         | Documentation d'un Bug    | Livrable #1 |
| 03-06         | Relâche    |  |
| 03-13         |     |  |
| 03-20         |     | |
| 03-27         |     | |
| 04-03         | Congé de Pâques    |  |
| 04-10         |     | |
| 04-17         |     | |
| 04-24         |     | |
| 05-01         | Présentation des projets en classe (Épreuve terminale)    | Livrable #4 |


# 2. Mise en situation (client)
Écrire une description de quelques lignes ou de quelques paragraphes représentant la demande du client. Je dois savoir exactement ce que je dois programmer en lisant votre texte.
> Pas le **comment**, mais le **quoi** !

# 3. Preuve de faisabilité technique
En utilisant tous les outils nécessaires, vous devez convaincre le client que les technologies existent et sont accessibles afin de réaliser le projet décrit en 1.1.
=======
<h2 align="center">CuccoAttack</h2>

# 1. Mise en situation (client)

> Un jeu de plateforme en 2D, inspiré des cuccos  de « The Legend of Zelda », mettant en scène un cucco samouraï comme personnage principal.  
> Le style visuel sera rétro, inspiré des jeux 8-bit / 16-bit, avec des graphismes pixel art.

---

# 2. Preuve de faisabilité technique

> Nous devons démontrer que les technologies nécessaires sont accessibles et adaptées à la réalisation du projet.

Le jeu sera développé avec les outils suivants :

- **Unity Hub** : gestion des versions et des projets Unity.
- **Unity (2D)** : moteur de jeu pour la création du gameplay, gestion des scènes, collisions, animations et interface.
- **C#** : langage de programmation pour le développement des mécaniques du jeu.
- **ibisPaint X** : création des personnages et sprites en pixel art.
- **Tilemap Unity** : création des niveaux.
- **AudioSource (Unity)** : gestion de la musique et des effets sonores.
- **Build Windows / Mac** : exportation multiplateforme.

Ces technologies sont largement documentées, accessibles gratuitement (version gratuite) et adaptées aux jeux 2D.

---

# 3. Conception

## 3.1 Vision globale

CuccoAttack est un jeu de plateforme 2D de style rétro dans lequel le joueur incarne un cucco samouraï.  
Le joueur explore un niveau, combat des ennemis et collecte des objets pour atteindre un objectif final.

## 3.2 Objectif du jeu

Le but est de récupérer des objets (œufs, autres cuccos, artefacts) et de les ramener à un point spécifique du niveau afin de compléter celui-ci.

## 3.3 Concept central

- Gameplay simple et accessible
- Déplacements fluides avec inertie légère
- Combat dynamique
- Collecte d’objets
- Style rétro pixel art

---

## 3.4 Besoins

### 3.4.1 Besoins fonctionnels

- Déplacement gauche/droite
- Saut simple
- Saut haut (maintien du bouton)
- Double saut
- Attaque (ergots **ou** arme blanche – à décider)
- Système de collecte d’objets
- Détection de collision (sol, murs, ennemis)
- Ennemis patrouillent
- Ennemis attaquent si proche
- Système de points de vie
- Condition de victoire
- Condition de défaite

---

### 3.4.2 Besoins non fonctionnels

- Performance fluide (60 FPS cible)
- Compatible Windows / Mac
- Temps de chargement court
- Interface intuitive
- Contrôles clairs et simples
- Code structuré et maintenable

---

# 4. Planification

- Le jeu est un **platformer** style Mario.
- Le personnage principal peut se déplacer, effectuer des sauts simples et des doubles sauts.
- La caméra suit automatiquement le joueur.
- Le joueur peut combattre des ennemis avec des coups d’ergots **ou** une arme blanche (à décider).
- Il doit trouver des objets (autres poulets, œufs, etc.).
- Une fois les objets ramassés, il doit les amener à un point commun pour réussir le niveau.
- Ajout de musique rétro 8-bit / 16-bit.
- Effets sonores : saut, attaque, collecte, victoire.

---

## 4.1 Phases du projet

### Phase 1 – Prototype
- Déplacement + saut
- Caméra qui suit
- 1 niveau simple
- 1 ennemi
- 1 objet collectable

### Phase 2 – Gameplay
- Attaque
- Système de vie
- Animation complète du personnage

### Phase 3 – Objectifs
- Système de victoire
- Écran Game Over
- HUD (vie + objets collectés)

### Phase 4 – Améliorations
- Musique
- Effets sonores
- Menu principal
- Optimisation

---

>>>>>>> develop
<hr>
<p align="center"><img src="./_bin/end.png" alt="drawing" width="150"/></p>