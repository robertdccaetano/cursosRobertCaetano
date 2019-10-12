<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Aula 04 Variáveis</title>
</head>
<body>
    <?php
        // $idade = 3;
        // $salario = 1900.00;
        // $nome = "Robert";
        // $casado = false;
        // PHP é case sensitive idade != Idade

        $n = 4;
        $nome = "Robert";
        $idade = 22;
        $n = 4.5;
        echo $nome." tem ".$idade." anos! <br/>"; // Concatenação através do caractere ponto .
        echo "$nome já fez $idade anos!"; //Concatena variáveis sem caractere ponto . contendo tudo dentro de aspas duplas
    ?>    

</body>
</html>


<!-- PHP atribui por coerção de acordo com a atribuição -->
<!-- //Pode forçar a definição de tipo de variavel -->
<!-- TYPECAST -->
<!-- //int (int), (integer) -->
<!-- //real (real), (float), (double) -->
<!-- //Caractere (string) -->
<!-- //Booleano (0 ou 1) -->