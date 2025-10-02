Ce projet est ma première application Blazor.

Je l'ai faite pour apprendre à un peu connaitre ce sous-framework d'ASP NET.CORE

Actuellement, j'ai ceci :

Une base de données MySql avec une table users qui contient : id, prenom, nom, email, username, password, datecreation

Une page d'inscrpition dans laquelle on entre ses données pour la première fois

Une page de connexion dans laquelle on se connecte avec Username et Passord

Une page /hello qui contient la liste de tous les utilisateurs existant dans la base de données ainsi que 2 boutons :
 -> Déconnexion
 -> Mon Profil


Une page /profile qui contient les information de l'utilisateur couramment connecté avec un bouton :
 -> Modifier son profil (Non-fonctionnel pour le moment)


Le mot de passe est crypté via SHA256
