Application de calculatrice simple, prenant example sur la calculatrice sous windows.
developpement des fonctionnalité simples dans un premier temps, puis ajout eventuel de fonctionnalité plus poussées
comme la calcultrice scientifique, ou le convertisseur de devise.

- Le form de la calulatrice est deja realisé en version simple.
- Implementation des fonctions de calcul de base et de gestions de la memoire.
- debut de la gestions de evenements du formulaire
	- boutons numeriques
	- boutons des operandes
	- l'evenemement permettant de changer le signe d'un nombre de positif a negatif et inversement prend en consideration la propriete de RightToLeft
	de la textbox tbxCalcul. 
		=> Remplacement de la propriete RightToLeft par la propriete TextAlign pour un affichage plus simple des virgules et de l'affichage du signe -
	- quand le form s'ouvre "0" est directement affiché dans la txb et est remplacé si l'user clique sur un bouton
	- gestion de l'evenment permettant d'obtenir le carré d'un nombre avec la fonction Math.Pow(). les resultats de la calculatrice
	peuvent etre hors de la plage du type double donc un cast en long a été fait.