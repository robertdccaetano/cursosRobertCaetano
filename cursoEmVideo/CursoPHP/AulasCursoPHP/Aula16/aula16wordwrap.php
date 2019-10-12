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
    //A função wordwrap quebra strings tanto visualmente quanto no código fonte
    // wordwrap($variavel, 5, "<br/>\n, true);
    //O primeiro parametro é a variável que contem a string a ser quebrada
    //Ja o segundo parametro delimita em quantas letras vai ser a largura da coluna a ser quebrada
    //O terceiro parametro aplica tag <br/> para efetivamente quebrar visualmente junto com o contra barra \n para quebrar no codigo fonte
    //O quarto parametro true or false booleano, false(mantem palavras com tamanho maior que o especificado no segunto parâmetro, já true quebra todas independente do tamanho delimitado)
        $t = "Aqui temos um texto gigante criado pelo PHP e vai mostrar o funcionamento da função wordwrap";
        $r = wordwrap($t, 5, "<br/>\n", true);
        echo $r;
    ?>
</body>
</html>