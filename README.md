**Description**

Ce projet implémente une calculatrice en ligne de commande développée en C#. Il permet d'effectuer les quatre opérations arithmétiques de base : addition, soustraction, multiplication et division, tout en gérant les entrées invalides et la division par zéro.

**Prérequis**

- .NET SDK (version 6.0 ou supérieure)

- Un terminal (Invite de commandes, PowerShell, Bash, etc.)
  
**Installation**
  1. Cloner le dépôt :

    git clone https://github.com/kbakazami/Calculator.git

  2. Accéder au répertoir du projet : 

    cd calculator

  3. Restaurer les dépendances : 

    dotnet restore

**Compilation**

Pour compiler le projet, exécutez :

    dotnet build

**Utilisation**

    dotnet run --project Calculator

Suivez ensuite les étapes :

1. Entrez le premier nombre.

2. Entrez le second nombre.

3. Choisissez un opérateur parmi +, -, * ou /.

4. Le résultat de l'opération s'affiche.

**Exemple d'exécution**

```
Welcome to the Calculator!
Please enter a number:
> 12
Please enter a number:
> 5
Please enter an operator (+, -, *, /):
> *
12 * 5 = 60
```

**Structure du projet**

```
Calculator/
├── Calculator.csproj        # Fichier de projet .NET
├── Program.cs               # Code source principal
```

  
