# Commentaires prof
Ton thème est intéressant et peut être conservé, mais le projet doit être une application avec de la gestion de données, dont le combat est une fonctionnalité. Il faudrait préciser la liste des fonctionnalités : ce que l’utilisateur peut créer, modifier, supprimer et consulter ; 
Tel quel, je ne pas vérifier s’il respecte les exigences du projet de session.

L'utilisation d'Entity Framework et d'une base de données est obligatoire. Les données doivent être sauvegardées dans la BD, pas dans des fichiers JSON.

le losange plein représente une composition, et non l'héritage (flèche à triangle vide). De plus, plusieurs aventuriers partagent la même classe : c’est une association, pas une composition. Les équipes, les groupes de monstres et les capacités sont absents du diagramme. Attaque est un comportement (méthodes), pas une entité à sauvegarder.
Dates : ton projet doit manipuler des dates (ex. date de création d'une équipe, historique des combats).


# Projet_WinUI_CombatDonjon

## Description du projet
Le projet est de créer des aventuriers ayant trois classe différentes, chaque classe ayant des stats d'attaque, de défence et d'esquive différentes,
et de se battre contre des groupes de monstres.

L'utilisateur va pouvoir sauvegarder des équipes et les charger via des fichiers Json(peut-être, si je ne trouve pas un meilleur format)
Chaque classe d'aventurier va pouvoir utilisé des capacité différentes

## Les classes
```mermaid
classDiagram
	class Jeu {
		- Donjon
		- EquipeJoueur
		+ Sauvegarder()
		+ ChargerPartie()
	}

	class Partie {

	}

	class Donjon {
		
	}

	class Monstre {
	
	}

	class Joueur {
	- Classe
	}

	class Acteur {
	- Attaque
	- Défence
	- Esquive
	}

	class ClasseJoueur {

	}

	class Combat {

	}

	class Attaque {
	+ Attaque_Normal()
	+ Attaque_Sp()
	}


	Jeu *-- Donjon
	Acteur *-- Joueur
	Acteur *-- Monstre
	Joueur *-- ClasseJoueur
	Combat --> Attaque
```

## Schémat Entité-Relation
```mermaid
	erDiagram
    CUSTOMER ||--o{ ORDER : places
    ORDER ||--|{ ORDER_ITEM : contains
    PRODUCT ||--o{ ORDER_ITEM : includes
    
	Partie ||--|| Donjon : "Possède (1:1)"
	Partie ||--|| EquipeJoueur : "Possède (1:1)"
	Donjon ||--|{ NivDonjon :"Contient (1:N)"
	NivDonjon }|--|| Biome : "Possède (N:1)"
	NivDonjon ||--o{ Combat : "Contient (1:N)"
	EquipeJoueur |o--o{ Joueur : "1:N"
	Combat ||--|| EquipeJoueur : "Possède (1:1)"
	Combat ||--|{ MonstreCombat :"Possède (1:N)"
	MonstreCombat }|--|| Monstre : ""
	Monstre }|--|| Biome : "Possède (N:1)"



	Partie {
		int		PartieID
		string	PartieNom
		int		DonjonID
		int		EquipeID
	}

	Donjon {
		int		DonjonID
		int		PartieID
	}

	NivDonjon {
		int		NivDonjonID
		int		BiomeID
	}

	Biome {
		int		BiomeID
	}

	Combat {
		int		CombatID
		int		NivDonjonID
		bool	Terminee
	}

	EquipeJoueur {
		int		EquipeID
		int		PartieID
	}

	Joueur {
		int		JoueurID
		int		EquipeID
	}

	Monstre {
		int		MonstreID
		int		BiomeID
	}

	MonstreCombat {
		int		MCID
		int		CombatID
		int		MonstreID
		decimal MonstrePV
		bool	Mort
	}

	EquipeMonstre {
		int		EQMonstreID
	}
	
	CUSTOMER {
        string id
        string name
        string email
    }
    ORDER {
        string id
        date orderDate
        string status
    }
    PRODUCT {
        string id
        string name
        float price
    }
    ORDER_ITEM {
        int quantity
        float price
    }
```