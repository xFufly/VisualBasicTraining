'Fichier : Program.vb'
'But : Faire deviner un nombre al�atoire compris entre 1 et 100 � un utilisateur en 10 essais'
'Auteur : DIDELOT Tim'
'Date de derni�re modification'
'Remarques : Ce programme a �t� r�alis� dans le but d'apprendre la synthaxe du Visual Basic'

Imports System

Module Program

    Sub Main(args As String())

        '-------------------------------'
        'D�clarations des variables'
        '-------------------------------'
        Dim nbrToGuess As Integer = randomNbr(100) ' Nombre � deviner '
        Dim tries As Integer = 10 'Nombre d'opportunit�s restantes � l'utilisateur pour deviner le nombre '
        Dim userNbr As Integer = 0 ' Nombre saisit par l'utilisateur '
        Dim success As Boolean = False 'Vrai si l'utilisateur a r�ussi, faux sinon


        '-------------------------------'
        'Traitements'
        'Documentation : donn�es > nomTraitement > r�sultats'
        '-------------------------------'

        '> afficherButJeu > (�cran)'
        Console.WriteLine("Je pense � un nombre entre un et 100, devine le en 10 essais.")
        Console.WriteLine("Commence par tapper un nombre avec ton clavier et appuis sur entrer.")
        Console.WriteLine("/!\ Si tu saisis un nombre incorrect, le programme se fermera /!\")

        'userNbr, nbrToGuess, success > faireDeviner > success'
        While (success <> True Or tries > 0)
            userNbr = Console.ReadLine()
            tries -= 1
            If (userNbr > nbrToGuess) Then
                Console.WriteLine("Recommence ! Je pense � plus petit !")
            ElseIf (userNbr < nbrToGuess) Then
                Console.WriteLine("Recommence ! Je pense � plus grand !")
            Else
                success = True
            End If
        End While

        'success, [tries] > afficherResultat > (�cran)'
        If (success) Then
            Console.WriteLine("Bravo ! Tu as r�ussi en " + String.Format("{0:00}", (10 - tries)) + " essais !")
        Else
            Console.WriteLine("Perdu !")
        End If

    End Sub

    '-------------------------------'
    'Sous-programmes'
    '-------------------------------'

    Function randomNbr(max As Integer) As Single
        ' Fonction retournant un entier al�atoire entre 1 et max '
        Randomize()
        Return Int((max * Rnd()) + 1)
    End Function
End Module
