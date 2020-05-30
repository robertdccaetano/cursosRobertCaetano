<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>
</head>
<body>
    <?php
    //O explode(" ", $site);
    //O Primeiro parâmetro especifica qual vai ser o delimitador entre as palavras da string
    //Nesse caso entre aspas é um espaço em branco, então quando o explode encontrar esse delimitador
    //Ele vai explodir e jogar dentro de um vetor as palavras separadas por esse delimitador
    //Assim pegando cada palavra separada jogando num indice do vetor

        $site = "Curso em Video";
        $vetor = explode(" ", $site);
        print_r($vetor);
    ?>

</body>
</html>