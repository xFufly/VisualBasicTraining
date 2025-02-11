'Fichier : Program.vb'
'But : Faire deviner un nombre aléatoire compris entre 1 et 100 à un utilisateur en 10 essais'
'Auteur : DIDELOT Tim'
'Date de dernière modification'
'Remarques : Ce programme a été réalisé dans le but d'apprendre la synthaxe du Visual Basic'

Imports System

Module Program

    Sub Main(args As String())

        '-------------------------------'
        'Déclarations des variables'
        '-------------------------------'
        Dim nbrToGuess As Integer = randomNbr(100) ' Nombre à deviner '
        Dim tries As Integer = 10 'Nombre d'opportunités restantes à l'utilisateur pour deviner le nombre '
        Dim userNbr As Integer = 0 ' Nombre saisit par l'utilisateur '
        Dim success As Boolean = False 'Vrai si l'utilisateur a réussi, faux sinon


        '-------------------------------'
        'Traitements'
        'Documentation : données > nomTraitement > résultats'
        '-------------------------------'

        '> afficherButJeu > (écran)'
        Console.WriteLine("Je pense à un nombre entre un et 100, devine le en 10 essais.")
        Console.WriteLine("Commence par tapper un nombre avec ton clavier et appuis sur entrer.")
        Console.WriteLine("/!\ Si tu saisis un nombre incorrect, le programme se fermera /!\")

        'userNbr, nbrToGuess, success > faireDeviner > success'
        While (success <> True Or tries > 0)
            userNbr = Console.ReadLine()
            tries -= 1
            If (userNbr > nbrToGuess) Then
                Console.WriteLine("Recommence ! Je pense à plus petit !")
            ElseIf (userNbr < nbrToGuess) Then
                Console.WriteLine("Recommence ! Je pense à plus grand !")
            Else
                success = True
            End If
        End While

        'success, [tries] > afficherResultat > (écran)'
        If (success) Then
            Console.WriteLine("Bravo ! Tu as réussi en " + String.Format("{0:00}", (10 - tries)) + " essais !")
        Else
            Console.WriteLine("Perdu !")
        End If

    End Sub

    '-------------------------------'
    'Sous-programmes'
    '-------------------------------'

    Function randomNbr(max As Integer) As Single
        ' Fonction retournant un entier aléatoire entre 1 et max '
        Randomize()
        Return Int((max * Rnd()) + 1)
    End Function
End Module
