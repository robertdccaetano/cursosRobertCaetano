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
    // str_word_count => Conta a quantidade de palavras contidas dentro de uma string 
    // O valor 0 conta apenas as palavras
    // O valor 1 insere(gera) as palavras dentro de um vetor
    // O valor 2 gera um vetor mantendo posiconamento de cada palavra dentro da string

    $frase = "Eu vou estudar PHP agora";
    $cont = str_word_count($frase, 2);
    print_r($cont);

    ?>

</body>
</html>